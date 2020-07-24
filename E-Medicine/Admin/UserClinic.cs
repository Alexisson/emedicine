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
    public partial class UserClinic : Form
    {
        int COUNT, cid, did, sw;
        string sql;
        static string connstr = Operations.connection_string;
        MySqlConnection conn = new MySqlConnection(connstr);

        private void SelectCountry(object sender, EventArgs e)
        {
            CBRegion.Text = "";
            CBRegion.Items.Clear();
            conn.Open();
            sql = "SELECT * FROM REGION";
            MySqlCommand region = new MySqlCommand(sql, conn);
            MySqlDataReader reader = region.ExecuteReader();
            while (reader.Read())
            {
                CBRegion.Items.Add(reader.GetString("REGION"));
            }
            conn.Close();
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
            AdminMainForm amf = new AdminMainForm();
            amf.Show();
            conn.Close();
        }

        private void SelectRegion(object sender, EventArgs e)
        {
            CBCity.Text = "";
            CBCity.Items.Clear();
            conn.Open();
            sql = "SELECT * FROM CITY WHERE REGION_ID_REGION = (" +
                "SELECT ID_REGION FROM REGION WHERE REGION = '" + CBRegion.Text + "')";
            MySqlCommand city = new MySqlCommand(sql, conn);
            MySqlDataReader reader = city.ExecuteReader();
            while (reader.Read())
            {
                CBCity.Items.Add(reader.GetString("CITY"));
            }
            conn.Close();
        }

        private void SelectCity(object sender, EventArgs e)
        {
            Messages msg = new Messages();
            CBSetClinic.Text = "";
            CBSetClinic.Items.Clear();
            conn.Open();
            sql = "SELECT COUNT(*) FROM CLINIC WHERE CITY_ID_CITY = (" +
            "SELECT ID_CITY FROM CITY WHERE CITY = '" + CBCity.Text + "')";
            MySqlCommand check = new MySqlCommand(sql, conn);
            COUNT = Convert.ToInt32(check.ExecuteScalar());
            if (COUNT == 0)
            {
               msg.DataError("В данном городе нет зарегистрированных аптек!");
                conn.Close();
            }
            else
            {
                sql = "SELECT * FROM CLINIC WHERE CITY_ID_CITY = (" +
                    "SELECT ID_CITY FROM CITY WHERE CITY = '" + CBCity.Text + "') " +
                    "ORDER BY 2 ASC";
                MySqlCommand setSpec = new MySqlCommand(sql, conn);
                MySqlDataReader reader = setSpec.ExecuteReader();
                while (reader.Read())
                {
                    CBSetClinic.Items.Add(reader.GetString("CLINIC_NAME"));
                }
                conn.Close();
            }
        }

        private void CheckDigit(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void CreateNewRecord(object sender, EventArgs e)
        {
            Messages msg = new Messages();
            AdminMainForm amf = new AdminMainForm();
            if (CBCity.Text == "")
            {
                msg.DataError("Выберите город!");
                CBCity.Focus();
            }
            else if (CBCountry.Text == "")
            {
                msg.DataError("Выберите страну!");
                CBCountry.Focus();
            }
            else if (CBRegion.Text == "")
            {
                msg.DataError("Выберите регион!");
                CBRegion.Focus();
            }
            else if (CBSetClinic.Text == "")
            {
                msg.DataError("Выберите поликлинику!");
                CBSetClinic.Focus();
            }
            else
            {
                conn.Open();
                sql = "SELECT ID_CLINIC FROM CLINIC WHERE CLINIC_NAME = '" + CBSetClinic.Text + "'";
                MySqlCommand clinicid = new MySqlCommand(sql, conn);
                cid = Convert.ToInt32(clinicid.ExecuteScalar());
                switch (sw)
                {
                    case 0:
                        sql = "SELECT COUNT(*) " +
                            "FROM CLINIC_HAS_PERSON " +
                            "WHERE PERSON_PERSON_IIN = '" + TextIIN.Text + "' AND " +
                            "CLINIC_ID_CLINIC = " + cid + "";
                        MySqlCommand pcheck = new MySqlCommand(sql, conn);
                        COUNT = Convert.ToInt32(pcheck.ExecuteScalar());
                        if (COUNT == 0)
                        {
                            sql = "INSERT INTO CLINIC_HAS_PERSON " +
                            "(PERSON_PERSON_IIN, CLINIC_ID_CLINIC) " +
                            "VALUES ('" + TextIIN.Text + "'," + cid + ")";
                            MySqlCommand pins = new MySqlCommand(sql, conn);
                            if (pins.ExecuteNonQuery() == 1)
                            {
                                msg.WriteSuccess();
                                this.Close();
                                amf.Show();
                                conn.Close();
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
                        break;
                    case 1:
                        sql = "SELECT ID_DOCTOR FROM DOCTOR WHERE DOC_IIN = '" + TextIIN.Text + "'";
                        MySqlCommand dociin = new MySqlCommand(sql, conn);
                        did = Convert.ToInt32(dociin.ExecuteScalar());

                        sql = "SELECT COUNT(*) " +
                            "FROM CLINIC_HAS_DOCTOR " +
                            "WHERE DOCTOR_ID_DOCTOR = " + did + " AND " +
                            "CLINIC_ID_CLINIC = " + cid + "";
                        MySqlCommand dcheck = new MySqlCommand(sql, conn);
                        COUNT = Convert.ToInt32(dcheck.ExecuteScalar());
                        if (COUNT == 0)
                        {
                            sql = "INSERT INTO CLINIC_HAS_DOCTOR " +
                            "(DOCTOR_ID_DOCTOR, CLINIC_ID_CLINIC) " +
                            "VALUES (" + did + " ," + cid + ")";
                            MySqlCommand dins = new MySqlCommand(sql, conn);
                            if (dins.ExecuteNonQuery() == 1)
                            {
                                msg.WriteSuccess();
                                this.Close();
                                amf.Show();
                                conn.Close();
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
                        break;
                }
            }
        }

        private void CheckUser(object sender, EventArgs e)
        {
            Messages msg = new Messages();
            if (TextIIN.Text == "")
            {
                msg.DataError("Введите ИИН!");
                TextIIN.Focus();
            }
            conn.Open();
            switch (sw)
            {
                case 0:
                    sql = "SELECT COUNT(*) FROM PERSON WHERE PERSON_IIN = '" + TextIIN.Text + "'";
                    MySqlCommand checkp = new MySqlCommand(sql, conn);
                    COUNT = Convert.ToInt32(checkp.ExecuteScalar());
                    break;
                case 1:
                    sql = "SELECT COUNT(*) FROM DOCTOR WHERE DOC_IIN = '" + TextIIN.Text + "'";
                    MySqlCommand checkd = new MySqlCommand(sql, conn);
                    COUNT = Convert.ToInt32(checkd.ExecuteScalar());
                    break;
            }
            if(COUNT == 1)
            {
                PanelClinic.Visible = true;  
            }
            else
            {
                msg.DataError("Пользователя нет в базе!");
            }
            conn.Close();
        }

        private void CheckButton_MouseMove(object sender, MouseEventArgs e)
        {
            CheckButton.BackColor = Color.FromArgb(10, 131, 35);
            CheckButton.ForeColor = Color.White;
        }

        private void UserClinic_MouseMove(object sender, MouseEventArgs e)
        {
            AddButton.BackColor = Color.White;
            AddButton.ForeColor = Color.FromArgb(10, 131, 35);
            CancelButton.BackColor = Color.White;
            CancelButton.ForeColor = Color.FromArgb(10, 131, 35);
            CheckButton.BackColor = Color.White;
            CheckButton.ForeColor = Color.FromArgb(10, 131, 35);
        }

        public UserClinic(int user)
        {
            sw = user;
            InitializeComponent();
            conn.Open();
            sql = "SELECT * FROM COUNTRY ORDER BY 2 ASC";
            MySqlCommand country = new MySqlCommand(sql, conn);
            MySqlDataReader reader = country.ExecuteReader();
            while (reader.Read())
            {
                CBCountry.Items.Add(reader.GetString("COUNTRY"));
            }
            conn.Close();
            CBCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CBCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CBRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CBSetClinic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            label1.ForeColor = Color.FromArgb(10, 131, 35);
            label2.ForeColor = Color.FromArgb(10, 131, 35);
            label3.ForeColor = Color.FromArgb(10, 131, 35);
            LabelCityClPh.ForeColor = Color.FromArgb(10, 131, 35);
            LabelIIN.ForeColor = Color.FromArgb(10, 131, 35);
            AddButton.BackColor = Color.White;
            AddButton.ForeColor = Color.FromArgb(10, 131, 35);
            CancelButton.BackColor = Color.White;
            CancelButton.ForeColor = Color.FromArgb(10, 131, 35);
            CheckButton.BackColor = Color.White;
            CheckButton.ForeColor = Color.FromArgb(10, 131, 35);
            this.BackColor = Color.White;

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
