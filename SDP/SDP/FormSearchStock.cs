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
            String sql = String.Format("select * from product where sku = {0}", txtData.Text);
            MySqlCommand cmd = Program.Logindb(sql);
            MySqlDataReader data = cmd.ExecuteReader();
        }

       
    }
}
