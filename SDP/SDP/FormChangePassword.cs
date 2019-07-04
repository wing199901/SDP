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

            }
        }
    }
}
