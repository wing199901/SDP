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
    public partial class FormGenerate : Form
    {
        private String type;
        public FormGenerate()
        {
            InitializeComponent();

        }

        private void FormGenerate_Load(object sender, EventArgs e)
        {
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = "dd/MM/yyyy";
            dtpStartDate.MaxDate = dtpEndDate.Value;
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.CustomFormat = "dd/MM/yyyy";
            dtpEndDate.MaxDate = DateTime.Today;
        }

        private void BtnGen_Click(object sender, EventArgs e)
        {
            lvReport.Columns.Clear();

            if (cboType.SelectedItem == null)
            {
                MessageBox.Show("Please select the type of the report!");
            }
            else
            {
                switch (cboType.SelectedIndex)
                {
                    case 0: // Defective Report

                        //ListView Header
                        lvReport.GridLines = true;
                        lvReport.View = View.Details;
                        lvReport.FullRowSelect = true;
                        lvReport.Columns.Add("Defective ID", 100);
                        lvReport.Columns.Add("Staff ID", 100);
                        lvReport.Columns.Add("Product ID", 100);
                        lvReport.Columns.Add("Date", 100);
                        lvReport.Columns.Add("Qty", 100);
                        lvReport.Columns.Add("Remark", 100);

                        String DG = String.Format("select * from defective");
                        MySqlCommand cmd = Program.ExecSQL(DG);
                        MySqlDataReader data = cmd.ExecuteReader();



                        while (data.Read())
                        {
                            ListViewItem lv = new ListViewItem(data.GetInt32(0).ToString());
                            lv.SubItems.Add(data.GetInt32(1).ToString());
                            lv.SubItems.Add(data.GetInt32(2).ToString());
                            lv.SubItems.Add(data.GetDateTime(3).ToString("dd/MM/yyyy"));
                            lv.SubItems.Add(data.GetString(4).ToString());
                            lv.SubItems.Add(data.GetInt32(5).ToString());
                            lv.SubItems.Add(data.GetInt32(6).ToString());
                            lv.SubItems.Add(data.GetInt32(7).ToString());
                            lv.SubItems.Add(data.GetDouble(8).ToString());
                            lvReport.Items.Add(lv);

                        }

                        data.Close();
                        cmd.Dispose();
                        break;

                        //case 1: // Inward
                        //ListView Header
                        /*lvReport.GridLines = true;
                        lvReport.View = View.Details;
                        lvReport.FullRowSelect = true;
                        lvReport.Columns.Add("Defective ID", 100);
                        lvReport.Columns.Add("Staff ID", 100);
                        lvReport.Columns.Add("Product ID", 100);
                        lvReport.Columns.Add("Date", 100);
                        lvReport.Columns.Add("Qty", 100);
                        lvReport.Columns.Add("Remark", 100);

                        String Inward = String.Format("select * from defective");
                        cmd = Program.ExecSQL(Inward);
                        data = cmd.ExecuteReader();

                        while (data.Read())
                        {
                            ListViewItem lv = new ListViewItem(data.GetInt32(0).ToString());
                            lv.SubItems.Add(data.GetInt32(1).ToString());
                            lv.SubItems.Add(data.GetInt32(2).ToString());
                            lv.SubItems.Add(data.GetDateTime(3).ToString("dd/MM/yyyy"));
                            lv.SubItems.Add(data.GetString(4).ToString());
                            lv.SubItems.Add(data.GetInt32(5).ToString());
                            lv.SubItems.Add(data.GetInt32(6).ToString());
                            lv.SubItems.Add(data.GetInt32(7).ToString());
                            lv.SubItems.Add(data.GetDouble(8).ToString());
                            lvReport.Items.Add(lv);
                        }

                        data.Close();
                        cmd.Dispose();
                        break;
                    case 2: // Outward
                        break;
                    case 3: // Turnover
                        break;
                }*/

                }
                //lvReport.Items.Clear();
            }
        }
    }
}
