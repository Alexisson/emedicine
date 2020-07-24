using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace E_Medicine
{
    public partial class LF : Form 
    {
        int sw;
        int id, COUNT;
        string sql, login, password;

        static string connstr = Operations.connection_string;

        MySqlConnection conn = new MySqlConnection(connstr);

        private void LF_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void ButtonLogin_MouseMove(object sender, MouseEventArgs e)
        {
            ButtonLogin.BackColor = Color.FromArgb(10, 131, 35);
            ButtonLogin.ForeColor = Color.White;
        }

        private void CancelButton_MouseMove(object sender, MouseEventArgs e)
        {
            CancelButton.BackColor = Color.FromArgb(10, 131, 35);
            CancelButton.ForeColor = Color.White;
        }

        private void LF_MouseMove(object sender, MouseEventArgs e)
        {
            CancelButton.BackColor = Color.White;
            CancelButton.ForeColor = Color.FromArgb(10, 131, 35);
            ButtonLogin.BackColor = Color.White;
            ButtonLogin.ForeColor = Color.FromArgb(10, 131, 35);
        }

        public LF(int user)
        {
            sw = user;
            InitializeComponent();
            conn.Open();
            LabelLogin.ForeColor = Color.FromArgb(10, 131, 35);
            LabelPassword.ForeColor = Color.FromArgb(10, 131, 35);
            this.BackColor = Color.White;
        }
        
        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
            MainForm mf = new MainForm();
            mf.Show();
            conn.Close();
        }

        private void Login(object sender, EventArgs e)
        {
            Messages msg = new Messages();
            AdminMainForm amf; 
            amf = new AdminMainForm();
            MainForm mainForm = new MainForm();



            switch (sw)
            {
                case 0:
                    sql = "SELECT COUNT(*) FROM INFO WHERE INFO_LOGIN = '" + TextLogin.Text + "'";
                    MySqlCommand querycheckadm = new MySqlCommand(sql, conn);
                    COUNT = Convert.ToInt32(querycheckadm.ExecuteScalar());
                    if (COUNT == 0)
                    {
                        msg.DataError("Логин и/или пароль неверный");
                    }
                    else
                    {
                        sql = "SELECT ID_INFO FROM INFO WHERE INFO_LOGIN = '" + TextLogin.Text + "'";
                        MySqlCommand queryidadm = new MySqlCommand(sql, conn);
                        id = (int)queryidadm.ExecuteScalar();
                        sql = "SELECT INFO_PASSWORD FROM INFO WHERE ID_INFO = '" + id + "'";
                        MySqlCommand querypasswordadm = new MySqlCommand(sql, conn);
                        password = querypasswordadm.ExecuteScalar().ToString();
                        if (TextPassword.Text == password)
                        {
                            this.Close();
                            amf.Show();
                            TextLogin.Text = "";
                            TextPassword.Text = "";
                            conn.Close();
                        }
                        else
                        {
                            msg.DataError("Логин и/или пароль неверный");
                        }
                    }
                    break;
                case 1:
                    sql = "SELECT COUNT(*) FROM PERSON WHERE PERSON_IIN = '" + TextLogin.Text + "'";
                    MySqlCommand querycheckperson = new MySqlCommand(sql, conn);
                    COUNT = Convert.ToInt32(querycheckperson.ExecuteScalar());
                    if (COUNT == 0)
                    {
                        MessageBox.Show("Логин и/или пароль неверный", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        sql = "SELECT PERSON_PASSWORD FROM PERSON WHERE PERSON_IIN = '" + TextLogin.Text + "'";
                        MySqlCommand querypasswordperson = new MySqlCommand(sql, conn);
                        password = querypasswordperson.ExecuteScalar().ToString();
                        if (TextPassword.Text == password)
                        {
                            login = TextLogin.Text;
                            PersonMode person = new PersonMode(login);
                            person.Show();
                            this.Close();
                            conn.Close();
                        }
                        else
                        {
                            msg.DataError("Логин и/или пароль неверный");
                        }
                    }
                    break;
                case 2:
                    sql = "SELECT COUNT(*) FROM DOCTOR WHERE DOC_IIN = '" + TextLogin.Text + "'";
                    MySqlCommand querycheckdoc = new MySqlCommand(sql, conn);
                    COUNT = Convert.ToInt32(querycheckdoc.ExecuteScalar());
                    if (COUNT == 0)
                    {
                        msg.DataError("Логин и/или пароль неверный");
                    }
                    else
                    {
                        sql = "SELECT ID_DOCTOR FROM DOCTOR WHERE DOC_IIN = '" + TextLogin.Text + "'";
                        MySqlCommand queryiddoc = new MySqlCommand(sql, conn);
                        id = (int)queryiddoc.ExecuteScalar();
                        sql = "SELECT DOC_PASSWORD FROM DOCTOR WHERE ID_DOCTOR = '" + id + "'";
                        MySqlCommand querypassworddoc = new MySqlCommand(sql, conn);
                        password = querypassworddoc.ExecuteScalar().ToString();
                        if (TextPassword.Text == password)
                        {
                            DoctorMode doctor = new DoctorMode(id);
                            doctor.Show();
                            this.Close();
                            conn.Close();
                        }
                        else
                        {
                            msg.DataError("Логин и/или пароль неверный");
                        }
                    }
                    break;
            }  
        }
    }
}
