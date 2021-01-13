using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestAPIDemoServer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {

            if (GlobalVar.currentUser.permission == 0)  //admin, do nothing
            {
            }
            else if (GlobalVar.currentUser.permission == 1) //cashier
            {
                userSettingToolStripMenuItem.Enabled = false;
                dataBaseToolStripMenuItem.Enabled = false;
            }
            else
            {
                //nothing show
                menuStrip1.Enabled = false;
                dataGridView1.Enabled = false;
            }
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            UpdateDataGridView();
            timer1.Interval = 30000;//update every 30s
            timer1.Enabled = true;
        }

        private void UpdateDataGridView()
        {
            SQL sql = new SQL();
            SqlCommand cmd = new SqlCommand("select Distinct a.id AS \"Table ID\",a.num AS \"Table No\",a.flag AS \"States\",a.description AS \"Room Remark\",b.billRequested AS \"Bill Request\" from TableTbl a left join OrderTbl b on a.id=b.tableID WHERE a.valid=1 ORDER BY a.num");
            DataTable dt = sql.executeSQLQuery(cmd);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.DefaultCellStyle.NullValue = "";
            dataGridView1.DataSource = dt;
            foreach (DataGridViewRow dv in dataGridView1.Rows)
            {
                if (dv.Cells["States"].Value.ToString() == "True")
                {
                    dv.DefaultCellStyle.BackColor = Color.LightYellow;
                }
                if (dv.Cells["Bill Request"].Value.ToString() == "True")
                {
                    dv.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }


        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword(GlobalVar.currentUser.id);
            cp.ShowDialog();
        }

        private void userSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserSetting us = new UserSetting();
            us.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            table.ShowDialog();
        }

        private void menuTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuType mt = new MenuType();
            mt.ShowDialog();
        }

        private void menuDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuDetail md = new MenuDetail();
            md.ShowDialog();
        }

        private void mobileUserSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Reset All Mobile Login Seession?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                SQL sql= new SQL();
                SqlCommand cmd = new SqlCommand("Update dbo.StaffTbl SET tokenExpire = @tokenExpire");
                cmd.Parameters.AddWithValue("@tokenExpire",DateTime.Now.AddYears(-1).ToString());
                if (sql.executeSQL(cmd) >= 1)
                {
                    MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataBaseBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("C:\\backup"))
            {
                Directory.CreateDirectory("C:\\backup");
            }
            SQL sql = new SQL();
            SqlCommand cmd = new SqlCommand("BACKUP DATABASE @dbname TO DISK = 'C:\\backup\\backup999.bak' WITH FORMAT, MEDIANAME = 'SQLServerBackups', NAME = 'Full Backup of comp5527'");
            //SqlCommand cmd = new SqlCommand("BACKUP DATABASE comp5527 TO DISK = 'c:\\backup.bak' WITH FORMAT, MEDIANAME = 'SQLServerBackups', NAME = 'Full Backup of comp5527'");
            cmd.Parameters.AddWithValue("@dbname","comp5527");
            string BackupPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "backup-" + DateTime.Now.ToString("yyyy-MM-dd-HHmmss")+".bak");
            sql.executeSQL(cmd);
            if (File.Exists("C:\\backup\\backup999.bak"))
            {
                File.Move("C:\\backup\\backup999.bak", BackupPath);
                MessageBox.Show("Success\nBackup File Location:\n" + BackupPath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Backup Failed","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            if (e.RowIndex == -1) { return; } //if click title or others, just ignored,otherwise index out of range will occur
            string tableID = dataGridView1.Rows[selectedRowIndex].Cells["Table ID"].Value.ToString();
            TableFunction tf = new TableFunction();
            if (!tf.CheckTableState(tableID))   //if table not open, just 88
            {
                MessageBox.Show("Table not in use", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            OrderDetail od = new OrderDetail(tableID);
            od.ShowDialog();
        }

        private void refrashNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }
    }
}
