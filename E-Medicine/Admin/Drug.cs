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
    public partial class CreateMedicine : Form
    {
        int COUNT = 0, groupid, typeid;
        string sql;
        static string connstr = Operations.connection_string;
        MySqlConnection conn = new MySqlConnection(connstr);

        private void CreateNewDrug(object sender, EventArgs e)
        {
            Messages msg = new Messages();
            if (TextNameMedicine.Text == "")
            {
                msg.DataError("Введите название!");
                TextNameMedicine.Focus();
            }
            else if (CBSetCategory.Text == "")
            {
                msg.DataError("Выберите категорию!");
                CBSetCategory.Focus();
            }
            else if (CBSetGroup.Text == "")
            {
                msg.DataError("Выберите группу!");
                CBSetGroup.Focus();
            }
            else if (CBSetType.Text == "")
            {
                msg.DataError("Выберите тип!");
                CBSetType.Focus();
            }
            else
            {
                conn.Open();
                sql = "SELECT COUNT(*) FROM DRUG WHERE DRUG_NAME = '" + TextNameMedicine.Text + "'";
                MySqlCommand check = new MySqlCommand(sql, conn);
                COUNT = Convert.ToInt32(check.ExecuteScalar());
                if (COUNT == 0)
                {
                    sql = "SELECT ID_GROUP FROM DRUG_GROUP WHERE GROUP_NAME = '" + CBSetGroup.Text + "'";
                    MySqlCommand grid = new MySqlCommand(sql, conn);
                    groupid = Convert.ToInt32(grid.ExecuteScalar());

                    sql = "SELECT ID_TYPE FROM DRUG_TYPE WHERE TYPE_NAME = '" + CBSetType.Text + "'";
                    MySqlCommand tyid = new MySqlCommand(sql, conn);
                    typeid = Convert.ToInt32(tyid.ExecuteScalar());

                    sql = "INSERT INTO DRUG (DRUG_NAME, " +
                        "DRUG_TYPE_ID_TYPE, " +
                        "DRUG_GROUP_ID_GROUP) " +
                        "VALUES ('" + TextNameMedicine.Text + "'," +
                        "" + typeid + ", " +
                        "" + groupid + ")";
                    MySqlCommand medins = new MySqlCommand(sql, conn);
                    if (medins.ExecuteNonQuery() == 1)
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
                    msg.DataError("Препарат уже существует в базе!");
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

        public CreateMedicine()
        {
            InitializeComponent();
            CBSetCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CBSetGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CBSetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            conn.Open();
            sql = "SELECT * FROM DRUG_CATEGORY ORDER BY 2 ASC";
            MySqlCommand category = new MySqlCommand(sql, conn);
            MySqlDataReader readercategory = category.ExecuteReader();
            while (readercategory.Read())
            {
                CBSetCategory.Items.Add(readercategory.GetString("CATEGORY_NAME"));
            }
            conn.Close();

            conn.Open();
            sql = "SELECT * FROM DRUG_TYPE ORDER BY 2 ASC";
            MySqlCommand type = new MySqlCommand(sql, conn);
            MySqlDataReader readertype = type.ExecuteReader();
            while (readertype.Read())
            {
                CBSetType.Items.Add(readertype.GetString("TYPE_NAME"));
            }
            conn.Close();
            label2.ForeColor = Color.FromArgb(10, 131, 35);
            label3.ForeColor = Color.FromArgb(10, 131, 35);
            label4.ForeColor = Color.FromArgb(10, 131, 35);
            LabelNameClPh.ForeColor = Color.FromArgb(10, 131, 35);
            AddButton.BackColor = Color.White;
            AddButton.ForeColor = Color.FromArgb(10, 131, 35);
            CancelButton.BackColor = Color.White;
            CancelButton.ForeColor = Color.FromArgb(10, 131, 35);
            this.BackColor = Color.White;
        }

        private void SelectCategory(object sender, EventArgs e)
        {
            CBSetGroup.Text = "";
            CBSetGroup.Items.Clear();
            conn.Open();
            sql = "SELECT * " +
                "FROM DRUG_GROUP " +
                "WHERE DRUG_CATEGORY_ID_CATEGORY = ( " +
                "SELECT ID_CATEGORY " +
                "FROM DRUG_CATEGORY " +
                "WHERE CATEGORY_NAME = '" + CBSetCategory.Text + "') " +
                "ORDER BY 2 ASC";
            MySqlCommand group = new MySqlCommand(sql, conn);
            MySqlDataReader readergroup = group.ExecuteReader();
            while (readergroup.Read())
            {
                CBSetGroup.Items.Add(readergroup.GetString("GROUP_NAME"));
            }
            conn.Close();
        }

        private void CreateMedicine_MouseMove(object sender, MouseEventArgs e)
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
        private void AddButton_MouseMove(object sender, MouseEventArgs e)
        {
            AddButton.BackColor = Color.FromArgb(10, 131, 35);
            AddButton.ForeColor = Color.White;
        }
    }
}
