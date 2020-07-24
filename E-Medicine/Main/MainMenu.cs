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
    
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();
            LogoLabel.ForeColor = Color.FromArgb(10, 131, 35);
            PersonButton.BackColor = Color.White;
            DoctorButton.BackColor = Color.White;
            ExitButton.BackColor = Color.White;
            PersonButton.ForeColor = Color.FromArgb(10, 131, 35);
            DoctorButton.ForeColor = Color.FromArgb(10, 131, 35);
            ExitButton.ForeColor = Color.FromArgb(10, 131, 35);
            this.BackColor = Color.White;
        }

        private void GoToAdminMode(object sender, EventArgs e)
        {
            //GoToLoginLikeAdministrator
            LF adm;
            adm = new LF(0);
            this.Hide();
            adm.Show();

        }

        private void Exit(object sender, EventArgs e)
        {
            //Exit
            Application.Exit();
        }

        private void GoToPersonMode(object sender, EventArgs e)
        {
            //GoToLoginLikePerson
            LF person;
            person = new LF(1);
            this.Hide();
            person.Show();

        }

        private void GoToDoctorMode(object sender, EventArgs e)
        {
            //GoToLoginLikeDoctor
            LF doctor;
            doctor = new LF(2);
            this.Hide();
            doctor.Show();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            PersonButton.BackColor = Color.White;
            DoctorButton.BackColor = Color.White;
            ExitButton.BackColor = Color.White;
            PersonButton.ForeColor = Color.FromArgb(10, 131, 35);
            DoctorButton.ForeColor = Color.FromArgb(10, 131, 35);
            ExitButton.ForeColor = Color.FromArgb(10, 131, 35);
        }

        private void PersonButton_MouseMove(object sender, MouseEventArgs e)
        {
            PersonButton.BackColor = Color.FromArgb(10, 131, 35);
            PersonButton.ForeColor = Color.White;
        }

        private void DoctorButton_MouseMove(object sender, MouseEventArgs e)
        {
            DoctorButton.BackColor = Color.FromArgb(10, 131, 35);
            DoctorButton.ForeColor = Color.White;
        }

        private void ExitButton_MouseMove(object sender, MouseEventArgs e)
        {
            ExitButton.BackColor = Color.FromArgb(10, 131, 35);
            ExitButton.ForeColor = Color.White;
        }
    }
}
