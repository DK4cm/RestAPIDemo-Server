namespace RestAPIDemoServer
{
    partial class MenuDetail
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_menuID = new System.Windows.Forms.TextBox();
            this.tb_menuName = new System.Windows.Forms.TextBox();
            this.tb_picLink = new System.Windows.Forms.TextBox();
            this.tb_unitPrice = new System.Windows.Forms.TextBox();
            this.tb_remark = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.cb_menuType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 167);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(948, 370);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Menu Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Unit Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Picture Link:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Menu Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(636, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Remark:";
            // 
            // tb_menuID
            // 
            this.tb_menuID.Enabled = false;
            this.tb_menuID.Location = new System.Drawing.Point(164, 6);
            this.tb_menuID.Name = "tb_menuID";
            this.tb_menuID.Size = new System.Drawing.Size(100, 31);
            this.tb_menuID.TabIndex = 7;
            // 
            // tb_menuName
            // 
            this.tb_menuName.Location = new System.Drawing.Point(164, 41);
            this.tb_menuName.Name = "tb_menuName";
            this.tb_menuName.Size = new System.Drawing.Size(189, 31);
            this.tb_menuName.TabIndex = 8;
            // 
            // tb_picLink
            // 
            this.tb_picLink.Location = new System.Drawing.Point(164, 79);
            this.tb_picLink.Name = "tb_picLink";
            this.tb_picLink.Size = new System.Drawing.Size(440, 31);
            this.tb_picLink.TabIndex = 9;
            // 
            // tb_unitPrice
            // 
            this.tb_unitPrice.Location = new System.Drawing.Point(482, 41);
            this.tb_unitPrice.Name = "tb_unitPrice";
            this.tb_unitPrice.Size = new System.Drawing.Size(122, 31);
            this.tb_unitPrice.TabIndex = 10;
            this.tb_unitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_unitPrice_KeyPress);
            // 
            // tb_remark
            // 
            this.tb_remark.Location = new System.Drawing.Point(737, 6);
            this.tb_remark.Multiline = true;
            this.tb_remark.Name = "tb_remark";
            this.tb_remark.Size = new System.Drawing.Size(226, 104);
            this.tb_remark.TabIndex = 11;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(278, 116);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(93, 42);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(430, 116);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(93, 42);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(569, 116);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(93, 42);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cb_menuType
            // 
            this.cb_menuType.FormattingEnabled = true;
            this.cb_menuType.Location = new System.Drawing.Point(430, 1);
            this.cb_menuType.Name = "cb_menuType";
            this.cb_menuType.Size = new System.Drawing.Size(174, 33);
            this.cb_menuType.TabIndex = 15;
            // 
            // MenuDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 563);
            this.Controls.Add(this.cb_menuType);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.tb_remark);
            this.Controls.Add(this.tb_unitPrice);
            this.Controls.Add(this.tb_picLink);
            this.Controls.Add(this.tb_menuName);
            this.Controls.Add(this.tb_menuID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MenuDetail";
            this.Text = "MenuDetail";
            this.Load += new System.EventHandler(this.MenuDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_menuID;
        private System.Windows.Forms.TextBox tb_menuName;
        private System.Windows.Forms.TextBox tb_picLink;
        private System.Windows.Forms.TextBox tb_unitPrice;
        private System.Windows.Forms.TextBox tb_remark;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cb_menuType;
    }
}