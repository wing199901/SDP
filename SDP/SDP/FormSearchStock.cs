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
            MySqlCommand cmd = Program.Logindb("select * from ?");
            MySqlDataReader data = cmd.ExecuteReader();
        }

       
    }
}
