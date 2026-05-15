namespace Clinic_Management
{
    partial class ReceptionistDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionistDashboard));
            this.pnlRecipNav = new System.Windows.Forms.Panel();
            this.lblRecipNavTitle = new System.Windows.Forms.Label();
            this.btnRecipLogout = new System.Windows.Forms.Button();
            this.dgvRecepPatientList = new System.Windows.Forms.DataGridView();
            this.pnlRecepFooter = new System.Windows.Forms.Panel();
            this.btnRecipDeletePatient = new System.Windows.Forms.Button();
            this.btnRecipAddPatient = new System.Windows.Forms.Button();
            this.btnRecipUpdatePatient = new System.Windows.Forms.Button();
            this.pnlRecipFilter = new System.Windows.Forms.Panel();
            this.lblRecipFilter = new System.Windows.Forms.Label();
            this.txtRecipFilterSerial = new System.Windows.Forms.TextBox();
            this.lblRecipFilterPhn = new System.Windows.Forms.Label();
            this.txtRecipFilterPhn = new System.Windows.Forms.TextBox();
            this.pnlRecipNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepPatientList)).BeginInit();
            this.pnlRecepFooter.SuspendLayout();
            this.pnlRecipFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRecipNav
            // 
            this.pnlRecipNav.BackColor = System.Drawing.Color.Teal;
            this.pnlRecipNav.Controls.Add(this.lblRecipNavTitle);
            this.pnlRecipNav.Controls.Add(this.btnRecipLogout);
            this.pnlRecipNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRecipNav.Location = new System.Drawing.Point(0, 0);
            this.pnlRecipNav.Name = "pnlRecipNav";
            this.pnlRecipNav.Size = new System.Drawing.Size(1182, 67);
            this.pnlRecipNav.TabIndex = 0;
            // 
            // lblRecipNavTitle
            // 
            this.lblRecipNavTitle.AutoSize = true;
            this.lblRecipNavTitle.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipNavTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRecipNavTitle.Location = new System.Drawing.Point(446, 16);
            this.lblRecipNavTitle.Name = "lblRecipNavTitle";
            this.lblRecipNavTitle.Size = new System.Drawing.Size(201, 36);
            this.lblRecipNavTitle.TabIndex = 1;
            this.lblRecipNavTitle.Text = "Patient Lists";
            this.lblRecipNavTitle.Click += new System.EventHandler(this.lblRecipNavTitle_Click);
            // 
            // btnRecipLogout
            // 
            this.btnRecipLogout.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecipLogout.Location = new System.Drawing.Point(992, 12);
            this.btnRecipLogout.Name = "btnRecipLogout";
            this.btnRecipLogout.Size = new System.Drawing.Size(127, 40);
            this.btnRecipLogout.TabIndex = 0;
            this.btnRecipLogout.Text = "Logout";
            this.btnRecipLogout.UseVisualStyleBackColor = true;
            this.btnRecipLogout.Click += new System.EventHandler(this.btnRecipLogout_Click);
            // 
            // dgvRecepPatientList
            // 
            this.dgvRecepPatientList.AllowUserToAddRows = false;
            this.dgvRecepPatientList.AllowUserToDeleteRows = false;
            this.dgvRecepPatientList.AllowUserToOrderColumns = true;
            this.dgvRecepPatientList.AllowUserToResizeColumns = false;
            this.dgvRecepPatientList.AllowUserToResizeRows = false;
            this.dgvRecepPatientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecepPatientList.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvRecepPatientList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvRecepPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecepPatientList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecepPatientList.Location = new System.Drawing.Point(12, 138);
            this.dgvRecepPatientList.MultiSelect = false;
            this.dgvRecepPatientList.Name = "dgvRecepPatientList";
            this.dgvRecepPatientList.ReadOnly = true;
            this.dgvRecepPatientList.RowHeadersVisible = false;
            this.dgvRecepPatientList.RowHeadersWidth = 51;
            this.dgvRecepPatientList.RowTemplate.Height = 24;
            this.dgvRecepPatientList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRecepPatientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecepPatientList.Size = new System.Drawing.Size(1158, 444);
            this.dgvRecepPatientList.TabIndex = 0;
            this.dgvRecepPatientList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecepPatientList_CellClick_1);
            this.dgvRecepPatientList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecepPatientList_CellContentClick);
            // 
            // pnlRecepFooter
            // 
            this.pnlRecepFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlRecepFooter.Controls.Add(this.btnRecipDeletePatient);
            this.pnlRecepFooter.Controls.Add(this.btnRecipAddPatient);
            this.pnlRecepFooter.Controls.Add(this.btnRecipUpdatePatient);
            this.pnlRecepFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRecepFooter.Location = new System.Drawing.Point(0, 588);
            this.pnlRecepFooter.Name = "pnlRecepFooter";
            this.pnlRecepFooter.Size = new System.Drawing.Size(1182, 65);
            this.pnlRecepFooter.TabIndex = 2;
            // 
            // btnRecipDeletePatient
            // 
            this.btnRecipDeletePatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecipDeletePatient.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecipDeletePatient.Location = new System.Drawing.Point(773, 15);
            this.btnRecipDeletePatient.Name = "btnRecipDeletePatient";
            this.btnRecipDeletePatient.Size = new System.Drawing.Size(166, 36);
            this.btnRecipDeletePatient.TabIndex = 3;
            this.btnRecipDeletePatient.Text = "Delete Patient";
            this.btnRecipDeletePatient.UseVisualStyleBackColor = true;
            this.btnRecipDeletePatient.Click += new System.EventHandler(this.btnRecipDeletePatient_Click);
            // 
            // btnRecipAddPatient
            // 
            this.btnRecipAddPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecipAddPatient.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecipAddPatient.Location = new System.Drawing.Point(234, 14);
            this.btnRecipAddPatient.Name = "btnRecipAddPatient";
            this.btnRecipAddPatient.Size = new System.Drawing.Size(172, 38);
            this.btnRecipAddPatient.TabIndex = 2;
            this.btnRecipAddPatient.Text = "Add Patient";
            this.btnRecipAddPatient.UseVisualStyleBackColor = true;
            this.btnRecipAddPatient.Click += new System.EventHandler(this.btnRecipAddPatient_Click);
            // 
            // btnRecipUpdatePatient
            // 
            this.btnRecipUpdatePatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecipUpdatePatient.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecipUpdatePatient.Location = new System.Drawing.Point(508, 15);
            this.btnRecipUpdatePatient.Name = "btnRecipUpdatePatient";
            this.btnRecipUpdatePatient.Size = new System.Drawing.Size(166, 37);
            this.btnRecipUpdatePatient.TabIndex = 1;
            this.btnRecipUpdatePatient.Text = "Update Patient";
            this.btnRecipUpdatePatient.UseVisualStyleBackColor = true;
            this.btnRecipUpdatePatient.Click += new System.EventHandler(this.btnRecipUpdatePatient_Click);
            // 
            // pnlRecipFilter
            // 
            this.pnlRecipFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlRecipFilter.Controls.Add(this.lblRecipFilter);
            this.pnlRecipFilter.Controls.Add(this.txtRecipFilterSerial);
            this.pnlRecipFilter.Controls.Add(this.lblRecipFilterPhn);
            this.pnlRecipFilter.Controls.Add(this.txtRecipFilterPhn);
            this.pnlRecipFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRecipFilter.Location = new System.Drawing.Point(0, 67);
            this.pnlRecipFilter.Name = "pnlRecipFilter";
            this.pnlRecipFilter.Size = new System.Drawing.Size(1182, 65);
            this.pnlRecipFilter.TabIndex = 3;
            // 
            // lblRecipFilter
            // 
            this.lblRecipFilter.AutoSize = true;
            this.lblRecipFilter.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipFilter.Location = new System.Drawing.Point(678, 20);
            this.lblRecipFilter.Name = "lblRecipFilter";
            this.lblRecipFilter.Size = new System.Drawing.Size(113, 25);
            this.lblRecipFilter.TabIndex = 4;
            this.lblRecipFilter.Text = "Patient ID";
            // 
            // txtRecipFilterSerial
            // 
            this.txtRecipFilterSerial.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipFilterSerial.Location = new System.Drawing.Point(797, 20);
            this.txtRecipFilterSerial.Name = "txtRecipFilterSerial";
            this.txtRecipFilterSerial.Size = new System.Drawing.Size(219, 29);
            this.txtRecipFilterSerial.TabIndex = 3;
            this.txtRecipFilterSerial.TextChanged += new System.EventHandler(this.txtRecipFilterSerial_TextChanged);
            // 
            // lblRecipFilterPhn
            // 
            this.lblRecipFilterPhn.AutoSize = true;
            this.lblRecipFilterPhn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipFilterPhn.Location = new System.Drawing.Point(160, 19);
            this.lblRecipFilterPhn.Name = "lblRecipFilterPhn";
            this.lblRecipFilterPhn.Size = new System.Drawing.Size(74, 25);
            this.lblRecipFilterPhn.TabIndex = 2;
            this.lblRecipFilterPhn.Text = "Phone";
            // 
            // txtRecipFilterPhn
            // 
            this.txtRecipFilterPhn.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipFilterPhn.Location = new System.Drawing.Point(262, 19);
            this.txtRecipFilterPhn.Name = "txtRecipFilterPhn";
            this.txtRecipFilterPhn.Size = new System.Drawing.Size(219, 29);
            this.txtRecipFilterPhn.TabIndex = 0;
            this.txtRecipFilterPhn.TextChanged += new System.EventHandler(this.txtRecipFilterPhn_TextChanged);
            // 
            // ReceptionistDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pnlRecipFilter);
            this.Controls.Add(this.dgvRecepPatientList);
            this.Controls.Add(this.pnlRecepFooter);
            this.Controls.Add(this.pnlRecipNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReceptionistDashboard";
            this.Text = "Receptionist Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReceptionistDashboard_FormClosing);
            this.Shown += new System.EventHandler(this.ReceptionistDashboard_Shown);
            this.pnlRecipNav.ResumeLayout(false);
            this.pnlRecipNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepPatientList)).EndInit();
            this.pnlRecepFooter.ResumeLayout(false);
            this.pnlRecipFilter.ResumeLayout(false);
            this.pnlRecipFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRecipNav;
        private System.Windows.Forms.Label lblRecipNavTitle;
        private System.Windows.Forms.Button btnRecipLogout;
        private System.Windows.Forms.Panel pnlRecepFooter;
        private System.Windows.Forms.Button btnRecipDeletePatient;
        private System.Windows.Forms.Button btnRecipAddPatient;
        private System.Windows.Forms.Button btnRecipUpdatePatient;
        private System.Windows.Forms.Panel pnlRecipFilter;
        private System.Windows.Forms.Label lblRecipFilter;
        private System.Windows.Forms.TextBox txtRecipFilterSerial;
        private System.Windows.Forms.Label lblRecipFilterPhn;
        private System.Windows.Forms.TextBox txtRecipFilterPhn;
        private System.Windows.Forms.DataGridView dgvRecepPatientList;
    }
}