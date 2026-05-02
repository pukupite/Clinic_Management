using Clinic_Management.AddingNew;
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
    public partial class AdminAdminManage : Form
    {
        private AdminDashboard adminDashboardRef;
        private string itemClicked;
        private int updateId;

        public AdminAdminManage(AdminDashboard admindshRef, string itemClicked)
        {
            this.adminDashboardRef = admindshRef;   
            InitializeComponent();
            this.itemClicked = itemClicked;
        }



        private void btnAdminAddNewAdmin_Click(object sender, EventArgs e)
        {
            if(itemClicked == "AdminManage")
            {
                AddUpdateAdmin addupdateAdmin = new AddUpdateAdmin(adminDashboardRef, "addNew", 0);
                addupdateAdmin.Show();


            }
            else if (itemClicked == "DoctorManage")
            {
                AddUpdateDoctor addupdateDoctor = new AddUpdateDoctor(adminDashboardRef, "addNew", 0);
                addupdateDoctor.Show();

            }
            else if (itemClicked == "ReceipManage")
            {
                AddUpdateReciptionist addupdateReciptionist = new AddUpdateReciptionist(adminDashboardRef, "addNew", 0);
                addupdateReciptionist.Show();
               
            }

            //this.adminDashboardRef.Hide();

        }



        private void btnAdminUpdateAdmin_Click(object sender, EventArgs e)
        {
            if (itemClicked == "AdminManage")
            {
                AddUpdateAdmin addupdateAdmin = new AddUpdateAdmin(adminDashboardRef, "update", updateId);
                addupdateAdmin.Show();
               
            }
            else if (itemClicked == "DoctorManage")
            {
                AddUpdateDoctor addupdateDoctor = new AddingNew.AddUpdateDoctor(adminDashboardRef, "update", updateId);
                addupdateDoctor.Show();
                

            }
            else if (itemClicked == "ReceipManage")
            {
                AddUpdateReciptionist addupdateReciptionist = new AddUpdateReciptionist(adminDashboardRef, "update", updateId);
                addupdateReciptionist.Show();
                

            }
            
            

        }

        private void btnAdminDeleteAdmin_Click(object sender, EventArgs e)
        {
            //Directly delete the admin without confirmation
        }

        private void AdminAdminManage_Load(object sender, EventArgs e)
        {

        }



    }
}
