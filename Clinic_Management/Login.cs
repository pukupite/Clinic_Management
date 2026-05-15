using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Clinic_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.txtEmail.Clear();
            this.txtPass.Text = "";
        }

        private void txtEmail_TextChanged(object sender, EventArgs e) { }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtEmail.Clear();
            this.txtPass.Text = "";
        }





        private bool ValidateLogin(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email is required!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password is required!");
                return false;
            }

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(email, pattern))
            {
                MessageBox.Show("Invalid email format!");
                return false;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters!");
                return false;
            }

            return true;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

            String role = "";
            String UserInputedEmail = this.txtEmail.Text;
            String UserInputedPassword = this.txtPass.Text;


            if (!ValidateLogin(UserInputedEmail, UserInputedPassword))
                return;


DataTable dt;
DataAccess da = new DataAccess();

// ADMIN
string sqlAdminQuery = $"select * from adminUser where Email='{UserInputedEmail}' and Password='{UserInputedPassword}'";
dt = da.ExecuteQueryTable(sqlAdminQuery);

if (dt.Rows.Count > 0)
{
    role = "Admin";
    MessageBox.Show("Login Success");
}
else
{
    // DOCTOR
    string sqlDoctorQuery = $"select * from Doctor where Email='{UserInputedEmail}' and Password='{UserInputedPassword}'";
    dt = da.ExecuteQueryTable(sqlDoctorQuery);

    if (dt.Rows.Count > 0)
    {
        role = "Doctor";
        MessageBox.Show("Login Success");
    }
    else
    {
        // RECEPTIONIST
        string sqlRecQuery = $"select * from Reciptionist where Email='{UserInputedEmail}' and Password='{UserInputedPassword}'";
        dt = da.ExecuteQueryTable(sqlRecQuery);

        if (dt.Rows.Count > 0)
        {
            role = "Receptionist";
            MessageBox.Show("Login Success");
        }
        else
        {
            MessageBox.Show("Invalid email or password. Please try again.");
            return;
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
           
            

            this.btnReset_Click(sender, e);

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbLoginPage_Click(object sender, EventArgs e)
        {

        }


    }
}
