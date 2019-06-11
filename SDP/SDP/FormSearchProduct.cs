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
    public partial class FormSearchProduct : Form
    {
        private String keyword;

        public String Keyword
        {
            get { return keyword; }
            set { keyword = value; }
        }
        public FormSearchProduct(String keyword)
        {
            InitializeComponent();
            Keyword = keyword;
            txtKeyword.Text = Keyword;
            BtnSearch_Click(new object(), new EventArgs());

            //ListView Header
            lvResult.GridLines = true;
            lvResult.View = View.Details;
            lvResult.Columns.Add("productId", 100);
            lvResult.Columns.Add("type", 100);
            lvResult.Columns.Add("brand", 100);
            lvResult.Columns.Add("productName", 100);
            lvResult.Columns.Add("Description", 150);
            lvResult.Columns.Add("atHand", 50);
            lvResult.Columns.Add("onHand", 50);
            lvResult.Columns.Add("inHand", 50);
            lvResult.Columns.Add("price", 50);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Keyword=txtKeyword.Text  ;
            if (txtKeyword.Text != "")
            {
                String sql = String.Format("select * from product where productId like '%{0}%' or type like '%{0}%' or brand like '%{0}%' or productName like '%{0}%' or Description like '%{0}%' or atHand like '%{0}%' or onHand like '%{0}%' or inHand like '%{0}%' or price like '%{0}%'", Keyword);
                MySqlCommand cmd = Program.ExecSQL(sql);
                MySqlDataReader data = cmd.ExecuteReader();

                lvResult.Items.Clear();

                while (data.Read())
                {
                    //result = data[0].ToString();

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
    }
}
