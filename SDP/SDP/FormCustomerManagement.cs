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
    public partial class FormCustomerManagement : Form
    {
        private ListViewItem currentItem;

        public FormCustomerManagement()
        {
            InitializeComponent();

            //ListView Header
            lvCustomer.GridLines = true;
            lvCustomer.View = View.Details;
            lvCustomer.FullRowSelect = true;
            lvCustomer.Columns.Add("Customer ID", 100);
            lvCustomer.Columns.Add("Customer Name", 100);
            lvCustomer.Columns.Add("Address", 100);
            lvCustomer.Columns.Add("Company Name", 100);
            lvCustomer.Columns.Add("Email", 150);
            lvCustomer.Columns.Add("Phone Number", 100);

        }

        private void FormCustomerManagement_Load(object sender, EventArgs e)
        {
            String sql = String.Format("select * from customer");
            MySqlCommand cmd = Program.ExecSQL(sql);
            MySqlDataReader data = cmd.ExecuteReader();

            lvCustomer.Items.Clear();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(data.GetString(0).ToString());
                lv.SubItems.Add(data.GetString(1).ToString());
                lv.SubItems.Add(data.GetString(2).ToString());
                lv.SubItems.Add(data.GetString(3).ToString());
                lv.SubItems.Add(data.GetString(4).ToString());
                lv.SubItems.Add(data.GetInt32(5).ToString());
                lvCustomer.Items.Add(lv);
            }

            data.Close();
            cmd.Dispose();
        }

        private void lvCustomer_MouseClick(object sender, MouseEventArgs e)
        {
            currentItem = lvCustomer.GetItemAt(e.X, e.Y);

            if (currentItem != null)
            {
                String CustomerID = currentItem.Text;

                String sql = String.Format("SELECT * FROM customer WHERE custID = {0}", CustomerID);
                MySqlCommand cmd = Program.ExecSQL(sql);
                MySqlDataReader data = cmd.ExecuteReader();

                while (data.Read())
                {
                    txtName.Text = data.GetString(1).ToString();
                    txtAddress.Text = data.GetString(2).ToString();
                    txtComName.Text = data.GetString(3).ToString();
                    txtEmail.Text = data.GetString(4).ToString();
                    txtPhone.Text = data.GetInt32(5).ToString();
                }
                data.Close();
                cmd.Dispose();
            }
            else
            {
                MessageBox.Show("Please select a user");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Customer Name can not be empty");
            }
            else if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address can not be empty");
            }
            else if (string.IsNullOrWhiteSpace(txtComName.Text))
            {
                MessageBox.Show("Company Name can not be empty");
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email can not be empty");
            }
            else if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone Number can not be empty");
            }
            else
            {
                MySqlCommand cmd = null;
                String check_Phone = String.Format("select * from customer where phone = '{0}'", txtPhone.Text);
                cmd = Program.ExecSQL(check_Phone);
                MySqlDataReader data = cmd.ExecuteReader();
                int tmp = 0;
                while (data.Read())
                {
                    tmp++;
                }
                if (tmp == 0)
                {
                    try
                    {
                        String sql = String.Format("INSERT INTO customer (custName, address, companyName, email, phone) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}') ", txtName.Text, txtAddress.Text, txtComName.Text, txtEmail.Text, txtPhone.Text);
                        cmd = Program.ExecSQL(sql);
                        cmd.ExecuteReader();
                        MessageBox.Show("Add successfully!");

                        Utilities.ResetAllControls(this);
                        FormCustomerManagement_Load(sender, e);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    cmd.Dispose();

                }
                else
                {
                    MessageBox.Show("Phone number cannot repeat");
                }
            }
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Customer Name can not be empty");
            }
            else if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address can not be empty");
            }
            else if (string.IsNullOrWhiteSpace(txtComName.Text))
            {
                MessageBox.Show("Company Name can not be empty");
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email can not be empty");
            }
            else if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone Number can not be empty");
            }
            else
            {
                if (currentItem != null)
                {

                    String CustomerID = currentItem.Text;
                    MySqlCommand cmd = null;
                    String check_Phone = String.Format("select * from customer where phone = '{0}' and custId = {1}", txtPhone.Text,CustomerID);
                    cmd = Program.ExecSQL(check_Phone);
                    MySqlDataReader data = cmd.ExecuteReader();
                    String currentPhone = "";
                    while (data.Read())
                    {
                        currentPhone = data.GetInt32(5).ToString();
                    }
                    data.Close();
                    cmd.Dispose();
                    String sql = String.Format("select * from customer where phone = '{0}'", txtPhone.Text);
                    cmd = Program.ExecSQL(sql);
                     data = cmd.ExecuteReader();
                    int resultCOunt = 0;
                    while (data.Read())
                    {
                        resultCOunt++;
                    }

                    //MessageBox.Show("current phone: " + currentPhone + "change phone: " + txtPhone.Text);
                    if (currentPhone == "" && resultCOunt==0)
                    {
                        sql = String.Format("UPDATE customer SET custName = '{0}', address = '{1}', companyName = '{2}', email = '{3}', phone = '{4}' WHERE custID = '{5}'", txtName.Text, txtAddress.Text, txtComName.Text, txtEmail.Text, txtPhone.Text, CustomerID);
                        cmd = Program.ExecSQL(sql);
                        cmd.ExecuteReader();
                        MessageBox.Show("Update successfully!");
                        FormCustomerManagement_Load(sender, e);
                    }
                    else if (currentPhone == txtPhone.Text&& currentPhone=="")
                    {

                         sql = String.Format("UPDATE customer SET custName = '{0}', address = '{1}', companyName = '{2}', email = '{3}', phone = '{4}' WHERE custID = '{5}'", txtName.Text, txtAddress.Text, txtComName.Text, txtEmail.Text, txtPhone.Text, CustomerID);
                        cmd = Program.ExecSQL(sql);
                        cmd.ExecuteReader();
                        MessageBox.Show("Update successfully!");
                        FormCustomerManagement_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Phone number cannot repeat");
                        Utilities.ResetAllControls(this);
                        FormCustomerManagement_Load(sender, e);
                    }
                }
            }
        }

        private void TxtHide_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

            private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
