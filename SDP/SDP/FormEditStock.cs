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
    public partial class FormEditStock : Form
    {
        private String productId = "";

        public String ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        public FormEditStock()
        {
            InitializeComponent();

            // ListView Header
            lvResult.GridLines = true;
            lvResult.View = View.Details;
            lvResult.FullRowSelect = true;
            lvResult.Columns.Add("Product ID", 100);
            lvResult.Columns.Add("Type", 100);
            lvResult.Columns.Add("Brand", 100);
            lvResult.Columns.Add("Product name", 100);
            lvResult.Columns.Add("Description", 150);
            lvResult.Columns.Add("At hand", 70);
            lvResult.Columns.Add("On hand", 70);
            lvResult.Columns.Add("In hand", 70);
            lvResult.Columns.Add("Price", 50);


        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            lvResult.Items.Clear();
            if (txtProductId.Text != "" || txtType.Text != "" || txtBrand.Text != "" || txtProductName.Text != "" || txtPrice.Text != "")
            {
                String sql = "";
                // String sql = String.Format("select * from product where productId = '{0}' or type = '{1}' or brand = '{2}' or productName like '%{3}%' or price = {4}",
                //   txtProductId.Text,txtType.Text,txtBrand.Text,txtProductName.Text,txtPrice.Text);
                if (txtProductId.Text != "")
                {
                    sql += " productId='" + Convert.ToInt32(txtProductId.Text).ToString() + "'";
                }
                if (txtType.Text != "")
                {
                    if (sql != "")
                    {
                        sql += " or";
                    }
                    sql += " type='" + txtType.Text.ToString() + "'";
                }
                if (txtBrand.Text != "")
                {
                    if (sql != "")
                    {
                        sql += " or";
                    }
                    sql += " brand='" + txtBrand.Text.ToString() + "'";
                }
                if (txtProductName.Text != "")
                {
                    if (sql != "")
                    {
                        sql += " or";
                    }
                    sql += " productName like '%" + txtProductName.Text.ToString() + "%'";
                }
                MySqlCommand cmd = Program.ExecSQL("select * from product where " + sql );
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
                    lv.SubItems.Add(data.GetDouble(8).ToString());
                    lvResult.Items.Add(lv);
                }

                data.Close();
                cmd.Dispose();
            }
        }
    }

}

