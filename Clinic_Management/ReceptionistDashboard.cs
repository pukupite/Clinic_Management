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
    public partial class ReceptionistDashboard : Form
    {
        private DataAccess da = new DataAccess();
        private Login loginPageRef;
        private string selectedPatientId = "-1";




        public ReceptionistDashboard(Login loginPageRef)
        {
            this.loginPageRef = loginPageRef;
            InitializeComponent();

            this.LoadPatientData();
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        private void LoadPatientData()
        {
            string filterPhn = txtRecipFilterPhn.Text.Trim();
            string filterSerial = txtRecipFilterSerial.Text.Trim();

            try
            {
                string sql = "SELECT * FROM Patient WHERE 1=1";

                if (filterSerial != "")
                {
                    sql += " AND PatientID = '" + filterSerial + "'";
                }

                if (filterPhn != "")
                {
                    sql += " AND Phone LIKE '%" + filterPhn + "%'";
                }

                DataTable dt = da.ExecuteQueryTable(sql);
                dgvRecepPatientList.DataSource = dt;
                dgvRecepPatientList.ClearSelection();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblRecipNavTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnRecipAddPatient_Click(object sender, EventArgs e)
        {
           
            RecipPatientManage patientManage = new RecipPatientManage(this, "addingNew", "-1");
            patientManage.ShowDialog();
            LoadPatientData();
            patientManage.Close();

        }


        private void btnRecipUpdatePatient_Click(object sender, EventArgs e)
        {
            if (selectedPatientId == null || selectedPatientId == "-1")
            {
                MessageBox.Show("Please select a patient first!");
                return;
            }

            RecipPatientManage patientManage = new RecipPatientManage(this, "update", selectedPatientId);
            patientManage.ShowDialog();
            LoadPatientData();
            selectedPatientId = "-1";
            
            patientManage.Close();

        }

        private void btnRecipDeletePatient_Click(object sender, EventArgs e)
        {

           if (selectedPatientId == null || selectedPatientId == "" || selectedPatientId == "-1")
            {
                MessageBox.Show("Please select a patient first!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this patient?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE FROM Patient WHERE PatientID = '" + selectedPatientId + "'";
                    int rows = da.ExecuteUpdateQuery(sql);

                    if (rows > 0)
                    {
                        MessageBox.Show("Patient deleted successfully!");

                        LoadPatientData();
                        selectedPatientId = null;
                    }
                    else
                    {
                        MessageBox.Show("Delete failed!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        private bool isLogoutClicked = false;
        private void ReceptionistDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isLogoutClicked)
            {
                Application.Exit();
            }
        }

        private void btnRecipLogout_Click(object sender, EventArgs e)
        {
            isLogoutClicked = true;
            this.Hide();
            loginPageRef.Show();
        }

        private void txtRecipFilterPhn_TextChanged(object sender, EventArgs e)
        {
            LoadPatientData();

        }

        private void txtRecipFilterSerial_TextChanged(object sender, EventArgs e)
        {
            LoadPatientData();

        }
     

       

        private void dgvRecepPatientList_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRecepPatientList.Rows[e.RowIndex];

                selectedPatientId = dgvRecepPatientList.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }



        // Clear selection when the form is Initially Load
        private void ReceptionistDashboard_Shown(object sender, EventArgs e)
        {
            dgvRecepPatientList.ClearSelection();
            
        }

        private void dgvRecepPatientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
