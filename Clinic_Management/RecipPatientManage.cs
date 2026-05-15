using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinic_Management
{
    public partial class RecipPatientManage : Form
    {

        private DataAccess da = new DataAccess();

        ReceptionistDashboard recipDashRef;
        private string oprationType;
        private bool isCancelClicked = false;
        private bool isSaveClicked = false;
        private string patientId;


        public RecipPatientManage(ReceptionistDashboard recipDashRef, string oprationType, string selectedPatientId)
        {
            InitializeComponent();
            this.recipDashRef = recipDashRef;
            this.oprationType = oprationType;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.patientId = selectedPatientId;

            if(selectedPatientId != "-1")
            {
                LoadPatientInfo();
            }

        }

        private void LoadPatientInfo()
        {
            try
            {
                string sql = "SELECT * FROM Patient WHERE PatientID = '" + patientId + "'";

                DataTable dt = da.ExecuteQueryTable(sql);

                if (dt.Rows.Count > 0)
                {
                    txtAddupdatePatientName.Text = dt.Rows[0]["Name"].ToString();
                    txtAddupdatePatientAge.Text = dt.Rows[0]["Age"].ToString();
                    cmbAddupdatePatientGender.Text = dt.Rows[0]["Gender"].ToString();
                    txtAddupdatePatientWeight.Text = dt.Rows[0]["Weight"].ToString();
                    txtAddupdatePatientPhn.Text = dt.Rows[0]["Phone"].ToString();
                    cmbAddUpdateBooldGroup.Text = dt.Rows[0]["BloodGroup"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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


        private void RecipPatientManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isCancelClicked && !isSaveClicked)
            {
                Application.Exit();
            }
        }


        private void cmbAddupdatePatientGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAddUpdateBooldGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private bool ValidatePatientInput(string name, string age, string weight,string phone)
        {
           
            // ================= NAME =================
            if (name.Length < 3)
            {
                MessageBox.Show("Name must be at least 3 characters!");
                return false;
            }

            // ================= AGE =================
            int validAge;

            if (!int.TryParse(age, out validAge))
            {
                MessageBox.Show("Age must be numeric!");
                return false;
            }

            if (validAge < 1 || validAge > 120)
            {
                MessageBox.Show("Enter a valid age!");
                return false;
            }

            // ================= WEIGHT =================
            double validWeight;

            if (!double.TryParse(weight, out validWeight))
            {
                MessageBox.Show("Weight must be numeric!");
                return false;
            }

            if (validWeight < 1 || validWeight > 300)
            {
                MessageBox.Show("Enter a valid weight!");
                return false;
            }

            // ================= PHONE =================
            if (phone.Length != 11)
            {
                MessageBox.Show("Phone number must be 11 digits!");
                return false;
            }

            if (!phone.All(char.IsDigit))
            {
                MessageBox.Show("Phone must contain only digits!");
                return false;
            }

            if (phone.Length != 11)
            {
                MessageBox.Show("Phone number must be 11 digits!");
                return false;
            }

            if (!(  phone.StartsWith("013") ||
                    phone.StartsWith("014") ||
                    phone.StartsWith("015") ||
                    phone.StartsWith("016") ||
                    phone.StartsWith("017") ||
                    phone.StartsWith("018") ||
                    phone.StartsWith("019")))
            {
                MessageBox.Show("Enter a valid Bangladeshi phone number!");
                return false;
            }

            return true;
        }





        private void btnAddUpdatePatientSave_Click(object sender, EventArgs e)
        {
            string name = txtAddupdatePatientName.Text;
            string age = txtAddupdatePatientAge.Text;
            string gender = cmbAddupdatePatientGender.Text;
            string weight = txtAddupdatePatientWeight.Text;
            string phone = txtAddupdatePatientPhn.Text;
            string bloodGrp = cmbAddUpdateBooldGroup.Text;

            if (name == "" || age == "" || gender == "" || weight == "" || phone == "" || bloodGrp == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            if (!ValidatePatientInput(name, age, weight, phone))
            {
                return;
            }


            try
            {
                int result = 0;

                // ================= ADD NEW =================
                if (oprationType == "addingNew")
                {
                    string sql = @"INSERT INTO Patient 
            (Name, Age, Gender, Weight, Phone, BloodGroup)
            VALUES 
            ('" + name + "', '" + age + "', '" + gender + "', '" + weight + "', '" + phone + "', '" + bloodGrp + "')";

                    result = da.ExecuteUpdateQuery(sql);

                    if (result > 0)
                        MessageBox.Show("New patient record saved successfully!");
                    else
                        MessageBox.Show("Insert failed!");
                }

                // ================= UPDATE =================
                else if (oprationType == "update")
                {
                    

                    string sql = @"UPDATE Patient SET Name = '" + name + "', Age = '" + age + "', Gender = '" + gender + "',Weight = '" + weight + "',Phone = '" + phone + "',BloodGroup = '" + bloodGrp + "'WHERE PatientID = '" + patientId + "'";
                    result = da.ExecuteUpdateQuery(sql);

                    if (result > 0)
                        MessageBox.Show("Patient record updated successfully!");
                    else
                        MessageBox.Show("Update failed! No record found.");
                }

                isSaveClicked = true;
                this.BackToRecipDashBoard();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }





    }
}
