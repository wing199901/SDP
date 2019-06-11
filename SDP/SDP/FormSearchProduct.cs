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
            lvResult.Columns.Add("productId", 150);
            lvResult.Columns.Add("type", 150);
            lvResult.Columns.Add("brand", 150);
            lvResult.Columns.Add("productName", 150);
            lvResult.Columns.Add("Description", 150);
            lvResult.Columns.Add("atHand", 150);
            lvResult.Columns.Add("onHand", 150);
            lvResult.Columns.Add("inHand", 150);
            lvResult.Columns.Add("price", 150);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtKeyword.Text != "")
            {
                String sql = String.Format("select * from product where '%{0}%' in (productId, type, brand, productName, Description, atHand, onHand, inHand, price)", Keyword);
                MySqlCommand cmd = Program.ExecSQL(sql);
                MySqlDataReader data = cmd.ExecuteReader();

                String result = "";

                while (data.Read())
                {
                    result = data[0].ToString();
                }

                txtResult.Text += result;
            }
        }
    }
}
