using Clinic_Management.AddingNew;
using System;
using System.Data;
using System.Windows.Forms;

namespace Clinic_Management
{
    public partial class AdminAdminManage : Form
    {
        private AdminDashboard adminDashboardRef;
        private string menuItemClicked;
        private int updateId;
        private DataAccess da;

        public AdminAdminManage(AdminDashboard admindshRef, string menuItemClicked  )
        {
            this.adminDashboardRef = admindshRef;
            this.menuItemClicked = menuItemClicked;
            this.da = new DataAccess();

            InitializeComponent();
            LoadAdminData();
        }

        // ================= LOAD DATA =================
        private void LoadAdminData(string id = "", string email = "")
        {
            string Query = "";

            if (menuItemClicked == "AdminManage")
            {
                Query = "SELECT * FROM adminUser WHERE 1=1";

                if (id != "")
                    Query += " AND CAST(AdminId AS VARCHAR) LIKE '%" + id + "%'";

                if (email != "")
                    Query += " AND Email LIKE '%" + email + "%'";
            }
            else if (menuItemClicked == "DoctorManage")
            {
                Query = "SELECT * FROM Doctor WHERE 1=1";

                if (id != "")
                    Query += " AND CAST(DoctorId AS VARCHAR) LIKE '%" + id + "%'";

                if (email != "")
                    Query += " AND Email LIKE '%" + email + "%'";
            }
            else if (menuItemClicked == "ReceipManage")
            {
                Query = "SELECT * FROM Reciptionist WHERE 1=1";

                if (id != "")
                    Query += " AND CAST(ReciptionistId AS VARCHAR) LIKE '%" + id + "%'";

                if (email != "")
                    Query += " AND Email LIKE '%" + email + "%'";
            }

            if (Query != "")
            dgvAdminManageList.DataSource = da.ExecuteQueryTable(Query);
        }
        // ================= FORM LOAD =================
        private void AdminAdminManage_Load(object sender, EventArgs e)
        {
            LoadAdminData();
        }

        // ================= ADD BUTTON =================
        private void btnAdminAddNewAdmin_Click(object sender, EventArgs e)
        {
            if (menuItemClicked == "AdminManage")
            {
                AddUpdateAdmin form = new AddUpdateAdmin(adminDashboardRef, "addNew", 0);
                form.Show();
            }
            else if (menuItemClicked == "DoctorManage")
            {
                AddUpdateDoctor form = new AddUpdateDoctor(adminDashboardRef, "addNew", 0);
                form.Show();
            }
            else if (menuItemClicked == "ReceipManage")
            {
                AddUpdateReciptionist form = new AddUpdateReciptionist(adminDashboardRef, "addNew", 0);
                form.Show();
            }
        }

        // ================= UPDATE BUTTON =================
        private void btnAdminUpdateAdmin_Click(object sender, EventArgs e)
        {
            if(updateId == 0)
            {
                MessageBox.Show("Please select a user first!");
                return;
            }


            if (menuItemClicked == "AdminManage")
            {
                AddUpdateAdmin form = new AddUpdateAdmin(adminDashboardRef, "update", updateId);
                form.Show();
            }
            else if (menuItemClicked == "DoctorManage")
            {
                AddUpdateDoctor form = new AddUpdateDoctor(adminDashboardRef, "update", updateId);
                form.Show();
            }
            else if (menuItemClicked == "ReceipManage")
            {
                AddUpdateReciptionist form = new AddUpdateReciptionist(adminDashboardRef, "update", updateId);
                form.Show();
            }
        }

        // ================= ID CATCH =================
        private void dgvAdminManageList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAdminManageList.Rows[e.RowIndex];

                if (row.Cells[0].Value != null)
                {
                    updateId = Convert.ToInt32(row.Cells[0].Value);

                    //// optional: show in textbox
                    //txtAdminFilterId.Text = updateId.ToString();
                }
            }
        }

        // ================= LIVE SEARCH BY ID =================
        private void txtAdminFilterId_TextChanged(object sender, EventArgs e)
        {
            LoadAdminData(
                txtAdminFilterId.Text,
                txtAdminFilterEmail.Text
            );
        }

        // ================= LIVE SEARCH BY EMAIL =================
        private void txtAdminFilterEmail_TextChanged(object sender, EventArgs e)
        {
            LoadAdminData(
                txtAdminFilterId.Text,
                txtAdminFilterEmail.Text
            );
        }

        private void btnAdminDeleteAdmin_Click(object sender, EventArgs e)
        {
            if (updateId == 0)
            {
                MessageBox.Show("Please select a user first!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                string sql = "";

                if (menuItemClicked == "AdminManage")
                {
                    sql = "DELETE FROM adminUser WHERE AdminId = " + updateId;
                }
                else if (menuItemClicked == "DoctorManage")
                {
                    sql = "DELETE FROM Doctor WHERE DoctorId = " + updateId;
                }
                else if (menuItemClicked == "ReceipManage")
                {
                    sql = "DELETE FROM Reciptionist WHERE ReciptionistId = " + updateId;
                }

                if (sql == "")
                {
                    MessageBox.Show("Invalid selection!");
                    return;
                }

                int rows = da.ExecuteUpdateQuery(sql);

                if (rows > 0)
                {
                    MessageBox.Show("Deleted successfully!");

                    LoadAdminData();
                    updateId = 0;
                }
                else
                {
                    MessageBox.Show("Delete failed!");
                }
            }
        }

        private void dgvAdminManageList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



    }
}