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
    public partial class FormReceive : Form
    {
        public FormReceive()
        {
            InitializeComponent();
        }

        private void FormReceive_Load(object sender, EventArgs e)
        {
            // ListView Header
            lvResult.GridLines = true;
            lvResult.View = View.Details;
            lvResult.FullRowSelect = true;
            lvResult.Columns.Add("Purchasing Order ID", 100);
            lvResult.Columns.Add("Product ID", 100);
            lvResult.Columns.Add("Quantity", 100);

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtOrderID.Text != "")
            {
                String sql = String.Format("select * from purchasingOrderProduct WHERE poId = '{0}'", txtOrderID.Text);
                MySqlCommand cmd = Program.ExecSQL(sql);
                MySqlDataReader data = cmd.ExecuteReader();

                lvResult.Items.Clear();

                while (data.Read())
                {
                    ListViewItem lv = new ListViewItem(data.GetString(0).ToString());
                    lv.SubItems.Add(data.GetString(1).ToString());
                    lv.SubItems.Add(data.GetString(2).ToString());
                    lvResult.Items.Add(lv);
                }

                data.Close();
                cmd.Dispose();
            }
        }

        private void TxtOrderID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.Focus();

                BtnSearch_Click(sender, e);

                txtOrderID.Focus();
            }
        }
    }
}
