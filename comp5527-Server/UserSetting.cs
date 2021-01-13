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
    public partial class UserSetting : Form
    {
        public UserSetting()
        {
            InitializeComponent();
        }

        private void UserSetting_Load(object sender, EventArgs e)
        {
            cb_gender.DropDownStyle = ComboBoxStyle.DropDownList;
            GetPremission();
            UpdateDataGridView();
        }

        private void GetPremission()
        {
            SQL sql = new SQL();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.PremissionTbl");
            DataTable dt = sql.executeSQLQuery(cmd);
            cb_premission.DataSource = dt;
            cb_premission.ValueMember = "id";
            cb_premission.DisplayMember = "premissionName";
            cb_premission.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_premission.SelectedIndex = -1;
        }

        private void UpdateDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.DefaultCellStyle.NullValue = "";
            SQL sql = new SQL();
            SqlCommand cmd = new SqlCommand("select staff.id AS ID,staff.account AS \"Display Name\",premi.premissionName AS Premission,staff.name as Name,staff.gender as Gender,staff.remark as Remark from StaffTbl staff join PremissionTbl premi on staff.permission=premi.id");
            DataTable dt = sql.executeSQLQuery(cmd);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check data
            if (!CheckInput())
            {
                return;
            }

            //get data
            GlobalVar.StaffData newUser = new GlobalVar.StaffData();
            newUser.account = tb_account.Text.Trim();
            newUser.gender = cb_gender.SelectedItem.ToString();
            newUser.name = tb_name.Text.Trim();
            newUser.passwordHash = ""; //useless
            newUser.permission = int.Parse(cb_premission.SelectedValue.ToString());
            newUser.remark = tb_remark.Text.Trim();

            SecurityFunction sf = new SecurityFunction();
            if (tb_ID.Text.Trim().Equals(""))
            {
                if (tb_password.Text.Trim().Equals(""))
                {
                    //new user must enter a password
                    MessageBox.Show("New User MUST have a password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //add new user
                if (!sf.NewUser(newUser, tb_password.Text.Trim()))
                {
                    MessageBox.Show("Add User Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //empty everything
                ResetField();
            }
            else
            {
                //change user data
                newUser.id = int.Parse(tb_ID.Text.Trim());
                if (!tb_password.Text.Trim().Equals(""))//passward not empty, call change password form
                {
                    ChangePassword cp = new ChangePassword(int.Parse(tb_ID.Text.Trim()));
                    cp.ShowDialog();
                }
                if (!sf.UpdataUserData(newUser))
                {
                    MessageBox.Show("User Data Changed Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //empty everything
                ResetField();
            }
            //whatever, update data
            UpdateDataGridView();
        }

        private bool CheckInput()
        {
            if (tb_account.Text.Equals(""))
            {
                MessageBox.Show("Login Name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (tb_name.Text.Equals(""))
            {
                MessageBox.Show("Name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cb_gender.SelectedIndex == -1 | cb_gender.Text.Trim().Equals(""))
            {
                MessageBox.Show("Gender is not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cb_premission.SelectedIndex == -1 |cb_premission.Text.Trim().Equals(""))
            {
                MessageBox.Show("Premission is not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            ResetField();
        }

        private void ResetField()
        {
            tb_account.Text = "";
            tb_ID.Text = "";
            tb_name.Text = "";
            tb_password.Text = "12345";
            tb_remark.Text = "";
            cb_gender.SelectedItem = "";
            cb_premission.SelectedIndex = 2;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            if (e.RowIndex == -1) { return; } //if click title or others, just ignored,otherwise index out of range will occur
            tb_ID.Text = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();
            tb_account.Text = dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString();
            cb_premission.Text = dataGridView1.Rows[selectedRowIndex].Cells[2].Value.ToString();
            tb_name.Text = dataGridView1.Rows[selectedRowIndex].Cells[3].Value.ToString();
            tb_password.Text = "";
            cb_gender.Text = dataGridView1.Rows[selectedRowIndex].Cells[4].Value.ToString();
            tb_remark.Text = dataGridView1.Rows[selectedRowIndex].Cells[5].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (tb_ID.Text.Trim().Equals(""))
            {
                return;
            }
            GlobalVar.StaffData deleteUser = new GlobalVar.StaffData();
            deleteUser.id = int.Parse(tb_ID.Text.Trim()); //Only id is needed
            DialogResult result = MessageBox.Show("Comfirm DELETE This USER??", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                SecurityFunction sf = new SecurityFunction();
                sf.DeleteUser(deleteUser);
                ResetField();
                UpdateDataGridView();
            }
        }
    }
}
