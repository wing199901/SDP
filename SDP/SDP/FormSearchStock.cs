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
        private ListViewItem currentItem;

        public String ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public FormSearchStock(String keyword)
        {
            InitializeComponent();
            Keyword = keyword;
            txtKeyword.Text = Keyword;
            BtnSearch_Click(new object(), new EventArgs());

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

            txtKeyword.Focus();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Keyword = txtKeyword.Text;
            if (txtKeyword.Text != "")
            {
                String sql = String.Format("select * from product where productId like '%{0}%' or type like '%{0}%' or brand like '%{0}%' or productName like '%{0}%' or Description like '%{0}%' or atHand like '%{0}%' or onHand like '%{0}%' or inHand like '%{0}%' or price like '%{0}%'", Keyword);
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
                    lv.SubItems.Add(data.GetDouble(8).ToString());
                    lvResult.Items.Add(lv);
                }

                data.Close();
                cmd.Dispose();
            }
        }

        private void TxtKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.Focus();

                BtnSearch_Click(sender, e);

                txtKeyword.Focus();
            }
        }

        private void LvResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (control.hasPermission(510))
            {
                currentItem = lvResult.GetItemAt(e.X, e.Y);

                if (currentItem != null)
                {
                    String productId = currentItem.Text;
                    FormEditStock formEditStock = new FormEditStock(productId);
                    formEditStock.ShowDialog();
                    BtnSearch_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("You do not have permission to edit product record.");
            }
        }
    }
}
