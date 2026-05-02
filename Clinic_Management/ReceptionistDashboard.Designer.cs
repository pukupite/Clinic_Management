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
            this.pnlRecipNav = new System.Windows.Forms.Panel();
            this.lblRecipNavTitle = new System.Windows.Forms.Label();
            this.btnRecipLogout = new System.Windows.Forms.Button();
            this.pnlRecipContentBody = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRecipDeletePatient = new System.Windows.Forms.Button();
            this.btnRecipAddPatient = new System.Windows.Forms.Button();
            this.btnRecipUpdatePatient = new System.Windows.Forms.Button();
            this.pnlRecipFilter = new System.Windows.Forms.Panel();
            this.lblRecipFilter = new System.Windows.Forms.Label();
            this.txtRecipFilter = new System.Windows.Forms.TextBox();
            this.lblRecipFilterPhn = new System.Windows.Forms.Label();
            this.txtRecipFilterPhn = new System.Windows.Forms.TextBox();
            this.pnlRecipNav.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlRecipFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRecipNav
            // 
            this.pnlRecipNav.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlRecipNav.Controls.Add(this.lblRecipNavTitle);
            this.pnlRecipNav.Controls.Add(this.btnRecipLogout);
            this.pnlRecipNav.Location = new System.Drawing.Point(12, 12);
            this.pnlRecipNav.Name = "pnlRecipNav";
            this.pnlRecipNav.Size = new System.Drawing.Size(776, 67);
            this.pnlRecipNav.TabIndex = 0;
            // 
            // lblRecipNavTitle
            // 
            this.lblRecipNavTitle.AutoSize = true;
            this.lblRecipNavTitle.Location = new System.Drawing.Point(45, 23);
            this.lblRecipNavTitle.Name = "lblRecipNavTitle";
            this.lblRecipNavTitle.Size = new System.Drawing.Size(78, 16);
            this.lblRecipNavTitle.TabIndex = 1;
            this.lblRecipNavTitle.Text = "Patient Lists";
            this.lblRecipNavTitle.Click += new System.EventHandler(this.lblRecipNavTitle_Click);
            // 
            // btnRecipLogout
            // 
            this.btnRecipLogout.Location = new System.Drawing.Point(658, 18);
            this.btnRecipLogout.Name = "btnRecipLogout";
            this.btnRecipLogout.Size = new System.Drawing.Size(75, 27);
            this.btnRecipLogout.TabIndex = 0;
            this.btnRecipLogout.Text = "Logout";
            this.btnRecipLogout.UseVisualStyleBackColor = true;
            this.btnRecipLogout.Click += new System.EventHandler(this.btnRecipLogout_Click);
            // 
            // pnlRecipContentBody
            // 
            this.pnlRecipContentBody.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlRecipContentBody.Location = new System.Drawing.Point(12, 135);
            this.pnlRecipContentBody.Name = "pnlRecipContentBody";
            this.pnlRecipContentBody.Size = new System.Drawing.Size(776, 254);
            this.pnlRecipContentBody.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnRecipDeletePatient);
            this.panel1.Controls.Add(this.btnRecipAddPatient);
            this.panel1.Controls.Add(this.btnRecipUpdatePatient);
            this.panel1.Location = new System.Drawing.Point(12, 395);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 43);
            this.panel1.TabIndex = 2;
            // 
            // btnRecipDeletePatient
            // 
            this.btnRecipDeletePatient.Location = new System.Drawing.Point(524, 8);
            this.btnRecipDeletePatient.Name = "btnRecipDeletePatient";
            this.btnRecipDeletePatient.Size = new System.Drawing.Size(133, 27);
            this.btnRecipDeletePatient.TabIndex = 3;
            this.btnRecipDeletePatient.Text = "Delete Patient";
            this.btnRecipDeletePatient.UseVisualStyleBackColor = true;
            this.btnRecipDeletePatient.Click += new System.EventHandler(this.btnRecipDeletePatient_Click);
            // 
            // btnRecipAddPatient
            // 
            this.btnRecipAddPatient.Location = new System.Drawing.Point(112, 8);
            this.btnRecipAddPatient.Name = "btnRecipAddPatient";
            this.btnRecipAddPatient.Size = new System.Drawing.Size(154, 27);
            this.btnRecipAddPatient.TabIndex = 2;
            this.btnRecipAddPatient.Text = "Add Patient";
            this.btnRecipAddPatient.UseVisualStyleBackColor = true;
            this.btnRecipAddPatient.Click += new System.EventHandler(this.btnRecipAddPatient_Click);
            // 
            // btnRecipUpdatePatient
            // 
            this.btnRecipUpdatePatient.Location = new System.Drawing.Point(337, 8);
            this.btnRecipUpdatePatient.Name = "btnRecipUpdatePatient";
            this.btnRecipUpdatePatient.Size = new System.Drawing.Size(144, 27);
            this.btnRecipUpdatePatient.TabIndex = 1;
            this.btnRecipUpdatePatient.Text = "Update Patient";
            this.btnRecipUpdatePatient.UseVisualStyleBackColor = true;
            this.btnRecipUpdatePatient.Click += new System.EventHandler(this.btnRecipUpdatePatient_Click);
            // 
            // pnlRecipFilter
            // 
            this.pnlRecipFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlRecipFilter.Controls.Add(this.lblRecipFilter);
            this.pnlRecipFilter.Controls.Add(this.txtRecipFilter);
            this.pnlRecipFilter.Controls.Add(this.lblRecipFilterPhn);
            this.pnlRecipFilter.Controls.Add(this.txtRecipFilterPhn);
            this.pnlRecipFilter.Location = new System.Drawing.Point(12, 85);
            this.pnlRecipFilter.Name = "pnlRecipFilter";
            this.pnlRecipFilter.Size = new System.Drawing.Size(776, 44);
            this.pnlRecipFilter.TabIndex = 3;
            // 
            // lblRecipFilter
            // 
            this.lblRecipFilter.AutoSize = true;
            this.lblRecipFilter.Location = new System.Drawing.Point(312, 13);
            this.lblRecipFilter.Name = "lblRecipFilter";
            this.lblRecipFilter.Size = new System.Drawing.Size(42, 16);
            this.lblRecipFilter.TabIndex = 4;
            this.lblRecipFilter.Text = "Serial";
            // 
            // txtRecipFilter
            // 
            this.txtRecipFilter.Location = new System.Drawing.Point(364, 11);
            this.txtRecipFilter.Name = "txtRecipFilter";
            this.txtRecipFilter.Size = new System.Drawing.Size(100, 22);
            this.txtRecipFilter.TabIndex = 3;
            // 
            // lblRecipFilterPhn
            // 
            this.lblRecipFilterPhn.AutoSize = true;
            this.lblRecipFilterPhn.Location = new System.Drawing.Point(19, 12);
            this.lblRecipFilterPhn.Name = "lblRecipFilterPhn";
            this.lblRecipFilterPhn.Size = new System.Drawing.Size(46, 16);
            this.lblRecipFilterPhn.TabIndex = 2;
            this.lblRecipFilterPhn.Text = "Phone";
            // 
            // txtRecipFilterPhn
            // 
            this.txtRecipFilterPhn.Location = new System.Drawing.Point(71, 10);
            this.txtRecipFilterPhn.Name = "txtRecipFilterPhn";
            this.txtRecipFilterPhn.Size = new System.Drawing.Size(100, 22);
            this.txtRecipFilterPhn.TabIndex = 0;
            // 
            // ReceptionistDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlRecipFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlRecipContentBody);
            this.Controls.Add(this.pnlRecipNav);
            this.Name = "ReceptionistDashboard";
            this.Text = "Receptionist Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReceptionistDashboard_FormClosing);
            this.pnlRecipNav.ResumeLayout(false);
            this.pnlRecipNav.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlRecipFilter.ResumeLayout(false);
            this.pnlRecipFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRecipNav;
        private System.Windows.Forms.Label lblRecipNavTitle;
        private System.Windows.Forms.Button btnRecipLogout;
        private System.Windows.Forms.Panel pnlRecipContentBody;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRecipDeletePatient;
        private System.Windows.Forms.Button btnRecipAddPatient;
        private System.Windows.Forms.Button btnRecipUpdatePatient;
        private System.Windows.Forms.Panel pnlRecipFilter;
        private System.Windows.Forms.Label lblRecipFilter;
        private System.Windows.Forms.TextBox txtRecipFilter;
        private System.Windows.Forms.Label lblRecipFilterPhn;
        private System.Windows.Forms.TextBox txtRecipFilterPhn;
    }
}