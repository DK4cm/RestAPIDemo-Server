using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestAPIDemoServer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SecurityFunction sf = new SecurityFunction();
            if (sf.UserLogin(tb_id.Text, tb_password.Text))
            {
                MainForm fm = new MainForm();
                this.Visible = false;
                fm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Failed.","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
