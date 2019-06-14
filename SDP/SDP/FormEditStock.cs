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
        public FormEditStock(String productId)
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            String productId = txtProductId.Text;
            FormSearchStock searchResult = new FormSearchStock(productId);

            if (searchResult.ShowDialog() == DialogResult.OK)
            {
                txtProductId.Text = searchResult.ProductId;
            }
           // txtKeyword.Text = "";
        }
    }

}
