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
    public partial class ChangePassword : Form
    {
        int SaffId = int.MaxValue;//default
        public ChangePassword(int InAccount)
        {
            SaffId = InAccount;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePw(SaffId);
        }

        private void ChangePw(int StaffID)
        {
            SecurityFunction sf = new SecurityFunction();
            //check if two password is equal
            if (tb_newPw.Text.Trim().Equals(tb_newPw2.Text.Trim()))
            {
                if (tb_newPw.Text.Trim().Equals(""))//nothing input
                {
                    MessageBox.Show("Empty Password", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (sf.ChangePassword(StaffID, tb_newPw.Text.Trim()))
                    {
                        MessageBox.Show("Password Changed", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //password Change, so current mobile session set to expire
                        sf.RemoveMobileSession(StaffID);
                    }
                    else
                    {
                        MessageBox.Show("Password not Changed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    this.Close(); //closed this form when finfished
                }
            }
            else
            {
                //not same
                MessageBox.Show("Password not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_newPw.Text = "";
                tb_newPw2.Text = "";
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
