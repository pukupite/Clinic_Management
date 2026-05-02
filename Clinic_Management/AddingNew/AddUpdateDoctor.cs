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
    public partial class AddUpdateDoctor : Form
    {

        private AdminDashboard admindshRef;
        private string operationType;
        private int updateId;
        public AddUpdateDoctor(AdminDashboard admindshRef, string operationType, int updateId)
        {

            this.operationType = operationType;
            this.admindshRef = admindshRef;
            this.updateId = updateId;
            InitializeComponent();
        }


        private void BackToAdminDashboard(object sender, FormClosedEventArgs e)
        {
            this.admindshRef.Show();
            this.Hide();
        }



        private void lblAddupdateRecipInfoTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUpdateRecipCancel_Click(object sender, EventArgs e)
        {
            this.BackToAdminDashboard(sender, null);

        }

        private void btnAddUpdateRecipSave_Click(object sender, EventArgs e)
        {

            string Doc_Name = this.txtAddUpdateDocName.Text;
            string Doc_Email = this.txtAddUpdateDocEmail.Text;
            string Doc_Password = this.txtAddUpdateDocPass.Text;
            string Doc_Specialist = this.txtAddUpdateDocSpecialist.Text;
            string Doc_Phone = this.txtAddUpdateDocPhn.Text;
            string Doc_Schedule = this.txtAddUpdateDocSchedule.Text;

            //if (Doc_Name == "" || Doc_Email == "" || Doc_Password == "" || Doc_Specialist == "" || Doc_Phone == "" || Doc_Schedule == "")
            //{
            //    MessageBox.Show("Please fill in all fields.");
            //    return;
            //}

            if (operationType == "addNew")
            {

                MessageBox.Show("New Doctor added successfully!");
            }
            else if (operationType == "update")
            {

                MessageBox.Show("Doctor information updated successfully!");
            }

            this.BackToAdminDashboard(sender, null);

        }




    }
}
