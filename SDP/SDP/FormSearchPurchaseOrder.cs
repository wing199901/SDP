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
    public partial class FormSearchPurchaseOrder : Form
    {
        private ListViewItem currentItem;

        public FormSearchPurchaseOrder()
        {
            InitializeComponent();

            // ListView Header
            lvOrder.GridLines = true;
            lvOrder.View = View.Details;
            lvOrder.FullRowSelect = true;
            lvOrder.Columns.Add("Purchasing Order ID", 150);
            lvOrder.Columns.Add("Staff ID", 70);
            lvOrder.Columns.Add("Status", 70);
            lvOrder.Columns.Add("Start Date", 100);
            lvOrder.Columns.Add("Arrived Date", 70);
            lvOrder.Columns.Add("Address", 200);
            lvOrder.Columns.Add("Total Amount", 100);
            lvOrder.Columns.Add("Remark", 100);

            // ListView Header
            lvProduct.GridLines = true;
            lvProduct.View = View.Details;
            lvProduct.FullRowSelect = true;
            lvProduct.Columns.Add("Purchasing Order ID", 150);
            lvProduct.Columns.Add("Product ID", 150);
            lvProduct.Columns.Add("Quantity", 150);

            cboStatus.SelectedIndex = 0;
        }

        private void FormSearchPurchaseOrder_Load(object sender, EventArgs e)
        {
            String sql = String.Format("select * from purchasingOrder");
            MySqlCommand cmd = Program.ExecSQL(sql);
            MySqlDataReader data = cmd.ExecuteReader();

            lvOrder.Items.Clear();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(data.GetString("poId").ToString());
                lv.SubItems.Add(data.GetString("staffId").ToString());
                lv.SubItems.Add(data.GetString("status").ToString());
                lv.SubItems.Add(data.GetString("date").ToString());
                lv.SubItems.Add(data.GetMySqlDateTime("deliveryDate").ToString());
                lv.SubItems.Add(data.GetString("address").ToString());
                lv.SubItems.Add(data.GetString("totalAmount").ToString());
                lv.SubItems.Add(data.GetString("remark").ToString());
                lvOrder.Items.Add(lv);
            }

            data.Close();
            cmd.Dispose();
        }

        private void LvOrder_MouseClick(object sender, MouseEventArgs e)
        {
            currentItem = lvOrder.GetItemAt(e.X, e.Y);

            if (currentItem != null)
            {
                String OrderID = currentItem.Text;
                MySqlCommand cmd = null;
                MySqlDataReader data = null;
                try
                {
                    String sql = String.Format("SELECT * FROM purchasingOrderProduct WHERE poId = '{0}'", OrderID);
                    cmd = Program.ExecSQL(sql);
                    data = cmd.ExecuteReader();

                    lvProduct.Items.Clear();

                    while (data.Read())
                    {
                        ListViewItem lv = new ListViewItem(data.GetString(0).ToString());
                        lv.SubItems.Add(data.GetString(1).ToString());
                        lv.SubItems.Add(data.GetString(2).ToString());
                        lvProduct.Items.Add(lv);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                data.Close();
                cmd.Dispose();

            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtOrderID.Text == "")
            {
                String sql = String.Format("SELECT * FROM purchasingOrder WHERE status = '{0}'", cboStatus.Text);
                MySqlCommand cmd = Program.ExecSQL(sql);
                MySqlDataReader data = cmd.ExecuteReader();

                lvOrder.Items.Clear();

                while (data.Read())
                {
                    ListViewItem lv = new ListViewItem(data.GetString("poId").ToString());
                    lv.SubItems.Add(data.GetString("staffId").ToString());
                    lv.SubItems.Add(data.GetString("status").ToString());
                    lv.SubItems.Add(data.GetString("date").ToString());
                    lv.SubItems.Add(data.GetMySqlDateTime("deliveryDate").ToString());
                    lv.SubItems.Add(data.GetString("address").ToString());
                    lv.SubItems.Add(data.GetString("totalAmount").ToString());
                    lv.SubItems.Add(data.GetString("remark").ToString());
                    lvOrder.Items.Add(lv);
                }

                data.Close();
                cmd.Dispose();

            }
            else
            {
                String sql = String.Format("SELECT * FROM purchasingOrder WHERE status = '{0}' AND poId = '{1}'", cboStatus.Text, txtOrderID.Text);
                MySqlCommand cmd = Program.ExecSQL(sql);
                MySqlDataReader data = cmd.ExecuteReader();

                lvOrder.Items.Clear();

                while (data.Read())
                {
                    ListViewItem lv = new ListViewItem(data.GetString("poId").ToString());
                    lv.SubItems.Add(data.GetString("staffId").ToString());
                    lv.SubItems.Add(data.GetString("status").ToString());
                    lv.SubItems.Add(data.GetString("date").ToString());
                    lv.SubItems.Add(data.GetMySqlDateTime("deliveryDate").ToString());
                    lv.SubItems.Add(data.GetString("address").ToString());
                    lv.SubItems.Add(data.GetString("totalAmount").ToString());
                    lv.SubItems.Add(data.GetString("remark").ToString());
                    lvOrder.Items.Add(lv);
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
