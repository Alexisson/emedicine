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
    public partial class SetGroup : Form
    {
        int sg, did;
        string sql, iin;
        static string connstr = Operations.connection_string;
        MySqlConnection conn = new MySqlConnection(connstr);
        public SetGroup(int id)
        {
            did = id;
            InitializeComponent();
            conn.Open();
            sql = "SELECT * FROM SOCIAL_GROUP ORDER BY 2 ASC";
            MySqlCommand category = new MySqlCommand(sql, conn);
            MySqlDataReader readercategory = category.ExecuteReader();
            while (readercategory.Read())
            {
                CBSetGroup.Items.Add(readercategory.GetString("SOCIAL_GROUP"));
            }
            conn.Close(); 
            CBSetGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            LabelGroup.ForeColor = Color.FromArgb(10, 131, 35);
            LabelIIN.ForeColor = Color.FromArgb(10, 131, 35);
            RemoveButton.BackColor = Color.White;
            RemoveButton.ForeColor = Color.FromArgb(10, 131, 35);
            ButtonCreate.BackColor = Color.White;
            ButtonCreate.ForeColor = Color.FromArgb(10, 131, 35);
            CancelButton.BackColor = Color.White;
            CancelButton.ForeColor = Color.FromArgb(10, 131, 35);
            this.BackColor = Color.White;
        }

        private void DeleteGroup(object sender, EventArgs e)
        {
            Messages msg = new Messages();
            conn.Open();
            iin = TextIIN.Text;
            if (TextIIN.Text == "")
            {
                msg.DataError("Заполните ИИН!");
            }
            else
            {
                sql = "UPDATE PERSON SET SOCIAL_GROUP_ID_SOCIAL_GROUP = NULL WHERE PERSON_IIN = '" + iin + "'";
                MySqlCommand upd2 = new MySqlCommand(sql, conn);
                if (upd2.ExecuteNonQuery() == 1)
                {
                    msg.DropSuccess();
                    this.Close();
                    DoctorMode doctorMode = new DoctorMode(did);
                    doctorMode.Show();
                    conn.Close();
                }
                else
                {
                    msg.DropSuccess();
                    conn.Close();
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

        private void ButtonCreate_MouseMove(object sender, MouseEventArgs e)
        {
            ButtonCreate.BackColor = Color.FromArgb(10, 131, 35);
            ButtonCreate.ForeColor = Color.White;
        }

        private void RemoveButton_MouseMove(object sender, MouseEventArgs e)
        {
            ButtonCreate.BackColor = Color.FromArgb(10, 131, 35);
            ButtonCreate.ForeColor = Color.White;
        }

        private void CancelButton_MouseMove(object sender, MouseEventArgs e)
        {
            CancelButton.BackColor = Color.FromArgb(10, 131, 35);
            CancelButton.ForeColor = Color.White;
        }

        private void SetGroup_MouseMove(object sender, MouseEventArgs e)
        {
            RemoveButton.BackColor = Color.White;
            RemoveButton.ForeColor = Color.FromArgb(10, 131, 35);
            ButtonCreate.BackColor = Color.White;
            ButtonCreate.ForeColor = Color.FromArgb(10, 131, 35);
            CancelButton.BackColor = Color.White;
            CancelButton.ForeColor = Color.FromArgb(10, 131, 35);
        }

        private void AddGroupToPerson(object sender, EventArgs e)
        {
            Messages msg = new Messages();
            iin = TextIIN.Text;
            if (TextIIN.Text == "" | CBSetGroup.Text == "")
            {
                msg.DataError("Заполните данные!");
            }
            else
            {
                conn.Open();
                sql = "SELECT ID_SOCIAL_GROUP FROM SOCIAL_GROUP WHERE SOCIAL_GROUP = '" + CBSetGroup.Text + "'";
                MySqlCommand sgid = new MySqlCommand(sql, conn);
                sg = Convert.ToInt32(sgid.ExecuteScalar());
                sql = "UPDATE EMEDICINE.PERSON SET SOCIAL_GROUP_ID_SOCIAL_GROUP = " + sg + " WHERE PERSON_IIN = '" + iin + "'";
                MySqlCommand upd1 = new MySqlCommand(sql, conn);
                if (upd1.ExecuteNonQuery() == 1)
                {
                    msg.WriteSuccess();
                    this.Close();
                    DoctorMode doctorMode = new DoctorMode(did);
                    doctorMode.Show();
                    conn.Close();
                }
                else
                {
                    msg.WriteError();
                    conn.Close();
                }
            }
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
            DoctorMode doctorMode = new DoctorMode(did);
            doctorMode.Show();
            conn.Close();
        }
    }
}
