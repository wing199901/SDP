using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP
{
    public partial class FormChangePassword : Form
    {
        private String userName = "";
        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public FormChangePassword(String username)
        {
            InitializeComponent();
            UserName = username;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOld.Text))
            {
                MessageBox.Show("Old Password can not be empty.");
            }
            else if (string.IsNullOrWhiteSpace(txtNew.Text))
            {
                MessageBox.Show("New Password can not be empty.");
            }
            else if (string.IsNullOrWhiteSpace(txtOld.Text))
            {
                MessageBox.Show("Confirm New Password can not be empty.");
            }
            else
            {
                String Old = null;
                String sql = String.Format("SELECT pwd FROM staff WHERE stafId = {0}", UserName);
                MySqlCommand cmd = Program.ExecSQL(sql);
                MySqlDataReader data = cmd.ExecuteReader();

                while (data.Read())
                {
                    Old = data.GetString(0);
                }

                if (Old.Equals(txtNew.Text))
                {
                    if (txtNew.Text.Equals(txtConfirmation.Text))
                    {
                        sql = String.Format("UPDATE staff SET pwd = '{0}' WHERE staffId = '{1}'", txtConfirmation.Text, UserName);
                        cmd = Program.ExecSQL(sql);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Your New Password and Confirmation Password are not match.");
                        txtNew.Clear();
                        txtConfirmation.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("New Password can not be same as your Old Password.");
                }
            }
        }
    }
}
