using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Clinic_Management.AddingNew
{
    public partial class AddUpdateDoctor : Form
    {
        private AdminDashboard admindshRef;
        private string operationType;
        private int updateId =-1;

        private DataAccess da = new DataAccess();

        public AddUpdateDoctor(AdminDashboard admindshRef, string operationType, int updateId)
        {
            this.operationType = operationType;
            this.admindshRef = admindshRef;
            this.updateId = updateId;
            
            InitializeComponent();
            if (operationType == "update" && updateId > 0)
            {
                LoadExistingDoctorData();
            }
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        // ================= FORM LOAD =================
        private void AddUpdateDoctor_Load(object sender, EventArgs e)
        {
            
        }

        // ================= LOAD EXISTING DATA =================
        private void LoadExistingDoctorData()
        {
            string sql = "SELECT * FROM Doctor WHERE DoctorId = " + updateId;

            DataTable dt = da.ExecuteQueryTable(sql);

            if (dt.Rows.Count > 0)
            {
                txtAddUpdateDocName.Text = dt.Rows[0]["Name"].ToString();
                txtAddUpdateDocEmail.Text = dt.Rows[0]["Email"].ToString();
                txtAddUpdateDocPhn.Text = dt.Rows[0]["Phone"].ToString();
                txtAddUpdateDocSpecialist.Text = dt.Rows[0]["Specialist"].ToString();
                cmbDocScheduleList.Text = dt.Rows[0]["Schedule"].ToString();
                txtAddUpdateDocPass.Text = dt.Rows[0]["Password"].ToString();
            }
            else
            {
                MessageBox.Show("No data found for this doctor!");
            }
        }

        // ================= BACK =================
        private void BackToAdminDashboard()
        {
            
            this.Close();
        }







        // ================= SAVE BUTTON =================
        private void btnAddUpdateRecipSave_Click(object sender, EventArgs e)
        {
            string Doc_Name = txtAddUpdateDocName.Text;
            string Doc_Email = txtAddUpdateDocEmail.Text;
            string Doc_Password = txtAddUpdateDocPass.Text;
            
            string specialist = txtAddUpdateDocSpecialist.Text.Trim();
            string Doc_Specialist = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(specialist.ToLower());
            string Doc_Phone = txtAddUpdateDocPhn.Text;
            string Doc_Schedule="";

            if (cmbDocScheduleList.SelectedItem != null)
            {
                Doc_Schedule = cmbDocScheduleList.SelectedItem.ToString();

            }


            if (Doc_Name == "" || Doc_Email == "" || Doc_Password == "" ||
                Doc_Specialist == "" || Doc_Phone == "" )
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }



            UtilityFunction UF = new UtilityFunction();
            if (!UF.NameValidation(Doc_Name) || !UF.EmailValidation(Doc_Email) ||
                !UF.PasswordValidation(Doc_Password) || !UF.SpecialistValidation(Doc_Specialist) ||
                !UF.PhoneValidation(Doc_Phone))
            {
                return;
            }


            if (!UF.IsEmailUnique(Doc_Email, updateId, "Doctor", "DoctorId"))
            {
                MessageBox.Show("Email already exists. Please use a different email.");
                return;
            }

            if (operationType == "addNew")
            {
                                
                string sql = "INSERT INTO Doctor (Name, Phone, Email, Specialist, Schedule, Password) " +
                             "VALUES ('" + Doc_Name + "', '" + Doc_Phone + "', '" + Doc_Email + "', '" +
                             Doc_Specialist + "', '" + Doc_Schedule + "', '" + Doc_Password + "')";

                int result = da.ExecuteUpdateQuery(sql);

                if (result > 0)
                    MessageBox.Show("New Doctor added successfully!");
                else
                    MessageBox.Show("Insert failed!");
            }
            else if (operationType == "update")
            {
                
                string sql = "UPDATE Doctor SET " +
                             "Name='" + Doc_Name + "', " +
                             "Phone='" + Doc_Phone + "', " +
                             "Email='" + Doc_Email + "', " +
                             "Specialist='" + Doc_Specialist + "', " +
                             "Schedule='" + Doc_Schedule + "', " +
                             "Password='" + Doc_Password + "' " +
                             "WHERE DoctorId=" + updateId;

                int result = da.ExecuteUpdateQuery(sql);

                if (result > 0)
                    MessageBox.Show("Doctor updated successfully!");
                else
                    MessageBox.Show("Update failed!");
            }

            BackToAdminDashboard();
        }

        // ================= CANCEL =================
        private void btnAddUpdateRecipCancel_Click(object sender, EventArgs e)
        {
            BackToAdminDashboard();
        }

        // optional (ignore)
        private void lblAddupdateRecipInfoTitle_Click(object sender, EventArgs e)
        {
        }

        private void pnlAddUpdateRecipFooter_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}