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
            dtpEndDate.MaxDate = DateTime.Today;

            //ListView Header
            lvResult_order.GridLines = true;
            lvResult_order.View = View.Details;
            lvResult_order.FullRowSelect = true;
            lvResult_order.Columns.Add("Order ID", 70);
            lvResult_order.Columns.Add("Staff ID", 70);
            lvResult_order.Columns.Add("Customer ID", 70);
            lvResult_order.Columns.Add("Status", 70);
            lvResult_order.Columns.Add("Date", 70);
            lvResult_order.Columns.Add("Delivery Date", 80);
            lvResult_order.Columns.Add("Shipping Address", 200);
            lvResult_order.Columns.Add("Total Amount", 80);
            lvResult_order.Columns.Add("Remark", 200);
        }
        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void BtnSearch_Click(object sender, EventArgs e)
        {
            String reference = "";
            String orderStatus = "";
            String custPhone = "";
            if (txtOrderId.Text != "")
            {
                String orderId = Convert.ToInt64(txtOrderId.Text).ToString();
                reference += " orderId='" + orderId + "'";
            }
            if (txtStaffId.Text != "")
            {
                String staffId = Convert.ToInt64(txtStaffId.Text).ToString();
                if (reference != "")
                {
                    reference += " or";
                }
                reference += " staffId='" + staffId + "'";
            }
            if (txtCustId.Text != "")
            {
                String custId = Convert.ToInt64(txtCustId.Text).ToString();
                if (reference != "")
                {
                    reference += " or";
                }
                reference += " custId='" + custId + "'";
            }
            if (txtCustPhone.Text != "") { 
            custPhone = txtCustPhone.Text;
                if (reference != "")
                {
                    reference += " or";
                }
                reference += " custPhone='" + custPhone + "'";
            }
            if (cboOrderStatus.SelectedItem != null)
            {
                orderStatus = cboOrderStatus.SelectedItem.ToString();
            }
            custPhone = txtCustPhone.Text;
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            if (reference != "")
            {
                String sql = "select * from dbOPSRS.order where " + reference;
                MySqlCommand cmd = Program.ExecSQL(sql);
                MySqlDataReader data = cmd.ExecuteReader();

                lvResult_order.Items.Clear();

                while (data.Read())
                {
                    ListViewItem lv = new ListViewItem(data.GetString(0).ToString());
                    lv.SubItems.Add(data.GetString(1).ToString());
                    lv.SubItems.Add(data.GetString(2).ToString());
                    lv.SubItems.Add(data.GetString(3).ToString());
                    lv.SubItems.Add(data.GetDateTime(4).ToString("dd/MM/yyyy"));
                    lv.SubItems.Add(data.GetDateTime(5).ToString("dd/MM/yyyy"));
                    lv.SubItems.Add(data.GetString(6).ToString());
                    lv.SubItems.Add("$" + data.GetString(7).ToString());
                    if (!data.IsDBNull(8))
                    {
                        lv.SubItems.Add(data.GetString(8).ToString());
                    }
                    lvResult_order.Items.Add(lv);
                }

                data.Close();
                cmd.Dispose();
            }
        }

    }
}
