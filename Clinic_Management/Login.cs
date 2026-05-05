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

            String role = "Admin";
            String UserInputedEmail = this.txtEmail.Text;
            String UserInputedPassword = this.txtPass.Text;


            //if (string.IsNullOrEmpty(UserInputedEmail) || string.IsNullOrEmpty(UserInputedPassword))
            //{
            //    MessageBox.Show("Please enter both email and password.");
            //    return;
            //}
            

            DataAccess da = new DataAccess();
            string sqlAdminQuery = $"select * from adminUser where Email='{UserInputedEmail}' and Password='{UserInputedPassword}'";
            DataTable dt = da.ExecuteQueryTable(sqlAdminQuery);

            if (dt.Rows.Count > 0) {
                role = "Admin";
                MessageBox.Show("Login Success");
            }
            else
            {
                sqlAdminQuery = $"select * from Doctor where Email='{UserInputedEmail}' and Password='{UserInputedPassword}'";
                if (dt.Rows.Count > 0)
                {
                    role = "Doctor";
                    MessageBox.Show("Login Success");
                }
                else
                {
                    sqlAdminQuery = $"select * from Reciptionist where Email='{UserInputedEmail}' and Password='{UserInputedPassword}'";
                    if (dt.Rows.Count > 0)
                    {
                        role = "Receptionist";
                        MessageBox.Show("Login Success");
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password. Please try again.");


                    }
                }

            }

            


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
            
           
            this.Show();
            this.btnReset_Click(sender, e);

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
