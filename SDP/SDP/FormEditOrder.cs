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
        private int subIndex;

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
            lvResult.Columns.Add("Despatched", 100);
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

            sql = String.Format("SELECT orderProduct.productId, type, brand, productName, description, price, qty, despatched FROM orderProduct, product WHERE orderProduct.orderId={0} and orderProduct.productId = product.productId", OrderId);
            cmd = Program.ExecSQL(sql);
            data = cmd.ExecuteReader();

            lvResult.Items.Clear();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(data.GetString(0).ToString());
                lv.SubItems.Add(data.GetString(1).ToString());
                lv.SubItems.Add(data.GetString(2).ToString());
                lv.SubItems.Add(data.GetString(3).ToString());
                lv.SubItems.Add(data.GetString(4).ToString());
                lv.SubItems.Add("$" + data.GetString(5).ToString());
                lv.SubItems.Add(data.GetString(6).ToString());
                lv.SubItems.Add(data.GetString(7).ToString());
                double price = data.GetDouble(5);
                double qty = data.GetDouble(6);
                total += price * qty;
                lvResult.Items.Add(lv);
            }
            txtAmount.Text = "$" + total;
            data.Close();
            cmd.Dispose();
            txtShipAddr.ReadOnly = (txtShipAddr.Text == txtAddr.Text);
            choShipAddr.Checked = (txtShipAddr.Text == txtAddr.Text);
        }

        private void LvResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            currentItem = lvResult.GetItemAt(e.X, e.Y);

            if (currentItem != null)
            {
                currentItemSub = currentItem.GetSubItemAt(e.X, e.Y);
                subIndex = currentItem.SubItems.IndexOf(currentItemSub);
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
                    case 7:
                        int lLeft2 = currentItemSub.Bounds.Left + 2;
                        int lWidth2 = currentItemSub.Bounds.Width;
                        txtHide.SetBounds(lLeft2 + lvResult.Left, currentItemSub.Bounds.Top + lvResult.Top, lWidth2, currentItemSub.Bounds.Height);
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (subIndex == 6)
            {
                double price = Convert.ToDouble(Regex.Replace(currentItem.SubItems[5].Text, "[$]", ""));
                double curQty = Convert.ToDouble(currentItem.SubItems[6].Text);
                double newQty = Convert.ToInt64(txtHide.Text);
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
            else if (subIndex == 7)
            {

                String sql = String.Format("select qty, despatched from orderProduct where orderId={0}", currentItem.SubItems[0].Text);
                MySqlCommand cmd = Program.ExecSQL(sql);
                MySqlDataReader data = cmd.ExecuteReader();
                data.Close();
                data = cmd.ExecuteReader();
                int despatched = 0;
                int qty = 0;
                while (data.Read())
                {
                    qty = data.GetInt32("qty");
                    despatched = data.GetInt32("despatched");
                }

                switch (e.KeyChar)
                {
                    case (char)13:  //Enter
                                    // despatched = Convert.ToInt32(txtHide.Text);
                        if (txtHide.Text != "")
                        {
                            if (Convert.ToInt32(txtHide.Text) < despatched)
                            {
                                currentItemSub.Text = despatched.ToString();
                            }
                            else if ((Convert.ToInt32(txtHide.Text) > qty))
                            {
                                currentItemSub.Text = qty.ToString();
                            }
                            else
                            {
                                currentItemSub.Text = txtHide.Text;
                            }
                        }
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
                try
                {
                    String sql = String.Format("update customer set email='{0}', phone='{1}' where custId='{2}'",
                    txtEmail.Text, txtPhone.Text, custId);
                    MySqlCommand cmd = Program.ExecSQL(sql);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    sql = String.Format("update dbOPSRS.order set staffId='{1}', deliveryDate='{2}', status='{3}',shippingAddress='{4}',totalAmount={5}, remark='{6}' where orderId= '{0}'",
                        OrderId, txtStaffId.Text, dtpDelivery.Value.ToString("yyyy-MM-dd"), cboStatus.Text, txtShipAddr.Text, total, txtRemark.Text);
                    cmd = Program.ExecSQL(sql);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    for (int i = 0; i < lvResult.Items.Count; i++)
                    {
                        String productId = lvResult.Items[i].Text;
                        int qty = Convert.ToInt32(lvResult.Items[i].SubItems[6].Text);
                        int currentDespatched = Convert.ToInt32(lvResult.Items[i].SubItems[7].Text);
                        sql = String.Format("update orderProduct set qty = {0}, despatched = {1} where  orderId = {2} and productId={3}",
                            qty,currentDespatched,OrderId,productId);
                        cmd = Program.ExecSQL(sql);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }

                    MessageBox.Show("Update Sussesed!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update failed. There are incorrected information.");
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
