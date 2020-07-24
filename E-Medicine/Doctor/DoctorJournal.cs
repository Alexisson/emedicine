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
    public partial class DoctorJournal : Form
    {
        static string connstr = Operations.connection_string;
        MySqlConnection conn = new MySqlConnection(connstr);
        int did, COUNT;
        string sql;
        public DoctorJournal(int id)
        {
            Messages msg = new Messages();
            did = id;
            InitializeComponent();

            conn.Open();
            sql = "SELECT COUNT(*) " +
                "FROM PRESCRIPTION " +
                "WHERE DOCTOR_ID_DOCTOR = " + did + "";
            MySqlCommand check = new MySqlCommand(sql, conn);
            COUNT = Convert.ToInt32(check.ExecuteScalar());
            if (COUNT == 0)
            {
               msg.DataError("Журналов нет!");
                CBJType.Enabled = false;
            }
            CBJType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BackColor = Color.White;
            ExitButton.BackColor = Color.White;
            ExitButton.ForeColor = Color.FromArgb(10, 131, 35);
        }

        private void SetTypeOfJournal(object sender, EventArgs e)
        {
            switch (CBJType.SelectedIndex)
            {
                    case 0:
                        DataTable dt1 = new DataTable();
                        sql = "SELECT PERSON.PERSON_LASTNAME 'Фамилия', " +
                        "PERSON.PERSON_FIRSTNAME 'Имя', " +
                        "PERSON.PERSON_IIN 'ИИН', " +
                        "PRESCRIPTION.PRESCRIPTION_DATE_START 'Дата посещения' " +
                        "FROM PRESCRIPTION INNER JOIN PERSON " +
                        "ON PERSON.PERSON_IIN = PRESCRIPTION.PERSON_PERSON_IIN  " +
                        "GROUP BY PERSON.PERSON_LASTNAME, " +
                        "PERSON.PERSON_FIRSTNAME, " +
                        "PERSON.PERSON_IIN, " +
                        "PRESCRIPTION.PRESCRIPTION_DATE_START," +
                        "PRESCRIPTION.DOCTOR_ID_DOCTOR " +
                        "HAVING PRESCRIPTION.DOCTOR_ID_DOCTOR = " + did + " " +
                        "ORDER BY 4 ASC";
                    MySqlCommand jlist1 = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = jlist1.ExecuteReader();
                    dt1.Load(reader);
                    JournalList.DataSource = dt1;
                    break;
                case 1:
                    DataTable dt2 = new DataTable();
                    sql = "SELECT PERSON.PERSON_LASTNAME 'Фамилия', " +
                        "PERSON.PERSON_FIRSTNAME 'Имя', " +
                        "PERSON.PERSON_IIN 'ИИН', " +
                        "DRUG.DRUG_NAME 'Препарат', " +
                        "PRESCRIPTION.PRESCRIPTION_DATE_START 'Дата выдачи' " +
                        "FROM PRESCRIPTION INNER JOIN PERSON " +
                        "ON PERSON.PERSON_IIN = PRESCRIPTION.PERSON_PERSON_IIN " +
                        "INNER JOIN DRUG " +
                        "ON PRESCRIPTION.MEDICINE_ID_MEDICINE = DRUG.ID_MEDICINE " +
                        "WHERE PRESCRIPTION.DOCTOR_ID_DOCTOR = " + did + " " +
                        "ORDER BY 5 ASC";
                    MySqlCommand jlist2 = new MySqlCommand(sql, conn);
                    MySqlDataReader reader2 = jlist2.ExecuteReader();
                    dt2.Load(reader2);
                    JournalList.DataSource = dt2;
                    break;
            }
        }

        private void ExitButton_MouseHover(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.FromArgb(10, 131, 35);
            ExitButton.ForeColor = Color.White;
        }

        private void DoctorJournal_MouseMove(object sender, MouseEventArgs e)
        {
            ExitButton.BackColor = Color.White;
            ExitButton.ForeColor = Color.FromArgb(10, 131, 35);
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
            DoctorMode doctorMode = new DoctorMode(did);
            doctorMode.Show();
            conn.Close();
        }
    }
}
