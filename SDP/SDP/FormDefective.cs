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
    }
}
