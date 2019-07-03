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
        private ListViewItem currentItem;
        private ListViewItem.ListViewSubItem currentItemSub;
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
            lvResult.Columns.Add("Available", 100);

            lvResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void FormStaff_Load(object sender, EventArgs e)
        {
            lvResult.Items.Clear();

            String sql = "SELECT * FROM staff";
            MySqlCommand cmd = Program.ExecSQL(sql);
            MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(data.GetInt32(0).ToString());
                lv.SubItems.Add(data.GetInt32(1).ToString());
                lv.SubItems.Add(data.GetString(2).ToString());
                lv.SubItems.Add(data.GetBoolean(4).ToString());
                lvResult.Items.Add(lv);
            }
            data.Close();
            cmd.Dispose();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            if (currentItem != null)
            {
                String StaffID = currentItem.Text;
                MySqlCommand cmd = null;
                try
                {
                    String sql = String.Format("UPDATE staff SET pwd = '000000' WHERE staffId = {0}", StaffID);
                    cmd = Program.ExecSQL(sql);
                    cmd.ExecuteReader();
                    MessageBox.Show("Password reset successfully!");
                    FormStaff_Load(sender, e);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                cmd.Dispose();
            }
            else
            {
                MessageBox.Show("Please selete a user");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name can not be empty.");
            }

            else if (string.IsNullOrWhiteSpace(txtRID.Text))
            {
                MessageBox.Show("Role ID can not be empty.");
            }
            else
            {
                if (currentItem != null)
                {
                    String StaffID = currentItem.Text;
                    MySqlCommand cmd = null;
                    try
                    {
                        Boolean available = cbAvailable.Checked;
                        String sql = String.Format("UPDATE staff SET roleId = {0}, staffName = '{1}', available = {2} WHERE staffId = {3}", txtRID.Text, txtName.Text, available, StaffID);
                        cmd = Program.ExecSQL(sql);
                        cmd.ExecuteReader();
                        MessageBox.Show("Update successfully!");
                        FormStaff_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    cmd.Dispose();

                }
                else
                {
                    MessageBox.Show("Please selete a user");
                }
            }
        }

        private void LvResult_MouseClick(object sender, MouseEventArgs e)
        {
            currentItem = lvResult.GetItemAt(e.X, e.Y);

            if (currentItem != null)
            {
                String StaffID = currentItem.Text;

                String sql = String.Format("SELECT * FROM staff WHERE staffId = {0}", StaffID);
                MySqlCommand cmd = Program.ExecSQL(sql);
                MySqlDataReader data = cmd.ExecuteReader();

                while (data.Read())
                {
                    txtRID.Text = data.GetInt32(1).ToString();
                    txtName.Text = data.GetString(2).ToString();
                    cbAvailable.Checked = data.GetBoolean(4);
                }
                data.Close();
                cmd.Dispose();
            }
            else
            {
                MessageBox.Show("Please selete a user");
            }
        }
    }
}
