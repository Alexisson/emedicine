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
    public partial class CreatePerson : Form
    {
        int COUNT = 0;
        string sql, sqlins;
        static string connstr = "server=localhost;user=root;database=emedicine;password='';";
        MySqlConnection conn = new MySqlConnection(connstr);
        public CreatePerson()
        {
            InitializeComponent();
            BirthdaySet.MaxDate = DateTime.Today;
            SexSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            label1.ForeColor = Color.FromArgb(10, 131, 35);
            LabelEmail.ForeColor = Color.FromArgb(10, 131, 35);
            LabelFirstName.ForeColor = Color.FromArgb(10, 131, 35);
            LabelBirthday.ForeColor = Color.FromArgb(10, 131, 35);
            LabelLastName.ForeColor = Color.FromArgb(10, 131, 35);
            LabelPassword.ForeColor = Color.FromArgb(10, 131, 35);
            LabelPatronymic.ForeColor = Color.FromArgb(10, 131, 35);
            LabelPhone.ForeColor = Color.FromArgb(10, 131, 35);
            LabelRepPassword.ForeColor = Color.FromArgb(10, 131, 35);
            LabelSex.ForeColor = Color.FromArgb(10, 131, 35);
            AddButton.BackColor = Color.White;
            AddButton.ForeColor = Color.FromArgb(10, 131, 35);
            CancelButton.BackColor = Color.White;
            CancelButton.ForeColor = Color.FromArgb(10, 131, 35);
            this.BackColor = Color.White;
        }

        private void CreateNewPerson(object sender, EventArgs e)
        {
            Messages msg = new Messages();
            if (TextLastName.Text == "")
            {
               msg.DataError("Введите фамилию!");
                TextLastName.Focus();
            }
            else if (TextFirstName.Text == "")
            {
                msg.DataError("Введите имя!");
                TextFirstName.Focus();
            }
            else if (SexSet.Text == "")
            {
                msg.DataError("Выберите пол!");
                SexSet.Focus();
            }
            else if (TextIIN.Text.Length != 12)
            {
                msg.DataError("Введите корректный ИИН!");
                TextIIN.Focus();
            }
            else if (TextEmail.Text == "")
            {
                msg.DataError("Введите адрес электронной почты!");
                TextEmail.Focus();
            }
            else if (TextPhone.Text == "")
            {
                msg.DataError("Введите номер телефона!");
                TextPhone.Focus();
            }
            else if (TextPassword.Text == "")
            {
                msg.DataError("Введите пароль!");
                TextPassword.Focus();
            }
            else if (TextPassword.Text != TextRepPassword.Text)
            {
                msg.DataError("Пароли не совпадают!");
                TextPassword.Focus();
            }
            else
            {
                conn.Open();
                sqlins = "INSERT INTO PERSON (PERSON_LASTNAME, " +
                            "PERSON_FIRSTNAME, " +
                            "PERSON_PATRONYMIC, " +
                            "PERSON_BIRTHDAY, " +
                            "PERSON_IIN, " +
                            "PERSON_PASSWORD, " +
                            "PERSON_EMAIL, " +
                            "PERSON_SEX, " +
                            "PERSON_PHONE) " +
                            "VALUES ('" + TextLastName.Text + "', " +
                            "'" + TextFirstName.Text + "', " +
                            "'" + TextPatronymic.Text + "', " +
                            "'" + this.BirthdaySet.Text + "', " +
                            "'" + TextIIN.Text + "', " +
                            "'" + TextPassword.Text + "', " +
                            "'" + TextEmail.Text + "', " +
                            "'" + SexSet.Text + "'," +
                            "'" + TextPhone.Text + "')";

                sql = "SELECT COUNT(*) FROM PERSON WHERE PERSON_EMAIL = '" + TextEmail.Text + "'";
                MySqlCommand checkEmail = new MySqlCommand(sql, conn);
                COUNT = Convert.ToInt32(checkEmail.ExecuteScalar());
                if (COUNT == 0)
                {
                    sql = "SELECT COUNT(*) FROM PERSON WHERE PERSON_IIN = '" + TextIIN.Text + "'";
                    MySqlCommand checkIIN = new MySqlCommand(sql, conn);
                    COUNT = Convert.ToInt32(checkIIN.ExecuteScalar());
                    if (COUNT == 0)
                    {
                        MySqlCommand cmd = new MySqlCommand(sqlins, conn);
                        if (cmd.ExecuteNonQuery() == 1)
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
                       msg.DataError("Номер документа уже существует в системе!");
                        conn.Close();
                        COUNT = 0;
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

        private void CheckPhone(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar<=47 || e.KeyChar >= 58) && e.KeyChar != 43 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
            conn.Close();
            AdminMainForm amf = new AdminMainForm();
            amf.Show();
        }
        private void CancelButton_MouseMove(object sender, MouseEventArgs e)
        {
            CancelButton.BackColor = Color.FromArgb(10, 131, 35);
            CancelButton.ForeColor = Color.White;
        }

        private void CreatePerson_MouseMove(object sender, MouseEventArgs e)
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
    }
}
