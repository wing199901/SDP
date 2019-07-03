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
            lvCustomer.Columns.Add("Customer Name", 100);
            lvCustomer.Columns.Add("Address", 100);
            lvCustomer.Columns.Add("Company Name", 100);
            lvCustomer.Columns.Add("Email", 150);
            lvCustomer.Columns.Add("Phone Number", 100);

        }

        private void LvCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            String sql = String.Format("select * from customer");
            MySqlCommand cmd = Program.ExecSQL(sql);
            MySqlDataReader data = cmd.ExecuteReader();

            lvCustomer.Items.Clear();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(data.GetString(1).ToString());
                lv.SubItems.Add(data.GetString(2).ToString());
                lv.SubItems.Add(data.GetString(3).ToString());
                lv.SubItems.Add(data.GetString(4).ToString());
                lv.SubItems.Add(data.GetInt32(5).ToString());
                lvCustomer.Items.Add(lv);
            }

            data.Close();
            cmd.Dispose();
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
                MessageBox.Show("Customer Name can not be empty");
            }
            else
            {
                MySqlCommand cmd = null;
                try
                {
                    String sql = String.Format("INSERT INTO customer VALUES ('{1}', '{2}', '{3}', '{4}', '{5}') ", txtName.Text, txtAddress.Text, txtComName.Text, txtEmail.Text, txtPhone.Text);
                    cmd = Program.ExecSQL(sql);
                    cmd.ExecuteReader();
                    MessageBox.Show("Add successfully!");
                    FormCustomerManagement_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                cmd.Dispose();

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
                MessageBox.Show("Customer Name can not be empty");
            }
            else
            {
                if (currentItem != null)
                {
                    String CustomerID = currentItem.Text;
                    MySqlCommand cmd = null;
                    try
                    {
                        String sql = String.Format("UPDATE customer SET custID = {0}, custName = '{1}', address = '{2}', companyName = '{3}', email = '{4}', phone = '{5}' WHERE custID = {6}", CustomerID, txtName.Text, txtAddress.Text, txtComName.Text, txtEmail.Text, txtPhone.Text, txtCID.Text);
                        cmd = Program.ExecSQL(sql);
                        cmd.ExecuteReader();
                        MessageBox.Show("Update successfully!");
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
                    MessageBox.Show("Please select a customer");
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
