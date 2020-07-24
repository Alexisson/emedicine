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
    public partial class SetAssignment : Form
    {
        int COUNT, did, sw;
        string sql, iin;
        static string connstr = Operations.connection_string;
        MySqlConnection conn = new MySqlConnection(connstr);
        DataTable dt = new DataTable();
        public SetAssignment(int id)
        {
            did = id;
            InitializeComponent();
            CBSetAssign.DropDownStyle = ComboBoxStyle.DropDownList;
            label1.ForeColor = Color.FromArgb(10, 131, 35);
            label2.ForeColor = Color.FromArgb(10, 131, 35);
            LabelIIN.ForeColor = Color.FromArgb(10, 131, 35);
            ApplyButtonCh.BackColor = Color.White;
            ApplyButtonCh.ForeColor = Color.FromArgb(10, 131, 35);
            ApplyButtonCr.BackColor = Color.White;
            ApplyButtonCr.ForeColor = Color.FromArgb(10, 131, 35);
            CreateButton.BackColor = Color.White;
            CreateButton.ForeColor = Color.FromArgb(10, 131, 35);
            CheckIINButton.BackColor = Color.White;
            CheckIINButton.ForeColor = Color.FromArgb(10, 131, 35);
            ChooseButton.BackColor = Color.White;
            ChooseButton.ForeColor = Color.FromArgb(10, 131, 35);
            ChangeButton.BackColor = Color.White;
            ChangeButton.ForeColor = Color.FromArgb(10, 131, 35);
            ViewButton.BackColor = Color.White;
            ViewButton.ForeColor = Color.FromArgb(10, 131, 35);
            ExitButtom.BackColor = Color.White;
            ExitButtom.ForeColor = Color.FromArgb(10, 131, 35);
            this.BackColor = Color.White;
        }

        private void CreateNewAssignmentMode(object sender, EventArgs e)
        {
            conn.Close();
            ViewAssignment.Visible = false;
            CreatePanel.Visible = true;
            ChoosePanel.Visible = false;
        }

        private void SelectAssignment(object sender, EventArgs e)
        {
            conn.Close();
            CBSetAssign.Items.Clear();
            CreatePanel.Visible = false;
            ChoosePanel.Visible = false;
            ViewAssignment.Visible = false;
            if (ChoosePanel.Visible == false)
            {
                sw = 0;
                conn.Open();
                ChoosePanel.Visible = true;
                sql = "SELECT * FROM ASSIGNMENT ORDER BY 2 ASC";
                MySqlCommand assign = new MySqlCommand(sql, conn);
                MySqlDataReader reader = assign.ExecuteReader();
                while (reader.Read())
                {
                    CBSetAssign.Items.Add(reader.GetString("ASSIGNMENT_NAME"));
                }
                conn.Close();
            }
            else
            {
                ChoosePanel.Visible = false;
            }
        }

        private void ModifyAssignmen(object sender, EventArgs e)
        {
            conn.Close();
            Messages msg = new Messages();
            conn.Open();
            iin = TextIIN.Text;
            switch (sw)
            {
                case 0:
                    sql = "SELECT COUNT(*) " +
                        "FROM PERSON_HAS_ASSIGNMENT INNER JOIN ASSIGNMENT " +
                        "ON PERSON_HAS_ASSIGNMENT.ASSIGNMENT_ID_ASSIGNMENT = ASSIGNMENT.ID_ASSIGNMENT " +
                        "WHERE ASSIGNMENT.ASSIGNMENT_NAME = '" + CBSetAssign.Text + "'" +
                        "AND PERSON_HAS_ASSIGNMENT.PERSON_PERSON_IIN = '" + iin + "'";
                    MySqlCommand check = new MySqlCommand(sql, conn);
                    COUNT = Convert.ToInt32(check.ExecuteScalar());
                    if (COUNT == 0)
                    {
                        sql = "INSERT INTO PERSON_HAS_ASSIGNMENT (PERSON_PERSON_IIN, ASSIGNMENT_ID_ASSIGNMENT) " +
                        "VALUES('" + iin + "', (SELECT ID_ASSIGNMENT FROM ASSIGNMENT " +
                        "WHERE ASSIGNMENT_NAME = '" + CBSetAssign.Text + "'))";
                        MySqlCommand insert = new MySqlCommand(sql, conn);
                        if (insert.ExecuteNonQuery() == 1)
                        {
                            msg.WriteSuccess();
                            conn.Close();
                            ChoosePanel.Visible = false;
                            CBSetAssign.Items.Clear();
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
                    break;
                case 1:
                    sql = "DELETE FROM PERSON_HAS_ASSIGNMENT " +
                        "WHERE ASSIGNMENT_ID_ASSIGNMENT = (SELECT ID_ASSIGNMENT FROM ASSIGNMENT " +
                        "WHERE ASSIGNMENT_NAME = '" + CBSetAssign.Text + "') " +
                        "AND PERSON_PERSON_IIN = '" + iin + "'";
                    MySqlCommand del = new MySqlCommand(sql, conn);
                    if (del.ExecuteNonQuery() == 1)
                    {
                        msg.DropSuccess();
                        conn.Close();
                        ChoosePanel.Visible = false;
                        CBSetAssign.Items.Clear();
                    }
                    else
                    {
                        msg.DropError();
                        conn.Close();
                    }
                    break;
            }
        }

        private void CreateNewAssignment(object sender, EventArgs e)
        {
            conn.Close();
            Messages msg = new Messages();
            iin = TextIIN.Text;
            if (TextAssign.Text == "")
            {
                msg.DataError("Введите назначение!");
                TextAssign.Focus();
            }
            else
            {
                conn.Open();
                sql = "SELECT COUNT(*) FROM ASSIGNMENT WHERE ASSIGNMENT_NAME LIKE '%" + TextAssign.Text + "'";
                MySqlCommand check = new MySqlCommand(sql, conn);
                COUNT = Convert.ToInt32(check.ExecuteScalar());
                if (COUNT == 0)
                {
                    sql = "INSERT INTO ASSIGNMENT(ASSIGNMENT_NAME) VALUES ('" + TextAssign.Text + "')";
                    MySqlCommand insassign = new MySqlCommand(sql, conn);
                    if (insassign.ExecuteNonQuery() == 1)
                    {
                        sql = "INSERT INTO PERSON_HAS_ASSIGNMENT (PERSON_PERSON_IIN, ASSIGNMENT_ID_ASSIGNMENT) " +
                            "VALUES('" + iin + "', (SELECT ID_ASSIGNMENT FROM ASSIGNMENT " +
                            "WHERE ASSIGNMENT_NAME = '" + TextAssign.Text + "'))";
                        MySqlCommand inspa = new MySqlCommand(sql, conn);
                        if (inspa.ExecuteNonQuery() == 1)
                        {
                            msg.WriteSuccess();
                            conn.Close();
                            CreatePanel.Visible = false;
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
                    conn.Close();
                    CreatePanel.Visible = false;
                    ChoosePanel.Visible = true;
                    sw = 0;
                    conn.Open();
                    ChoosePanel.Visible = true;
                    sql = "SELECT * FROM ASSIGNMENT ORDER BY 2 ASC";
                    MySqlCommand assign = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = assign.ExecuteReader();
                    while (reader.Read())
                    {
                        CBSetAssign.Items.Add(reader.GetString("ASSIGNMENT_NAME"));
                    }
                    conn.Close();
                }
            }
        }

        private void ViewAssignmentMode(object sender, EventArgs e)
        {
            conn.Close();
            CreatePanel.Visible = false;
            ChoosePanel.Visible = false;
            ViewAssignment.Visible = true;
            conn.Open();
            iin = TextIIN.Text;

            sql = "SELECT ASSIGNMENT_NAME 'Назначение' FROM ASSIGNMENT " +
                "INNER JOIN PERSON_HAS_ASSIGNMENT " +
                "ON ASSIGNMENT.ID_ASSIGNMENT = PERSON_HAS_ASSIGNMENT.ASSIGNMENT_ID_ASSIGNMENT " +
                "WHERE PERSON_HAS_ASSIGNMENT.PERSON_PERSON_IIN = '" + iin + "'";
            MySqlCommand assignlist = new MySqlCommand(sql, conn);
            MySqlDataReader reader = assignlist.ExecuteReader();
            dt.Load(reader);
            ViewAssignment.DataSource = dt;
            conn.Close();
        }

        private void CheckDigit(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void SetAssignment_MouseMove(object sender, MouseEventArgs e)
        {
            ApplyButtonCh.BackColor = Color.White;
            ApplyButtonCh.ForeColor = Color.FromArgb(10, 131, 35);
            ApplyButtonCr.BackColor = Color.White;
            ApplyButtonCr.ForeColor = Color.FromArgb(10, 131, 35);
            CreateButton.BackColor = Color.White;
            CreateButton.ForeColor = Color.FromArgb(10, 131, 35);
            CheckIINButton.BackColor = Color.White;
            CheckIINButton.ForeColor = Color.FromArgb(10, 131, 35);
            ChooseButton.BackColor = Color.White;
            ChooseButton.ForeColor = Color.FromArgb(10, 131, 35);
            ChangeButton.BackColor = Color.White;
            ChangeButton.ForeColor = Color.FromArgb(10, 131, 35);
            ViewButton.BackColor = Color.White;
            ViewButton.ForeColor = Color.FromArgb(10, 131, 35);
            ExitButtom.BackColor = Color.White;
            ExitButtom.ForeColor = Color.FromArgb(10, 131, 35);
        }

        private void ChoosePanel_MouseMove(object sender, MouseEventArgs e)
        {
            ApplyButtonCh.BackColor = Color.White;
            ApplyButtonCh.ForeColor = Color.FromArgb(10, 131, 35);
            ApplyButtonCr.BackColor = Color.White;
            ApplyButtonCr.ForeColor = Color.FromArgb(10, 131, 35);
            CreateButton.BackColor = Color.White;
            CreateButton.ForeColor = Color.FromArgb(10, 131, 35);
            CheckIINButton.BackColor = Color.White;
            CheckIINButton.ForeColor = Color.FromArgb(10, 131, 35);
            ChooseButton.BackColor = Color.White;
            ChooseButton.ForeColor = Color.FromArgb(10, 131, 35);
            ChangeButton.BackColor = Color.White;
            ChangeButton.ForeColor = Color.FromArgb(10, 131, 35);
            ViewButton.BackColor = Color.White;
            ViewButton.ForeColor = Color.FromArgb(10, 131, 35);
            ExitButtom.BackColor = Color.White;
            ExitButtom.ForeColor = Color.FromArgb(10, 131, 35);
        }

        private void CreatePanel_MouseMove(object sender, MouseEventArgs e)
        {
            ApplyButtonCh.BackColor = Color.White;
            ApplyButtonCh.ForeColor = Color.FromArgb(10, 131, 35);
            ApplyButtonCr.BackColor = Color.White;
            ApplyButtonCr.ForeColor = Color.FromArgb(10, 131, 35);
            CreateButton.BackColor = Color.White;
            CreateButton.ForeColor = Color.FromArgb(10, 131, 35);
            CheckIINButton.BackColor = Color.White;
            CheckIINButton.ForeColor = Color.FromArgb(10, 131, 35);
            ChooseButton.BackColor = Color.White;
            ChooseButton.ForeColor = Color.FromArgb(10, 131, 35);
            ChangeButton.BackColor = Color.White;
            ChangeButton.ForeColor = Color.FromArgb(10, 131, 35);
            ViewButton.BackColor = Color.White;
            ViewButton.ForeColor = Color.FromArgb(10, 131, 35);
            ExitButtom.BackColor = Color.White;
            ExitButtom.ForeColor = Color.FromArgb(10, 131, 35);
        }

        private void CheckIINButton_MouseMove(object sender, MouseEventArgs e)
        {
            CheckIINButton.BackColor = Color.FromArgb(10, 131, 35);
            CheckIINButton.ForeColor = Color.White;
        }

        private void CreateButton_MouseMove(object sender, MouseEventArgs e)
        {
            CreateButton.BackColor = Color.FromArgb(10, 131, 35);
            CreateButton.ForeColor = Color.White;
        }

        private void ChooseButton_MouseMove(object sender, MouseEventArgs e)
        {
            ChooseButton.BackColor = Color.FromArgb(10, 131, 35);
            ChooseButton.ForeColor = Color.White;
        }

        private void ChangeButton_MouseMove(object sender, MouseEventArgs e)
        {
            ChangeButton.BackColor = Color.FromArgb(10, 131, 35);
            ChangeButton.ForeColor = Color.White;
        }

        private void ViewButton_MouseMove(object sender, MouseEventArgs e)
        {
            ViewButton.BackColor = Color.FromArgb(10, 131, 35);
            ViewButton.ForeColor = Color.White;
        }

        private void ExitButtom_MouseMove(object sender, MouseEventArgs e)
        {
            ExitButtom.BackColor = Color.FromArgb(10, 131, 35);
            ExitButtom.ForeColor = Color.White;
        }

        private void ApplyButtonCh_MouseMove(object sender, MouseEventArgs e)
        {
            ApplyButtonCh.BackColor = Color.FromArgb(10, 131, 35);
            ApplyButtonCh.ForeColor = Color.White;
        }

        private void ApplyButtonCr_MouseMove(object sender, MouseEventArgs e)
        {
            ApplyButtonCr.BackColor = Color.FromArgb(10, 131, 35);
            ApplyButtonCr.ForeColor = Color.White;
        }

        private void DeleteAssignment(object sender, EventArgs e)
        {
            CBSetAssign.Items.Clear();
            CreatePanel.Visible = false;
            ChoosePanel.Visible = false;
            ViewAssignment.Visible = false;
            if (ChoosePanel.Visible == false)
            {
                conn.Open();
                sw = 1;
                iin = TextIIN.Text;
                ChoosePanel.Visible = true;
                sql = "SELECT ASSIGNMENT_NAME " +
                    "FROM ASSIGNMENT INNER JOIN PERSON_HAS_ASSIGNMENT " +
                    "ON ASSIGNMENT.ID_ASSIGNMENT = PERSON_HAS_ASSIGNMENT.ASSIGNMENT_ID_ASSIGNMENT " +
                    "INNER JOIN PERSON " +
                    "ON PERSON_HAS_ASSIGNMENT.PERSON_PERSON_IIN = PERSON.PERSON_IIN " +
                    "WHERE PERSON.PERSON_IIN = '" + iin + "' ORDER BY 1 ASC";
                MySqlCommand assign = new MySqlCommand(sql, conn);
                MySqlDataReader reader = assign.ExecuteReader();
                while (reader.Read())
                {
                    CBSetAssign.Items.Add(reader.GetString("ASSIGNMENT_NAME"));
                }
                conn.Close();
            }
            else
            {
                ChoosePanel.Visible = false;
            }
        }
    
        private void Exit(object sender, EventArgs e)
        {
            this.Close();
            conn.Close();
            DoctorMode doctorMode = new DoctorMode(did);
            doctorMode.Show();
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
                CreateButton.Visible = true;
                ChooseButton.Visible = true;
                ChangeButton.Visible = true;
                ViewButton.Visible = true;
                conn.Close();
            }
        }
    }
}
