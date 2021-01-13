using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestAPIDemoServer
{
    public partial class MenuType : Form
    {
        public MenuType()
        {
            InitializeComponent();
        }

        private void MenuType_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            SQL sql = new SQL();
            SqlCommand cmd = new SqlCommand("SELECT id AS \"Type ID\", name AS \"Type Name\" FROM dbo.MenuTypeTbl WHERE valid=1");
            DataTable dt = sql.executeSQLQuery(cmd);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.DefaultCellStyle.NullValue = "";
            dataGridView1.DataSource = dt;
        }

        /// <summary>
        /// Function to Control the textbox can only input the Digital number(positive only).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_MenuTypeID_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            tb_typeID.Text = "";
            tb_typeName.Text = "";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //check if id empty
            if (tb_typeID.Text.Trim().Equals(""))
            {
                MessageBox.Show("Menutype ID can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dr = MessageBox.Show("Confirm Delete This Menutype?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.No)
            {
                return; //not delete, just exit
            }

            MenuFuction mf = new MenuFuction();
            if (mf.DeleteMenuType(int.Parse(tb_typeID.Text.Trim())))
            {
                MessageBox.Show("MenuType Deleted\nRemeber update the Menu items, otherwise menu in deleted type cannot be shown", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else
            {
                MessageBox.Show("MenuType Deleted Failed!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateDataGridView();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            if (e.RowIndex == -1) { return; } //if click title or others, just ignored,otherwise index out of range will occur
            tb_typeID.Text = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();
            tb_typeName.Text = dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //check if id empty
            MenuFuction mf = new MenuFuction();
            if (mf.AddOrUpdateMenuType(tb_typeID.Text.Trim(), tb_typeName.Text.Trim()))
            {
                MessageBox.Show("Success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SecurityFunction sf = new SecurityFunction();
                sf.UpdateModifyTime();
                Clear();
            }
            else
            {
                MessageBox.Show("Save/Add Menu Type failed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateDataGridView();
        }
    }
}
