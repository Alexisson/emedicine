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
    public partial class PersonMode : Form
    {
        int COUNT;
        string sql, iin, gr;
        static string connstr = Operations.connection_string;
        MySqlConnection conn = new MySqlConnection(connstr);
        public PersonMode(string login)
        {
            conn.Close();
            Messages msg = new Messages();

            iin = login;
            InitializeComponent();
            DataTable dt = new DataTable(); 
            conn.Open();
            sql = "SELECT COUNT(*) " +
                "FROM PRESCRIPTION " +
                "WHERE PERSON_PERSON_IIN = '" + iin + "'";
                MySqlCommand check = new MySqlCommand(sql, conn);
                COUNT = Convert.ToInt32(check.ExecuteScalar());
            if (COUNT == 0)
            {
                msg.DataError("Активных рецептов нет!");
                
            }
            conn.Close();
            conn.Open();
            sql = "SELECT SOCIAL_GROUP_ID_SOCIAL_GROUP " +
                "FROM PERSON " +
                "WHERE PERSON.PERSON_IIN = '" + iin + "'";
            MySqlCommand ch = new MySqlCommand(sql, conn);
            MySqlDataReader mdr_info = ch.ExecuteReader();
            mdr_info.Read();

            if (mdr_info.IsDBNull(0))
            {
                button1.Visible = false;
                conn.Close();
            }
            else
            {
                button1.Visible = true;
                conn.Close();
            }
            
            this.BackColor = Color.White;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            ExitButton.BackColor = Color.White;
            ExitButton.ForeColor = Color.FromArgb(10, 131, 35);
            button1.BackColor = Color.White;
            button1.ForeColor = Color.FromArgb(10, 131, 35);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Messages msg = new Messages();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    DataTable dt1 = new DataTable();
                    conn.Open();
                    sql = "SELECT COUNT(*) " +
                        "FROM PRESCRIPTION " +
                        "WHERE PERSON_PERSON_IIN = '" + iin + "'";
                    MySqlCommand check1 = new MySqlCommand(sql, conn);
                    COUNT = Convert.ToInt32(check1.ExecuteScalar());
                    if (COUNT == 0)
                    {
                        msg.DataError("Активных рецептов нет!");
                    }

                    else
                    {
                        sql = "SELECT SPECIALISATION.SPECIALISATION 'Врач'," +
                            "DRUG.DRUG_NAME 'Препарат', " +
                            "PRESCRIPTION.PRESCRIPTION_DATE_START 'Дата начала' " +
                            "FROM SPECIALISATION INNER JOIN DOCTOR " +
                            "ON ID_SPEC = SPECIALISATION_ID_SPEC " +
                            "INNER JOIN PRESCRIPTION " +
                            "ON ID_DOCTOR = DOCTOR_ID_DOCTOR " +
                            "INNER JOIN DRUG " +
                            "ON DRUG.ID_MEDICINE = PRESCRIPTION.MEDICINE_ID_MEDICINE " +
                            "WHERE PRESCRIPTION.PERSON_PERSON_IIN = '" + iin + "' " +
                            "AND PRESCRIPTION.PRESCRIPTION_DATE_FINISH IS NULL";
                        MySqlCommand prescriptionlist = new MySqlCommand(sql, conn);
                        MySqlDataReader reader = prescriptionlist.ExecuteReader();
                        dt1.Load(reader);
                        PrescriptionList.DataSource = dt1;
                        conn.Close();
                    }
                    break;
                case 1:
                    DataTable dt2 = new DataTable();
                    conn.Open();
                    sql = "SELECT COUNT(*) " +
                        "FROM PERSON_has_ASSIGNMENT " +
                        "WHERE PERSON_has_ASSIGNMENT.PERSON_PERSON_IIN = '" + iin + "'";
                    MySqlCommand check2 = new MySqlCommand(sql, conn);
                    COUNT = Convert.ToInt32(check2.ExecuteScalar());
                    if (COUNT == 0)
                    {
                        msg.DataError("Назначений нет!");
                        conn.Close();
                    }

                    else
                    {
                        sql = "SELECT ASSIGNMENT.ASSIGNMENT_NAME 'Назначение' " +
                            "FROM ASSIGNMENT INNER JOIN PERSON_has_ASSIGNMENT " +
                            "ON ASSIGNMENT.ID_ASSIGNMENT = PERSON_has_ASSIGNMENT.ASSIGNMENT_ID_ASSIGNMENT " +
                            "WHERE PERSON_has_ASSIGNMENT.PERSON_PERSON_IIN = '" + iin + "' ";
                        MySqlCommand reclist = new MySqlCommand(sql, conn);
                        MySqlDataReader reader = reclist.ExecuteReader();
                        dt2.Load(reader);
                        PrescriptionList.DataSource = dt2;
                        conn.Close();
                    }
                    break;
                case 2:
                    DataTable dt3 = new DataTable();
                    conn.Open();
                    sql = "SELECT COUNT(*) " +
                        "FROM FORBIDDEN_DRUG " +
                        "WHERE FORBIDDEN_DRUG.PERSON_PERSON_IIN = '" + iin + "'";
                    MySqlCommand check3 = new MySqlCommand(sql, conn);
                    COUNT = Convert.ToInt32(check3.ExecuteScalar());
                    if (COUNT == 0)
                    {
                        msg.DataError("Ограничений нет!");
                        conn.Close();
                    }

                    else
                    {
                        sql = "SELECT DRUG_NAME 'Препарат' " +
                            "FROM DRUG  " +
                            "INNER JOIN FORBIDDEN_DRUG ON " +
                            "DRUG.ID_MEDICINE = FORBIDDEN_DRUG.MEDICINE_ID_MEDICINE " +
                            "WHERE FORBIDDEN_DRUG.PERSON_PERSON_IIN = '" + iin + "' ";
                        MySqlCommand reclist = new MySqlCommand(sql, conn);
                        MySqlDataReader reader = reclist.ExecuteReader();
                        dt3.Load(reader);
                        PrescriptionList.DataSource = dt3;
                        conn.Close();
                    }
                    break;
            }
        }

        private void ExitButton_MouseMove(object sender, MouseEventArgs e)
        {
            ExitButton.BackColor = Color.FromArgb(10, 131, 35);
            ExitButton.ForeColor = Color.White;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.FromArgb(10, 131, 35);
            button1.ForeColor = Color.White;
        }

        private void PersonMode_MouseMove(object sender, MouseEventArgs e)
        {
            ExitButton.BackColor = Color.White;
            ExitButton.ForeColor = Color.FromArgb(10, 131, 35);
            button1.BackColor = Color.White;
            button1.ForeColor = Color.FromArgb(10, 131, 35);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = "SELECT SOCIAL_GROUP " +
                "FROM SOCIAL_GROUP " +
                "INNER JOIN PERSON ON " +
                "SOCIAL_GROUP.ID_SOCIAL_GROUP = PERSON.SOCIAL_GROUP_ID_SOCIAL_GROUP " +
                "WHERE PERSON.PERSON_IIN = '" + iin + "'";
            MySqlCommand ch = new MySqlCommand(sql, conn);
            MySqlDataReader reader = ch.ExecuteReader();
            while (reader.Read())
            {
                gr += $"{reader.GetString("SOCIAL_GROUP")}";
            }
            
            MessageBox.Show(gr,"",MessageBoxButtons.OK,MessageBoxIcon.Information);
            conn.Close();
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
            conn.Close();
            MainForm mf = new MainForm();
            mf.Show();
        }
        

    }
}
