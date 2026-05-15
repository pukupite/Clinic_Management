namespace Clinic_Management
{
    partial class DoctorDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorDashboard));
            this.pnlDocNav = new System.Windows.Forms.Panel();
            this.lblDocNavTitle = new System.Windows.Forms.Label();
            this.btnDocLogout = new System.Windows.Forms.Button();
            this.dgvDocPatientList = new System.Windows.Forms.DataGridView();
            this.pnlDocFooter = new System.Windows.Forms.Panel();
            this.txtDocFilterPatientId = new System.Windows.Forms.TextBox();
            this.lblDocFilterSerial = new System.Windows.Forms.Label();
            this.btnDocMarkComplete = new System.Windows.Forms.Button();
            this.pnlDocNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocPatientList)).BeginInit();
            this.pnlDocFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDocNav
            // 
            this.pnlDocNav.BackColor = System.Drawing.Color.Teal;
            this.pnlDocNav.Controls.Add(this.lblDocNavTitle);
            this.pnlDocNav.Controls.Add(this.btnDocLogout);
            this.pnlDocNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDocNav.Location = new System.Drawing.Point(0, 0);
            this.pnlDocNav.Name = "pnlDocNav";
            this.pnlDocNav.Size = new System.Drawing.Size(1182, 86);
            this.pnlDocNav.TabIndex = 0;
            // 
            // lblDocNavTitle
            // 
            this.lblDocNavTitle.AutoSize = true;
            this.lblDocNavTitle.BackColor = System.Drawing.Color.Teal;
            this.lblDocNavTitle.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocNavTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDocNavTitle.Location = new System.Drawing.Point(471, 24);
            this.lblDocNavTitle.Name = "lblDocNavTitle";
            this.lblDocNavTitle.Size = new System.Drawing.Size(201, 40);
            this.lblDocNavTitle.TabIndex = 1;
            this.lblDocNavTitle.Text = "Patient List";
            // 
            // btnDocLogout
            // 
            this.btnDocLogout.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocLogout.Location = new System.Drawing.Point(986, 23);
            this.btnDocLogout.Name = "btnDocLogout";
            this.btnDocLogout.Size = new System.Drawing.Size(133, 36);
            this.btnDocLogout.TabIndex = 0;
            this.btnDocLogout.Text = "Logout";
            this.btnDocLogout.UseVisualStyleBackColor = true;
            this.btnDocLogout.Click += new System.EventHandler(this.btnDocLogout_Click);
            // 
            // dgvDocPatientList
            // 
            this.dgvDocPatientList.AllowUserToAddRows = false;
            this.dgvDocPatientList.AllowUserToDeleteRows = false;
            this.dgvDocPatientList.AllowUserToOrderColumns = true;
            this.dgvDocPatientList.AllowUserToResizeColumns = false;
            this.dgvDocPatientList.AllowUserToResizeRows = false;
            this.dgvDocPatientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocPatientList.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvDocPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocPatientList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDocPatientList.Location = new System.Drawing.Point(12, 92);
            this.dgvDocPatientList.MultiSelect = false;
            this.dgvDocPatientList.Name = "dgvDocPatientList";
            this.dgvDocPatientList.ReadOnly = true;
            this.dgvDocPatientList.RowHeadersVisible = false;
            this.dgvDocPatientList.RowHeadersWidth = 51;
            this.dgvDocPatientList.RowTemplate.Height = 24;
            this.dgvDocPatientList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDocPatientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocPatientList.Size = new System.Drawing.Size(1158, 469);
            this.dgvDocPatientList.TabIndex = 0;
            this.dgvDocPatientList.AllowUserToAddRowsChanged += new System.EventHandler(this.dgvDocPatientList_AllowUserToAddRowsChanged);
            this.dgvDocPatientList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocPatientList_CellClick);
            // 
            // pnlDocFooter
            // 
            this.pnlDocFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlDocFooter.Controls.Add(this.txtDocFilterPatientId);
            this.pnlDocFooter.Controls.Add(this.lblDocFilterSerial);
            this.pnlDocFooter.Controls.Add(this.btnDocMarkComplete);
            this.pnlDocFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDocFooter.Location = new System.Drawing.Point(0, 567);
            this.pnlDocFooter.Name = "pnlDocFooter";
            this.pnlDocFooter.Size = new System.Drawing.Size(1182, 86);
            this.pnlDocFooter.TabIndex = 1;
            // 
            // txtDocFilterPatientId
            // 
            this.txtDocFilterPatientId.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocFilterPatientId.Location = new System.Drawing.Point(374, 30);
            this.txtDocFilterPatientId.Name = "txtDocFilterPatientId";
            this.txtDocFilterPatientId.Size = new System.Drawing.Size(189, 29);
            this.txtDocFilterPatientId.TabIndex = 2;
            this.txtDocFilterPatientId.TextChanged += new System.EventHandler(this.txtDocFilterPatientId_TextChanged);
            // 
            // lblDocFilterSerial
            // 
            this.lblDocFilterSerial.AutoSize = true;
            this.lblDocFilterSerial.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblDocFilterSerial.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocFilterSerial.Location = new System.Drawing.Point(244, 34);
            this.lblDocFilterSerial.Name = "lblDocFilterSerial";
            this.lblDocFilterSerial.Size = new System.Drawing.Size(113, 25);
            this.lblDocFilterSerial.TabIndex = 1;
            this.lblDocFilterSerial.Text = "Patient ID";
            // 
            // btnDocMarkComplete
            // 
            this.btnDocMarkComplete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocMarkComplete.Location = new System.Drawing.Point(666, 26);
            this.btnDocMarkComplete.Name = "btnDocMarkComplete";
            this.btnDocMarkComplete.Size = new System.Drawing.Size(242, 35);
            this.btnDocMarkComplete.TabIndex = 0;
            this.btnDocMarkComplete.Text = "Mark As Complete!";
            this.btnDocMarkComplete.UseVisualStyleBackColor = true;
            this.btnDocMarkComplete.Click += new System.EventHandler(this.btnDocMarkComplete_Click);
            // 
            // DoctorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.dgvDocPatientList);
            this.Controls.Add(this.pnlDocFooter);
            this.Controls.Add(this.pnlDocNav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DoctorDashboard";
            this.Text = "Doctor Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoctorDashboard_FormClosing);
            this.Load += new System.EventHandler(this.DoctorDashboard_Load);
            this.Shown += new System.EventHandler(this.DoctorDashboard_Shown);
            this.pnlDocNav.ResumeLayout(false);
            this.pnlDocNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocPatientList)).EndInit();
            this.pnlDocFooter.ResumeLayout(false);
            this.pnlDocFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDocNav;
        private System.Windows.Forms.Button btnDocLogout;
        private System.Windows.Forms.Label lblDocNavTitle;
        private System.Windows.Forms.DataGridView dgvDocPatientList;
        private System.Windows.Forms.Panel pnlDocFooter;
        private System.Windows.Forms.Label lblDocFilterSerial;
        private System.Windows.Forms.Button btnDocMarkComplete;
        private System.Windows.Forms.TextBox txtDocFilterPatientId;
    }
}