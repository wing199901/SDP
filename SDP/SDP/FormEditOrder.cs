using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private ListViewItem currentItem;
        private ListViewItem.ListViewSubItem currentItemSub;

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


            String sql = String.Format("select * from dbOPSRS.order where orderId='{0}'", OrderId);
            MySqlCommand cmd = Program.ExecSQL(sql);
            MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                txtNumber.Text = data.GetString(0).ToString();
                txtStaffId.Text = data.GetString(1).ToString();
                custId = data.GetString(2).ToString();
                cboStatus.Text = data.GetString(3).ToString();
                txtDate.Text = data.GetDateTime(4).ToString("dd/MM/yyyy");
                dtpDelivery.Value = data.GetDateTime(5);
                txtShipAddr.Text = data.GetString(6).ToString();
                txtAmount.Text = data.GetDouble(7).ToString();
                if (!data.IsDBNull(8))
                {
                    txtRemark.Text = data.GetString(8).ToString();
                }
                
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

                       sql = String.Format("select productId, qty from orderProduct where orderId = '{0}'", OrderId);
            cmd = Program.ExecSQL(sql);
            data = cmd.ExecuteReader();

            lvResult.Items.Clear();

            while (data.Read())
            {
                txtProductID.Text = data.GetString(0).ToString();
                txtQty.Text = data.GetDouble(1).ToString();
                BtnAdd_Click(sender, e);
            }

            txtShipAddr.ReadOnly = (txtShipAddr.Text == txtAddr.Text);
            choShipAddr.Checked = (txtShipAddr.Text == txtAddr.Text);
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

        private void LvResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            currentItem = lvResult.GetItemAt(e.X, e.Y);

            if (currentItem != null)
            {
                currentItemSub = currentItem.GetSubItemAt(e.X, e.Y);
                int subIndex = currentItem.SubItems.IndexOf(currentItemSub);
                switch (subIndex)
                {
                    case 6:
                        int lLeft = currentItemSub.Bounds.Left + 2;
                        int lWidth = currentItemSub.Bounds.Width;
                        txtHide.SetBounds(lLeft + lvResult.Left, currentItemSub.Bounds.Top + lvResult.Top, lWidth, currentItemSub.Bounds.Height);
                        txtHide.Text = currentItemSub.Text;
                        txtHide.Show();
                        txtHide.Focus();
                        break;
                    default:
                        break;
                }
            }
        }

        private void TxtHide_KeyPress(object sender, KeyPressEventArgs e)
        {
            double price = Convert.ToDouble(Regex.Replace(currentItem.SubItems[5].Text, "[$]", ""));
            double curQty = Convert.ToDouble(currentItem.SubItems[6].Text);
            double newQty = Convert.ToInt32(txtHide.Text);
            switch (e.KeyChar)
            {
                case (char)13:  //Enter
                    if (curQty > newQty)
                    {
                        curQty -= newQty;
                        total -= (price * curQty);
                    }
                    else if (curQty < newQty)
                    {
                        newQty -= curQty;
                        total += (price * newQty);
                    }
                    txtAmount.Text = "$" + total.ToString();
                    currentItemSub.Text = txtHide.Text;

                    e.Handled = true;
                    txtHide.Hide();
                    break;

                case (char)27:  //Escape
                    txtHide.Text = "";
                    e.Handled = true;
                    txtHide.Hide();
                    break;
                default:
                    break;
            }
        }

        private void TxtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.Focus();

                BtnAdd_Click(sender, e);

                txtQty.Focus();
            }
        }

        private void TxtRemark_Enter(object sender, EventArgs e)
        {
            if (txtRemark.Text == "Remark")
            {
                txtRemark.Text = "";
                txtRemark.ForeColor = Color.Black;
            }
        }

        private void TxtRemark_Leave(object sender, EventArgs e)
        {
            if (txtRemark.Text == "")
            {
                txtRemark.Text = "Remark";
                txtRemark.ForeColor = Color.Silver;
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            String keyword = txtKeyword.Text;
            FormSearchProduct searchResult = new FormSearchProduct(keyword);

            if (searchResult.ShowDialog() == DialogResult.OK)
            {
                txtProductID.Text = searchResult.ProductId;
            }
            txtKeyword.Text = "";
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if ((txtName.Text == "") || (txtCompany.Text == "") || (txtAddr.Text == "") || (txtShipAddr.Text == "") || (txtEmail.Text == "") || (txtPhone.Text == ""))
            {
                MessageBox.Show("Please fill in the customer infomation!");
            }
            else if (txtAmount.Text == "$")     //If Total Amount Is Empty
            {
                MessageBox.Show("There is no product in cart!");
            }
            else
            {

                String sql = String.Format("update customer set custName='{0}', address='{1}', companyName='{2}', email='{3}', phone='{4}' where custId='{5}'",
                txtName.Text, txtAddr.Text, txtCompany.Text, txtEmail.Text, txtPhone.Text, custId);
                MySqlCommand cmd = Program.ExecSQL(sql);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                sql = String.Format("update dbOPSRS.order set staffId='{6}' status='{0}', deliveryDate='{1}', shippingAddress='{2}', totalAmount={3}, remark='{4}' where orderId = '{5}'",
                    cboStatus.Text, dtpDelivery.Value.ToString("yyyy-MM-dd"), txtShipAddr.Text, total, txtRemark.Text, OrderId, txtStaffId.Text);
                cmd = Program.ExecSQL(sql);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                sql = String.Format("delete from orderProduct where orderId='{0}'", OrderId);
                cmd = Program.ExecSQL(sql);
                cmd.ExecuteNonQuery();

                cmd.Dispose();

                for (int i = 0; i < lvResult.Items.Count; i++)
                {
                    String productId = lvResult.Items[i].Text;
                    int qty = Convert.ToInt32(lvResult.Items[i].SubItems[6].Text);
                    sql = String.Format("insert into orderProduct (orderId, productId, qty) " +
                        "values ('{0}', '{1}', {2})", OrderId, productId, qty);
                    cmd = Program.ExecSQL(sql);
                    cmd.ExecuteNonQuery();

                    cmd.Dispose();
                }

                MessageBox.Show("Update Sussesed!");
                this.Close();
            }
        }

        private void ChoShipAddr_CheckStateChanged(object sender, EventArgs e)
        {
            if (choShipAddr.Checked)
            {
                txtShipAddr.Text = txtAddr.Text;
                txtShipAddr.ReadOnly = true;
            }
            else
            {
                txtShipAddr.ReadOnly = false;
            }
        }
    }
}
