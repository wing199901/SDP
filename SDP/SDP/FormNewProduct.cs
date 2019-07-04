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
    public partial class FormNewProduct : Form
    {
        private String type;

        public FormNewProduct()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Product Name can not be empty");
            }
            else if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Price can not be empty");
            }
            else if (string.IsNullOrWhiteSpace(txtBrand.Text))
            {
                MessageBox.Show("Brand can not be empty");
            }
            else if (string.IsNullOrWhiteSpace(txtDes.Text))
            {
                MessageBox.Show("Description can not be empty");
            }

            else
            {
                if (cbType.SelectedIndex == 0)
                {
                    type = "A";
                }

                if (cbType.SelectedIndex == 1)
                {
                    type = "B";
                }
                if (cbType.SelectedIndex == 2)
                {
                    type = "C";
                }
                if (cbType.SelectedIndex == 3)
                {
                    type = "D";
                }
                try
                {
                    MySqlCommand cmd = null;
                    String sql;
                    String check_Name = String.Format("select * from product where productName = '{0}'", txtName.Text);
                    cmd = Program.ExecSQL(check_Name);
                    MySqlDataReader data = cmd.ExecuteReader();
                    int tmp = 0;
                    while (data.Read())
                    {
                        tmp++;
                    }
                    if (tmp == 0)
                    {
                        if (txtLeadTime.Text == "")
                        {
                            sql = String.Format("INSERT INTO product(type, brand,productName,description, price) VALUES('{0}','{1}','{2}','{3}','{4}')", type, txtBrand.Text, txtName.Text, txtDes.Text, txtPrice.Text);
                        }
                        else
                        {
                            sql = String.Format("INSERT INTO product(type, brand,productName,description, price, leadTime) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", type, txtBrand.Text, txtName.Text, txtDes.Text, txtPrice.Text, txtLeadTime.Text);
                        }
                        cmd = Program.ExecSQL(sql);
                        cmd.ExecuteReader();
                        cmd.Dispose();
                        MessageBox.Show("Add successfully!");
                        Utilities.ResetAllControls(this);
                    }
                    else
                    {
                        MessageBox.Show("Product Name cannot repeat");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNewProduct_Load(object sender, EventArgs e)
        {
            cbType.SelectedIndex = 0;
        }

        private void CbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}