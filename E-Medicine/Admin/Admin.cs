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
    public partial class CreateAdministrator : Form
    {
        int COUNT;
        string sql;

        static string connstr = Operations.connection_string;
        Operations op = new Operations();
        MySqlConnection conn = new MySqlConnection(connstr);
        public CreateAdministrator()
        {
            InitializeComponent();
            op.ColorAdmin();
            this.BackColor = Color.White;
        }

        private void CreateNewAdministrator(object sender, EventArgs e)
        {
            if (TextLogin.Text == "")
            {
                MessageBox.Show("Введите логин!");
                TextLogin.Focus();
            }
            else if (TextPassword.Text == "")
            {
                MessageBox.Show("Введите пароль!");
                TextPassword.Focus();
            }
            else
            {
                conn.Open();
                sql = "SELECT COUNT(*) FROM INFO WHERE INFO_LOGIN = '" + TextLogin.Text + "'";
                MySqlCommand querycheckadm = new MySqlCommand(sql, conn);
                COUNT = Convert.ToInt32(querycheckadm.ExecuteScalar());
                if (COUNT == 0)
                {
                    sql = "INSERT INTO INFO (INFO_LOGIN, INFO_PASSWORD) VALUES ('" + TextLogin.Text + "','" + TextPassword.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Пользователь успешно создан!");
                        this.Close();
                        AdminMainForm amf = new AdminMainForm();
                        amf.Show();
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Запись не удалась");
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Такой пользователь уже существует!");
                    conn.Close();
                }
            }
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
            AdminMainForm amf = new AdminMainForm();
            amf.Show();
            conn.Close();
        }

        private void CreateAdministrator_MouseMove(object sender, MouseEventArgs e)
        {
            op.ColorAdmin();
        }

        private void CancelButton_MouseMove(object sender, MouseEventArgs e)
        {
            CancelButton.BackColor = Color.FromArgb(10, 131, 35);
            CancelButton.ForeColor = Color.White;
        }

        private void ButtonLogin_MouseMove(object sender, MouseEventArgs e)
        {
            ButtonLogin.BackColor = Color.FromArgb(10, 131, 35);
            ButtonLogin.ForeColor = Color.White;
        }
    }
}
