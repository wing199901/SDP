using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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
            lvResult.Columns.Add("Quantity", 50);
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

            /*MySqlCommand cmd = Program.ExecSQL("select * from staff");
            MySqlDataReader data = cmd.ExecuteReader();
            Console.WriteLine("是否查到資料:{0}", data.HasRows);
            Console.WriteLine("欄位數:{0}", data.FieldCount);
            for (int i = 0; i < data.FieldCount; i++)
            {
                Console.WriteLine("欄位 {0} 的名稱為 {1} ; 資料型態為 {2}", i, data.GetName(i), data.GetDataTypeName(i));
            }
            while (data.Read())
            {

                //以欄位名稱取得資料並列出
                Console.WriteLine("Staff id={0} , Staff name={1}, Staff position={2},Staff password={3}", data[0], data[1],data[2],data[3]);
            }
            data.Close();*/

            txtId.Text = UserName;
            
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

        private void btnCancel_Click(object sender, EventArgs e)
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
                        lv.SubItems.Add(data.GetDouble(5).ToString());
                        lv.SubItems.Add(txtQty.Text);
                        lvResult.Items.Add(lv);
                    }
                }
                else
                {
                    MessageBox.Show("Product ID can not be empty!");
                }
            }
            else
            {
                MessageBox.Show("Qantity can not be empty!");
            }
        }
    }
}