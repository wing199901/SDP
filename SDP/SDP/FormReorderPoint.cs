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
        /*
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
        */
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
                lv.SubItems.Add(data.GetInt32(6).ToString());
                lv.SubItems.Add(data.GetInt32(7).ToString());
                lvResult.Items.Add(lv);
            }

            data.Close();
            cmd.Dispose();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //Safety stock = (Maximum daily usage * Maximum lead time in days) – (Average daily usage * Average lead time in days)last month
            // string lMonth = DateTime.Now.ToString("MM");
            //lMonth = lMonth.Replace("0", "");
            String sql = "select productId from product";
            MySqlCommand cmd = Program.ExecSQL(sql);
            MySqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {

                String productId = data.GetString("productId");
                sql = String.Format("SELECT qty FROM dbOPSRS.order,orderProduct WHERE YEAR(date) = YEAR(CURRENT_DATE - INTERVAL 1 MONTH) AND MONTH(date) = MONTH(CURRENT_DATE - INTERVAL 1 MONTH) AND dbOPSRS.order.orderId = orderProduct.orderId AND status = 'Finish' and productId = {0}",productId);
                cmd = Program.ExecSQL(sql);
                MySqlDataReader subData = cmd.ExecuteReader();
                int totalUsage = 0;
                int maxUsage = 0;
                while (subData.Read())
                {
                    if (subData.GetInt32(0) > maxUsage)
                    {
                        maxUsage = subData.GetInt32(0);
                    }
                    totalUsage += subData.GetInt32(0);
                }
                subData.Close();
                cmd.Dispose();
                sql = String.Format("select leadTime from product where productId = {0}", productId);
                cmd = Program.ExecSQL(sql);
                subData = cmd.ExecuteReader();
                int leadTime = 0;
                while (subData.Read())
                {
                    leadTime = subData.GetInt32(0);
                }
                int dailyUsage = (int)(totalUsage / 30.0);
                int safetyStock = (maxUsage * leadTime) - (dailyUsage * leadTime);
                int reorderPoint = (dailyUsage * leadTime) + safetyStock;
                subData.Close();
                cmd.Dispose();
                sql = String.Format("update product set safetyStock = {0}, reorderPoint = {1} where productId = {2}", safetyStock, reorderPoint, productId);
                cmd = Program.ExecSQL(sql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("productId: "+productId.ToString()+"\ndailyUsage: "+dailyUsage.ToString()+"\nmaxUsage: " + maxUsage
                    +"\nsafetyStock: "+safetyStock+"\nreorderPoint: "+reorderPoint);

            }
            data.Close();
            cmd.Dispose();
            //

        }
    }
}
