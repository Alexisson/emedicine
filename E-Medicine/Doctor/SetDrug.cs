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
    public partial class SetMedicine : Form
    {
        int COUNT, did, mid;
        string sql, iin;
        static string connstr = Operations.connection_string;
        MySqlConnection conn = new MySqlConnection(connstr);
        public SetMedicine(int id)
        {
            did = id;
            InitializeComponent();
            conn.Open();
            sql = "SELECT * FROM DRUG_CATEGORY ORDER BY 2 ASC";
            MySqlCommand category = new MySqlCommand(sql, conn);
            MySqlDataReader readercategory = category.ExecuteReader();
            while (readercategory.Read())
            {
                CBSetCategory.Items.Add(readercategory.GetString("CATEGORY_NAME"));
            }
            conn.Close();
            CBSetCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CBSetGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CBSetName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CBSetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            AddButton.BackColor = Color.White;
            AddButton.ForeColor = Color.FromArgb(10, 131, 35);
            CancelButton.BackColor = Color.White;
            CancelButton.ForeColor = Color.FromArgb(10, 131, 35);
            label2.ForeColor = Color.FromArgb(10, 131, 35);
            label3.ForeColor = Color.FromArgb(10, 131, 35);
            label4.ForeColor = Color.FromArgb(10, 131, 35);
            LabelIIN.ForeColor = Color.FromArgb(10, 131, 35);
            LabelNameClPh.ForeColor = Color.FromArgb(10, 131, 35);
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

        private void SelectGroup(object sender, EventArgs e)
        {
            CBSetName.Text = "";
            CBSetName.Items.Clear();
            conn.Open();
            sql = "SELECT * " +
                "FROM DRUG " +
                "WHERE DRUG_GROUP_ID_GROUP = ( " +
                "SELECT ID_GROUP " +
                "FROM DRUG_GROUP " +
                "WHERE GROUP_NAME = '" + CBSetGroup.Text + "') " +
                "ORDER BY 2 ASC";
            MySqlCommand name = new MySqlCommand(sql, conn);
            MySqlDataReader readername = name.ExecuteReader();
            while (readername.Read())
            {
                CBSetName.Items.Add(readername.GetString("DRUG_NAME"));
            }
            conn.Close();
        }

        private void CheckDigit(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void SelectType(object sender, EventArgs e)
        {
            if (CBSetType.Text != "")
            {
                PanelMedicine.Visible = true;
            }
            else
            {
                PanelMedicine.Visible = false;
            }
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
            DoctorMode doctorMode = new DoctorMode(did);
            doctorMode.Show();
            conn.Close();
        }

        private void SetMedicine_MouseMove(object sender, MouseEventArgs e)
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

        private void SetMedicineToPerson(object sender, EventArgs e)
        {

            iin = TextIIN.Text;
            Messages msg = new Messages();
          
            if (CBSetType.Text == "")
            {
                msg.DataError("Выберите тип препарата!");
                CBSetType.Focus();
            }
            else if (TextIIN.Text.Length != 12)
            {
                msg.DataError("Введите корректный ИИН!");
                TextIIN.Focus();
            }
            else if (CBSetCategory.Text == "")
            {
                msg.DataError("Выберите категорию препарата!");
                CBSetCategory.Focus();
            }
            else if (CBSetGroup.Text == "")
            {
                msg.DataError("Выберите группу препарата!");
                CBSetGroup.Focus();
            }
            else if (CBSetName.Text == "")
            {
                msg.DataError("Выберите название препарата!");
                CBSetName.Focus();
            }
            else
            {
                conn.Open();
                sql = "SELECT COUNT(*) " +
               "FROM PERSON_HAS_DOCTOR " +
               "WHERE PERSON_HAS_DOCTOR.PERSON_PERSON_IIN = '" + iin + "' " +
               "AND PERSON_HAS_DOCTOR.DOCTOR_ID_DOCTOR = " + did + "";
                MySqlCommand checkperson = new MySqlCommand(sql, conn);
                COUNT = Convert.ToInt32(checkperson.ExecuteScalar());
                if (COUNT == 0)
                {
                    msg.DataError("Невозможно назначить препарат!");
                    conn.Close();
                }
                else
                {
                    sql = "SELECT ID_MEDICINE FROM DRUG WHERE DRUG_NAME = '" + CBSetName.Text + "' ";
                    MySqlCommand medicineid = new MySqlCommand(sql, conn);
                    mid = Convert.ToInt32(medicineid.ExecuteScalar());
                    switch (CBSetType.SelectedIndex)
                    {
                        case 0:
                            sql = "SELECT COUNT(*) FROM FORBIDDEN_DRUG WHERE MEDICINE_ID_MEDICINE = " + mid + "";
                            MySqlCommand recmed = new MySqlCommand(sql, conn);
                            COUNT = Convert.ToInt32(recmed.ExecuteScalar());
                            if (COUNT == 0)
                            {
                                sql = "SELECT COUNT(*) FROM RECOMMENDED_DRUG " +
                                    "WHERE MEDICINE_ID_MEDICINE = " + mid + " AND PERSON_PERSON_IIN = " + iin + "";
                                MySqlCommand checkmed = new MySqlCommand(sql, conn);
                                COUNT = Convert.ToInt32(checkmed.ExecuteScalar());
                                if (COUNT == 0)
                                {
                                    sql = "INSERT INTO RECOMMENDED_DRUG ( PERSON_PERSON_IIN, MEDICINE_ID_MEDICINE) " +
                                        "VALUES ('" + iin + "', " + mid + ")";
                                    MySqlCommand insrecmed = new MySqlCommand(sql, conn);

                                    if (insrecmed.ExecuteNonQuery() == 1)
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
                                else
                                {
                                    msg.DataError("Запись уже существует!");
                                    conn.Close();
                                }
                            }
                            else
                            {
                                msg.DataError("Ошибка совместимости!");
                                conn.Close();
                            }
                            break;

                        case 1:
                            sql = "SELECT COUNT(*) FROM RECOMMENDED_DRUG WHERE MEDICINE_ID_MEDICINE = " + mid + "";
                            MySqlCommand formed = new MySqlCommand(sql, conn);
                            COUNT = Convert.ToInt32(formed.ExecuteScalar());
                            if (COUNT == 0)
                            {
                                sql = "SELECT COUNT(*) FROM FORBIDDEN_DRUG " +
                                    "WHERE MEDICINE_ID_MEDICINE = " + mid + " AND PERSON_PERSON_IIN = " + iin + "";
                                MySqlCommand checkmed = new MySqlCommand(sql, conn);
                                COUNT = Convert.ToInt32(checkmed.ExecuteScalar());
                                if (COUNT == 0)
                                {
                                    sql = "INSERT INTO FORBIDDEN_DRUG (MEDICINE_ID_MEDICINE, PERSON_PERSON_IIN) " +
                                    "VALUES (" + mid + ",'" + iin + "')";
                                    MySqlCommand insrformed = new MySqlCommand(sql, conn);
                                    if (insrformed.ExecuteNonQuery() == 1)
                                    {
                                        msg.WriteSuccess();
                                        this.Close();
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
                                    msg.DataError("Запись уже существует!");
                                    conn.Close();
                                }
                            }
                            else
                            {
                                msg.DataError("Ошибка совместимости!");
                                conn.Close();
                            }
                            break;
                    }
                }
            }
        }
    }
}
