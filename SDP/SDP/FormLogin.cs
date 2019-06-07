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
        private static String userName = "";
        private static String password = "";

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
                MySqlCommand cmd = Program.Logindb(sql);
                MySqlDataReader data = cmd.ExecuteReader();

                while (data.Read())
                {
                    userName = data[0].ToString();
                }

                if (txtUserName.Text.ToString() == userName)
                {
                    sql = String.Format("select staffpwd from staff where staffpwd ='{0}'", txtPassword.Text);
                    cmd = Program.Logindb(sql);
                    data = cmd.ExecuteReader();

                    while (data.Read())
                    {
                        password = data[0].ToString();
                        //Console.WriteLine(password);
                    }

                    if (txtPassword.Text.ToString() == password)
                    {
                        Form menu = new FormMenu();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("The user name or password is incorrect! Try again.", "Error", MessageBoxButtons.OKCancel,
                                        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("The user name or password is incorrect! Try again.", "Error", MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
        }

        public static String getUserName()
        {
            return userName;
        }
    }
}
