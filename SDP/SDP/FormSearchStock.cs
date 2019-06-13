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
    public partial class FormSearchStock : Form
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

        private String category;

        public String Category
        {
            get { return category; }
            set { category = value; }
        }
        public FormSearchStock()
        {
            InitializeComponent();
            Keyword = keyword;
            txtKeyword.Text = Keyword;
            ProductId = productId;
            txtPID.Text = ProductId;
            Category = category;
            txtCategory.Text = Category;
            BtnSearch_Click(new object(), new EventArgs());

            //ListView Header
            lviSearch.GridLines = true;
            lviSearch.View = View.Details;
            lviSearch.FullRowSelect = true;
            lviSearch.Columns.Add("Product ID", 100);
            lviSearch.Columns.Add("Type", 100);
            lviSearch.Columns.Add("Product name", 100);
            lviSearch.Columns.Add("Description", 150);
            lviSearch.Columns.Add("At hand", 50);
            lviSearch.Columns.Add("On hand", 50);
            lviSearch.Columns.Add("In hand", 50);
            lviSearch.Columns.Add("Price", 50);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtPID.Text != "")
            {
                String sql = String.Format("select * from product where productId like '%{0}%'", ProductId);
                MySqlCommand cmd = Program.ExecSQL(sql);
                MySqlDataReader data = cmd.ExecuteReader();

                lviSearch.Items.Clear();

                while (data.Read())
                {
                    ListViewItem lvi = new ListViewItem(data.GetString(0).ToString());
                    lvi.SubItems.Add(data.GetString(1).ToString());
                    lvi.SubItems.Add(data.GetString(2).ToString());
                    lvi.SubItems.Add(data.GetString(3).ToString());
                    lvi.SubItems.Add(data.GetString(4).ToString());
                    lvi.SubItems.Add(data.GetInt32(5).ToString());
                    lvi.SubItems.Add(data.GetInt32(6).ToString());
                    lvi.SubItems.Add(data.GetInt32(7).ToString());
                    lvi.SubItems.Add(data.GetDouble(8).ToString());
                    lviSearch.Items.Add(lvi);
                }
                data.Close();
                cmd.Dispose();
            }
           
            /*if(txtCategory.Text != "")
            {
              sql = String.Format("")
            }*/
        }
        private void TxtPID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch.Focus();
                BtnSearch_Click(sender, e);
                txtPID.Focus();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
