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
        String orderId = "";
        String staffId = "";
        String orderStatus = "";
        String custId = "";
        String custPhone = "";
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
            lvResult_order.Columns.Add("Remark", 200);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            String orderId = Convert.ToInt32(txtOrderId.Text).ToString();
            String staffId = txtStaffId.Text;
            if (cboOrderStatus.SelectedItem != null) { 
            String orderStatus = cboOrderStatus.SelectedItem.ToString();
        } 
            String custId = tbCustId.Text;
            String custPhone = tbCustPhone.Text;
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            String sql = String.Format("select * from dbOPSRS.order where {0}{1}{2}{3}{4}{5}",
                                        " orderId = '"+orderId+"'",
                                        "", "", "", "", "");
            MySqlCommand cmd = Program.ExecSQL(sql);
            MySqlDataReader data = cmd.ExecuteReader();

            //lvResult_order.Clear();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(data.GetString(0).ToString());
                lv.SubItems.Add(data.GetString(1).ToString());
                lv.SubItems.Add(data.GetString(2).ToString());
                lv.SubItems.Add(data.GetString(3).ToString());
                lv.SubItems.Add(data.GetDateTime(4).ToString("dd/MM/yyyy"));
                lv.SubItems.Add(data.GetDateTime(5).ToString("dd/MM/yyyy"));
                lv.SubItems.Add(data.GetString(6).ToString());
                if(!data.IsDBNull(7))
                {
                    lv.SubItems.Add(data.GetString(7).ToString());
                }
                lvResult_order.Items.Add(lv);
            }

            data.Close();
            cmd.Dispose();
        }
    }
}
