using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management.AddingNew
{
    public partial class AddUpdateAdmin : Form
    {
        private AdminDashboard admindshRef;
        private string operationType;
        private int updateId;

        public AddUpdateAdmin(AdminDashboard admindshRef, string operationType, int updateId)   
        {
            this.admindshRef = admindshRef; 
            this.operationType = operationType;
            this.updateId = updateId;
            InitializeComponent();
        }


        private void BackToAdminDashboard(object sender, FormClosedEventArgs e)
        {
            
            this.admindshRef.Show();
            this.Hide();
        }


        private void pnlAddUpdateRecipBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddUpdateAdminCancel_Click(object sender, EventArgs e)
        {
            this.isCancelClicked = true;
            this.BackToAdminDashboard(sender, null);
            
        }

        private void btnAddUpdateAdminSave_Click(object sender, EventArgs e)
        {
            string Admin_Name = this.txtAddUpdateAdminName.Text;
            string Admin_Email = this.txtAddUpdateAdminEmail.Text;
            string Admin_Password = this.txtAddUpdateAdminPass.Text;
            string Admin_Phone = this.txtAddUpdateAdminPhn.Text;

            if (Admin_Name == "" || Admin_Email == "" || Admin_Password == "" || Admin_Phone == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (operationType == "addNew")
            {

                MessageBox.Show("New Admin added successfully!");
            }
            else if (operationType == "update")
            {

                MessageBox.Show("Admin information updated successfully!");
            }

            this.BackToAdminDashboard(sender, null);
        }


        private bool isCancelClicked = false;
        private void AddUpdateAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isCancelClicked)
            {
                Application.Exit();
            }
        }



    }
}
