using System;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Clinic_Management.AddingNew
{
    public partial class AddUpdateReciptionist : Form
    {
        private AdminDashboard admindshRef;
        private string operationType;
        private int updateId=-1;

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
            this.StartPosition = FormStartPosition.CenterScreen;
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
        private void BackToAdminDashboard()
        {
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

            UtilityFunction UF = new UtilityFunction();
            if (!UF.NameValidation(Recip_Name) || !UF.EmailValidation(Recip_Email) ||
                !UF.PasswordValidation(Recip_Password) || !UF.NIDValidation(Recip_NID) ||
                !UF.PhoneValidation(Recip_Phone))
            {
                return;
            }


            if (!UF.IsEmailUnique(Recip_Email, updateId, "Reciptionist", "ReciptionistId"))
            {
                MessageBox.Show("Email already Exists. Please use a different email.");
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

            BackToAdminDashboard();
        }

        // ================= CANCEL =================
        private void btnAddUpdateRecipCancel_Click(object sender, EventArgs e)
        {
            BackToAdminDashboard();
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

        private void pnlAddUpdateRecipBody_Paint(object sender, PaintEventArgs e)
        {

        }




    }
}