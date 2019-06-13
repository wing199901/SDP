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

        public String ProductID
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
            ProductID = productId;
            
        }

        private void FormSearchStock_Load(object sender, EventArgs e)
        {
            
        }

       
    }
}
