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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            Form newOrder = new FormNewOrder();
            newOrder.ShowDialog();
        }

        private void BtnSearchOrder_Click(object sender, EventArgs e)
        {
            Form searchOrder = new FormSearchOrder();
            searchOrder.ShowDialog();
        }

        private void BtnDefective_Click(object sender, EventArgs e)
        {
            Form defective = new FormDefective();
            defective.ShowDialog();
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            Form stock = new FormSearchStock();
            stock.ShowDialog();
        }
    }
}
