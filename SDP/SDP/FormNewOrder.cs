using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SDP
{
    public partial class FormNewOrder : Form
    {
        private String userName = "";
        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private String priceTxt = "";
        private double quantity = 0;
        private double total = 0;

        private String custId = "";
        private String orderId = "";

        ListViewItem currentItem;
        private ListViewItem.ListViewSubItem currentItemSub;
        public FormNewOrder(String username)
        {
            InitializeComponent();
            UserName = username;

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

        private void ChoShipAddr_Click(object sender, EventArgs e)
        {
            switch (choShipAddr.CheckState)
            {
                case CheckState.Checked:
                    txtShipAddr.Text = txtAddr.Text;
                    break;
                case CheckState.Unchecked:
                    txtShipAddr.Text = "";
                    break;
            }
        }

        private void FormNewOrder_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            dtpDelivery.Format = DateTimePickerFormat.Custom;
            dtpDelivery.CustomFormat = "dd/MM/yyyy";
            dtpDelivery.MinDate = DateTime.Today.AddDays(1);

            MySqlCommand cmd = Program.ExecSQL("select max(orderId) from dbOPSRS.order");
            MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                txtNumber.Text = (data.GetInt32(0) + 1).ToString();
            }
            data.Close();
            cmd.Dispose();

            txtStaffId.Text = UserName;

            //cboStatus default value
            cboStatus.SelectedIndex = 0;

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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void TxtKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.Focus();

                BtnSearch_Click(sender, e);

            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text != "")
            {
                if (txtQty.Text != "")
                {
                    String sql = String.Format("select onHand from product where productId = {0}", txtProductID.Text.ToString());
                    MySqlCommand cmd = Program.ExecSQL(sql);
                    MySqlDataReader data = cmd.ExecuteReader();
                    int onHand = 0;
                    while (data.Read())
                    {
                        onHand = data.GetInt32(0);
                    }
                    if (onHand > 0)
                    {
                        sql = String.Format("select productId, type, brand, productName, Description, price from product where productId like '%{0}%'", txtProductID.Text);
                        cmd = Program.ExecSQL(sql);
                        data = cmd.ExecuteReader();

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
                        txtProductID.Text = "";
                        txtQty.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("This product is out of stock.");
                    }
                }
                else
                {
                    MessageBox.Show("Qantity can not be empty!");
                    txtQty.Focus();
                }
            }
            else
            {
                MessageBox.Show("Product ID can not be empty!");
                txtProductID.Focus();
            }

        }

        private void TxtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.Focus();

                BtnAdd_Click(sender, e);

                txtProductID.Focus();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                double price = Convert.ToDouble(Regex.Replace(lvResult.SelectedItems[0].SubItems[5].Text, "[$]", ""));
                double qty = Convert.ToDouble(lvResult.SelectedItems[0].SubItems[6].Text);
                total -= (price * qty);
                txtAmount.Text = "$" + total.ToString();
                lvResult.Items.Remove(lvResult.SelectedItems[0]);
            }
            catch (Exception ex)
            {
            }

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

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            String submitTime = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");

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
                String sql = String.Format("insert into customer (custName, address, companyName, email, phone) select '{0}', '{1}', '{2}', '{3}', '{4}' from dual where not exists (select phone from customer where phone='{4}')",
                    txtName.Text, txtAddr.Text, txtCompany.Text, txtEmail.Text, txtPhone.Text);
                MySqlCommand cmd = Program.ExecSQL(sql);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                sql = String.Format("select custId from customer where phone='{0}'", txtPhone.Text);
                cmd = Program.ExecSQL(sql);
                MySqlDataReader data = cmd.ExecuteReader();

                while (data.Read())
                {
                    custId = data.GetString(0).ToString();
                }

                data.Close();
                cmd.Dispose();

                sql = String.Format("insert into dbOPSRS.order (staffId, custId, status, date, deliveryDate, shippingAddress, totalAmount, remark) " +
                    "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6}, '{7}')",
                    txtStaffId.Text, custId, cboStatus.Text, submitTime, dtpDelivery.Value.ToString("yyyy-MM-dd"), txtShipAddr.Text, total, txtRemark.Text);
                cmd = Program.ExecSQL(sql);
                cmd.ExecuteNonQuery();

                cmd.Dispose();

                sql = String.Format("select orderId from dbOPSRS.order where custId = '{0}' and date = '{1}'", custId, submitTime);
                cmd = Program.ExecSQL(sql);
                data = cmd.ExecuteReader();

                while (data.Read())
                {
                    orderId = data.GetString(0).ToString();
                }

                data.Close();
                cmd.Dispose();

                String poId = null;

                for (int i = 0; i < lvResult.Items.Count; i++)
                {
                    String productId = lvResult.Items[i].Text;
                    double amount = Convert.ToDouble(Regex.Replace(lvResult.Items[i].SubItems[5].Text, "[$]", ""));
                    int qty = Convert.ToInt32(lvResult.Items[i].SubItems[6].Text);
                    sql = String.Format("insert into orderProduct (orderId, productId, qty) " +
                        "values ('{0}', '{1}', {2})", orderId, productId, qty);
                    cmd = Program.ExecSQL(sql);
                    cmd.ExecuteNonQuery();

                    int onHand = 0;
                    int leadTime = 0;
                    sql = String.Format("SELECT onHand, leadTime FROM product WHERE productId = '{0}'", productId);
                    cmd = Program.ExecSQL(sql);
                    data = cmd.ExecuteReader();

                    while (data.Read())
                    {
                        onHand = data.GetInt32(0);
                        leadTime = data.GetInt32(1);
                    }

                    if (qty > onHand)
                    {
                        if (poId == null)
                        {
                            sql = String.Format("INSERT INTO purchasingOrder(`staffId`, status, `date`, `deliveryDate`, `address`, `totalAmount`) " +
                                "VALUES('99999', 'Pending', '{0}', '{1}', 'LWL', 0)", DateTime.Now.ToString("yyyy-MM-dd"),
                                DateTime.Now.AddDays(leadTime).ToString("yyyy-MM-dd"));
                            cmd = Program.ExecSQL(sql);
                            cmd.ExecuteNonQuery();

                            sql = String.Format("SELECT poId FROM purchasingOrder WHERE staffId = '99999' AND address = 'LWL' AND totalAmount = '0'");
                            cmd = Program.ExecSQL(sql);
                            data = cmd.ExecuteReader();

                            while (data.Read())
                            {
                                poId = data.GetString(0);
                            }

                        }
                        sql = String.Format("INSERT INTO purchasingOrderProduct VALUES('{0}','{1}','{2}')", poId, productId, qty - onHand);
                        cmd = Program.ExecSQL(sql);
                        cmd.ExecuteNonQuery();

                        sql = String.Format("UPDATE product SET atHand = atHand + {0} WHERE productId = {1}", qty - onHand, productId);
                        cmd = Program.ExecSQL(sql);
                        cmd.ExecuteNonQuery();

                        sql = String.Format("UPDATE purchasingOrder SET totalAmount = totalAmount + {0} WHERE poId = {1}", amount * (qty - onHand), poId);
                        cmd = Program.ExecSQL(sql);
                        cmd.ExecuteNonQuery();

                        cmd.Dispose();

                    }

                    sql = String.Format("update product set onHand = onHand - {0}, inHand = inHand + {0} where productId = {1}", qty, productId);
                    cmd = Program.ExecSQL(sql);
                    cmd.ExecuteNonQuery();

                    cmd.Dispose();
                }

                MessageBox.Show("Submit Sussesed!");
                Utilities.ResetAllControls(this);
                //dtpDelivery.Value = DateTime.Today.AddDays(1);
            }
        }
    }
}