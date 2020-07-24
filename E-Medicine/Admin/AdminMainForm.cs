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
    public partial class AdminMainForm : Form
    {     
        public AdminMainForm()
        {
            InitializeComponent();
            ExitButton.BackColor = Color.White;
            ExitButton.ForeColor = Color.FromArgb(10, 131, 35);
            DCButton.BackColor = Color.White;
            DCButton.ForeColor = Color.FromArgb(10, 131, 35);
            PCButton.BackColor = Color.White;
            PCButton.ForeColor = Color.FromArgb(10, 131, 35);
            CreateClinicButton.BackColor = Color.White;
            CreateClinicButton.ForeColor = Color.FromArgb(10, 131, 35);
            CreateMedicineButton.BackColor = Color.White;
            CreateMedicineButton.ForeColor = Color.FromArgb(10, 131, 35);
            CreateAdminButton.BackColor = Color.White;
            CreateAdminButton.ForeColor = Color.FromArgb(10, 131, 35);
            button1.BackColor = Color.White;
            button1.ForeColor = Color.FromArgb(10, 131, 35);
            CreatePersonButton.BackColor = Color.White;
            CreatePersonButton.ForeColor = Color.FromArgb(10, 131, 35);
            this.BackColor = Color.White;
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
            MainForm mf = new MainForm();
            mf.Show();
        }

        private void CreateAdministrator(object sender, EventArgs e)
        {
            CreateAdministrator ca = new CreateAdministrator();
            ca.Show();
            this.Hide();
        }

        private void CreateClinic(object sender, EventArgs e)
        {
            CreateClinic clinic = new CreateClinic();
            clinic.Show();
            this.Hide();
        }

        private void CreatePerson(object sender, EventArgs e)
        {
            CreatePerson person = new CreatePerson();
            person.Show();
            this.Hide();
        }

        private void CreateDoctor(object sender, EventArgs e)
        {
            CreateDoctor doctor = new CreateDoctor();
            doctor.Show();
            this.Hide();
        }

        private void CreateMedicine(object sender, EventArgs e)
        {
            CreateMedicine medicine = new CreateMedicine();
            medicine.Show();
            this.Hide();
        }

        private void UserClinicPerson(object sender, EventArgs e)
        {
            UserClinic userp = new UserClinic(0);
            userp.Show();
            this.Hide();
        }

        private void UserClinicDoctor(object sender, EventArgs e)
        {
            UserClinic userd = new UserClinic(1);
            userd.Show();
            this.Hide();
        }

        private void CreatePersonButton_MouseMove(object sender, MouseEventArgs e)
        {
            CreatePersonButton.BackColor = Color.FromArgb(10, 131, 35);
            CreatePersonButton.ForeColor = Color.White;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.FromArgb(10, 131, 35);
            button1.ForeColor = Color.White;
        }

        private void CreateAdminButton_MouseMove(object sender, MouseEventArgs e)
        {
            CreateAdminButton.BackColor = Color.FromArgb(10, 131, 35);
            CreateAdminButton.ForeColor = Color.White;
        }

        private void CreateMedicineButton_MouseMove(object sender, MouseEventArgs e)
        {
            CreateMedicineButton.BackColor = Color.FromArgb(10, 131, 35);
            CreateMedicineButton.ForeColor = Color.White;
        }

        private void CreateClinicButton_MouseMove(object sender, MouseEventArgs e)
        {
            CreateClinicButton.BackColor = Color.FromArgb(10, 131, 35);
            CreateClinicButton.ForeColor = Color.White;
        }

        private void PCButton_MouseMove(object sender, MouseEventArgs e)
        {
            PCButton.BackColor = Color.FromArgb(10, 131, 35);
            PCButton.ForeColor = Color.White;
        }

        private void DCButton_MouseMove(object sender, MouseEventArgs e)
        {
            DCButton.BackColor = Color.FromArgb(10, 131, 35);
            DCButton.ForeColor = Color.White;
        }

        private void ExitButton_MouseMove(object sender, MouseEventArgs e)
        {
            ExitButton.BackColor = Color.FromArgb(10, 131, 35);
            ExitButton.ForeColor = Color.White;
        }

        private void AdminMainForm_MouseMove(object sender, MouseEventArgs e)
        {
            ExitButton.BackColor = Color.White;
            ExitButton.ForeColor = Color.FromArgb(10, 131, 35);
            DCButton.BackColor = Color.White;
            DCButton.ForeColor = Color.FromArgb(10, 131, 35);
            PCButton.BackColor = Color.White;
            PCButton.ForeColor = Color.FromArgb(10, 131, 35);
            CreateClinicButton.BackColor = Color.White;
            CreateClinicButton.ForeColor = Color.FromArgb(10, 131, 35);
            CreateMedicineButton.BackColor = Color.White;
            CreateMedicineButton.ForeColor = Color.FromArgb(10, 131, 35);
            CreateAdminButton.BackColor = Color.White;
            CreateAdminButton.ForeColor = Color.FromArgb(10, 131, 35);
            button1.BackColor = Color.White;
            button1.ForeColor = Color.FromArgb(10, 131, 35);
            CreatePersonButton.BackColor = Color.White;
            CreatePersonButton.ForeColor = Color.FromArgb(10, 131, 35);
        }
    }
}
