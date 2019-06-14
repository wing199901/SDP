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
        public FormEditStock(String productId)
        {
            InitializeComponent();

            ProductId = productId;

            // ListView Header
            lvResult.GridLines = true;
            lvResult.View = View.Details;
            lvResult.FullRowSelect = true;
            lvResult.Columns.Add("Product ID", 100);
            lvResult.Columns.Add("Type", 100);
            lvResult.Columns.Add("Brand", 100);
            lvResult.Columns.Add("Product name", 100);
            lvResult.Columns.Add("Description", 150);
            lvResult.Columns.Add("At hand", 50);
            lvResult.Columns.Add("On hand", 50);
            lvResult.Columns.Add("In hand", 50);
            lvResult.Columns.Add("Price", 50);

            
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            
        }
    }

}
