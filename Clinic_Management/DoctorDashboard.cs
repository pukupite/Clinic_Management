using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management
{
    public partial class DoctorDashboard : Form
    {

        private Login loginRef;
        private DataAccess da = new DataAccess();
        private string selectedPatientId = "-1";


        //Constructor
        public DoctorDashboard(Login login)
        {
            this.loginRef = login;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadPatientData();
        }

        //Method to load patient data
        private void LoadPatientData()
        {
            string filterPhn = txtDocFilterPatientId.Text.Trim();           
            try
            {
                string sql = "SELECT * FROM Patient WHERE Status = 'Incomplete'";

                if (filterPhn != "")
                {
                    sql += " AND PatientID = '" + filterPhn + "'";
                }

            
                DataTable dt = da.ExecuteQueryTable(sql);
                dgvDocPatientList.DataSource = dt;
                dgvDocPatientList.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void DoctorDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnDocLogout_Click(object sender, EventArgs e)
        {
            isLogoutClicked = true;
            this.Close();
            loginRef.Show();
        }

        private void btnDocMarkComplete_Click(object sender, EventArgs e)
        {
            if(selectedPatientId == "-1")
            {
                MessageBox.Show("Please select a patient from the list.");
                return;
            }

            try
            {
                string sql = "UPDATE Patient SET Status = 'Completed' WHERE PatientID = '" + selectedPatientId + "'";
                int rowsAffected = da.ExecuteUpdateQuery(sql);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Patient marked as completed.");
                    LoadPatientData();
                }
                else
                {
                    MessageBox.Show("Failed to update patient status.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDocFilterPatientId_TextChanged(object sender, EventArgs e)
        {
            LoadPatientData();
        }

        private void dgvDocPatientList_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {

        }

        private void dgvDocPatientList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDocPatientList.Rows[e.RowIndex];

                selectedPatientId = dgvDocPatientList.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void DoctorDashboard_Shown(object sender, EventArgs e)
        {
            dgvDocPatientList.ClearSelection();
        }



        private bool isLogoutClicked = false;
        private void DoctorDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isLogoutClicked)
            {
                Application.Exit();
            }
        }



    }
}
