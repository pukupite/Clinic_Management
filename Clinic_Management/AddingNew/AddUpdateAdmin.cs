using System;
using System.Data;
using System.Windows.Forms;

namespace Clinic_Management.AddingNew
{
    public partial class AddUpdateAdmin : Form
    {
        private AdminDashboard admindshRef;
        private string operationType;
        private int updateId;

        private DataAccess da = new DataAccess();

        private bool isCancelClicked = false;

        public AddUpdateAdmin(AdminDashboard admindshRef, string operationType, int updateId)
        {
            this.admindshRef = admindshRef;
            this.operationType = operationType;
            this.updateId = updateId;
            
            InitializeComponent();
            if (operationType == "update")
            {
                LoadExistingData();
            }


        }

        
        // ================= LOAD EXISTING DATA =================
        private void LoadExistingData()
        {
            string sql = "SELECT * FROM adminUser WHERE AdminId = " + updateId;

            DataTable dt = da.ExecuteQueryTable(sql);

            if (dt.Rows.Count == 1)
            {
                txtAddUpdateAdminName.Text = dt.Rows[0]["Name"].ToString();
                txtAddUpdateAdminEmail.Text = dt.Rows[0]["Email"].ToString();
                txtAddUpdateAdminPhn.Text = dt.Rows[0]["Phone"].ToString();
                txtAddUpdateAdminPass.Text = dt.Rows[0]["Password"].ToString();
            }
        }

        // ================= BACK =================
        private void BackToAdminDashboard(object sender, EventArgs e)
        {
            admindshRef.Show();
            this.Close();
        }

        // ================= SAVE BUTTON =================
        private void btnAddUpdateAdminSave_Click(object sender, EventArgs e)
        {

            string Admin_Name = txtAddUpdateAdminName.Text;
            string Admin_Email = txtAddUpdateAdminEmail.Text;
            string Admin_Password = txtAddUpdateAdminPass.Text;
            string Admin_Phone = txtAddUpdateAdminPhn.Text;

            if (Admin_Name == "" || Admin_Email == "" || Admin_Password == "" || Admin_Phone == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (operationType == "addNew")
            {
                string sql = "INSERT INTO adminUser (Name, Email, Phone, Password) " +
                             "VALUES ('" + Admin_Name + "', '" + Admin_Email + "', '" + Admin_Phone + "', '" + Admin_Password + "')";

                int result = da.ExecuteUpdateQuery(sql);

                if (result > 0)
                    MessageBox.Show("New Admin added successfully!");
                else
                    MessageBox.Show("Insert failed!");
            }
            else if (operationType == "update")
            {
                string sql = "UPDATE adminUser SET " +
                             "Name='" + Admin_Name + "', " +
                             "Email='" + Admin_Email + "', " +
                             "Phone='" + Admin_Phone + "', " +
                             "Password='" + Admin_Password + "' " +
                             "WHERE AdminId=" + updateId;

                int result = da.ExecuteUpdateQuery(sql);

                if (result > 0)
                    MessageBox.Show("Admin updated successfully!");
                else
                    MessageBox.Show("Update failed!");
            }

            BackToAdminDashboard(sender, e);
        }

        // ================= CANCEL BUTTON =================
        private void btnAddUpdateAdminCancel_Click(object sender, EventArgs e)
        {
            isCancelClicked = true;
            BackToAdminDashboard(sender, e);
        }

        // ================= FORM CLOSE =================
        private void AddUpdateAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isCancelClicked)
            {
                Application.Exit();
            }
        }

        private void pnlAddUpdateRecipBody_Paint(object sender, PaintEventArgs e)
        {
        }



    }
}