using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management
{
    public partial class DoctorDashboard : Form
    {

        private Login loginRef;
        public DoctorDashboard(Login login)
        {
            this.loginRef = login;
            InitializeComponent();
            
        }

        private void DoctorDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnDocLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            loginRef.Show();
        }

        private void btnDocMarkComplete_Click(object sender, EventArgs e)
        {

        }
    }
}
