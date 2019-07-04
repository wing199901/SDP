using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP
{
    public partial class FormMenu : Form
    {
        private String userName = "";
        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private Boolean btnLogoutWasClicked;

        public FormMenu(String username)
        {
            InitializeComponent();
            UserName = username;

            DateTime firstDay = new DateTime();
            firstDay = firstDay.AddDays(-(firstDay.Day - 1));
            if (DateTime.Now.Day.Equals(firstDay.Day))
            {
                this.Reorder("");
            }
        }

        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            Form newOrder = new FormNewOrder(UserName);
            newOrder.ShowDialog();
        }

        private void BtnSearchOrder_Click(object sender, EventArgs e)
        {
            Form searchOrder = new FormSearchOrder();
            searchOrder.ShowDialog();
        }

        private void BtnDefective_Click(object sender, EventArgs e)
        {
            Form defective = new FormDefective(UserName);
            defective.ShowDialog();
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            Form stock = new FormSearchStock("");
            stock.ShowDialog();
        }

        private void BtnGoods_Click(object sender, EventArgs e)
        {
            Form good = new FormReceive();
            good.ShowDialog();
        }

        private void BtnGenReport_Click(object sender, EventArgs e)
        {
            Form report = new FormGenerate();
            report.ShowDialog();
        }

        private void BtnROL_Click(object sender, EventArgs e)
        {
            Form rol = new FormReorderPoint();
            rol.ShowDialog();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

            String sql = String.Format("select staffName from staff where staffId ={0}", UserName);
            MySqlCommand cmd = Program.ExecSQL(sql);
            MySqlDataReader data = cmd.ExecuteReader();
            String name = "";

            while (data.Read())
            {
                name = data[0].ToString();
            }

            data.Close();
            cmd.Dispose();

            lblWelcome.Text += name;

            btnLogoutWasClicked = false;

            SetUpTimer(new TimeSpan(12, 00, 00));
        }



        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnLogoutWasClicked == false)
            {
                DialogResult result = MessageBox.Show("Are you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                e.Cancel = (result == DialogResult.No);
                Environment.Exit(0);
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            btnLogoutWasClicked = true;

            DialogResult result = MessageBox.Show("Are you want to log out?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                btnLogoutWasClicked = false;
            }
        }

        private void BtnCust_Click(object sender, EventArgs e)
        {
            Form csutomerManagement = new FormCustomerManagement();
            csutomerManagement.ShowDialog();
        }

        private void BtnJPos_Click(object sender, EventArgs e)
        {
            Form roleControl = new FormRoleControl();
            roleControl.ShowDialog();
        }

        private void BtnStaff_Click(object sender, EventArgs e)
        {

            Form staff = new FormStaff();
            staff.ShowDialog();
        }

        private void BtnNProduct_Click(object sender, EventArgs e)
        {
            Form newProduct = new FormNewProduct();
            newProduct.ShowDialog();
        }

        private void BtnNewPO_Click(object sender, EventArgs e)
        {
            Form newPurchaseOrder = new FormNewPurchaseOrder(UserName);
            newPurchaseOrder.ShowDialog();
        }

        private void BtnPassword_Click(object sender, EventArgs e)
        {
            Form changePassword = new FormChangePassword(UserName);
            changePassword.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form searchPO = new FormSearchPurchaseOrder();
            searchPO.ShowDialog();
        }

        private System.Threading.Timer timer;

        private void SetUpTimer(TimeSpan alertTime)
        {
            DateTime current = DateTime.Now;
            TimeSpan timeToGo = alertTime - current.TimeOfDay;
            if (timeToGo < TimeSpan.Zero)
            {
                return;//time already passed
            }
            this.timer = new System.Threading.Timer(x =>
            {
                this.Reorder("");
            }, null, timeToGo, Timeout.InfiniteTimeSpan);
        }

        private void Reorder(String productID)
        {
            if (productID == "")
            {
                String poId = null;
                DateTime dDay = new DateTime();

                try
                {
                    String sql = "SELECT productId, atHand, onHand, price, leadTime, reorderPoint FROM product WHERE reorderPoint > (atHand + onHand)";
                    MySqlCommand cmd = Program.ExecSQL(sql);
                    MySqlDataReader data = cmd.ExecuteReader();

                    while (data.Read())
                    {
                        if (poId == null)
                        {
                            sql = String.Format("INSERT INTO purchasingOrder(`staffId`, status, `date`, `deliveryDate`, `address`, `totalAmount`) " +
                                "VALUES('99999', 'Pending', '{0}', '{1}', 'LWL', 0)", DateTime.Now.ToString("yyyy-MM-dd"),
                                DateTime.Now.ToString("yyyy-MM-dd"));
                            cmd = Program.ExecSQL(sql);
                            cmd.ExecuteNonQuery();

                            sql = String.Format("SELECT poId ,deliveryDay FROM purchasingOrder WHERE staffId = '99999' AND address = 'LWL' AND totalAmount = '0'");
                            cmd = Program.ExecSQL(sql);
                            data = cmd.ExecuteReader();

                            while (data.Read())
                            {
                                poId = data.GetString(0);
                                dDay = data.GetDateTime(1);
                            }
                        }
                        sql = String.Format("INSERT INTO purchasingOrderProduct VALUES('{0}','{1}','{2}')"
                            , poId, data.GetString("productId"), data.GetInt32("reorderPoint"));
                        cmd = Program.ExecSQL(sql);
                        cmd.ExecuteNonQuery();

                        sql = String.Format("UPDATE product SET atHand = atHand + {0} WHERE productId = {1}"
                            , data.GetInt32("reorderPoint"), data.GetString("productId"));
                        cmd = Program.ExecSQL(sql);
                        cmd.ExecuteNonQuery();

                        sql = String.Format("UPDATE purchasingOrder SET totalAmount = totalAmount + {0} WHERE poId = {1}"
                            , data.GetDouble("price") * data.GetDouble("reorderPoint"), poId);
                        cmd = Program.ExecSQL(sql);
                        cmd.ExecuteNonQuery();

                        sql = String.Format("UPDATE purchasingOrder SET deliveryDate = GEATEST(deliveryDate, '{0}') WHERE poId = {1}"
                            , dDay.AddDays(data.GetInt32("leadTime")), poId);
                        cmd = Program.ExecSQL(sql);
                        cmd.ExecuteNonQuery();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("No product need to reorder.");
                }
            }
            else
            {
                String sql = String.Format("SELECT * FROM product WHERE productId = '{0}'", productID);
                MySqlCommand cmd = Program.ExecSQL(sql);
                MySqlDataReader data = cmd.ExecuteReader();

                while (data.Read())
                {
                    if ((data.GetInt32("atHand") + data.GetInt32("onHand")) < data.GetInt32("reorderPoint"))
                    {
                        String poId = null;

                        sql = String.Format("INSERT INTO purchasingOrder(`staffId`, status, `date`, `deliveryDate`, `address`, `totalAmount`) " +
                                "VALUES('99999', 'Pending', '{0}', '{1}', 'LWL', 0)", DateTime.Now.ToString("yyyy-MM-dd"),
                                DateTime.Now.AddDays(data.GetInt32("leadTime")).ToString("yyyy-MM-dd"));
                        cmd = Program.ExecSQL(sql);
                        cmd.ExecuteNonQuery();

                        sql = String.Format("SELECT poId ,deliveryDay FROM purchasingOrder WHERE staffId = '99999' AND address = 'LWL' AND totalAmount = '0'");
                        cmd = Program.ExecSQL(sql);
                        data = cmd.ExecuteReader();

                        while (data.Read())
                        {
                            poId = data.GetString(0);
                        }

                        sql = String.Format("INSERT INTO purchasingOrderProduct VALUES('{0}','{1}','{2}')"
                            , poId, data.GetString("productId"), data.GetInt32("reorderPoint"));
                        cmd = Program.ExecSQL(sql);
                        cmd.ExecuteNonQuery();

                        sql = String.Format("UPDATE product SET atHand = atHand + {0} WHERE productId = {1}"
                            , data.GetInt32("reorderPoint"), data.GetString("productId"));
                        cmd = Program.ExecSQL(sql);
                        cmd.ExecuteNonQuery();

                        sql = String.Format("UPDATE purchasingOrder SET totalAmount = totalAmount + {0} WHERE poId = {1}"
                            , data.GetDouble("price") * data.GetDouble("reorderPoint"), poId);
                        cmd = Program.ExecSQL(sql);
                        cmd.ExecuteNonQuery();

                    }
                    else
                    {
                        MessageBox.Show("This product is no need to reorder.");
                    }

                    cmd.Dispose();
                }
            }
        }
    }
}
