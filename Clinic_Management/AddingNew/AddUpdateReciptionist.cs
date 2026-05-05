using System;
using System.Data;
using System.Windows.Forms;

namespace Clinic_Management.AddingNew
{
    public partial class AddUpdateReciptionist : Form
    {
        private AdminDashboard admindshRef;
        private string operationType;
        private int updateId;

        private DataAccess da = new DataAccess();

        public AddUpdateReciptionist(AdminDashboard admindshRef, string operationType, int updateId)
        {
            this.operationType = operationType;
            this.admindshRef = admindshRef;
            this.updateId = updateId;

            InitializeComponent();

            if (operationType == "update" && updateId > 0)
            {
                LoadExistingReciptionistData();
            }
        }

        

        // ================= LOAD EXISTING DATA =================
        private void LoadExistingReciptionistData()
        {
            string sql = "SELECT * FROM Reciptionist WHERE ReciptionistId = " + updateId;

            DataTable dt = da.ExecuteQueryTable(sql);

            if (dt.Rows.Count > 0)
            {
                txtAddUpdateRecipName.Text = dt.Rows[0]["Name"].ToString();
                txtAddUpdateRecipEmail.Text = dt.Rows[0]["Email"].ToString();
                txtAddUpdateRecipPhn.Text = dt.Rows[0]["Phone"].ToString();
                txtAddUpdateRecipNID.Text = dt.Rows[0]["NID"].ToString();
                txtAddUpdateRecipPass.Text = dt.Rows[0]["Password"].ToString();
            }
            else
            {
                MessageBox.Show("No data found!");
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
            string Recip_Name = txtAddUpdateRecipName.Text;
            string Recip_Email = txtAddUpdateRecipEmail.Text;
            string Recip_Password = txtAddUpdateRecipPass.Text;
            string Recip_NID = txtAddUpdateRecipNID.Text;
            string Recip_Phone = txtAddUpdateRecipPhn.Text;

            if (Recip_Name == "" || Recip_Email == "" || Recip_Password == "" ||
                Recip_NID == "" || Recip_Phone == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (operationType == "addNew")
            {
                string sql = "INSERT INTO Reciptionist (Name, Email, NID, Phone, Password) " +
                             "VALUES ('" + Recip_Name + "', '" + Recip_Email + "', '" +
                             Recip_NID + "', '" + Recip_Phone + "', '" + Recip_Password + "')";

                int result = da.ExecuteUpdateQuery(sql);

                if (result > 0)
                    MessageBox.Show("New receptionist added successfully!");
                else
                    MessageBox.Show("Insert failed!");
            }
            else if (operationType == "update")
            {
                string sql = "UPDATE Reciptionist SET " +
                             "Name='" + Recip_Name + "', " +
                             "Email='" + Recip_Email + "', " +
                             "NID='" + Recip_NID + "', " +
                             "Phone='" + Recip_Phone + "', " +
                             "Password='" + Recip_Password + "' " +
                             "WHERE ReciptionistId=" + updateId;

                int result = da.ExecuteUpdateQuery(sql);

                if (result > 0)
                    MessageBox.Show("Receptionist updated successfully!");
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

        private void lblAddupdateRecipInfoTitle_Click(object sender, EventArgs e)
        {
        }



        private void label5_Click(object sender, EventArgs e)
        {
            // do nothing
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // do nothing
        }


    }
}