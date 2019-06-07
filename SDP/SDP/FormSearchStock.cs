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
    public partial class FormSearchStock : Form
    {
        public FormSearchStock()
        {
            InitializeComponent();
        }

        private void FormSearchStock_Load(object sender, EventArgs e)
        {
            ConnectData();
        }

        private void ConnectData()
        {
            DataTable dt = new DataTable();
            {
                String sql = String.Format("select * from product", dgvProduct.DataSource);
                MySqlCommand cmd = Program.Logindb(sql);
                MySqlDataReader data = cmd.ExecuteReader();
                dt.Load(data);

                if (dt.Rows.Count > 0)
                {
                    dgvProduct.DataSource = dt;
                }
            }
        }
    }
}
