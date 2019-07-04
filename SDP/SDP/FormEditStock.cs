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
    public partial class FormEditStock : Form
    {
        private String productId = "";

        public String ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        public FormEditStock(String productId)
        {
            InitializeComponent();
            ProductId = productId;

        }

        private void FormEditStock_Load(object sender, EventArgs e)
        {
            String sql = String.Format("select * from product where productId='{0}'", ProductId);
            MySqlCommand cmd = Program.ExecSQL(sql);
            MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                txtProductId.Text = data.GetString("productId");
                txtType.Text = data.GetString("type");
                txtBrand.Text = data.GetString("brand");
                txtProductName.Text = data.GetString("productName");
                txtPrice.Text = data.GetString("price");
                txtDescription.Text = data.GetString("description");
            }

            txtProductId.ReadOnly = true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductId.Text))
            {
                MessageBox.Show("Product ID can not be empty");
            }
            else if (string.IsNullOrWhiteSpace(txtType.Text))
            {
                MessageBox.Show("Type can not be empty");
            }
            else if (string.IsNullOrWhiteSpace(txtBrand.Text))
            {
                MessageBox.Show("Brand can not be empty");
            }
            else if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Product Name can not be empty");
            }
            else if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Price can not be empty");
            }
            else if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Description can not be empty");
            }
            else
            {
                String sql = String.Format("UPDATE product SET type = '{0}', brand = '{1}', productName = '{2}', price = '{3}', description = '{4}' WHERE productId = '{5}'"
                    , txtType.Text, txtBrand.Text, txtProductName.Text, txtPrice.Text, txtDescription.Text, txtProductId.Text);
                MySqlCommand cmd = Program.ExecSQL(sql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update successfully.");
            }
        }

    }
}
