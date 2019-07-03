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
                MySqlCommand cmd = null;
                try
                {
                    String sql = String.Format("INSERT INTO product(productName, type, price, brand, description) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}') ", txtName.Text, type, txtPrice.Text, txtBrand.Text, txtDes.Text);
                    cmd = Program.ExecSQL(sql);
                    cmd.ExecuteReader();
                    MessageBox.Show("Add successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                cmd.Dispose();


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
            //String type;


            if(cbType.SelectedIndex == 0)
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
        }
    }
}