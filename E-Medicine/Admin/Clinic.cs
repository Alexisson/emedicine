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
    public partial class CreateClinic : Form
    {
        int COUNT, id, cityid;
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

        private void CreateNewClinic(object sender, EventArgs e)
        {
            Messages msg = new Messages();
            if (TextNameClPh.Text == "")
            {
                msg.DataError("Введите название!");
                TextNameClPh.Focus();
            }
            else if (TextZipClPh.Text == "")
            {
                msg.DataError("Введите почтовый индекс!");
                TextZipClPh.Focus();
            }
            else if (CBCity.Text == "")
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
            else if (TextStreetClPh.Text == "")
            {
                msg.DataError("Введите улицу!");
                TextStreetClPh.Focus();
            }
            else if (TextBuildingClPh.Text == "")
            {
                msg.DataError("Введите номер строения!");
                TextBuildingClPh.Focus();
            }
            else if (TextPhoneClPh.Text == "")
            {
                msg.DataError("Введите номер телефона!");
                TextPhoneClPh.Focus();
            }
            else
            {
                conn.Open();
                sql = "SELECT ID_CITY FROM CITY WHERE CITY ='" + CBCity.Text + "'";
                MySqlCommand cid = new MySqlCommand(sql, conn);
                cityid = Convert.ToInt32(cid.ExecuteScalar());
            }
            sql = "SELECT COUNT(*) FROM CLINIC WHERE CLINIC_NAME = '" + TextNameClPh.Text + "'";
            MySqlCommand querycheckcl = new MySqlCommand(sql, conn);
            COUNT = Convert.ToInt32(querycheckcl.ExecuteScalar());
            if (COUNT == 0)
            {
                sql = "INSERT INTO CLINIC (CLINIC_NAME, " +
                    "CITY_ID_CITY, " +
                    "CLINIC_ZIP_CODE, " +
                    "CLINIC_STREET, " +
                    "CLINIC_BUILDING) " +
                    "VALUES ('" + TextNameClPh.Text + "', " +
                    "" + cityid + "," +
                    " '" + TextZipClPh.Text + "'," +
                    " '" + TextStreetClPh.Text + "'," +
                    " '" + TextBuildingClPh.Text + "')";
                MySqlCommand cmdcl = new MySqlCommand(sql, conn);
                if (cmdcl.ExecuteNonQuery() == 1)
                {
                    sql = "SELECT ID_CLINIC FROM CLINIC WHERE CLINIC_NAME = '" + TextNameClPh.Text + "'";
                    MySqlCommand clquery = new MySqlCommand(sql, conn);
                    id = (int)clquery.ExecuteScalar();
                    sql = "INSERT INTO CLINIC_PHONE (CLINIC_PHONE, CLINIC_ID_CLINIC) VALUES ('" + TextPhoneClPh.Text + "', " + id + ")";
                    MySqlCommand clphone = new MySqlCommand(sql, conn);
                    if (clphone.ExecuteNonQuery() == 1)
                    {
                        msg.WriteSuccess();
                        this.Close();
                        AdminMainForm amf = new AdminMainForm();
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
                    msg.WriteError();
                    conn.Close();
                }
            }
            else
            {
                msg.DataError("Такое медицинское учреждение уже существует!");
                conn.Close();
            }
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

        private void CreateClinic_MouseMove(object sender, MouseEventArgs e)
        {
            AddButton.BackColor = Color.White;
            AddButton.ForeColor = Color.FromArgb(10, 131, 35);
            CancelButton.BackColor = Color.White;
            CancelButton.ForeColor = Color.FromArgb(10, 131, 35);
        }

        public CreateClinic()
        {
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
            label1.ForeColor = Color.FromArgb(10, 131, 35);
            label2.ForeColor = Color.FromArgb(10, 131, 35);
            label6.ForeColor = Color.FromArgb(10, 131, 35);
            LabelBuildingClPh.ForeColor = Color.FromArgb(10, 131, 35);
            LabelCityClPh.ForeColor = Color.FromArgb(10, 131, 35);
            LabelClPh.ForeColor = Color.FromArgb(10, 131, 35);
            LabelNameClPh.ForeColor = Color.FromArgb(10, 131, 35);
            LabelStreetClPh.ForeColor = Color.FromArgb(10, 131, 35);
            LabelZipClPh.ForeColor = Color.FromArgb(10, 131, 35);
            AddButton.BackColor = Color.White;
            AddButton.ForeColor = Color.FromArgb(10, 131, 35);
            CancelButton.BackColor = Color.White;
            CancelButton.ForeColor = Color.FromArgb(10, 131, 35);
            this.BackColor = Color.White;

        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
            AdminMainForm amf = new AdminMainForm();
            amf.Show();
            conn.Close();
        }
    }
}
