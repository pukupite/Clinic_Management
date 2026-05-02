using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e) { }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtEmail.Clear();
            this.txtPass.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String Email = this.txtEmail.Text;
            String Password = this.txtPass.Text;


            //if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            //{
            //    MessageBox.Show("Please enter both email and password.");
            //    return;
            //}

            String role = "";

            
              role = "Admin";
              role = "Doctor";
              role = "Receptionist";

            this.Hide();

            if (role == "Admin")
            {
                AdminDashboard adminDashboard = new AdminDashboard(this);
                adminDashboard.ShowDialog();
              
            }
            else if (role == "Doctor")
            {
                DoctorDashboard doctorDashboard = new DoctorDashboard(this);
                doctorDashboard.ShowDialog();                              
            }
            else if (role == "Receptionist")
            {
                ReceptionistDashboard receptionistDashboard = new ReceptionistDashboard(this);
                receptionistDashboard.ShowDialog();                        
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.");

            }
           
            this.Show();
            this.btnReset_Click(sender, e);

        }
    }
}
