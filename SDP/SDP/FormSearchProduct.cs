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


        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtKeyword.Text != "")
            {
                String sql = String.Format("select * from product where '%{0}%' in (type, productId, brand, productName, Description, atHand, onHand, inHand, price)", Keyword);
                MySqlCommand cmd = Program.Logindb(sql);
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
