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
    public partial class MenuDetail : Form
    {
        public MenuDetail()
        {
            InitializeComponent();
        }

        private void MenuDetail_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
            GetMenuType();
        }

        private void GetMenuType()
        {
            SQL sql = new SQL();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.MenuTypeTbl WHERE valid=1");
            DataTable dt = sql.executeSQLQuery(cmd);
            cb_menuType.DataSource = dt;
            cb_menuType.ValueMember = "id";
            cb_menuType.DisplayMember = "Name";
            cb_menuType.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_menuType.SelectedIndex = -1;
        }

        private void UpdateDataGridView()
        {
            SQL sql = new SQL();
            SqlCommand cmd = new SqlCommand("select a.id as \"Food ID\", a.name AS \"Food Name\",a.price AS \"Unit Price\",b.name as \"Menu Type\",a.remark AS \"Remark\",a.pic AS \"Pic Link\" from MenuTbl a left join MenuTypeTbl b on a.typeID = b.id WHERE a.valid=1");
            DataTable dt = sql.executeSQLQuery(cmd);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.DefaultCellStyle.NullValue = "";
            dataGridView1.DataSource = dt;
            if (dt.Rows.Count > 1)
            {
                dataGridView1.Columns["Unit Price"].DefaultCellStyle.Format = "c";
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            if (e.RowIndex == -1) { return; } //if click title or others, just ignored,otherwise index out of range will occur
            tb_menuID.Text = dataGridView1.Rows[selectedRowIndex].Cells["Food ID"].Value.ToString();
            tb_menuName.Text = dataGridView1.Rows[selectedRowIndex].Cells["Food Name"].Value.ToString();
            tb_remark.Text = dataGridView1.Rows[selectedRowIndex].Cells["Remark"].Value.ToString();
            tb_unitPrice.Text = dataGridView1.Rows[selectedRowIndex].Cells["Unit Price"].Value.ToString();
            tb_picLink.Text = dataGridView1.Rows[selectedRowIndex].Cells["Pic Link"].Value.ToString();
            cb_menuType.Text = dataGridView1.Rows[selectedRowIndex].Cells["Menu Type"].Value.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            tb_menuID.Text = "";
            tb_menuName.Text = "";
            tb_picLink.Text = "";
            tb_remark.Text = "";
            tb_unitPrice.Text = "";
            cb_menuType.SelectedText = "";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //check if empty
            if (tb_menuID.Text.Trim().Equals(""))
            {
                MessageBox.Show("Menu ID can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dr = MessageBox.Show("Confirm Delete This Menu?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.No)
            {
                return; //not delete, just exit
            }

            MenuFuction mf = new MenuFuction();
            if (mf.DeleteMenu(int.Parse(tb_menuID.Text.Trim())))
            {
                MessageBox.Show("Menu Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            else
            {
                MessageBox.Show("Menu Deleted Failed!! \n", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //whatever delete or not, better to refresh the list
            UpdateDataGridView();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            GlobalVar.MenuData newMenu = new GlobalVar.MenuData();
            newMenu.id = tb_menuID.Text.Trim();
            newMenu.name = tb_menuName.Text.Trim();
            newMenu.pic = tb_picLink.Text.Trim();
            newMenu.price = tb_unitPrice.Text.Trim();
            newMenu.remark = tb_remark.Text.Trim();
            newMenu.typeID = int.Parse(cb_menuType.SelectedValue.ToString());
            MenuFuction mf = new MenuFuction();
            if (mf.AddOrUpdateMenu(newMenu))
            {
                MessageBox.Show("Success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SecurityFunction sf = new SecurityFunction();
                sf.UpdateModifyTime();
                clear();
            }
            else
            {
                MessageBox.Show("Save/Add Menu Type failed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateDataGridView();
        }

        private void tb_unitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool allowSpace = false;
            NumberFormatInfo numberFormatInfo = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
            string decimalSeparator = numberFormatInfo.NumberDecimalSeparator;
            string groupSeparator = numberFormatInfo.NumberGroupSeparator;
            string negativeSign = numberFormatInfo.NegativeSign;

            string keyInput = e.KeyChar.ToString();

            if (Char.IsDigit(e.KeyChar))
            {
                // Digits are OK
            }
            else if (keyInput.Equals(decimalSeparator) || keyInput.Equals(groupSeparator) ||
             keyInput.Equals(negativeSign))
            {
                // Decimal separator is OK
            }
            else if (e.KeyChar == '\b')
            {
                // Backspace key is OK
            }

            else if (allowSpace && e.KeyChar == ' ')
            {

            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
