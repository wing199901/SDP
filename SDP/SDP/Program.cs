using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SDP
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }

        public static MySqlCommand ExecSQL(String sql)
        {
            string dbHost = "192.168.64.2";
            string dbUser = "user";
            string dbPass = "user";
            string dbName = "dbOPSRS";

            string connStr = "server=" + dbHost + ";uid=" + dbUser + ";pwd=" + dbPass + ";database=" + dbName;
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = null;
            try
            {
                conn.Open();
                cmd = new MySqlCommand(sql, conn);
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("無法連線到資料庫.");
                        break;
                    case 1045:
                        Console.WriteLine("使用者帳號或密碼錯誤,請再試一次.");
                        break;
                }
            }
            return cmd;
        }
    }

    public class Utilities
    {
        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    if (textBox.Name == "txtNumber")
                    {
                        MySqlCommand cmd = Program.ExecSQL("select max(orderId) from dbOPSRS.order");
                        MySqlDataReader data = cmd.ExecuteReader();

                        while (data.Read())
                        {
                            textBox.Text = (data.GetInt32(0) + 1).ToString();
                        }
                    }
                    else if (textBox.Name == "txtDate")
                    {
                        textBox.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    }
                    else if (textBox.Name == "txtStaffId")
                    {

                    }
                    else
                    {
                        textBox.Text = null;
                    }
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }

                if (control is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)control;
                    if (dateTimePicker.Name == "dtpDelivery")
                        dateTimePicker.Value = DateTime.Today.AddDays(1);
                    else { dateTimePicker.Value = DateTime.Today; }
                }
                if (control is ListView)
                {
                    ListView listView = (ListView)control;
                    listView.Items.Clear();
                }

            }
        }
    }
}
