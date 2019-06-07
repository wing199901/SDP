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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            this.AcceptButton = this.btnOK;

            this.CancelButton = this.btnCancel;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("User name or password can not be null!","Error", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MySqlCommand cmd = Program.Logindb("select staffId ,staffpwd from staff");
                MySqlDataReader data = cmd.ExecuteReader();

            }
        }
    }
}
