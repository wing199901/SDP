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
            lvReport.GridLines = true;
            lvReport.View = View.Details;
            lvReport.FullRowSelect = true;
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
            lvReport.Items.Clear();

            if (cboType.SelectedItem == null)
            {
                MessageBox.Show("Please select the type of the report!");
            }
            else
            {
                int starMonth = Convert.ToInt32(dtpStartDate.Value.ToString("MM"));
                int starYear = Convert.ToInt32(dtpStartDate.Value.ToString("yyyy"));
                int endMonth = Convert.ToInt32(dtpEndDate.Value.ToString("MM"));
                int endYear = Convert.ToInt32(dtpEndDate.Value.ToString("yyyy"));

                lvReport.Columns.Add("Cycle",100);
                lvReport.Columns.Add("qty", 100);
                int different = (endYear - starYear > 0) ? endYear - starYear : 0;
                for(int i = starYear; i <= endYear; i++)
                {
                    
                    for(int j = starMonth; (endYear-starYear==0)?j <= endMonth:j<=12; j++)
                    {

                        if (endYear - starYear != 0&&i!=starYear&&different-->0)
                    {
                        j = 1;
                    }
                        //lvReport.Items[0].SubItems
                        ListViewItem lv = new ListViewItem(j.ToString()+"/"+i.ToString());//Cycle
                        String sql = String.Format("select count(*) from defective where date > '{0}' and date < '{1}'");

                        //lv.SubItems.Add();
                        lvReport.Items.Add(lv);
                        if (i == endYear && j == endMonth)
                        {
                            break;
                        }
                    }

                }
                //MessageBox.Show(starMonth);
                /*
                ListViewItem lv = new ListViewItem();
                switch (cboType.SelectedIndex)
                {
                    case 0: // Defective Report

                        //ListView Header
                        lvReport.GridLines = true;
                        lvReport.View = View.Details;
                        lvReport.FullRowSelect = true;
                        lvReport.Columns.Add("Date (Period)", 100);
                        lvReport.Columns.Add("QTY (Affected Purchasing Order)", 100);
                        lvReport.Columns.Add("QTY (Total Affected Purchasing Order", 100);
                        lvReport.Columns.Add("Cost", 100);

                        //String period = String.Format("SELECT date FROM defective WHERE MONTH(date) = MONTH(%m) AND Year(date) = YEAR(%Y)");
                        String period = String.Format("SELECT DATE_FORMAT(date, '%m/%Y') FROM defective");
                        MySqlCommand p = Program.ExecSQL(period);
                        MySqlDataReader P = p.ExecuteReader();

                        long d = 0;
                        while (P.Read())
                        {
                            d += long.Parse(DateTime.ToString(P));
                        }
                        lv.SubItems.Add(d.ToString());
                        /*int month = 0;
                        int year = 0;
                        String M;
                        while (P.Read())
                        {
                            month++;
                            year++;
                             M = Convert.ToString(month, year);
                            if (month > 0 && year > 0)
                            {
                               
                                lv.SubItems.Add(M.GetDateTime(0).ToString(");

                            }
                            else
                            {
                                MessageBox.Show("No defective report!");
                            }
                        }*/
                        
                  /*
                        //ListViewItem lv = new ListViewItem(M);*/

                        //QTY (Affected Purchasing Order)

                /*
                        String DG = String.Format("select * from defective");
                        MySqlCommand cmd = Program.ExecSQL(DG);
                        MySqlDataReader data = cmd.ExecuteReader();

                        int tmp = 0;
                        String Tmp;
                        while (data.Read())
                        {
                            tmp++;
                        }

                        if (tmp > 0)
                        {
                            Tmp = Convert.ToString(tmp);

                            lv.SubItems.Add(Tmp);
                        }


                        // QTY (Total A.P.O)
                        String tapo = String.Format("select qty from defective ");
                        MySqlCommand t = Program.ExecSQL(tapo);
                        MySqlDataReader T = t.ExecuteReader();

                        int totalQTY=0;
                        while (T.Read())
                        {
                            totalQTY += T.GetInt32(0);
                        }
                        lv.SubItems.Add(totalQTY.ToString());


                        // Cost
                        String c = String.Format("select price from product");
                        MySqlCommand msc = Program.ExecSQL(c);
                        MySqlDataReader msdrT = msc.ExecuteReader();

                        int price = 0;
                        String totalCost;
                        while (msdrT.Read())
                        {
                            price++;
                        }
                        totalCost = Convert.ToString(price * totalQTY);
                        lv.SubItems.Add(totalCost);
                        

                        lvReport.Items.Add(lv);
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
               // }
                
                //lvReport.Items.Clear();
            }
        }
    }
}
