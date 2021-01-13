namespace RestAPIDemoServer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mobileUserSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBaseBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.refrashNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 435);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(687, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.tableSettingToolStripMenuItem,
            this.menuSettingToolStripMenuItem,
            this.dataBaseToolStripMenuItem,
            this.refrashNowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(687, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userSettingToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 19);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // userSettingToolStripMenuItem
            // 
            this.userSettingToolStripMenuItem.Name = "userSettingToolStripMenuItem";
            this.userSettingToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.userSettingToolStripMenuItem.Text = "User Setting";
            this.userSettingToolStripMenuItem.Click += new System.EventHandler(this.userSettingToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tableSettingToolStripMenuItem
            // 
            this.tableSettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableToolStripMenuItem});
            this.tableSettingToolStripMenuItem.Name = "tableSettingToolStripMenuItem";
            this.tableSettingToolStripMenuItem.Size = new System.Drawing.Size(87, 19);
            this.tableSettingToolStripMenuItem.Text = "Table Setting";
            // 
            // tableToolStripMenuItem
            // 
            this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            this.tableToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.tableToolStripMenuItem.Text = "Table";
            this.tableToolStripMenuItem.Click += new System.EventHandler(this.tableToolStripMenuItem_Click);
            // 
            // menuSettingToolStripMenuItem
            // 
            this.menuSettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTypeToolStripMenuItem,
            this.menuDetailToolStripMenuItem});
            this.menuSettingToolStripMenuItem.Name = "menuSettingToolStripMenuItem";
            this.menuSettingToolStripMenuItem.Size = new System.Drawing.Size(90, 19);
            this.menuSettingToolStripMenuItem.Text = "Menu Setting";
            // 
            // menuTypeToolStripMenuItem
            // 
            this.menuTypeToolStripMenuItem.Name = "menuTypeToolStripMenuItem";
            this.menuTypeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.menuTypeToolStripMenuItem.Text = "Menu Type";
            this.menuTypeToolStripMenuItem.Click += new System.EventHandler(this.menuTypeToolStripMenuItem_Click);
            // 
            // menuDetailToolStripMenuItem
            // 
            this.menuDetailToolStripMenuItem.Name = "menuDetailToolStripMenuItem";
            this.menuDetailToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.menuDetailToolStripMenuItem.Text = "Menu Detail";
            this.menuDetailToolStripMenuItem.Click += new System.EventHandler(this.menuDetailToolStripMenuItem_Click);
            // 
            // dataBaseToolStripMenuItem
            // 
            this.dataBaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mobileUserSessionToolStripMenuItem,
            this.dataBaseBackupToolStripMenuItem});
            this.dataBaseToolStripMenuItem.Name = "dataBaseToolStripMenuItem";
            this.dataBaseToolStripMenuItem.Size = new System.Drawing.Size(67, 19);
            this.dataBaseToolStripMenuItem.Text = "DataBase";
            // 
            // mobileUserSessionToolStripMenuItem
            // 
            this.mobileUserSessionToolStripMenuItem.Name = "mobileUserSessionToolStripMenuItem";
            this.mobileUserSessionToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.mobileUserSessionToolStripMenuItem.Text = "Reset All Login Seesion";
            this.mobileUserSessionToolStripMenuItem.Click += new System.EventHandler(this.mobileUserSessionToolStripMenuItem_Click);
            // 
            // dataBaseBackupToolStripMenuItem
            // 
            this.dataBaseBackupToolStripMenuItem.Name = "dataBaseBackupToolStripMenuItem";
            this.dataBaseBackupToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.dataBaseBackupToolStripMenuItem.Text = "DataBase Backup";
            this.dataBaseBackupToolStripMenuItem.Click += new System.EventHandler(this.dataBaseBackupToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(687, 408);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // refrashNowToolStripMenuItem
            // 
            this.refrashNowToolStripMenuItem.Name = "refrashNowToolStripMenuItem";
            this.refrashNowToolStripMenuItem.Size = new System.Drawing.Size(86, 19);
            this.refrashNowToolStripMenuItem.Text = "Refrash Now";
            this.refrashNowToolStripMenuItem.Click += new System.EventHandler(this.refrashNowToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 457);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mobileUserSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBaseBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem refrashNowToolStripMenuItem;
    }
}