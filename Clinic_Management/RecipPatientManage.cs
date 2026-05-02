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
    public partial class RecipPatientManage : Form
    {

        ReceptionistDashboard recipDashRef;
        private string oprationType;
        private bool isCancelClicked = false;
        private bool isSaveClicked = false;


        public RecipPatientManage(ReceptionistDashboard recipDashRef, string oprationType)
        {
            InitializeComponent();
            this.recipDashRef = recipDashRef;
            this.oprationType = oprationType;
        }

        private void lblAddUpdateRecipEmail_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BackToRecipDashBoard()
        {
            //recipDashRef.Show();
            this.Close();
        }

        private void btnAddUpdatePatientCancel_Click(object sender, EventArgs e)
        {
            isCancelClicked = true;
            this.BackToRecipDashBoard();
        }

        private void btnAddUpdatePatientSave_Click(object sender, EventArgs e)
        {
            this.isSaveClicked = true;
            if (oprationType == "addingNew")
            {
                // Code to save new patient record
                MessageBox.Show("New patient record saved successfully!");
            }
            else if (oprationType == "update")
            {
                // Code to update existing patient record
                MessageBox.Show("Patient record updated successfully!");
            }
            this.BackToRecipDashBoard();
        }
        
        private void RecipPatientManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isCancelClicked && !isSaveClicked)
            {
                Application.Exit();
            }
        }



    }
}
