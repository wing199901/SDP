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
            lvCustomer.Columns.Add("Phone Number", 50);

            txtCID.Focus();

        }

        private void LvCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            String sql = String.Format("select * from customer where custId like '%{0}%' or custName like '%{1}%' or address like '%{2}% or companyName like '%{3}%' or email like '%{4}%' or phone like '%{5}%' ",txtCID,txtName,txtAddress,txtComName,txtEmail,txtPhone);
            MySqlCommand cmd = Program.ExecSQL(sql);
            MySqlDataReader data = cmd.ExecuteReader();
        }
    }
}
