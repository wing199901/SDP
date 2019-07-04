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
    public partial class FormSearchPurchaseOrder : Form
    {
        public FormSearchPurchaseOrder()
        {
            InitializeComponent();

            // ListView Header
            lvOrder.GridLines = true;
            lvOrder.View = View.Details;
            lvOrder.FullRowSelect = true;
            lvOrder.Columns.Add("Purchasing Order ID", 150);
            lvOrder.Columns.Add("Staff ID", 100);
            lvOrder.Columns.Add("Start Date", 100);
            lvOrder.Columns.Add("Arrived Date", 100);
            lvOrder.Columns.Add("Address", 200);
            lvOrder.Columns.Add("Total Amount", 150);
            lvOrder.Columns.Add("Remark", 100);

            // ListView Header
            lvProduct.GridLines = true;
            lvProduct.View = View.Details;
            lvProduct.FullRowSelect = true;
            lvProduct.Columns.Add("Purchasing Order ID", 150);
            lvProduct.Columns.Add("Product ID", 150);
            lvProduct.Columns.Add("Quantity", 150);
        }
    }
}
