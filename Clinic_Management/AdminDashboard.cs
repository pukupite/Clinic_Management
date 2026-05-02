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
    public partial class AdminDashboard : Form
    {
        private Login loginPageRef;
        private bool isLogoutClicked = false;
        private AdminAdminManage adminManagePageRef= null;

        public AdminDashboard(Login loginPageRef)
        {
            this.loginPageRef = loginPageRef;
            InitializeComponent();
            this.lblAdminNavTitle.Text= "Welcome to Dashboard";
        }

        private void pnlAdminSidebarDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }




        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            this.isLogoutClicked = true;
            this.loginPageRef.Show();
            this.Close();
            

        }

        private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isLogoutClicked)
            {
                Application.Exit();
            }
                
        }

        private void SidebarItemClickNevigation(string page)
        {
            if (page == "AdminManage")
            {
                this.lblAdminNavTitle.Text = "Welcome to Admin Management";
            }
            else if (page == "DoctorManage")
            {
                this.lblAdminNavTitle.Text = "Welcome to Doctor Management";

            }
            else if (page == "ReceipManage")
            {
                this.lblAdminNavTitle.Text = "Welcome to Reciptionist Management";
            }
            else
            {
                this.lblAdminNavTitle.Text = "Welcome to Dashboard";
                if (adminManagePageRef != null) {
                    this.adminManagePageRef.Hide();
                   
                }
            }

            if(page != "Dashboard") {
                AdminAdminManage AdminAdminManage = new AdminAdminManage(this, page);
                this.LoadForm(AdminAdminManage);
                this.adminManagePageRef = AdminAdminManage;
            }
           
        }



        //Sidebar Label Click Events
        private void lblAdminSidebarDashboard_Click(object sender, EventArgs e)
        {
            this.SidebarItemClickNevigation("Dashboard");
        }

        private void lblAdminSidebarAdmManage_Click(object sender, EventArgs e)
        {
            this.SidebarItemClickNevigation("AdminManage");
        }

        private void lblAdminSidebarDocManage_Click(object sender, EventArgs e)
        {
            this.SidebarItemClickNevigation("DoctorManage");
        }

        private void lblAdminSidebarRecipManage_Click(object sender, EventArgs e)
        {
            this.SidebarItemClickNevigation("ReceipManage");
        }

    


        

        //Sidebar Panel Click Events
        private void pnlAdminSidebarDashboard_MouseClick(object sender, MouseEventArgs e)
        {
            this.SidebarItemClickNevigation("Dashboard");
        }

      
        private void pnlAdminSidebarAdmManage_MouseClick(object sender, MouseEventArgs e)
        {
            this.SidebarItemClickNevigation("AdminManage");
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            this.SidebarItemClickNevigation("DoctorManage");
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            this.SidebarItemClickNevigation("ReceipManage");
        }

      


        private void LoadForm(AdminAdminManage form)
        {
            pnlAdminContentBody.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            pnlAdminContentBody.Controls.Add(form);
            form.Show();
        }




    }
}
