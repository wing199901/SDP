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
        public FormNewOrder()
        {
            InitializeComponent();
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

            MySqlCommand cmd = Program.Logindb("select * from staff");
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
            data.Close();

            txtId.Text = FormLogin.getUserName();
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
    }
}