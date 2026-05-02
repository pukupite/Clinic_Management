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
    public partial class AddUpdateReciptionist : Form
    {

        private AdminDashboard admindshRef;
        private string operationType;
        private int updateId;

        public AddUpdateReciptionist(AdminDashboard admindshRef, string operationType, int updateId)
        {
            this.operationType = operationType;
            this.admindshRef = admindshRef;
            this.updateId = updateId;
            InitializeComponent();
        }


        private void lblAddupdateRecipInfoTitle_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void BackToAdminDashboard(object sender, FormClosedEventArgs e)
        {
            this.admindshRef.Show();
            this.Hide();
        }

        private void btnAddUpdateRecipCancel_Click(object sender, EventArgs e)
        {
            this.BackToAdminDashboard(sender, null);
        }

        private void btnAddUpdateRecipSave_Click(object sender, EventArgs e)
        {
            string Recip_Name = this.txtAddUpdateRecipName.Text;
            string Recip_Email = this.txtAddUpdateRecipEmail.Text;
            string Recip_Password = this.txtAddUpdateRecipPass.Text;
            string Recip_NID = this.txtAddUpdateRecipNID.Text;
            string Recip_Phone = this.txtAddUpdateRecipPhn.Text;


            //if(Recip_Name == "" || Recip_Email == "" || Recip_Password == "" || Recip_NID == "" || Recip_Phone == "")
            //{
            //    MessageBox.Show("Please fill in all fields.");
            //    return;
            //}

            if(operationType == "addNew")
            {
                
                MessageBox.Show("New receptionist added successfully!");
            }
            else if(operationType == "update")
            {
                
                MessageBox.Show("Receptionist information updated successfully!");
            }

            this.BackToAdminDashboard(sender, null);
         

        }



    }
}
