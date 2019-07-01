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
    public partial class FormROL : Form
    {
        private String keyword;

        public String Keyword
        {
            get { return keyword; }
            set { keyword = value; }
        }

        private String productId = "";

        public String ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        public FormROL()
        {
            InitializeComponent();

            BtnSearch_Click(new object(), new EventArgs());

            //ListView Header
            lvResult.GridLines = true;
            lvResult.View = View.Details;
            lvResult.FullRowSelect = true;
            lvResult.Columns.Add("Product ID", 100);
            lvResult.Columns.Add("Type", 100);
            lvResult.Columns.Add("Brand", 100);
            lvResult.Columns.Add("Product name", 100);
            lvResult.Columns.Add("Description", 150);
            lvResult.Columns.Add("Safety Stock", 100);
            lvResult.Columns.Add("Reorder Point", 100);
            lvResult.Columns.Add("Reorder Level", 100);

            txtSafetyStock.Focus();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Keyword = txtProductID.Text;
            if (txtProductID.Text != "")
            {
                String sql = String.Format("select productId, type, brand, productName, description, safetyStock, reorderPoint from product where productId = '{0}'", txtProductID.Text);
                MySqlCommand cmd = Program.ExecSQL(sql);
                MySqlDataReader data = cmd.ExecuteReader();

                lvResult.Items.Clear();

                while (data.Read())
                {
                    ListViewItem lv = new ListViewItem(data.GetString(0).ToString());
                    lv.SubItems.Add(data.GetString(1).ToString());
                    lv.SubItems.Add(data.GetString(2).ToString());
                    lv.SubItems.Add(data.GetString(3).ToString());
                    lv.SubItems.Add(data.GetString(4).ToString());
                    lv.SubItems.Add(data.GetInt32(5).ToString());
                    lv.SubItems.Add(data.GetInt32(6).ToString());
                    lvResult.Items.Add(lv);
                }

                data.Close();
                cmd.Dispose();
            }
        }

        private void TxtProductID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.Focus();

                BtnSearch_Click(sender, e);

                txtProductID.Focus();
            }
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvResult.SelectedItems[0].ToString() != "")
                {
                    ProductId = lvResult.SelectedItems[0].ToString();
                    ProductId = System.Text.RegularExpressions.Regex.Replace(ProductId, "[a-zA-Z{}: ]", "");

                    String sql = String.Format("UPDATE product SET safetyStock = {0} WHERE productId = {1}", txtSafetyStock.Text, ProductId);
                    MySqlCommand cmd = Program.ExecSQL(sql);
                    MySqlDataReader data = cmd.ExecuteReader();

                    MessageBox.Show("Update successfully!");

                    data.Close();
                    cmd.Dispose();

                    txtSafetyStock.Clear();
                    txtProductID.Clear();
                    lvResult.Clear();
                }
                else
                {
                    MessageBox.Show("Please select a product");
                }
            }
            catch
            {
                MessageBox.Show("Please select a product");
            }

        }

        private void LvResult_Click(object sender, EventArgs e)
        {
            txtSafetyStock.Text = lvResult.SelectedItems[0].SubItems[5].Text;
        }
    }
}
