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
    public partial class FormMenu : Form
    {
        private String userName = "";
        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private Boolean btnLogoutWasClicked;
        public FormMenu(String username)
        {
            InitializeComponent();
            UserName = username;
        }

        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            Form newOrder = new FormNewOrder(UserName);
            newOrder.ShowDialog();
        }

        private void BtnSearchOrder_Click(object sender, EventArgs e)
        {
            Form searchOrder = new FormSearchOrder();
            searchOrder.ShowDialog();
        }

        private void BtnDefective_Click(object sender, EventArgs e)
        {
            Form defective = new FormDefective();
            defective.ShowDialog();
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            Form stock = new FormEditStock();
            stock.ShowDialog();
        }

        private void BtnGoods_Click(object sender, EventArgs e)
        {
            Form good = new FormReceive();
            good.ShowDialog();
        }

        private void BtnGenReport_Click(object sender, EventArgs e)
        {
            Form report = new FormGenerate();
            report.ShowDialog();
        }

        private void BtnROL_Click(object sender, EventArgs e)
        {
            Form rol = new FormROL();
            rol.ShowDialog();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

            String sql = String.Format("select staffName from staff where staffId ={0}", UserName);
            MySqlCommand cmd = Program.ExecSQL(sql);
            MySqlDataReader data = cmd.ExecuteReader();
            String name = "";

            while (data.Read())
            {
                name = data[0].ToString();
            }

            data.Close();
            cmd.Dispose();

            lblWelcome.Text += name;

            btnLogoutWasClicked = false;
        }



        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnLogoutWasClicked == false)
            {
                DialogResult result = MessageBox.Show("Are you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                e.Cancel = (result == DialogResult.No);
                Environment.Exit(0);
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            btnLogoutWasClicked = true;

            DialogResult result = MessageBox.Show("Are you want to log out?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                btnLogoutWasClicked = false;
            }
        }
              
    }
}
