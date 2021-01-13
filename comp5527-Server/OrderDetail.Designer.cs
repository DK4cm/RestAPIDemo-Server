namespace RestAPIDemoServer
{
    partial class OrderDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_billrequest = new System.Windows.Forms.Button();
            this.tb_tableNo = new System.Windows.Forms.TextBox();
            this.tb_noOfPerson = new System.Windows.Forms.TextBox();
            this.tb_Staff = new System.Windows.Forms.TextBox();
            this.tb_orderID = new System.Windows.Forms.TextBox();
            this.tb_OrderTime = new System.Windows.Forms.TextBox();
            this.tb_total = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table Num:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "No. of Person:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Staff:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Order ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Order Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(425, 261);
            this.dataGridView1.TabIndex = 6;
            // 
            // btn_billrequest
            // 
            this.btn_billrequest.Location = new System.Drawing.Point(343, 462);
            this.btn_billrequest.Name = "btn_billrequest";
            this.btn_billrequest.Size = new System.Drawing.Size(94, 35);
            this.btn_billrequest.TabIndex = 7;
            this.btn_billrequest.Text = "Pay";
            this.btn_billrequest.UseVisualStyleBackColor = true;
            this.btn_billrequest.Click += new System.EventHandler(this.btn_billrequest_Click);
            // 
            // tb_tableNo
            // 
            this.tb_tableNo.Location = new System.Drawing.Point(170, 6);
            this.tb_tableNo.Name = "tb_tableNo";
            this.tb_tableNo.ReadOnly = true;
            this.tb_tableNo.Size = new System.Drawing.Size(267, 31);
            this.tb_tableNo.TabIndex = 8;
            // 
            // tb_noOfPerson
            // 
            this.tb_noOfPerson.Location = new System.Drawing.Point(170, 41);
            this.tb_noOfPerson.Name = "tb_noOfPerson";
            this.tb_noOfPerson.ReadOnly = true;
            this.tb_noOfPerson.Size = new System.Drawing.Size(267, 31);
            this.tb_noOfPerson.TabIndex = 9;
            // 
            // tb_Staff
            // 
            this.tb_Staff.Location = new System.Drawing.Point(170, 76);
            this.tb_Staff.Name = "tb_Staff";
            this.tb_Staff.ReadOnly = true;
            this.tb_Staff.Size = new System.Drawing.Size(267, 31);
            this.tb_Staff.TabIndex = 10;
            // 
            // tb_orderID
            // 
            this.tb_orderID.Location = new System.Drawing.Point(170, 111);
            this.tb_orderID.Name = "tb_orderID";
            this.tb_orderID.ReadOnly = true;
            this.tb_orderID.Size = new System.Drawing.Size(267, 31);
            this.tb_orderID.TabIndex = 11;
            // 
            // tb_OrderTime
            // 
            this.tb_OrderTime.Location = new System.Drawing.Point(170, 148);
            this.tb_OrderTime.Name = "tb_OrderTime";
            this.tb_OrderTime.ReadOnly = true;
            this.tb_OrderTime.Size = new System.Drawing.Size(267, 31);
            this.tb_OrderTime.TabIndex = 12;
            // 
            // tb_total
            // 
            this.tb_total.Location = new System.Drawing.Point(84, 469);
            this.tb_total.Name = "tb_total";
            this.tb_total.ReadOnly = true;
            this.tb_total.Size = new System.Drawing.Size(134, 31);
            this.tb_total.TabIndex = 13;
            // 
            // OrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 506);
            this.Controls.Add(this.tb_total);
            this.Controls.Add(this.tb_OrderTime);
            this.Controls.Add(this.tb_orderID);
            this.Controls.Add(this.tb_Staff);
            this.Controls.Add(this.tb_noOfPerson);
            this.Controls.Add(this.tb_tableNo);
            this.Controls.Add(this.btn_billrequest);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "OrderDetail";
            this.Text = "OrderDetail";
            this.Load += new System.EventHandler(this.OrderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_billrequest;
        private System.Windows.Forms.TextBox tb_tableNo;
        private System.Windows.Forms.TextBox tb_noOfPerson;
        private System.Windows.Forms.TextBox tb_Staff;
        private System.Windows.Forms.TextBox tb_orderID;
        private System.Windows.Forms.TextBox tb_OrderTime;
        private System.Windows.Forms.TextBox tb_total;
    }
}