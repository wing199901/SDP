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
    public partial class FormEditOrder : Form
    {
        private String orderId = "";
        private string custId;
        private string priceTxt;
        private double quantity;
        private double total;

        public String OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }
        public FormEditOrder(String orderId)
        {
            InitializeComponent();

            OrderId = orderId;

            //ListView Header
            lvResult.GridLines = true;
            lvResult.View = View.Details;
            lvResult.FullRowSelect = true;
            lvResult.Columns.Add("Product ID", 100);
            lvResult.Columns.Add("Type", 100);
            lvResult.Columns.Add("Brand", 100);
            lvResult.Columns.Add("Product name", 100);
            lvResult.Columns.Add("Description", 150);
            lvResult.Columns.Add("Price", 50);
            lvResult.Columns.Add("Quantity", 100);
        }

        private void FormEditOrder_Load(object sender, EventArgs e)
        {
            dtpDelivery.Format = DateTimePickerFormat.Custom;
            dtpDelivery.CustomFormat = "dd/MM/yyyy";
            

            String sql = String.Format("select * from dbOPSRS.order where orderId='{0}'",OrderId);
            MySqlCommand cmd = Program.ExecSQL(sql);
            MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                txtStaffId.Text = data.GetString(1).ToString();
                custId = data.GetString(2).ToString();
                cboStatus.Text = data.GetString(3).ToString();
                txtDate.Text = data.GetDateTime(4).ToString("dd/MM/yyyy");
                dtpDelivery.Value = data.GetDateTime(5);
                txtShipAddr.Text = data.GetString(6).ToString();
                txtAmount.Text = data.GetDouble(7).ToString();
                txtRemark.Text = data.GetString(8).ToString();
            }

            data.Close();
            cmd.Dispose();

             sql = String.Format("select * from customer where custId='{0}'", custId);
             cmd = Program.ExecSQL(sql);
             data = cmd.ExecuteReader();

            while (data.Read())
            {
                txtName.Text = data.GetString(1).ToString();
                txtAddr.Text = data.GetString(2).ToString();
                txtCompany.Text = data.GetString(3).ToString();
                txtEmail.Text = data.GetString(4).ToString();
                txtPhone.Text = data.GetString(5).ToString();
            }

            data.Close();
            cmd.Dispose();

            if (txtAddr.Text.Equals(txtShipAddr.Text))
            {
                choShipAddr.Checked = true;
            }

             sql = String.Format("select productId, qty from orderProduct where orderId = '{0}'",OrderId);
             cmd = Program.ExecSQL(sql);
             data = cmd.ExecuteReader();

            lvResult.Items.Clear();

            while (data.Read())
            {
                txtProductID.Text = data.GetString(0).ToString();
                txtQty.Text = data.GetDouble(1).ToString();
                BtnAdd_Click(sender, e);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text != "")
            {
                if (txtProductID.Text != "")
                {
                    String sql = String.Format("select productId, type, brand, productName, Description, price from product where productId like '%{0}%'", txtProductID.Text);
                    MySqlCommand cmd = Program.ExecSQL(sql);
                    MySqlDataReader data = cmd.ExecuteReader();

                    while (data.Read())
                    {
                        ListViewItem lv = new ListViewItem(data.GetString(0).ToString());
                        lv.SubItems.Add(data.GetString(1).ToString());
                        lv.SubItems.Add(data.GetString(2).ToString());
                        lv.SubItems.Add(data.GetString(3).ToString());
                        lv.SubItems.Add(data.GetString(4).ToString());
                        priceTxt = data.GetDouble(5).ToString();
                        lv.SubItems.Add("$" + priceTxt);
                        lv.SubItems.Add(txtQty.Text);
                        lvResult.Items.Add(lv);
                        double price = Convert.ToDouble(priceTxt);
                        quantity = Convert.ToDouble(txtQty.Text);
                        price *= quantity;
                        total += price;
                        txtAmount.Text = "$" + total.ToString();
                    }

                    data.Close();
                    cmd.Dispose();
                }
                else
                {
                    MessageBox.Show("Product ID can not be empty!");
                    txtProductID.Focus();
                }
            }
            else
            {
                MessageBox.Show("Qantity can not be empty!");
            }
            txtProductID.Text = "";
            txtQty.Text = "";
        }
    }
}
