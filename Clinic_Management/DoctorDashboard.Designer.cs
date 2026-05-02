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
            this.pnlDocNav = new System.Windows.Forms.Panel();
            this.lblDocNavTitle = new System.Windows.Forms.Label();
            this.btnDocLogout = new System.Windows.Forms.Button();
            this.pnlContentBody = new System.Windows.Forms.Panel();
            this.dgvDocPatientList = new System.Windows.Forms.DataGridView();
            this.pnlDocFooter = new System.Windows.Forms.Panel();
            this.lblDocFilterSerial = new System.Windows.Forms.Label();
            this.btnDocMarkComplete = new System.Windows.Forms.Button();
            this.txtDocFilterSerial = new System.Windows.Forms.TextBox();
            this.pnlDocNav.SuspendLayout();
            this.pnlContentBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocPatientList)).BeginInit();
            this.pnlDocFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDocNav
            // 
            this.pnlDocNav.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlDocNav.Controls.Add(this.lblDocNavTitle);
            this.pnlDocNav.Controls.Add(this.btnDocLogout);
            this.pnlDocNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDocNav.Location = new System.Drawing.Point(0, 0);
            this.pnlDocNav.Name = "pnlDocNav";
            this.pnlDocNav.Size = new System.Drawing.Size(800, 72);
            this.pnlDocNav.TabIndex = 0;
            // 
            // lblDocNavTitle
            // 
            this.lblDocNavTitle.AutoSize = true;
            this.lblDocNavTitle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblDocNavTitle.Location = new System.Drawing.Point(86, 32);
            this.lblDocNavTitle.Name = "lblDocNavTitle";
            this.lblDocNavTitle.Size = new System.Drawing.Size(71, 16);
            this.lblDocNavTitle.TabIndex = 1;
            this.lblDocNavTitle.Text = "Patient List";
            // 
            // btnDocLogout
            // 
            this.btnDocLogout.Location = new System.Drawing.Point(657, 23);
            this.btnDocLogout.Name = "btnDocLogout";
            this.btnDocLogout.Size = new System.Drawing.Size(75, 28);
            this.btnDocLogout.TabIndex = 0;
            this.btnDocLogout.Text = "Logout";
            this.btnDocLogout.UseVisualStyleBackColor = true;
            this.btnDocLogout.Click += new System.EventHandler(this.btnDocLogout_Click);
            // 
            // pnlContentBody
            // 
            this.pnlContentBody.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlContentBody.Controls.Add(this.dgvDocPatientList);
            this.pnlContentBody.Location = new System.Drawing.Point(0, 78);
            this.pnlContentBody.Name = "pnlContentBody";
            this.pnlContentBody.Size = new System.Drawing.Size(800, 294);
            this.pnlContentBody.TabIndex = 1;
            // 
            // dgvDocPatientList
            // 
            this.dgvDocPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocPatientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocPatientList.Location = new System.Drawing.Point(0, 0);
            this.dgvDocPatientList.Name = "dgvDocPatientList";
            this.dgvDocPatientList.RowHeadersWidth = 51;
            this.dgvDocPatientList.RowTemplate.Height = 24;
            this.dgvDocPatientList.Size = new System.Drawing.Size(800, 294);
            this.dgvDocPatientList.TabIndex = 0;
            // 
            // pnlDocFooter
            // 
            this.pnlDocFooter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlDocFooter.Controls.Add(this.txtDocFilterSerial);
            this.pnlDocFooter.Controls.Add(this.lblDocFilterSerial);
            this.pnlDocFooter.Controls.Add(this.btnDocMarkComplete);
            this.pnlDocFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDocFooter.Location = new System.Drawing.Point(0, 378);
            this.pnlDocFooter.Name = "pnlDocFooter";
            this.pnlDocFooter.Size = new System.Drawing.Size(800, 72);
            this.pnlDocFooter.TabIndex = 1;
            // 
            // lblDocFilterSerial
            // 
            this.lblDocFilterSerial.AutoSize = true;
            this.lblDocFilterSerial.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblDocFilterSerial.Location = new System.Drawing.Point(76, 28);
            this.lblDocFilterSerial.Name = "lblDocFilterSerial";
            this.lblDocFilterSerial.Size = new System.Drawing.Size(42, 16);
            this.lblDocFilterSerial.TabIndex = 1;
            this.lblDocFilterSerial.Text = "Serial";
            // 
            // btnDocMarkComplete
            // 
            this.btnDocMarkComplete.Location = new System.Drawing.Point(498, 21);
            this.btnDocMarkComplete.Name = "btnDocMarkComplete";
            this.btnDocMarkComplete.Size = new System.Drawing.Size(185, 28);
            this.btnDocMarkComplete.TabIndex = 0;
            this.btnDocMarkComplete.Text = "Mark As Complete!";
            this.btnDocMarkComplete.UseVisualStyleBackColor = true;
            this.btnDocMarkComplete.Click += new System.EventHandler(this.btnDocMarkComplete_Click);
            // 
            // txtDocFilterSerial
            // 
            this.txtDocFilterSerial.Location = new System.Drawing.Point(146, 24);
            this.txtDocFilterSerial.Name = "txtDocFilterSerial";
            this.txtDocFilterSerial.Size = new System.Drawing.Size(171, 22);
            this.txtDocFilterSerial.TabIndex = 2;
            // 
            // DoctorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlDocFooter);
            this.Controls.Add(this.pnlContentBody);
            this.Controls.Add(this.pnlDocNav);
            this.Name = "DoctorDashboard";
            this.Text = "Doctor Dashboard";
            this.Load += new System.EventHandler(this.DoctorDashboard_Load);
            this.pnlDocNav.ResumeLayout(false);
            this.pnlDocNav.PerformLayout();
            this.pnlContentBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocPatientList)).EndInit();
            this.pnlDocFooter.ResumeLayout(false);
            this.pnlDocFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDocNav;
        private System.Windows.Forms.Button btnDocLogout;
        private System.Windows.Forms.Panel pnlContentBody;
        private System.Windows.Forms.Label lblDocNavTitle;
        private System.Windows.Forms.DataGridView dgvDocPatientList;
        private System.Windows.Forms.Panel pnlDocFooter;
        private System.Windows.Forms.Label lblDocFilterSerial;
        private System.Windows.Forms.Button btnDocMarkComplete;
        private System.Windows.Forms.TextBox txtDocFilterSerial;
    }
}