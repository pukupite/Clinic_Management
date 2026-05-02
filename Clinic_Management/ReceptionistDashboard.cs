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
    public partial class ReceptionistDashboard : Form
    {

        private Login loginPageRef;
        public ReceptionistDashboard(Login loginPageRef)
        {
            this.loginPageRef = loginPageRef;
            InitializeComponent();
        }

        private void lblRecipNavTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnRecipAddPatient_Click(object sender, EventArgs e)
        {
            RecipPatientManage patientManage = new RecipPatientManage(this, "addingNew");
            patientManage.ShowDialog();
            patientManage.Close();

        }

        private void btnRecipUpdatePatient_Click(object sender, EventArgs e)
        {
            RecipPatientManage patientManage = new RecipPatientManage(this, "update");
            patientManage.ShowDialog();
            patientManage.Close();

        }


        private void btnRecipDeletePatient_Click(object sender, EventArgs e)
        {
            // Code to delete a patient record
        }

        private bool isLogoutClicked = false;
        private void ReceptionistDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isLogoutClicked)
            {
                Application.Exit();
            }
        }

        private void btnRecipLogout_Click(object sender, EventArgs e)
        {
            isLogoutClicked = true;
            this.Hide();
            loginPageRef.Show();
        }
        


    }
}
