namespace Clinic_Management
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.pnlAdminNavTitle = new System.Windows.Forms.Panel();
            this.lblAdminNavTitle = new System.Windows.Forms.Label();
            this.pnlAdminSidebar = new System.Windows.Forms.Panel();
            this.pbxMenuIcon = new System.Windows.Forms.PictureBox();
            this.btnAdminLogout = new System.Windows.Forms.Button();
            this.pnlAdminSidebarDashboard = new System.Windows.Forms.Panel();
            this.lblAdminSidebarDashboard = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAdminSidebarRecipManage = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAdminSidebarDocManage = new System.Windows.Forms.Label();
            this.pnlAdminSidebarAdmManage = new System.Windows.Forms.Panel();
            this.lblAdminSidebarAdmManage = new System.Windows.Forms.Label();
            this.pnlAdminContentBody = new System.Windows.Forms.Panel();
            this.lblAdminDashboardContentBody = new System.Windows.Forms.Label();
            this.pnlAdminNavTitle.SuspendLayout();
            this.pnlAdminSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenuIcon)).BeginInit();
            this.pnlAdminSidebarDashboard.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlAdminSidebarAdmManage.SuspendLayout();
            this.pnlAdminContentBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAdminNavTitle
            // 
            this.pnlAdminNavTitle.BackColor = System.Drawing.Color.Teal;
            this.pnlAdminNavTitle.Controls.Add(this.lblAdminNavTitle);
            this.pnlAdminNavTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdminNavTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlAdminNavTitle.Name = "pnlAdminNavTitle";
            this.pnlAdminNavTitle.Size = new System.Drawing.Size(1182, 89);
            this.pnlAdminNavTitle.TabIndex = 1;
            // 
            // lblAdminNavTitle
            // 
            this.lblAdminNavTitle.AutoSize = true;
            this.lblAdminNavTitle.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminNavTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblAdminNavTitle.Location = new System.Drawing.Point(222, 27);
            this.lblAdminNavTitle.Name = "lblAdminNavTitle";
            this.lblAdminNavTitle.Size = new System.Drawing.Size(409, 40);
            this.lblAdminNavTitle.TabIndex = 1;
            this.lblAdminNavTitle.Text = "Welcome to Clinic BD";
            this.lblAdminNavTitle.Click += new System.EventHandler(this.lblAdminSidebarDocManage_Click);
            // 
            // pnlAdminSidebar
            // 
            this.pnlAdminSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlAdminSidebar.Controls.Add(this.pbxMenuIcon);
            this.pnlAdminSidebar.Controls.Add(this.btnAdminLogout);
            this.pnlAdminSidebar.Controls.Add(this.pnlAdminSidebarDashboard);
            this.pnlAdminSidebar.Controls.Add(this.panel3);
            this.pnlAdminSidebar.Controls.Add(this.panel2);
            this.pnlAdminSidebar.Controls.Add(this.pnlAdminSidebarAdmManage);
            this.pnlAdminSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAdminSidebar.Location = new System.Drawing.Point(0, 89);
            this.pnlAdminSidebar.Name = "pnlAdminSidebar";
            this.pnlAdminSidebar.Size = new System.Drawing.Size(229, 564);
            this.pnlAdminSidebar.TabIndex = 3;
            // 
            // pbxMenuIcon
            // 
            this.pbxMenuIcon.Image = global::Clinic_Management.Properties.Resources.clinic_icon_Photoroom;
            this.pbxMenuIcon.Location = new System.Drawing.Point(39, 25);
            this.pbxMenuIcon.Name = "pbxMenuIcon";
            this.pbxMenuIcon.Size = new System.Drawing.Size(154, 139);
            this.pbxMenuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMenuIcon.TabIndex = 6;
            this.pbxMenuIcon.TabStop = false;
            // 
            // btnAdminLogout
            // 
            this.btnAdminLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdminLogout.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogout.Location = new System.Drawing.Point(50, 477);
            this.btnAdminLogout.Name = "btnAdminLogout";
            this.btnAdminLogout.Size = new System.Drawing.Size(103, 38);
            this.btnAdminLogout.TabIndex = 5;
            this.btnAdminLogout.Text = "Logout";
            this.btnAdminLogout.UseVisualStyleBackColor = false;
            this.btnAdminLogout.Click += new System.EventHandler(this.btnAdminLogout_Click);
            // 
            // pnlAdminSidebarDashboard
            // 
            this.pnlAdminSidebarDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlAdminSidebarDashboard.Controls.Add(this.lblAdminSidebarDashboard);
            this.pnlAdminSidebarDashboard.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAdminSidebarDashboard.Location = new System.Drawing.Point(4, 191);
            this.pnlAdminSidebarDashboard.Name = "pnlAdminSidebarDashboard";
            this.pnlAdminSidebarDashboard.Size = new System.Drawing.Size(219, 45);
            this.pnlAdminSidebarDashboard.TabIndex = 5;
            this.pnlAdminSidebarDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAdminSidebarDashboard_Paint);
            this.pnlAdminSidebarDashboard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlAdminSidebarDashboard_MouseClick);
            // 
            // lblAdminSidebarDashboard
            // 
            this.lblAdminSidebarDashboard.AutoSize = true;
            this.lblAdminSidebarDashboard.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminSidebarDashboard.Location = new System.Drawing.Point(55, 13);
            this.lblAdminSidebarDashboard.Name = "lblAdminSidebarDashboard";
            this.lblAdminSidebarDashboard.Size = new System.Drawing.Size(101, 20);
            this.lblAdminSidebarDashboard.TabIndex = 1;
            this.lblAdminSidebarDashboard.Text = "Dashboard";
            this.lblAdminSidebarDashboard.Click += new System.EventHandler(this.lblAdminSidebarDashboard_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.lblAdminSidebarRecipManage);
            this.panel3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(4, 369);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 45);
            this.panel3.TabIndex = 3;
            this.panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseClick);
            // 
            // lblAdminSidebarRecipManage
            // 
            this.lblAdminSidebarRecipManage.AutoSize = true;
            this.lblAdminSidebarRecipManage.Location = new System.Drawing.Point(7, 14);
            this.lblAdminSidebarRecipManage.Name = "lblAdminSidebarRecipManage";
            this.lblAdminSidebarRecipManage.Size = new System.Drawing.Size(182, 20);
            this.lblAdminSidebarRecipManage.TabIndex = 1;
            this.lblAdminSidebarRecipManage.Text = "Reciptionist Manage";
            this.lblAdminSidebarRecipManage.Click += new System.EventHandler(this.lblAdminSidebarRecipManage_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.lblAdminSidebarDocManage);
            this.panel2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(4, 310);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 45);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            // 
            // lblAdminSidebarDocManage
            // 
            this.lblAdminSidebarDocManage.AutoSize = true;
            this.lblAdminSidebarDocManage.Location = new System.Drawing.Point(38, 13);
            this.lblAdminSidebarDocManage.Name = "lblAdminSidebarDocManage";
            this.lblAdminSidebarDocManage.Size = new System.Drawing.Size(137, 20);
            this.lblAdminSidebarDocManage.TabIndex = 1;
            this.lblAdminSidebarDocManage.Text = "Doctor Manage";
            this.lblAdminSidebarDocManage.Click += new System.EventHandler(this.lblAdminSidebarDocManage_Click);
            // 
            // pnlAdminSidebarAdmManage
            // 
            this.pnlAdminSidebarAdmManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlAdminSidebarAdmManage.Controls.Add(this.lblAdminSidebarAdmManage);
            this.pnlAdminSidebarAdmManage.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAdminSidebarAdmManage.Location = new System.Drawing.Point(4, 250);
            this.pnlAdminSidebarAdmManage.Name = "pnlAdminSidebarAdmManage";
            this.pnlAdminSidebarAdmManage.Size = new System.Drawing.Size(219, 45);
            this.pnlAdminSidebarAdmManage.TabIndex = 1;
            this.pnlAdminSidebarAdmManage.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.pnlAdminSidebarAdmManage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlAdminSidebarAdmManage_MouseClick);
            // 
            // lblAdminSidebarAdmManage
            // 
            this.lblAdminSidebarAdmManage.AutoSize = true;
            this.lblAdminSidebarAdmManage.Location = new System.Drawing.Point(38, 13);
            this.lblAdminSidebarAdmManage.Name = "lblAdminSidebarAdmManage";
            this.lblAdminSidebarAdmManage.Size = new System.Drawing.Size(137, 20);
            this.lblAdminSidebarAdmManage.TabIndex = 1;
            this.lblAdminSidebarAdmManage.Text = "Admin Manage";
            this.lblAdminSidebarAdmManage.Click += new System.EventHandler(this.lblAdminSidebarAdmManage_Click);
            // 
            // pnlAdminContentBody
            // 
            this.pnlAdminContentBody.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlAdminContentBody.Controls.Add(this.lblAdminDashboardContentBody);
            this.pnlAdminContentBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdminContentBody.Location = new System.Drawing.Point(229, 89);
            this.pnlAdminContentBody.Name = "pnlAdminContentBody";
            this.pnlAdminContentBody.Size = new System.Drawing.Size(953, 564);
            this.pnlAdminContentBody.TabIndex = 4;
            // 
            // lblAdminDashboardContentBody
            // 
            this.lblAdminDashboardContentBody.AutoSize = true;
            this.lblAdminDashboardContentBody.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminDashboardContentBody.Location = new System.Drawing.Point(348, 25);
            this.lblAdminDashboardContentBody.Name = "lblAdminDashboardContentBody";
            this.lblAdminDashboardContentBody.Size = new System.Drawing.Size(207, 20);
            this.lblAdminDashboardContentBody.TabIndex = 2;
            this.lblAdminDashboardContentBody.Text = "Welcome to Dashboard";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pnlAdminContentBody);
            this.Controls.Add(this.pnlAdminSidebar);
            this.Controls.Add(this.pnlAdminNavTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminDashboard";
            this.Text = "Admin Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminDashboard_FormClosing);
            this.pnlAdminNavTitle.ResumeLayout(false);
            this.pnlAdminNavTitle.PerformLayout();
            this.pnlAdminSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenuIcon)).EndInit();
            this.pnlAdminSidebarDashboard.ResumeLayout(false);
            this.pnlAdminSidebarDashboard.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlAdminSidebarAdmManage.ResumeLayout(false);
            this.pnlAdminSidebarAdmManage.PerformLayout();
            this.pnlAdminContentBody.ResumeLayout(false);
            this.pnlAdminContentBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlAdminNavTitle;
        private System.Windows.Forms.Panel pnlAdminSidebar;
        private System.Windows.Forms.Button btnAdminLogout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAdminSidebarRecipManage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAdminSidebarDocManage;
        private System.Windows.Forms.Panel pnlAdminSidebarAdmManage;
        private System.Windows.Forms.Label lblAdminSidebarAdmManage;
        private System.Windows.Forms.Panel pnlAdminSidebarDashboard;
        private System.Windows.Forms.Label lblAdminSidebarDashboard;
        private System.Windows.Forms.Label lblAdminNavTitle;
        private System.Windows.Forms.Panel pnlAdminContentBody;
        private System.Windows.Forms.Label lblAdminDashboardContentBody;
        private System.Windows.Forms.PictureBox pbxMenuIcon;
    }
}