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
    public partial class FormRoleControl : Form
    {
        //private ListViewItem currentItem;
        public FormRoleControl()
        {
            InitializeComponent();

            //ListView Header
            lvResult.GridLines = true;
            lvResult.View = View.Details;
            lvResult.FullRowSelect = true;
            lvResult.Columns.Add("Role ID", 50);
            lvResult.Columns.Add("Role Name", 200);
        }

        private void FormRoleControl_Load(object sender, EventArgs e)
        {
            lvResult.Items.Clear();

            String sql = "SELECT * FROM role";
            MySqlCommand cmd = Program.ExecSQL(sql);
            MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(data.GetInt32(0).ToString());
                lv.SubItems.Add(data.GetString(1).ToString());
                lvResult.Items.Add(lv);
            }
            data.Close();
            cmd.Dispose();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Role Name can not be empty.");
            }

            else if (string.IsNullOrWhiteSpace(txtRID.Text))
            {
                MessageBox.Show("Role ID can not be empty.");
            }
            else
            {
                MySqlCommand cmd = null;
                try
                {
                    String sql = String.Format("INSERT INTO role VALUES({0},'{1}')", txtRID.Text, txtName.Text);
                    cmd = Program.ExecSQL(sql);
                    cmd.ExecuteReader();
                    MessageBox.Show("Update successfully!");
                    FormRoleControl_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                cmd.Dispose();

            }
        }
    }
}

