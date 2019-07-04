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
        //private ListViewItem currentItem;

        public FormReceive()
        {
            InitializeComponent();
        }

        private void FormReceive_Load(object sender, EventArgs e)
        {
            dtpDay.MinDate = DateTime.Today;

            // ListView Header
            lvResult.GridLines = true;
            lvResult.View = View.Details;
            lvResult.FullRowSelect = true;
            lvResult.Columns.Add("Purchasing Order ID", 150);
            lvResult.Columns.Add("Product ID", 100);
            lvResult.Columns.Add("Type", 50);
            lvResult.Columns.Add("Brand", 50);
            lvResult.Columns.Add("Product Name", 100);
            lvResult.Columns.Add("Description", 150);
            lvResult.Columns.Add("Quantity", 100);

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtOrderID.Text != "")
            {
                try
                {
                    String sql = String.Format("select * from purchasingOrder WHERE poId = '{0}' AND status = 'Creation'", txtOrderID.Text);
                    MySqlCommand cmd = Program.ExecSQL(sql);
                    MySqlDataReader data = cmd.ExecuteReader();

                    String orderID = "";

                    while (data.Read())
                    {
                        orderID = data.GetString("poId");
                        MessageBox.Show(orderID);
                    }

                    if (orderID != "")
                    {
                        sql = String.Format("select * from purchasingOrderProduct, product WHERE poId = '{0}' AND purchasingOrderProduct.productId = product.productId", orderID);
                        cmd = Program.ExecSQL(sql);
                        data = cmd.ExecuteReader();

                        lvResult.Items.Clear();

                        while (data.Read())
                        {
                            ListViewItem lv = new ListViewItem(data.GetString("poId").ToString());
                            lv.SubItems.Add(data.GetString("productId").ToString());
                            lv.SubItems.Add(data.GetString("type").ToString());
                            lv.SubItems.Add(data.GetString("brand").ToString());
                            lv.SubItems.Add(data.GetString("productName").ToString());
                            lv.SubItems.Add(data.GetString("description").ToString());
                            lv.SubItems.Add(data.GetString("qty").ToString());
                            lvResult.Items.Add(lv);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This order is Finished!");
                    }

                    data.Close();
                    cmd.Dispose();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("No this order!");
                }
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

        private void LvResult_MouseClick(object sender, MouseEventArgs e)
        {
            //currentItem = lvResult.GetItemAt(e.X, e.Y);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnReceived_Click(object sender, EventArgs e)
        {
            if (lvResult != null)
            {
                String sql = String.Format("select * from purchasingOrderProduct WHERE poId = '{0}'", txtOrderID.Text);
                MySqlCommand cmd = Program.ExecSQL(sql);
                MySqlDataReader data = cmd.ExecuteReader();

                while (data.Read())
                {
                    sql = String.Format("UPDATE product SET onHand = onHand + {0}, atHand = atHand - {0} WHERE productId = '{1}'", data.GetString(2), data.GetString(1));
                    cmd = Program.ExecSQL(sql);
                    cmd.ExecuteNonQuery();
                }

                sql = String.Format("UPDATE purchasingOrder SET status = 'Finish', deliveryDate = '{0}' WHERE poId = '{1}'", dtpDay.Value.ToString("yyyy-MM-dd"), txtOrderID.Text);
                cmd = Program.ExecSQL(sql);
                cmd.ExecuteNonQuery();

                data.Close();
                cmd.Dispose();

                MessageBox.Show("Order Finished");
            }
            else
            {
                MessageBox.Show("Please search a order");
            }

            lvResult.Items.Clear();
            txtOrderID.Clear();
            dtpDay.Value = DateTime.Now;
        }

        private void DtpDay_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;
        }
    }
}
