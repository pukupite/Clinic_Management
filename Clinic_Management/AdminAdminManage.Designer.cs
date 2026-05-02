namespace Clinic_Management
{
    partial class AdminAdminManage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAdminFilterEmail = new System.Windows.Forms.TextBox();
            this.lblAdminFilterEmail = new System.Windows.Forms.Label();
            this.txtAdminFilterId = new System.Windows.Forms.TextBox();
            this.lblAdminFilterId = new System.Windows.Forms.Label();
            this.btnAdminDeleteAdmin = new System.Windows.Forms.Button();
            this.btnAdminUpdateAdmin = new System.Windows.Forms.Button();
            this.btnAdminAddNewAdmin = new System.Windows.Forms.Button();
            this.pnlAdminManageFooter = new System.Windows.Forms.Panel();
            this.dgvAdminManageList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.pnlAdminManageFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminManageList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtAdminFilterEmail);
            this.panel1.Controls.Add(this.lblAdminFilterEmail);
            this.panel1.Controls.Add(this.txtAdminFilterId);
            this.panel1.Controls.Add(this.lblAdminFilterId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 53);
            this.panel1.TabIndex = 0;
            // 
            // txtAdminFilterEmail
            // 
            this.txtAdminFilterEmail.Location = new System.Drawing.Point(371, 12);
            this.txtAdminFilterEmail.Name = "txtAdminFilterEmail";
            this.txtAdminFilterEmail.Size = new System.Drawing.Size(169, 22);
            this.txtAdminFilterEmail.TabIndex = 3;
            // 
            // lblAdminFilterEmail
            // 
            this.lblAdminFilterEmail.AutoSize = true;
            this.lblAdminFilterEmail.Location = new System.Drawing.Point(309, 15);
            this.lblAdminFilterEmail.Name = "lblAdminFilterEmail";
            this.lblAdminFilterEmail.Size = new System.Drawing.Size(41, 16);
            this.lblAdminFilterEmail.TabIndex = 2;
            this.lblAdminFilterEmail.Text = "Email";
            // 
            // txtAdminFilterId
            // 
            this.txtAdminFilterId.Location = new System.Drawing.Point(78, 14);
            this.txtAdminFilterId.Name = "txtAdminFilterId";
            this.txtAdminFilterId.Size = new System.Drawing.Size(123, 22);
            this.txtAdminFilterId.TabIndex = 1;
            // 
            // lblAdminFilterId
            // 
            this.lblAdminFilterId.AutoSize = true;
            this.lblAdminFilterId.Location = new System.Drawing.Point(42, 16);
            this.lblAdminFilterId.Name = "lblAdminFilterId";
            this.lblAdminFilterId.Size = new System.Drawing.Size(20, 16);
            this.lblAdminFilterId.TabIndex = 0;
            this.lblAdminFilterId.Text = "ID";
            // 
            // btnAdminDeleteAdmin
            // 
            this.btnAdminDeleteAdmin.Location = new System.Drawing.Point(421, 18);
            this.btnAdminDeleteAdmin.Name = "btnAdminDeleteAdmin";
            this.btnAdminDeleteAdmin.Size = new System.Drawing.Size(177, 29);
            this.btnAdminDeleteAdmin.TabIndex = 3;
            this.btnAdminDeleteAdmin.Text = "Delete";
            this.btnAdminDeleteAdmin.UseVisualStyleBackColor = true;
            this.btnAdminDeleteAdmin.Click += new System.EventHandler(this.btnAdminDeleteAdmin_Click);
            // 
            // btnAdminUpdateAdmin
            // 
            this.btnAdminUpdateAdmin.Location = new System.Drawing.Point(220, 18);
            this.btnAdminUpdateAdmin.Name = "btnAdminUpdateAdmin";
            this.btnAdminUpdateAdmin.Size = new System.Drawing.Size(170, 29);
            this.btnAdminUpdateAdmin.TabIndex = 2;
            this.btnAdminUpdateAdmin.Text = "Update";
            this.btnAdminUpdateAdmin.UseVisualStyleBackColor = true;
            this.btnAdminUpdateAdmin.Click += new System.EventHandler(this.btnAdminUpdateAdmin_Click);
            // 
            // btnAdminAddNewAdmin
            // 
            this.btnAdminAddNewAdmin.Location = new System.Drawing.Point(45, 18);
            this.btnAdminAddNewAdmin.Name = "btnAdminAddNewAdmin";
            this.btnAdminAddNewAdmin.Size = new System.Drawing.Size(143, 29);
            this.btnAdminAddNewAdmin.TabIndex = 1;
            this.btnAdminAddNewAdmin.Text = "Add New";
            this.btnAdminAddNewAdmin.UseVisualStyleBackColor = true;
            this.btnAdminAddNewAdmin.Click += new System.EventHandler(this.btnAdminAddNewAdmin_Click);
            // 
            // pnlAdminManageFooter
            // 
            this.pnlAdminManageFooter.BackColor = System.Drawing.SystemColors.Info;
            this.pnlAdminManageFooter.Controls.Add(this.btnAdminDeleteAdmin);
            this.pnlAdminManageFooter.Controls.Add(this.btnAdminUpdateAdmin);
            this.pnlAdminManageFooter.Controls.Add(this.btnAdminAddNewAdmin);
            this.pnlAdminManageFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAdminManageFooter.Location = new System.Drawing.Point(0, 391);
            this.pnlAdminManageFooter.Name = "pnlAdminManageFooter";
            this.pnlAdminManageFooter.Size = new System.Drawing.Size(800, 59);
            this.pnlAdminManageFooter.TabIndex = 2;
            // 
            // dgvAdminManageList
            // 
            this.dgvAdminManageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminManageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdminManageList.Location = new System.Drawing.Point(0, 53);
            this.dgvAdminManageList.Name = "dgvAdminManageList";
            this.dgvAdminManageList.RowHeadersWidth = 51;
            this.dgvAdminManageList.RowTemplate.Height = 24;
            this.dgvAdminManageList.Size = new System.Drawing.Size(800, 338);
            this.dgvAdminManageList.TabIndex = 3;
            // 
            // AdminAdminManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAdminManageList);
            this.Controls.Add(this.pnlAdminManageFooter);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAdminManage";
            this.Text = "Admin Management";
            this.Load += new System.EventHandler(this.AdminAdminManage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlAdminManageFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminManageList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdminDeleteAdmin;
        private System.Windows.Forms.Button btnAdminUpdateAdmin;
        private System.Windows.Forms.Button btnAdminAddNewAdmin;
        private System.Windows.Forms.TextBox txtAdminFilterEmail;
        private System.Windows.Forms.Label lblAdminFilterEmail;
        private System.Windows.Forms.TextBox txtAdminFilterId;
        private System.Windows.Forms.Label lblAdminFilterId;
        private System.Windows.Forms.Panel pnlAdminManageFooter;
        private System.Windows.Forms.DataGridView dgvAdminManageList;
    }
}