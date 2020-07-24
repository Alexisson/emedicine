using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Medicine
{
    public partial class PersonDoctor : Form
    {
        
        int COUNT, cid, did;
        string sql;
        static string connstr = Operations.connection_string;
        MySqlConnection conn = new MySqlConnection(connstr);
        
        public PersonDoctor(int id)
        {
            did = id;
            InitializeComponent();
            conn.Open();
            sql = "SELECT CLINIC.CLINIC_NAME " +
                "FROM CLINIC INNER JOIN CLINIC_HAS_DOCTOR " +
                "ON CLINIC.ID_CLINIC = CLINIC_HAS_DOCTOR.CLINIC_ID_CLINIC " +
                "WHERE CLINIC_HAS_DOCTOR.DOCTOR_ID_DOCTOR = " + did +" " +
                "ORDER BY 1 ASC";
            MySqlCommand clinic = new MySqlCommand(sql, conn);
            MySqlDataReader reader = clinic.ExecuteReader();
            while (reader.Read())
            {
                CBSetClinic.Items.Add(reader.GetString("CLINIC_NAME"));
            }
            conn.Close();
            CBSetClinic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            label1.ForeColor = Color.FromArgb(10, 131, 35);
            LabelIIN.ForeColor = Color.FromArgb(10, 131, 35);
            AddButton.BackColor = Color.White;
            AddButton.ForeColor = Color.FromArgb(10, 131, 35);
            CancelButton.BackColor = Color.White;
            CancelButton.ForeColor = Color.FromArgb(10, 131, 35);
            this.BackColor = Color.White;
        }

        private void AddNewRecord(object sender, EventArgs e)
        {
            Messages msg = new Messages();
            if (CBSetClinic.Text == "")
            {
                msg.DataError("Выберите поликлинику!");
                CBSetClinic.Focus();
            }
            else if (TextIIN.Text == "")
            {
                msg.DataError("Введите ИИН!");
                TextIIN.Focus();
            }
            else
            {
                conn.Open();
                sql = "SELECT COUNT(*) " +
                    "FROM PERSON WHERE PERSON_IIN = '" + TextIIN.Text + "' ";
                MySqlCommand check = new MySqlCommand(sql, conn);
                COUNT = Convert.ToInt32(check.ExecuteScalar());
                if (COUNT == 0)
                {
                    msg.DataError("Пациент не найден в базе данных!");
                    conn.Close();
                }
                else
                {

                    sql = "SELECT COUNT(*) " +
                        "FROM PERSON_HAS_DOCTOR " +
                        "WHERE PERSON_PERSON_IIN = '" + TextIIN.Text + "' " +
                        "AND CLINIC_ID_CLINIC = " + cid + " " +
                        "AND DOCTOR_ID_DOCTOR = " + did + "";
                    MySqlCommand checkpc = new MySqlCommand(sql, conn);
                    COUNT = Convert.ToInt32(checkpc.ExecuteScalar());
                    if (COUNT == 0)
                    {
                        sql = "INSERT INTO PERSON_HAS_DOCTOR (PERSON_PERSON_IIN, CLINIC_ID_CLINIC, DOCTOR_ID_DOCTOR) " +
                            "VALUES ('" + TextIIN.Text + "'," + cid + ", " + did + ")";
                        MySqlCommand ins = new MySqlCommand(sql, conn);
                        if (ins.ExecuteNonQuery() == 1)
                        {
                            msg.WriteSuccess();
                            this.Close();
                            conn.Close();
                            DoctorMode doctorMode = new DoctorMode(did);
                            doctorMode.Show();
                        }
                        else
                        {
                            msg.WriteError();
                            conn.Close();
                        }
                    }
                    else
                    {
                        msg.DataError("Запись уже существует в базе данных!");
                        conn.Close();
                    }
                }
            }
        }

        private void CheckDigit(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void SelectClinic(object sender, EventArgs e)
        {
            conn.Open();
            sql = "SELECT ID_CLINIC FROM CLINIC WHERE CLINIC_NAME = '" + CBSetClinic.Text + "'";
            MySqlCommand clinicid = new MySqlCommand(sql, conn);
            cid = Convert.ToInt32(clinicid.ExecuteScalar());
            conn.Close();
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
            DoctorMode doctorMode = new DoctorMode(did);
            doctorMode.Show();
            conn.Close();
        }

        private void PersonDoctor_MouseMove(object sender, MouseEventArgs e)
        {
            AddButton.BackColor = Color.White;
            AddButton.ForeColor = Color.FromArgb(10, 131, 35);
            CancelButton.BackColor = Color.White;
            CancelButton.ForeColor = Color.FromArgb(10, 131, 35);
        }

        private void AddButton_MouseMove(object sender, MouseEventArgs e)
        {
            AddButton.BackColor = Color.FromArgb(10, 131, 35);
            AddButton.ForeColor = Color.White;
        }
        private void CancelButton_MouseMove(object sender, MouseEventArgs e)
        {
            CancelButton.BackColor = Color.FromArgb(10, 131, 35);
            CancelButton.ForeColor = Color.White;
        }
    }
}
