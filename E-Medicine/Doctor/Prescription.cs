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
    public partial class Prescription : Form
    {
        int sw = 0, COUNT, did, m1, m2, m3, m4;
        string sql, sqlins1, sqlins2, sqlins3, sqlins4, iin;
        static string connstr = Operations.connection_string;
        MySqlConnection conn = new MySqlConnection(connstr);
        string sqlcat = "SELECT * FROM DRUG_CATEGORY ORDER BY 2 ASC";
        string date = DateTime.Now.ToString("yyyy.MM.dd");
        public Prescription(int id)
        {
            did = id;
            
            InitializeComponent();

            CBSetCategory1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CBSetCategory2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CBSetCategory3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CBSetCategory4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CBSetGroup1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CBSetGroup2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CBSetGroup3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CBSetGroup4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CBSetName1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CBSetName2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CBSetName3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CBSetName4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            label1.ForeColor = Color.FromArgb(10, 131, 35);
            label10.ForeColor = Color.FromArgb(10, 131, 35);
            label11.ForeColor = Color.FromArgb(10, 131, 35);
            label2.ForeColor = Color.FromArgb(10, 131, 35);
            label3.ForeColor = Color.FromArgb(10, 131, 35);
            label4.ForeColor = Color.FromArgb(10, 131, 35);
            label5.ForeColor = Color.FromArgb(10, 131, 35);
            label6.ForeColor = Color.FromArgb(10, 131, 35);
            label7.ForeColor = Color.FromArgb(10, 131, 35);
            label8.ForeColor = Color.FromArgb(10, 131, 35);
            label9.ForeColor = Color.FromArgb(10, 131, 35);
            LabelIIN.ForeColor = Color.FromArgb(10, 131, 35);
            LabelNameClPh.ForeColor = Color.FromArgb(10, 131, 35);
            button1.BackColor = Color.White;
            button1.ForeColor = Color.FromArgb(10, 131, 35);
            button3.BackColor = Color.White;
            button3.ForeColor = Color.FromArgb(10, 131, 35);
            ApplyButton.BackColor = Color.White;
            ApplyButton.ForeColor = Color.FromArgb(10, 131, 35);
            CheckIINButton.BackColor = Color.White;
            CheckIINButton.ForeColor = Color.FromArgb(10, 131, 35);
            RemoveButton.BackColor = Color.White;
            RemoveButton.ForeColor = Color.FromArgb(10, 131, 35);
            this.BackColor = Color.White;
        }

        private void SelectCategory1(object sender, EventArgs e)
        {
            CBSetGroup1.Text = "";
            CBSetGroup1.Items.Clear();
            conn.Open();
            sql = "SELECT * " +
                "FROM DRUG_GROUP " +
                "WHERE DRUG_CATEGORY_ID_CATEGORY = ( " +
                "SELECT ID_CATEGORY " +
                "FROM DRUG_CATEGORY " +
                "WHERE CATEGORY_NAME = '" + CBSetCategory1.Text + "') " +
                "ORDER BY 2 ASC";
            MySqlCommand group1 = new MySqlCommand(sql, conn);
            MySqlDataReader readergroup1 = group1.ExecuteReader();
            while (readergroup1.Read())
            {
                CBSetGroup1.Items.Add(readergroup1.GetString("GROUP_NAME"));
            }
            conn.Close();
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
            DoctorMode doctorMode = new DoctorMode(did);
            doctorMode.Show();
            conn.Close();
        }

        private void SelectCategory2(object sender, EventArgs e)
        {
            CBSetGroup2.Text = "";
            CBSetGroup2.Items.Clear();
            conn.Open();
            sql = "SELECT * " +
                "FROM DRUG_GROUP " +
                "WHERE DRUG_CATEGORY_ID_CATEGORY = ( " +
                "SELECT ID_CATEGORY " +
                "FROM DRUG_CATEGORY " +
                "WHERE CATEGORY_NAME = '" + CBSetCategory2.Text + "') " +
                "ORDER BY 2 ASC";
            MySqlCommand group2 = new MySqlCommand(sql, conn);
            MySqlDataReader readergroup2 = group2.ExecuteReader();
            while (readergroup2.Read())
            {
                CBSetGroup2.Items.Add(readergroup2.GetString("GROUP_NAME"));
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

        private void Prescription_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.FromArgb(10, 131, 35);
            button3.BackColor = Color.White;
            button3.ForeColor = Color.FromArgb(10, 131, 35);
            ApplyButton.BackColor = Color.White;
            ApplyButton.ForeColor = Color.FromArgb(10, 131, 35);
            CheckIINButton.BackColor = Color.White;
            CheckIINButton.ForeColor = Color.FromArgb(10, 131, 35);
            RemoveButton.BackColor = Color.White;
            RemoveButton.ForeColor = Color.FromArgb(10, 131, 35);
        }

        private void CheckIINButton_MouseMove(object sender, MouseEventArgs e)
        {
            CheckIINButton.BackColor = Color.FromArgb(10, 131, 35);
            CheckIINButton.ForeColor = Color.White;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.FromArgb(10, 131, 35);
            button1.ForeColor = Color.White;
        }

        private void RemoveButton_MouseMove(object sender, MouseEventArgs e)
        {
            RemoveButton.BackColor = Color.FromArgb(10, 131, 35);
            RemoveButton.ForeColor = Color.White;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.FromArgb(10, 131, 35);
            button3.ForeColor = Color.White;
        }

        private void ApplyButton_MouseMove(object sender, MouseEventArgs e)
        {
            ApplyButton.BackColor = Color.FromArgb(10, 131, 35);
            ApplyButton.ForeColor = Color.White;
        }

        private void SelectCategory3(object sender, EventArgs e)
        {
            CBSetGroup3.Text = "";
            CBSetGroup3.Items.Clear();
            conn.Open();
            sql = "SELECT * " +
                "FROM DRUG_GROUP " +
                "WHERE DRUG_CATEGORY_ID_CATEGORY = ( " +
                "SELECT ID_CATEGORY " +
                "FROM DRUG_CATEGORY " +
                "WHERE CATEGORY_NAME = '" + CBSetCategory3.Text + "') " +
                "ORDER BY 2 ASC";
            MySqlCommand group3 = new MySqlCommand(sql, conn);
            MySqlDataReader readergroup3 = group3.ExecuteReader();
            while (readergroup3.Read())
            {
                CBSetGroup3.Items.Add(readergroup3.GetString("GROUP_NAME"));
            }
            conn.Close();
        }

        private void SelectCategory4(object sender, EventArgs e)
        {
            CBSetGroup4.Text = "";
            CBSetGroup4.Items.Clear();
            conn.Open();
            sql = "SELECT * " +
                "FROM DRUG_GROUP " +
                "WHERE DRUG_CATEGORY_ID_CATEGORY = ( " +
                "SELECT ID_CATEGORY " +
                "FROM DRUG_CATEGORY " +
                "WHERE CATEGORY_NAME = '" + CBSetCategory4.Text + "') " +
                "ORDER BY 2 ASC";
            MySqlCommand group4 = new MySqlCommand(sql, conn);
            MySqlDataReader readergroup4 = group4.ExecuteReader();
            while (readergroup4.Read())
            {
                CBSetGroup1.Items.Add(readergroup4.GetString("GROUP_NAME"));
            }
            conn.Close();
        }

        private void SelectGroup1(object sender, EventArgs e)
        {
            CBSetName1.Text = "";
            CBSetName1.Items.Clear();
            conn.Open();
            sql = "SELECT * " +
                "FROM DRUG " +
                "WHERE DRUG_GROUP_ID_GROUP = ( " +
                "SELECT ID_GROUP " +
                "FROM DRUG_GROUP " +
                "WHERE GROUP_NAME = '" + CBSetGroup1.Text + "') " +
                "ORDER BY 2 ASC";
            MySqlCommand name1 = new MySqlCommand(sql, conn);
            MySqlDataReader readername1 = name1.ExecuteReader();
            while (readername1.Read())
            {
                CBSetName1.Items.Add(readername1.GetString("DRUG_NAME"));
            }
            conn.Close();
        }

        private void SelectGroup2(object sender, EventArgs e)
        {
            CBSetName2.Text = "";
            CBSetName2.Items.Clear();
            conn.Open();
            sql = "SELECT * " +
                "FROM DRUG " +
                "WHERE DRUG_GROUP_ID_GROUP = ( " +
                "SELECT ID_GROUP " +
                "FROM DRUG_GROUP " +
                "WHERE GROUP_NAME = '" + CBSetGroup2.Text + "') " +
                "ORDER BY 2 ASC";
            MySqlCommand name2 = new MySqlCommand(sql, conn);
            MySqlDataReader readername2 = name2.ExecuteReader();
            while (readername2.Read())
            {
                CBSetName2.Items.Add(readername2.GetString("DRUG_NAME"));
            }
            conn.Close();
        }

        private void SelectGroup3(object sender, EventArgs e)
        {
            CBSetName3.Text = "";
            CBSetName3.Items.Clear();
            conn.Open();
            sql = "SELECT * " +
                "FROM DRUG " +
                "WHERE DRUG_GROUP_ID_GROUP = ( " +
                "SELECT ID_GROUP " +
                "FROM DRUG_GROUP " +
                "WHERE GROUP_NAME = '" + CBSetGroup3.Text + "') " +
                "ORDER BY 2 ASC";
            MySqlCommand name3 = new MySqlCommand(sql, conn);
            MySqlDataReader readername3 = name3.ExecuteReader();
            while (readername3.Read())
            {
                CBSetName3.Items.Add(readername3.GetString("DRUG_NAME"));
            }
            conn.Close();
        }

        private void SelectGroup4(object sender, EventArgs e)
        {
            CBSetName4.Text = "";
            CBSetName4.Items.Clear();
            conn.Open();
            sql = "SELECT * " +
                "FROM DRUG " +
                "WHERE DRUG_GROUP_ID_GROUP = ( " +
                "SELECT ID_GROUP " +
                "FROM DRUG_GROUP " +
                "WHERE GROUP_NAME = '" + CBSetGroup4.Text + "') " +
                "ORDER BY 2 ASC";
            MySqlCommand name4 = new MySqlCommand(sql, conn);
            MySqlDataReader readername4 = name4.ExecuteReader();
            while (readername4.Read())
            {
                CBSetName4.Items.Add(readername4.GetString("DRUG_NAME"));
            }
            conn.Close();
        }

        private void CheckIIN(object sender, EventArgs e)
        {
            Messages msg = new Messages();
            iin = TextIIN.Text;
            conn.Open();
            sql = "SELECT COUNT(*) " +
           "FROM PERSON_HAS_DOCTOR " +
           "WHERE PERSON_HAS_DOCTOR.PERSON_PERSON_IIN = '" + iin + "' " +
           "AND PERSON_HAS_DOCTOR.DOCTOR_ID_DOCTOR = " + did + "";
            MySqlCommand checkperson = new MySqlCommand(sql, conn);
            COUNT = Convert.ToInt32(checkperson.ExecuteScalar());
            if (COUNT == 0)
            {
                msg.DataError("Пациент не найден!");
                conn.Close();
            }
            else
            {
                button1.Visible = true;
                RemoveButton.Visible = true;
                ApplyButton.Visible = true;
                conn.Close();
            }
        }

        private void SetPrescription(object sender, EventArgs e)
        {
            Messages msg = new Messages();
            iin = TextIIN.Text;
            conn.Open();
            switch (sw)
            {
                case 1:
                    if(CBSetName1.Text == "")
                    {
                        msg.DataError("Заполните данные!");
                    }
                    else
                    {
                        sql = "SELECT ID_MEDICINE FROM DRUG WHERE DRUG_NAME = '" + CBSetName1.Text + "'";
                        MySqlCommand med1 = new MySqlCommand(sql, conn);
                        m1 = Convert.ToInt32(med1.ExecuteScalar());
                        sql = "SELECT COUNT(*) FROM FORBIDDEN_DRUG " +
                            "WHERE PERSON_PERSON_IIN = '" + iin + "' " +
                            "AND MEDICINE_ID_MEDICINE = " + m1 +"";
                        MySqlCommand c1 = new MySqlCommand(sql, conn);
                        COUNT = Convert.ToInt32(c1.ExecuteScalar());
                        if(COUNT == 0)
                        {
                            sql = "INSERT INTO PRESCRIPTION (MEDICINE_ID_MEDICINE, PRESCRIPTION_DATE_START, PERSON_PERSON_IIN, DOCTOR_ID_DOCTOR) " +
                                "VALUES (" + m1 + ",'" + date + "', '" + iin + "', " + did + ")";
                            MySqlCommand inspr1 = new MySqlCommand(sql, conn);

                            if (inspr1.ExecuteNonQuery() == 1)
                            {
                                    msg.WriteSuccess();
                                    this.Close();
                                    DoctorMode doctorMode = new DoctorMode(did);
                                    doctorMode.Show();
                                    conn.Close();
                            }
                            else
                            {
                                msg.DataError("Создание рецепта не удалось!");
                                conn.Close();
                            }
                        }
                        else
                        {
                            msg.DataError("Ошибка совместимости!");
                            conn.Close();
                        }
                    }
                    break;
                case 2:
                    if (CBSetName1.Text == CBSetName2.Text)
                    {
                       msg.DataError("Данные совпадают!");
                    }
                    else if (CBSetName1.Text == "" | CBSetName2.Text == "")
                    {
                        msg.DataError("Заполните данные!");
                    }
                    else
                    {
                        sql = "SELECT ID_MEDICINE FROM DRUG WHERE DRUG_NAME = '" + CBSetName1.Text + "'";
                        MySqlCommand med1 = new MySqlCommand(sql, conn);
                        m1 = Convert.ToInt32(med1.ExecuteScalar());
                        sql = "SELECT COUNT(*) FROM FORBIDDEN_DRUG " +
                            "WHERE PERSON_PERSON_IIN = '" + iin + "' " +
                            "AND MEDICINE_ID_MEDICINE = " + m1 + "";
                        MySqlCommand c1 = new MySqlCommand(sql, conn);
                        COUNT = Convert.ToInt32(c1.ExecuteScalar());
                        if (COUNT == 0)
                        {
                            sql = "SELECT ID_MEDICINE FROM DRUG WHERE DRUG_NAME = '" + CBSetName2.Text + "'";
                            MySqlCommand med2 = new MySqlCommand(sql, conn);
                            m2 = Convert.ToInt32(med2.ExecuteScalar());
                            sql = "SELECT COUNT(*) FROM FORBIDDEN_DRUG " +
                                "WHERE PERSON_PERSON_IIN = '" + iin + "' " +
                                "AND MEDICINE_ID_MEDICINE = " + m2 + "";
                            MySqlCommand c2 = new MySqlCommand(sql, conn);
                            COUNT = Convert.ToInt32(c2.ExecuteScalar());
                            if (COUNT == 0)
                            {
                                sqlins1 = "INSERT INTO PRESCRIPTION (MEDICINE_ID_MEDICINE, PRESCRIPTION_DATE_START, PERSON_PERSON_IIN, DOCTOR_ID_DOCTOR) " +
                                      "VALUES (" + m1 + ",'" + date + "', '" + iin + "', " + did + ")";
                                MySqlCommand inspr1 = new MySqlCommand(sqlins1, conn);
                                sqlins2 = "INSERT INTO PRESCRIPTION (MEDICINE_ID_MEDICINE, PRESCRIPTION_DATE_START, PERSON_PERSON_IIN, DOCTOR_ID_DOCTOR) " +
                                      "VALUES (" + m2 + ",'" + date + "', '" + iin + "', " + did + ")";
                                MySqlCommand inspr2 = new MySqlCommand(sqlins2, conn);
                                if (inspr1.ExecuteNonQuery() == 1)
                                {
                                    if (inspr2.ExecuteNonQuery() == 1)
                                    {
                                        msg.WriteSuccess();
                                        this.Close();
                                        DoctorMode doctorMode = new DoctorMode(did);
                                        doctorMode.Show();
                                        conn.Close();
                                    }
                                    else
                                    {
                                        msg.DataError("Создание рецепта не удалось!");
                                        conn.Close();
                                    }
                                }                                
                                else
                                {
                                    msg.DataError("Создание рецепта не удалось!");
                                    conn.Close();
                                }
                            }
                            else
                            {
                                msg.DataError("Ошибка совместимости!");
                                conn.Close();
                            }
                        }
                        else
                        {
                            msg.DataError("Ошибка совместимости!");
                            conn.Close();
                        }
                    }
                        break;
                case 3:
                    if (CBSetName1.Text == CBSetName2.Text |
                        CBSetName1.Text == CBSetName3.Text |
                        CBSetName3.Text == CBSetName2.Text)
                    {
                       msg.DataError("Данные совпадают!");
                    }
                    else if (CBSetName1.Text == "" | CBSetName2.Text == "" | CBSetName3.Text == "")
                    {
                        msg.DataError("Заполните данные!");
                    }
                    else
                    {
                        sql = "SELECT ID_MEDICINE FROM DRUG WHERE DRUG_NAME = '" + CBSetName1.Text + "'";
                        MySqlCommand med1 = new MySqlCommand(sql, conn);
                        m1 = Convert.ToInt32(med1.ExecuteScalar());
                        sql = "SELECT COUNT(*) FROM FORBIDDEN_DRUG " +
                            "WHERE PERSON_PERSON_IIN = '" + iin + "' " +
                            "AND MEDICINE_ID_MEDICINE = " + m1 + "";
                        MySqlCommand c1 = new MySqlCommand(sql, conn);
                        COUNT = Convert.ToInt32(c1.ExecuteScalar());
                        if (COUNT == 0)
                        {
                            sql = "SELECT ID_MEDICINE FROM DRUG WHERE DRUG_NAME = '" + CBSetName2.Text + "'";
                            MySqlCommand med2 = new MySqlCommand(sql, conn);
                            m2 = Convert.ToInt32(med2.ExecuteScalar());
                            sql = "SELECT COUNT(*) FROM FORBIDDEN_DRUG " +
                                "WHERE PERSON_PERSON_IIN = '" + iin + "' " +
                                "AND MEDICINE_ID_MEDICINE = " + m2 + "";
                            MySqlCommand c2 = new MySqlCommand(sql, conn);
                            COUNT = Convert.ToInt32(c2.ExecuteScalar());
                            if (COUNT == 0)
                            {
                                sql = "SELECT ID_MEDICINE FROM DRUG WHERE DRUG_NAME = '" + CBSetName3.Text + "'";
                                MySqlCommand med3 = new MySqlCommand(sql, conn);
                                m3 = Convert.ToInt32(med2.ExecuteScalar());
                                sql = "SELECT COUNT(*) FROM FORBIDDEN_DRUG " +
                                    "WHERE PERSON_PERSON_IIN = '" + iin + "' " +
                                    "AND MEDICINE_ID_MEDICINE = " + m3 + "";
                                MySqlCommand c3 = new MySqlCommand(sql, conn);
                                COUNT = Convert.ToInt32(c3.ExecuteScalar());
                                if (COUNT == 0)
                                {
                                    sqlins1 = "INSERT INTO PRESCRIPTION (MEDICINE_ID_MEDICINE, PRESCRIPTION_DATE_START, PERSON_PERSON_IIN, DOCTOR_ID_DOCTOR) " +
                                      "VALUES ("+m1+",'" + date + "', '" + iin + "', " + did + ")";
                                    MySqlCommand inspr1 = new MySqlCommand(sqlins1, conn);
                                    sqlins2 = "INSERT INTO PRESCRIPTION (MEDICINE_ID_MEDICINE, PRESCRIPTION_DATE_START, PERSON_PERSON_IIN, DOCTOR_ID_DOCTOR) " +
                                          "VALUES ("+m2+",'" + date + "', '" + iin + "', " + did + ")";
                                    MySqlCommand inspr2 = new MySqlCommand(sqlins2, conn);
                                    sqlins3 = "INSERT INTO PRESCRIPTION (MEDICINE_ID_MEDICINE, PRESCRIPTION_DATE_START, PERSON_PERSON_IIN, DOCTOR_ID_DOCTOR) " +
                                        "VALUES ("+m3+",'" + date + "', '" + iin + "', " + did + ")";
                                    MySqlCommand inspr3 = new MySqlCommand(sqlins3, conn);
                                    if (inspr1.ExecuteNonQuery() == 1)
                                    {
                                        if (inspr2.ExecuteNonQuery() == 1)
                                        {
                                            if (inspr3.ExecuteNonQuery() == 1)
                                            {
                                                msg.WriteSuccess();
                                                this.Close();
                                                DoctorMode doctorMode = new DoctorMode(did);
                                                doctorMode.Show();
                                                conn.Close();
                                            }
                                            else
                                            {
                                                msg.DataError("Создание рецепта не удалось!");
                                                conn.Close();
                                            }
                                        }
                                        else
                                        {
                                            msg.DataError("Создание рецепта не удалось!");
                                            conn.Close();
                                        }
                                    }
                                    else
                                    {
                                        msg.DataError("Создание рецепта не удалось!");
                                        conn.Close();
                                    }
                                }
                                else
                                {
                                    msg.DataError("Ошибка совместимости!");
                                    conn.Close();
                                }
                            }
                            else
                            {
                                msg.DataError("Ошибка совместимости!");
                                conn.Close();
                            }
                        }
                        else
                        {
                            msg.DataError("Ошибка совместимости!");
                            conn.Close();
                        }
                    }
                    break;
                case 4:
                    if (CBSetName1.Text == CBSetName2.Text |
                        CBSetName1.Text == CBSetName3.Text |
                        CBSetName1.Text == CBSetName4.Text |
                        CBSetName2.Text == CBSetName3.Text |
                        CBSetName2.Text == CBSetName4.Text |
                        CBSetName3.Text == CBSetName4.Text)
                    {
                       msg.DataError("Данные совпадают!");
                    }
                    else if (CBSetName1.Text == "" | 
                        CBSetName2.Text == "" | 
                        CBSetName3.Text == "" | 
                        CBSetName4.Text == "")
                    {
                        msg.DataError("Заполните данные!");
                    }
                    else
                    {
                        sql = "SELECT ID_MEDICINE FROM DRUG WHERE DRUG_NAME = '" + CBSetName1.Text + "'";
                        MySqlCommand med1 = new MySqlCommand(sql, conn);
                        m1 = Convert.ToInt32(med1.ExecuteScalar());
                        sql = "SELECT COUNT(*) FROM FORBIDDEN_DRUG " +
                            "WHERE PERSON_PERSON_IIN = '" + iin + "' " +
                            "AND MEDICINE_ID_MEDICINE = " + m1 + "";
                        MySqlCommand c1 = new MySqlCommand(sql, conn);
                        COUNT = Convert.ToInt32(c1.ExecuteScalar());
                        if (COUNT == 0)
                        {
                            sql = "SELECT ID_MEDICINE FROM DRUG WHERE DRUG_NAME = '" + CBSetName2.Text + "'";
                            MySqlCommand med2 = new MySqlCommand(sql, conn);
                            m2 = Convert.ToInt32(med2.ExecuteScalar());
                            sql = "SELECT COUNT(*) FROM FORBIDDEN_DRUG " +
                                "WHERE PERSON_PERSON_IIN = '" + iin + "' " +
                                "AND MEDICINE_ID_MEDICINE = " + m2 + "";
                            MySqlCommand c2 = new MySqlCommand(sql, conn);
                            COUNT = Convert.ToInt32(c2.ExecuteScalar());
                            if (COUNT == 0)
                            {
                                sql = "SELECT ID_MEDICINE FROM DRUG WHERE DRUG_NAME = '" + CBSetName3.Text + "'";
                                MySqlCommand med3 = new MySqlCommand(sql, conn);
                                m3 = Convert.ToInt32(med2.ExecuteScalar());
                                sql = "SELECT COUNT(*) FROM FORBIDDEN_DRUG " +
                                    "WHERE PERSON_PERSON_IIN = '" + iin + "' " +
                                    "AND MEDICINE_ID_MEDICINE = " + m3 + "";
                                MySqlCommand c3 = new MySqlCommand(sql, conn);
                                COUNT = Convert.ToInt32(c3.ExecuteScalar());
                                if (COUNT == 0)
                                {
                                    sql = "SELECT ID_MEDICINE FROM DRUG WHERE DRUG_NAME = '" + CBSetName4.Text + "'";
                                    MySqlCommand med4 = new MySqlCommand(sql, conn);
                                    m4 = Convert.ToInt32(med2.ExecuteScalar());
                                    sql = "SELECT COUNT(*) FROM FORBIDDEN_DRUG " +
                                        "WHERE PERSON_PERSON_IIN = '" + iin + "' " +
                                        "AND MEDICINE_ID_MEDICINE = " + m4 + "";
                                    MySqlCommand c4 = new MySqlCommand(sql, conn);
                                    COUNT = Convert.ToInt32(c4.ExecuteScalar());
                                    if (COUNT == 0)
                                    {
                                        sqlins1 = "INSERT INTO PRESCRIPTION (MEDICINE_ID_MEDICINE, PRESCRIPTION_DATE_START, PERSON_PERSON_IIN, DOCTOR_ID_DOCTOR) " +
                                      "VALUES ("+m1+",'" + date + "', '" + iin + "', " + did + ")";
                                        MySqlCommand inspr1 = new MySqlCommand(sqlins1, conn);
                                        sqlins2 = "INSERT INTO PRESCRIPTION (MEDICINE_ID_MEDICINE, PRESCRIPTION_DATE_START, PERSON_PERSON_IIN, DOCTOR_ID_DOCTOR) " +
                                              "VALUES ("+m2+",'" + date + "', '" + iin + "', " + did + ")";
                                        MySqlCommand inspr2 = new MySqlCommand(sqlins2, conn);
                                        sqlins3 = "INSERT INTO PRESCRIPTION (MEDICINE_ID_MEDICINE, PRESCRIPTION_DATE_START, PERSON_PERSON_IIN, DOCTOR_ID_DOCTOR) " +
                                            "VALUES ("+m3+",'" + date + "', '" + iin + "', " + did + ")";
                                        MySqlCommand inspr3 = new MySqlCommand(sqlins3, conn);
                                        sqlins4 = "INSERT INTO PRESCRIPTION (MEDICINE_ID_MEDICINE, PRESCRIPTION_DATE_START, PERSON_PERSON_IIN, DOCTOR_ID_DOCTOR) " +
                                             "VALUES ("+m4+",'" + date + "', '" + iin + "', " + did + ")";
                                        MySqlCommand inspr4 = new MySqlCommand(sqlins4, conn);
                                        if (inspr1.ExecuteNonQuery() == 1)
                                        {
                                            if (inspr2.ExecuteNonQuery() == 1)
                                            {
                                                if (inspr3.ExecuteNonQuery() == 1)
                                                {
                                                    if (inspr4.ExecuteNonQuery() == 1)
                                                    {
                                                        msg.WriteSuccess();
                                                        this.Close();
                                                        DoctorMode doctorMode = new DoctorMode(did);
                                                        doctorMode.Show();
                                                        conn.Close();
                                                    }
                                                    else
                                                    {
                                                        msg.DataError("Создание рецепта не удалось!");
                                                        conn.Close();
                                                    }
                                                }
                                                else
                                                {
                                                    msg.DataError("Создание рецепта не удалось!");
                                                    conn.Close();
                                                }
                                            }
                                            else
                                            {
                                                msg.DataError("Создание рецепта не удалось!");
                                                conn.Close();
                                            }
                                        }
                                        else
                                        {
                                            msg.DataError("Создание рецепта не удалось!");
                                            conn.Close();
                                        }
                                    }
                                    else
                                    {
                                        msg.DataError("Ошибка совместимости!");
                                        conn.Close();
                                    }
                                }
                                else
                                {
                                    msg.DataError("Ошибка совместимости!");
                                    conn.Close();
                                }
                            }
                            else
                            {
                                msg.DataError("Ошибка совместимости!");
                                conn.Close();
                            }
                        }
                        else
                        {
                            msg.DataError("Ошибка совместимости!");
                            conn.Close();
                        }
                    }
             break;
            }
        }

        private void AddPrescription(object sender, EventArgs e)
        {
            sw = sw + 1;
            if(sw == 4)
            {
                button1.Enabled = false;
            }
            RemoveButton.Enabled = true;
            ApplyButton.Enabled = true;
            PanelVisible();
            
            conn.Open();
            switch (sw)
            {
                case 1:
                    MySqlCommand category1 = new MySqlCommand(sqlcat, conn);
                    MySqlDataReader readercategory1 = category1.ExecuteReader();
                    while (readercategory1.Read())
                    {
                        CBSetCategory1.Items.Add(readercategory1.GetString("CATEGORY_NAME"));
                    }
                    conn.Close();
                    break;
                case 2:
                    MySqlCommand category2 = new MySqlCommand(sqlcat, conn);
                    MySqlDataReader readercategory2 = category2.ExecuteReader();
                    while (readercategory2.Read())
                    {
                        CBSetCategory2.Items.Add(readercategory2.GetString("CATEGORY_NAME"));
                    }
                    conn.Close();
                    break;
                case 3:
                    MySqlCommand category3 = new MySqlCommand(sqlcat, conn);
                    MySqlDataReader readercategory3 = category3.ExecuteReader();
                    while (readercategory3.Read())
                    {
                        CBSetCategory3.Items.Add(readercategory3.GetString("CATEGORY_NAME"));
                    }
                    conn.Close();
                    break;
                case 4:
                    MySqlCommand category4 = new MySqlCommand(sqlcat, conn);
                    MySqlDataReader readercategory4 = category4.ExecuteReader();
                    while (readercategory4.Read())
                    {
                        CBSetCategory4.Items.Add(readercategory4.GetString("CATEGORY_NAME"));
                    }
                    conn.Close();
                    break;
            }
        }

        private void PanelVisible()
        {
            switch (sw)
            {
                case 0:
                    PanelMedicine1.Visible = false;
                    break;
                case 1:
                    PanelMedicine1.Visible = true;
                    PanelMedicine2.Visible = false;
                    break;
                case 2:
                    PanelMedicine2.Visible = true;
                    PanelMedicine3.Visible = false;
                    break;
                case 3:
                    PanelMedicine3.Visible = true;
                    PanelMedicine4.Visible = false;
                    break;
                case 4:
                    PanelMedicine4.Visible = true;
                    break;
            }
        }

        private void DeletePrescription(object sender, EventArgs e)
        {
            sw = sw - 1;
            if (sw == 0)
            {
                RemoveButton.Enabled = false;
                ApplyButton.Enabled = false;
            }
            button1.Enabled = true;

            PanelVisible();
        }
    }
}
