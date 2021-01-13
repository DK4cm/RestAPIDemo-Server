using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestAPIDemoServer
{
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
        }

        private void Table_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.DefaultCellStyle.NullValue = "";
            SQL sql = new SQL();
            SqlCommand cmd = new SqlCommand("SELECT id AS \"Table ID\",num AS \"Table Num\",description AS Description FROM dbo.TableTbl WHERE valid=1");
            DataTable dt = sql.executeSQLQuery(cmd);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            tb_description.Text = "";
            tb_num.Text = "";
            tb_tableID.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            if (e.RowIndex == -1) { return;} //if click title or others, just ignored,otherwise index out of range will occur
            tb_tableID.Text = dataGridView1.Rows[selectedRowIndex].Cells["Table ID"].Value.ToString();
            tb_num.Text = dataGridView1.Rows[selectedRowIndex].Cells["Table Num"].Value.ToString();
            tb_description.Text = dataGridView1.Rows[selectedRowIndex].Cells["Description"].Value.ToString();
        }

        private void btn_save_clicked(object sender, EventArgs e)
        {
            TableFunction tf = new TableFunction();
            if (tf.AddOrUpdateTable(tb_tableID.Text.Trim(), int.Parse(tb_num.Text.Trim()), tb_description.Text.Trim()))
            {
                MessageBox.Show("Success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SecurityFunction sf = new SecurityFunction();
                sf.UpdateModifyTime();
                ClearData();
            }
            else
            {
                MessageBox.Show("Save/Add Table failed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //update ui view
            UpdateDataGridView();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (tb_tableID.Text.Trim().Equals(""))//empty tableid
            {
                MessageBox.Show("Table ID can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dr = MessageBox.Show("Confirm Delete This Table?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (dr == DialogResult.No)
            {
                return; //not delete, just exit
            }

            TableFunction tf = new TableFunction();
            if (tf.DeleteTable(int.Parse(tb_tableID.Text.Trim())))
            {
                MessageBox.Show("Table Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
            }
            else
            {
                MessageBox.Show("Table Deleted Failed!! \n", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //whatever delete or not, better to refresh the list
            UpdateDataGridView();
        }

        /// <summary>
        /// Function to Control the textbox can only input the Digital number(positive only).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_tableNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            bool allowSpace = false;//no space allowed

            string keyInput = e.KeyChar.ToString();

            if (Char.IsDigit(e.KeyChar))
            {
                // Digits are OK
            }
            else if (e.KeyChar == '\b')
            {
                // Backspace key is OK
            }
            else if (allowSpace && e.KeyChar == ' ')
            {
                //if allowSpace= true, then can have space, we no need here
            }
            else
            {
                //whatever what key press other than digital, just ignored it
                //and tell the system is handled this key
                e.Handled = true;   
            }
        }
    }
}
