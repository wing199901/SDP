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
    public partial class FormDefective : Form
    {
        private String userName = "";
        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public FormDefective(String username)
        {
            InitializeComponent();
            UserName = username;

        }

        private void FormDefective_Load(object sender, EventArgs e)
        {
            txtSid.Text = UserName;
            txtSid.ReadOnly = true;

            try
            {
                String sql = "select max(defectiveId) from defective";
                MySqlCommand cmd = Program.ExecSQL(sql);
                MySqlDataReader data = cmd.ExecuteReader();

                while (data.Read())
                {
                    txtDid.Text = data.GetString(0);
                }
            }
            catch
            {
                txtDid.Text = "100001";
            }

            txtDid.ReadOnly = true;


            dtpDefective.MaxDate = DateTime.Today;
        }

        private void DtpDefective_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (txtDid.Text == "")
            {
                MessageBox.Show("Defective ID can not be empty.");
            }
            else if (txtSid.Text == "")
            {
                MessageBox.Show("Staff ID can not be empty.");
            }
            else if (txtSKU.Text == "")
            {
                MessageBox.Show("Product ID can not be empty.");
            }
            else if (txtQTY.Text == "")
            {
                MessageBox.Show("Quantity can not be empty.");
            }
            else if (txtReason.Text == "")
            {
                MessageBox.Show("Reason can not be empty.");
            }
            else
            {
                String sql = String.Format("INSERT INTO defective(`staffId`, `productId`, `date`, `qty`, `reason`, `remark`) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", txtSid.Text, txtSKU.Text, dtpDefective.Value.ToString("yyyy-MM-dd"), txtQTY.Text, txtReason.Text, txtRemark.Text);
                MySqlCommand cmd = Program.ExecSQL(sql);
                cmd.ExecuteNonQuery();

                sql = String.Format("UPDATE product SET onHand = onHand - {0} WHERE productId = {1}", txtQTY.Text, txtSKU.Text);
                cmd = Program.ExecSQL(sql);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Update successfully!");

            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
