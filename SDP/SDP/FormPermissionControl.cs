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
    public partial class FormPermissionControl : Form
    {
        private ListViewItem currentItem;
        private ListViewItem.ListViewSubItem currentItemSub;
        private String roleId;
        public String RoleId
        {
            get { return roleId; }
            set { roleId = value; }
        }
        public FormPermissionControl(String roleId)
        {
            InitializeComponent();

            RoleId = roleId;
            //ListView Header
            lvResult.GridLines = true;
            lvResult.View = View.Details;
            lvResult.FullRowSelect = true;
            lvResult.Columns.Add("Control ID", 100);
            lvResult.Columns.Add("Page", 200);
            lvResult.Columns.Add("Description", 200);
            lvResult.Columns.Add("disbled", 100);
        }
        private void FormPermissionControl_Load(object sender, EventArgs e)
        {
            String sql = String.Format("SELECT controlRole.controlId, controlRole.page, description, disabled from controlRole, control where roleId = {0} and controlRole.controlId = control.controlId order by controlRole.controlId ASC",roleId);
            MySqlCommand cmd = Program.ExecSQL(sql);
            MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(data.GetString(0));
                lv.SubItems.Add(data.GetString(1));
                lv.SubItems.Add(data.GetString(2));
                lv.SubItems.Add(data.GetString(3));
                lvResult.Items.Add(lv);
            }
        }

        private void LvResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            currentItem = lvResult.GetItemAt(e.X, e.Y);
            String productId = currentItem.Text;
            String sql = String.Format("select onHand from product where productId = {0}", productId);
            MySqlCommand cmd = Program.ExecSQL(sql);
            MySqlDataReader data = cmd.ExecuteReader();

        }
    }
}
