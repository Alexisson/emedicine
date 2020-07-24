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
    public partial class CreateDoctor : Form
    {
        int COUNT = 0, idspec;
        string sql;
        static string connstr = Operations.connection_string;
        MySqlConnection conn = new MySqlConnection(connstr);

        private void SelectSpecialisation(object sender, EventArgs e)
        {
            conn.Open();
            sql = "SELECT ID_SPEC FROM SPECIALISATION WHERE SPECIALISATION = '" + CBSetSpec.Text + "'";
            MySqlCommand getidspec = new MySqlCommand(sql, conn);
            idspec = Convert.ToInt32(getidspec.ExecuteScalar());
            conn.Close();
        }

        public CreateDoctor()
        {
            InitializeComponent();
            CBSetSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            conn.Open();
            sql = "SELECT * FROM SPECIALISATION ORDER BY 2 ASC";
            MySqlCommand setSpec = new MySqlCommand(sql, conn);
            MySqlDataReader reader = setSpec.ExecuteReader();
            while (reader.Read())
            {
                CBSetSpec.Items.Add(reader.GetString("SPECIALISATION"));
            }
            conn.Close();
            label1.ForeColor = Color.FromArgb(10, 131, 35);
            LabelEmail.ForeColor = Color.FromArgb(10, 131, 35);
            LabelFirstName.ForeColor = Color.FromArgb(10, 131, 35);
            LabelIIN.ForeColor = Color.FromArgb(10, 131, 35);
            LabelLastName.ForeColor = Color.FromArgb(10, 131, 35);
            LabelPassword.ForeColor = Color.FromArgb(10, 131, 35);
            LabelPatronymic.ForeColor = Color.FromArgb(10, 131, 35);
            LabelPhone.ForeColor = Color.FromArgb(10, 131, 35);
            LabelRepPassword.ForeColor = Color.FromArgb(10, 131, 35);
            AddButton.BackColor = Color.White;
            AddButton.ForeColor = Color.FromArgb(10, 131, 35);
            CancelButton.BackColor = Color.White;
            CancelButton.ForeColor = Color.FromArgb(10, 131, 35);
            this.BackColor = Color.White;
        }


        private void CheckPhone(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 43 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void CreateDoctor_MouseMove(object sender, MouseEventArgs e)
        {
            AddButton.BackColor = Color.White;
            AddButton.ForeColor = Color.FromArgb(10, 131, 35);
            CancelButton.BackColor = Color.White;
            CancelButton.ForeColor = Color.FromArgb(10, 131, 35);
        }

        private void CancelButton_MouseMove(object sender, MouseEventArgs e)
        {
            CancelButton.BackColor = Color.FromArgb(10, 131, 35);
            CancelButton.ForeColor = Color.White;
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
            AdminMainForm amf = new AdminMainForm();
            amf.Show();
            conn.Close();
        }

        private void AddButton_MouseMove(object sender, MouseEventArgs e)
        {
            AddButton.BackColor = Color.FromArgb(10, 131, 35);
            AddButton.ForeColor = Color.White;
        }

        private void CheckDigit(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void CreateNewDoctor(object sender, EventArgs e)
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
            else if (CBSetSpec.Text == "")
            {
                msg.DataError("Выберите специализацию!");
                CBSetSpec.Focus();
            }
            else
            {
                conn.Open();
                sql = "SELECT COUNT(*) FROM DOCTOR WHERE DOC_EMAIL = '" + TextEmail.Text + "'";
                MySqlCommand checkEmail = new MySqlCommand(sql, conn);
                COUNT = Convert.ToInt32(checkEmail.ExecuteScalar());
                if (COUNT == 0)
                {
                    sql = "SELECT COUNT(*) FROM DOCTOR WHERE DOC_IIN = '" + TextIIN.Text + "'";
                    MySqlCommand checkIIN = new MySqlCommand(sql, conn);
                    COUNT = Convert.ToInt32(checkIIN.ExecuteScalar());
                    if (COUNT == 0)
                    {
                        sql = "INSERT INTO DOCTOR (DOC_LASTNAME, " +
                            "DOC_FIRSTNAME, " +
                            "DOC_PATRONYMIC, " +
                            "DOC_IIN, " +
                            "DOC_EMAIL, " +
                            "DOC_PHONE, " +
                            "DOC_PASSWORD, " +
                            "SPECIALISATION_ID_SPEC) " +
                            "VALUES ('" + TextLastName.Text + "', " +
                            "'" + TextFirstName.Text + "', " +
                            "'" + TextPatronymic.Text + "', " +
                            "'" + TextIIN.Text + "', " +
                            "'" + TextEmail.Text + "', " +
                            "'" + TextPhone.Text + "', " +
                            "'" + TextPassword.Text + "', " +
                            "" + idspec + ")";
                        MySqlCommand insdoc = new MySqlCommand(sql, conn);
                        if (insdoc.ExecuteNonQuery() == 1)
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
                        msg.DataError("ИИН уже существует в системе!");
                        conn.Close();
                    }
                }
                else
                {
                    msg.DataError("Электронный адрес уже существует в системе!");
                    conn.Close();
                }
            }
        }

    }
}
