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
    public partial class FormSearchOrder : Form
    {
        public FormSearchOrder()
        {
            InitializeComponent();
        }

        private void FormSearchOrder_Load(object sender, EventArgs e)
        {
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = "dd/MM/yyyy";
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.CustomFormat = "dd/MM/yyyy";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(txtOrderId.Text);
            String staffId = txtStaffId.Text;
            String orderStatus = cboOrderStatus.SelectedItem.ToString();
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;
            Console.WriteLine(orderStatus + "     " + startDate.ToString() + "    " + endDate.ToString());
            MessageBox.Show(orderStatus + "     " + startDate.ToString() + "    " + endDate.ToString());

        }
    }
}
