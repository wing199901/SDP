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
    public partial class FormReorderPoint : Form
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
        public FormReorderPoint()
        {
            InitializeComponent();

            //ListView Header
            lvResult.GridLines = true;
            lvResult.View = View.Details;
            lvResult.FullRowSelect = true;
            lvResult.Columns.Add("Product ID", 100);
            lvResult.Columns.Add("Type", 100);
            lvResult.Columns.Add("Brand", 100);
            lvResult.Columns.Add("Product name", 100);
            lvResult.Columns.Add("Description", 150);
            lvResult.Columns.Add("Lead Time", 70);
            lvResult.Columns.Add("Safety Stock", 70);
            lvResult.Columns.Add("Reorder Point", 70);

            txtSafetyStock.Focus();
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

        private void FormROL_Load(object sender, EventArgs e)
        {
            String sql = "select productId, type, brand, productName, description, leadTime, safetyStock, reorderPoint from product";
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
                lv.SubItems.Add(data.GetInt32(5).ToString());
                lv.SubItems.Add(data.GetInt32(6).ToString());
                lvResult.Items.Add(lv);
            }

            data.Close();
            cmd.Dispose();
        }
    }
}
