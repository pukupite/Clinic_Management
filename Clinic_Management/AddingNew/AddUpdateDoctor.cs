using System;
using System.Data;
using System.Windows.Forms;

namespace Clinic_Management.AddingNew
{
    public partial class AddUpdateDoctor : Form
    {
        private AdminDashboard admindshRef;
        private string operationType;
        private int updateId;

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
                txtAddUpdateDocSchedule.Text = dt.Rows[0]["Schedule"].ToString();
                txtAddUpdateDocPass.Text = dt.Rows[0]["Password"].ToString();
            }
            else
            {
                MessageBox.Show("No data found for this doctor!");
            }
        }

        // ================= BACK =================
        private void BackToAdminDashboard(object sender, EventArgs e)
        {
            admindshRef.Show();
            this.Close();
        }

        // ================= SAVE BUTTON =================
        private void btnAddUpdateRecipSave_Click(object sender, EventArgs e)
        {
            string Doc_Name = txtAddUpdateDocName.Text;
            string Doc_Email = txtAddUpdateDocEmail.Text;
            string Doc_Password = txtAddUpdateDocPass.Text;
            string Doc_Specialist = txtAddUpdateDocSpecialist.Text;
            string Doc_Phone = txtAddUpdateDocPhn.Text;
            string Doc_Schedule = txtAddUpdateDocSchedule.Text;

            if (Doc_Name == "" || Doc_Email == "" || Doc_Password == "" ||
                Doc_Specialist == "" || Doc_Phone == "" || Doc_Schedule == "")
            {
                MessageBox.Show("Please fill in all fields.");
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

            BackToAdminDashboard(sender, e);
        }

        // ================= CANCEL =================
        private void btnAddUpdateRecipCancel_Click(object sender, EventArgs e)
        {
            BackToAdminDashboard(sender, e);
        }

        // optional (ignore)
        private void lblAddupdateRecipInfoTitle_Click(object sender, EventArgs e)
        {
        }
    }
}