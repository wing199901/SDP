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
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();

            //ListView Header
            lvResult.GridLines = true;
            lvResult.View = View.Details;
            lvResult.FullRowSelect = true;
            lvResult.Columns.Add("Staff ID", 100);
            lvResult.Columns.Add("Role ID", 100);
            lvResult.Columns.Add("Staff Name", 100);
            lvResult.Columns.Add("Quantity", 100);

            
        }

        private void FormStaff_Load(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM staff";
            MySqlCommand cmd = Program.ExecSQL(sql);
            MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(data.GetInt32(0).ToString());
                lv.SubItems.Add(data.GetInt32(1).ToString());
                lv.SubItems.Add(data.GetString(2).ToString());
                lv.SubItems.Add(data.GetString(3).ToString());
                lv.SubItems.Add(data.GetBoolean(4).ToString());
            }
            data.Close();
            cmd.Dispose();
        }

        private void FormStaff_Activated(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM staff";
            MySqlCommand cmd = Program.ExecSQL(sql);
            MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(data.GetInt32(0).ToString());
                lv.SubItems.Add(data.GetInt32(1).ToString());
                lv.SubItems.Add(data.GetString(2).ToString());
                lv.SubItems.Add(data.GetString(3).ToString());
                lv.SubItems.Add(data.GetBoolean(4).ToString());
            }
            data.Close();
            cmd.Dispose();
        }
    }
}
