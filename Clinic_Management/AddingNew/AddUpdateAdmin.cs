using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Clinic_Management.AddingNew
{
    public partial class AddUpdateAdmin : Form
    {
        private AdminAdminManage admindshRef;
        private string operationType;
        private int updateId = -1;

        private DataAccess da = new DataAccess();

       

        public AddUpdateAdmin(AdminAdminManage admindshRef, string operationType, int updateId)
        {
            this.admindshRef = admindshRef;
            this.operationType = operationType;
            this.updateId = updateId;
            
            InitializeComponent();
            if (operationType == "update")
            {
                LoadExistingData();
            }
            this.StartPosition = FormStartPosition.CenterScreen;


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
        private void BackToAdminDashboard()
        {
                     
            this.Close();
           
        }

     
       


        // ================= SAVE BUTTON =================
        private void btnAddUpdateAdminSave_Click(object sender, EventArgs e)
        {
            isSavedBtnClicked = true;

            string Admin_Name = txtAddUpdateAdminName.Text;
            string Admin_Email = txtAddUpdateAdminEmail.Text;
            string Admin_Password = txtAddUpdateAdminPass.Text;
            string Admin_Phone = txtAddUpdateAdminPhn.Text;

            if (Admin_Name == "" || Admin_Email == "" || Admin_Password == "" || Admin_Phone == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }



            UtilityFunction UF = new UtilityFunction();

           
            if (!UF.EmailValidation(Admin_Email) || !UF.NameValidation(Admin_Name) || !UF.PhoneValidation(Admin_Phone) || !UF.PasswordValidation(Admin_Password))
            {
                      return;
            }



            if (!UF.IsEmailUnique(Admin_Email, updateId, "adminUser", "AdminId"))
            {
                MessageBox.Show("Email already exists. Please use a different email.");
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

            BackToAdminDashboard();
        }

        // ================= CANCEL BUTTON =================
        private void btnAddUpdateAdminCancel_Click(object sender, EventArgs e)
        {
            isCancelClicked = true;
            BackToAdminDashboard();
        }

        // ================= FORM CLOSE =================
        private bool isCancelClicked = false;
        private bool isSavedBtnClicked = false;
        private void AddUpdateAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isCancelClicked && !isSavedBtnClicked)
            {
                Application.Exit();
            }
        }

        private void pnlAddUpdateRecipBody_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnlAddUpdateRecipFooter_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}