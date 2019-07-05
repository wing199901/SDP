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
        private ListViewItem currentItem;
        private ListViewItem.ListViewSubItem currentItemSub;
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
                    String sql = String.Format("select * from role where roleId = {0}", txtRID.Text);
                    cmd = Program.ExecSQL(sql);
                    MySqlDataReader data = cmd.ExecuteReader();
                    int count = 0;
                    while (data.Read())
                    {
                        count++;
                    }
                    if (count == 0)
                    {
                        cmd.Dispose();
                        sql = String.Format("INSERT INTO role VALUES({0},'{1}')", txtRID.Text, txtName.Text);
                        cmd = Program.ExecSQL(sql);
                        cmd.ExecuteReader();
                        cmd.Dispose();
                        sql = "SELECT page,controlId from control";
                        cmd = Program.ExecSQL(sql);
                        data = cmd.ExecuteReader();
                        while (data.Read())
                        {//insert into controlRole VALUES (10,'Correct ROL',900,true)
                            sql = String.Format("insert into controlRole values ({0},'{1}',{2},{3})", txtRID.Text, data.GetString(0), data.GetString(1), "true");
                            cmd = Program.ExecSQL(sql);
                            cmd.ExecuteReader();
                        }
                        MessageBox.Show("Update successfully!");
                    }
                    else
                    {
                        MessageBox.Show("This role Id alreadly exist.");
                    }
                    cmd.Dispose();
                    Utilities.ResetAllControls(this);
                    FormRoleControl_Load(sender, e);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                cmd.Dispose();

            }
        }

        private void LvResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            currentItem = lvResult.GetItemAt(e.X, e.Y);
            if (currentItem != null)
            {
                String roleId = currentItem.Text.ToString();
                FormPermissionControl permissionControl = new FormPermissionControl(roleId);
                permissionControl.ShowDialog();
            }
        }
    }
}

