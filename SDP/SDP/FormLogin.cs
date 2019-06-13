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
        private String userName = "";
        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private String password = "";
        public String Password
        {
            get { return password; }
            set { password = value; }
        }


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
                MessageBox.Show("User name or password can not be null!", "Error", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                String sql = String.Format("select staffId from staff where staffId ={0}", txtUserName.Text);
                MySqlCommand cmd;
                MySqlDataReader data = null;
                try
                {
                    cmd = Program.ExecSQL(sql);
                    data = cmd.ExecuteReader();
                    while (data.Read())
                    {
                        UserName = data[0].ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("No server connected! Try again later.", "Error", MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    System.Windows.Forms.Application.Exit();
                }

                if (txtUserName.Text.ToString() == UserName)
                {
                    sql = String.Format("select pwd from staff where pwd ='{0}'", txtPassword.Text);
                    cmd = Program.ExecSQL(sql);
                    data = cmd.ExecuteReader();




                    while (data.Read())
                    {
                        Password = data[0].ToString();
                        //Console.WriteLine(password);
                    }

                    if (txtPassword.Text.ToString() == Password)
                    {
                        this.Hide();
                        Form menu = new FormMenu(UserName);
                        menu.ShowDialog();
                        //After Form Menu Closed.
                        clear();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("The user name or password is incorrect! Try again.", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("The user name or password is incorrect! Try again.", "Error");
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void clear()
        {
            UserName = "";
            Password = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
        }
    }
}
