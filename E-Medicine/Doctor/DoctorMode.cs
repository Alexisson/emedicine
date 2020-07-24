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
    public partial class DoctorMode : Form
    {
        int did;
        public DoctorMode(int id)
        {
            did = id;
            InitializeComponent();
            AddMedicineButton.BackColor = Color.White;
            AddMedicineButton.ForeColor = Color.FromArgb(10, 131, 35);
            AddPersonButton.BackColor = Color.White;
            AddPersonButton.ForeColor = Color.FromArgb(10, 131, 35);
            AddPrescriptionButton.BackColor = Color.White;
            AddPrescriptionButton.ForeColor = Color.FromArgb(10, 131, 35);
            button1.BackColor = Color.White;
            button1.ForeColor = Color.FromArgb(10, 131, 35);
            button2.BackColor = Color.White;
            button2.ForeColor = Color.FromArgb(10, 131, 35);
            ExitButton.BackColor = Color.White;
            ExitButton.ForeColor = Color.FromArgb(10, 131, 35);
            JournalButton.BackColor = Color.White;
            JournalButton.ForeColor = Color.FromArgb(10, 131, 35);
            this.BackColor = Color.White;
        }

        private void PersonDoctor(object sender, EventArgs e)
        {
            PersonDoctor person = new PersonDoctor(did);
            person.Show();
            this.Hide();
        }

        private void SetDrug(object sender, EventArgs e)
        {
            SetMedicine medicine = new SetMedicine(did);
            medicine.Show();
            this.Hide();
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
            MainForm mf = new MainForm();
            mf.Show();
        }

        private void SetPrescription(object sender, EventArgs e)
        {
            Prescription sp = new Prescription(did);
            sp.Show();
            this.Hide();
        }

        private void ViewJournal(object sender, EventArgs e)
        {
            DoctorJournal DJ = new DoctorJournal(did);
            DJ.Show();
            this.Hide();
        }

        private void SetGroup(object sender, EventArgs e)
        {
            SetGroup sg = new SetGroup(did);
            sg.Show();
            this.Hide();
        }

        private void SetAssignment(object sender, EventArgs e)
        {
            SetAssignment sa = new SetAssignment(did);
            sa.Show();
            this.Hide();
        }

        private void AddPersonButton_MouseMove(object sender, MouseEventArgs e)
        {
            AddPersonButton.BackColor = Color.FromArgb(10, 131, 35);
            AddPersonButton.ForeColor = Color.White;
        }

        private void AddMedicineButton_MouseMove(object sender, MouseEventArgs e)
        {
            AddMedicineButton.BackColor = Color.FromArgb(10, 131, 35);
            AddMedicineButton.ForeColor = Color.White;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.FromArgb(10, 131, 35);
            button1.ForeColor = Color.White;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.FromArgb(10, 131, 35);
            button2.ForeColor = Color.White;
        }

        private void AddPrescriptionButton_MouseMove(object sender, MouseEventArgs e)
        {
            AddPrescriptionButton.BackColor = Color.FromArgb(10, 131, 35);
            AddPrescriptionButton.ForeColor = Color.White;
        }

        private void JournalButton_MouseMove(object sender, MouseEventArgs e)
        {
            JournalButton.BackColor = Color.FromArgb(10, 131, 35);
            JournalButton.ForeColor = Color.White;
        }

        private void ExitButton_MouseMove(object sender, MouseEventArgs e)
        {
            ExitButton.BackColor = Color.FromArgb(10, 131, 35);
            ExitButton.ForeColor = Color.White;
        }

        private void DoctorMode_MouseMove(object sender, MouseEventArgs e)
        {
            AddMedicineButton.BackColor = Color.White;
            AddMedicineButton.ForeColor = Color.FromArgb(10, 131, 35);
            AddPersonButton.BackColor = Color.White;
            AddPersonButton.ForeColor = Color.FromArgb(10, 131, 35);
            AddPrescriptionButton.BackColor = Color.White;
            AddPrescriptionButton.ForeColor = Color.FromArgb(10, 131, 35);
            button1.BackColor = Color.White;
            button1.ForeColor = Color.FromArgb(10, 131, 35);
            button2.BackColor = Color.White;
            button2.ForeColor = Color.FromArgb(10, 131, 35);
            ExitButton.BackColor = Color.White;
            ExitButton.ForeColor = Color.FromArgb(10, 131, 35);
            JournalButton.BackColor = Color.White;
            JournalButton.ForeColor = Color.FromArgb(10, 131, 35);
        }
    }
}
