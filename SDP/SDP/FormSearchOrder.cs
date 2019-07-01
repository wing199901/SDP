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
        private ListViewItem currentItem;

        public FormSearchOrder()
        {
            InitializeComponent();

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

        private void FormSearchOrder_Load(object sender, EventArgs e)
        {
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = "dd/MM/yyyy";
            dtpStartDate.MaxDate = dtpEndDate.Value;
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.CustomFormat = "dd/MM/yyyy";
            dtpEndDate.MaxDate = DateTime.Today;

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
            if (txtOrderId.Text != "")
            {
                reference += " orderId='" + Convert.ToInt32(txtOrderId.Text).ToString() + "'";
            }
            if (txtStaffId.Text != "")
            {
                if (reference != "")
                {
                    reference += " AND";
                }
                reference += " staffId='" + Convert.ToInt32(txtStaffId.Text).ToString() + "'";
            }
            if (txtCustId.Text != "")
            {
                if (reference != "")
                {
                    reference += " AND";
                }
                reference += " custId='" + Convert.ToInt32(txtCustId.Text).ToString() + "'";
            }
            if (txtCustPhone.Text != "")
            {
                String custId = "";
                MySqlCommand cmd = Program.ExecSQL("select custId from customer where phone='" + txtCustPhone.Text + "'");
                MySqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    custId = data.GetString(0).ToString();
                }
                if (reference != "" && custId != "")
                {
                    reference += " AND" + " custId='" + custId + "'";
                }
            }
            if (cboOrderStatus.SelectedItem != null)
            {
                if (reference != "")
                {
                    reference += " AND";
                }
                reference += " status='" + cboOrderStatus.SelectedItem.ToString() + "'";
            }
            String startDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
            startDate += " 00:00:00";
            String endDate = dtpEndDate.Value.ToString("yyyy-MM-dd");
            endDate += " 23:59:59";
            if (reference != "")
            {
                reference += " AND";
            }
            reference += " date>='" + startDate + "' and date<='" + endDate + "'";
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
        private void btnReset_Click(object sender, EventArgs e)
        {
            lvResult_order.Items.Clear();
            txtOrderId.Clear();
            txtStaffId.Clear();
            txtCustId.Clear();
            txtCustPhone.Clear();
            cboOrderStatus.SelectedItem = null;
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
        }

        private void DtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            dtpStartDate.MaxDate = dtpEndDate.Value;
        }

        private void LvResult_order_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            currentItem = lvResult_order.GetItemAt(e.X, e.Y);

            if (currentItem != null)
            {
                String orderId = currentItem.Text;
                FormEditOrder editOrder = new FormEditOrder(orderId);
                editOrder.ShowDialog();
            }
        }
    }
}
