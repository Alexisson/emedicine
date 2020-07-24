using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Medicine
{
    class Operations
    {
        CreateAdministrator admin = new CreateAdministrator();

        public static string connection_string = "server=localhost;user=root;database=emedicine;password='';";
        public void ColorAdmin()
        {
            admin.LabelLogin.ForeColor = Color.FromArgb(10, 131, 35);
            admin.admin.LabelPassword.ForeColor = Color.FromArgb(10, 131, 35);
            admin.CancelButton.BackColor = Color.White;
            admin.CancelButton.ForeColor = Color.FromArgb(10, 131, 35);
            admin.ButtonLogin.BackColor = Color.White;
            admin.ButtonLogin.ForeColor = Color.FromArgb(10, 131, 35);
        }
        public void ColorAdminMainForm()
        {

        }
    }
}
