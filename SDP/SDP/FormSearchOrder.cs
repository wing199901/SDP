using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP
{
    public partial class FormSearchOrder : Form
    {
        private ListViewItem currentItem;

        public FormSearchOrder()
        {
            InitializeComponent();

            //ListView Header
            lvResult_order.GridLines = true;
            lvResult_order.View = View.Details;
            lvResult_order.FullRowSelect = true;
            lvResult_order.Columns.Add("Order ID", 70);
            lvResult_order.Columns.Add("Staff ID", 70);
            lvResult_order.Columns.Add("Customer ID", 70);
            lvResult_order.Columns.Add("Status", 70);
            lvResult_order.Columns.Add("Date", 70);
            lvResult_order.Columns.Add("Delivery Date", 80);
            lvResult_order.Columns.Add("Shipping Address", 200);
            lvResult_order.Columns.Add("Total Amount", 80);
            lvResult_order.Columns.Add("Remark", 200);

        }

        private void FormSearchOrder_Load(object sender, EventArgs e)
        {
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = "dd/MM/yyyy";
            dtpStartDate.MaxDate = dtpEndDate.Value;
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.CustomFormat = "dd/MM/yyyy";
            dtpEndDate.MaxDate = DateTime.Today;

        }
        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void BtnSearch_Click(object sender, EventArgs e)
        {
            String reference = "";
            if (txtOrderId.Text != "")
            {
                reference += " orderId='" + Convert.ToInt32(txtOrderId.Text).ToString() + "'";
            }
            if (txtStaffId.Text != "")
            {
                if (reference != "")
                {
                    reference += " AND";
                }
                reference += " staffId='" + Convert.ToInt32(txtStaffId.Text).ToString() + "'";
            }
            if (txtCustId.Text != "")
            {
                if (reference != "")
                {
                    reference += " AND";
                }
                reference += " custId='" + Convert.ToInt32(txtCustId.Text).ToString() + "'";
            }
            if (txtCustPhone.Text != "")
            {
                String custId = "";
                MySqlCommand cmd = Program.ExecSQL("select custId from customer where phone='" + txtCustPhone.Text + "'");
                MySqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    custId = data.GetString(0).ToString();
                }
                if (reference != "")
                {
                    reference += " AND";
                }
                Console.WriteLine(custId);
                reference += " custId='" + custId + "'";
            }
            if (cboOrderStatus.SelectedItem != null && cboOrderStatus.SelectedIndex != 0)
            {
                if (reference != "")
                {
                    reference += " AND";
                }
                reference += " status='" + cboOrderStatus.SelectedItem.ToString() + "'";
            }
            String startDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
            startDate += " 00:00:00";
            String endDate = dtpEndDate.Value.ToString("yyyy-MM-dd");
            endDate += " 23:59:59";
            if (reference != "")
            {
                reference += " AND";
            }
            reference += " date>='" + startDate + "' and date<='" + endDate + "'";
            if (reference != "")
            {
                String sql = "select * from dbOPSRS.order where " + reference;
                MySqlCommand cmd = Program.ExecSQL(sql);
                MySqlDataReader data = cmd.ExecuteReader();

                lvResult_order.Items.Clear();

                while (data.Read())
                {
                    ListViewItem lv = new ListViewItem(data.GetString(0).ToString());
                    lv.SubItems.Add(data.GetString(1).ToString());
                    lv.SubItems.Add(data.GetString(2).ToString());
                    lv.SubItems.Add(data.GetString(3).ToString());
                    lv.SubItems.Add(data.GetDateTime(4).ToString("dd/MM/yyyy"));
                    lv.SubItems.Add(data.GetDateTime(5).ToString("dd/MM/yyyy"));
                    lv.SubItems.Add(data.GetString(6).ToString());
                    lv.SubItems.Add("$" + data.GetString(7).ToString());
                    if (!data.IsDBNull(8))
                    {
                        lv.SubItems.Add(data.GetString(8).ToString());
                    }
                    lvResult_order.Items.Add(lv);
                }

                data.Close();
                cmd.Dispose();
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            lvResult_order.Items.Clear();
            txtOrderId.Clear();
            txtStaffId.Clear();
            txtCustId.Clear();
            txtCustPhone.Clear();
            cboOrderStatus.SelectedItem = null;
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
        }

        private void DtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            dtpStartDate.MaxDate = dtpEndDate.Value;
        }

        private void LvResult_order_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (control.hasPermission(210))
            {
                currentItem = lvResult_order.GetItemAt(e.X, e.Y);

                if (currentItem != null)
                {
                    String orderId = currentItem.Text;
                    FormEditOrder editOrder = new FormEditOrder(orderId);
                    editOrder.ShowDialog();
                    BtnSearch_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("You do not have permission to edit order.");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGenIN_Click(object sender, EventArgs e)
        {
            if (currentItem != null)
            {
                String orderId = currentItem.Text;
                String status = currentItem.SubItems[3].Text;

                if (status == "Finish" || status == "Shipping")
                {

                    String sql = String.Format("SELECT * FROM dbOPSRS.order WHERE orderId = '{0}'", orderId);
                    MySqlCommand cmd = Program.ExecSQL(sql);
                    MySqlDataReader dataOrder = cmd.ExecuteReader();
                    while (dataOrder.Read())
                    {
                        Document invoice = new Document(PageSize.A4, 36, 72, 100, 100);
                        try
                        {
                            FileStream fs = new FileStream(@"Z:\OneDrive - Vocational Training Council\SDP\Invoice_" + dataOrder.GetString("orderId") + ".pdf", FileMode.Create);
                            PdfWriter.GetInstance(invoice, fs);
                            Paragraph p = new Paragraph("Smart & Luxury Motor Company (Spares)", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 20f));
                            invoice.Open();
                            invoice.Add(p);
                            invoice.Add(new Paragraph("3 King Ling Road Tseung Kwan O, New Territories"));
                            invoice.Add(new Paragraph("Tel: 3928 2000 Fax: 3928 2024 Email: cs-dilwl@vtc.edu.hk"));
                            invoice.Add(new Paragraph("Invoice", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 20f)));
                            invoice.AddTitle("Invoice: [Order ID:" + dataOrder.GetString("orderId") + "]");    //文件標題
                            invoice.AddAuthor(dataOrder.GetString("staffId"));   //文件作者

                            PdfPTable address = new PdfPTable(1);
                            float[] columnDefinitionSize = { 150F };
                            address.SetTotalWidth(columnDefinitionSize);
                            address.HorizontalAlignment = 0;
                            address.DefaultCell.BorderColor = BaseColor.WHITE;
                            address.LockedWidth = true;

                            sql = String.Format("SELECT * FROM customer WHERE custId = '{0}'", dataOrder.GetString("custId"));
                            cmd = Program.ExecSQL(sql);
                            MySqlDataReader data = cmd.ExecuteReader();
                            while (data.Read())
                            {
                                address.AddCell(new Phrase("Bill To:"));
                                address.AddCell(new Phrase(data.GetString("custName")));
                                address.AddCell(new Phrase(data.GetString("companyName")));
                                address.AddCell(new Phrase(data.GetString("address")));
                                address.AddCell(new Phrase(data.GetString("phone")));
                                address.AddCell(new Phrase(data.GetString("email")));
                            }

                            invoice.Add(address);

                            PdfPTable info = new PdfPTable(1);
                            info.SetTotalWidth(columnDefinitionSize);
                            info.HorizontalAlignment = 2;
                            info.DefaultCell.BorderColor = BaseColor.WHITE;
                            info.LockedWidth = true;
                            info.AddCell(new Phrase("Order Date: " + dataOrder.GetDateTime("date").ToString("dd/MM/yyyy")));
                            info.AddCell(new Phrase("Invoice number: " + orderId));
                            info.AddCell(new Phrase("Invoice Date: " + DateTime.Now.ToString("dd/MM/yyyy")));
                            info.AddCell(new Phrase("Due Date: " + DateTime.Now.AddDays(14).ToString("dd/MM/yyyy") + "\n"));

                            invoice.Add(info);

                            PdfPTable table = new PdfPTable(4);
                            table.HorizontalAlignment = 1;      //0=Left, 1=Centre, 2=Right
                            table.AddCell("Description");
                            table.AddCell("Quantity");
                            table.AddCell("Unit Price");
                            table.AddCell("Amount");

                            sql = String.Format("SELECT * FROM `orderProduct`, product WHERE orderId= {0} AND orderProduct.productId = product.productId", orderId);
                            cmd = Program.ExecSQL(sql);
                            MySqlDataReader dataProduct = cmd.ExecuteReader();
                            while (dataProduct.Read())
                            {
                                table.AddCell(dataProduct.GetString("productName"));
                                table.AddCell(dataProduct.GetString("qty"));
                                table.AddCell("$" + dataProduct.GetString("price"));
                                double total = (dataProduct.GetDouble("qty") * dataProduct.GetDouble("price"));
                                table.AddCell(new Phrase("$" + total.ToString()));
                            }
                            PdfPCell bottom = new PdfPCell(new Phrase(""));
                            bottom.Colspan = 2;
                            table.AddCell(bottom);
                            table.AddCell("Total Amount:");
                            table.AddCell("$" + dataOrder.GetString("totalAmount"));

                            invoice.Add(table);

                            PdfPTable remark = new PdfPTable(1);
                            remark.HorizontalAlignment = 1;
                            remark.AddCell("Remark: ");
                            try
                            {
                                remark.AddCell(dataOrder.GetString("remark"));
                            }
                            catch
                            {
                                remark.AddCell(" ");
                            }

                            invoice.Add(remark);

                            Paragraph end1 = new Paragraph("If you have any questions about this invoice, Please feel free to contact us.");
                            Paragraph end2 = new Paragraph("Thank you for Your Business!");
                            end1.Alignment = 1;
                            end2.Alignment = 1;

                            invoice.Add(end1);
                            invoice.Add(end2);

                            Paragraph sign1 = new Paragraph("Sign: \n\n\n", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 20f));
                            Paragraph sign2 = new Paragraph("_____________________________________________");
                            sign1.Alignment = 0;
                            sign2.Alignment = 0;

                            invoice.Add(sign1);
                            invoice.Add(sign2);

                            MessageBox.Show("Invoice output successfully.");
                            invoice.Close();
                            fs.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);

                            MessageBox.Show("Please try again.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("The order status must be Shipping or Finish!");
                }
            }
            else
            {
                MessageBox.Show("Please select a order.");
            }


        }

        private void LvResult_order_MouseClick(object sender, MouseEventArgs e)
        {
            currentItem = lvResult_order.GetItemAt(e.X, e.Y);
        }

        private void BtnGenDIS_Click(object sender, EventArgs e)
        {
            if (currentItem != null)
            {
                String orderId = currentItem.Text;
                String status = currentItem.SubItems[3].Text;

                if (status == "Shipping")
                {

                    String sql = String.Format("SELECT * FROM dbOPSRS.order WHERE orderId = '{0}'", orderId);
                    MySqlCommand cmd = Program.ExecSQL(sql);
                    MySqlDataReader dataOrder = cmd.ExecuteReader();
                    while (dataOrder.Read())
                    {
                        Document DIS = new Document(PageSize.A4, 36, 72, 100, 100);
                        try
                        {
                            FileStream fs = new FileStream(@"Z:\OneDrive - Vocational Training Council\SDP\DIS_" + dataOrder.GetString("orderId") + ".pdf", FileMode.Create);
                            PdfWriter.GetInstance(DIS, fs);
                            Paragraph p = new Paragraph("Smart & Luxury Motor Company (Spares)", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 20f));
                            DIS.Open();
                            DIS.Add(p);
                            DIS.Add(new Paragraph("3 King Ling Road Tseung Kwan O, New Territories"));
                            DIS.Add(new Paragraph("Tel: 3928 2000 Fax: 3928 2024 Email: cs-dilwl@vtc.edu.hk"));
                            DIS.Add(new Paragraph("DIS", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 20f)));
                            DIS.AddTitle("DIS: [Order ID:" + dataOrder.GetString("orderId") + "]");    //文件標題
                            DIS.AddAuthor(dataOrder.GetString("staffId"));   //文件作者

                            PdfPTable address = new PdfPTable(1);
                            float[] columnDefinitionSize = { 150F };
                            address.SetTotalWidth(columnDefinitionSize);
                            address.HorizontalAlignment = 0;
                            address.DefaultCell.BorderColor = BaseColor.WHITE;
                            address.LockedWidth = true;

                            sql = String.Format("SELECT * FROM customer WHERE custId = '{0}'", dataOrder.GetString("custId"));
                            cmd = Program.ExecSQL(sql);
                            MySqlDataReader data = cmd.ExecuteReader();
                            while (data.Read())
                            {
                                address.AddCell(new Phrase("Bill To:"));
                                address.AddCell(new Phrase(data.GetString("custName")));
                                address.AddCell(new Phrase(data.GetString("companyName")));
                                address.AddCell(new Phrase(data.GetString("address")));
                                address.AddCell(new Phrase(data.GetString("phone")));
                                address.AddCell(new Phrase(data.GetString("email")));
                            }

                            DIS.Add(address);

                            PdfPTable info = new PdfPTable(1);
                            info.SetTotalWidth(columnDefinitionSize);
                            info.HorizontalAlignment = 2;
                            info.DefaultCell.BorderColor = BaseColor.WHITE;
                            info.LockedWidth = true;
                            info.AddCell(new Phrase("Order Date: " + dataOrder.GetDateTime("date").ToString("dd/MM/yyyy")));
                            info.AddCell(new Phrase("DIS number: " + orderId));
                            info.AddCell(new Phrase("DIS Date: " + DateTime.Now.ToString("dd/MM/yyyy")));
                            info.AddCell(new Phrase("Due Date: " + DateTime.Now.AddDays(14).ToString("dd/MM/yyyy") + "\n"));

                            DIS.Add(info);

                            PdfPTable table = new PdfPTable(4);
                            table.HorizontalAlignment = 1;      //0=Left, 1=Centre, 2=Right
                            table.AddCell("Description");
                            table.AddCell("Quantity");
                            table.AddCell("Unit Price");
                            table.AddCell("Amount");

                            sql = String.Format("SELECT * FROM `orderProduct`, product WHERE orderId= {0} AND orderProduct.productId = product.productId", orderId);
                            cmd = Program.ExecSQL(sql);
                            MySqlDataReader dataProduct = cmd.ExecuteReader();
                            while (dataProduct.Read())
                            {
                                table.AddCell(dataProduct.GetString("productName"));
                                table.AddCell(dataProduct.GetString("qty"));
                                table.AddCell("$" + dataProduct.GetString("price"));
                                double total = (dataProduct.GetDouble("qty") * dataProduct.GetDouble("price"));
                                table.AddCell(new Phrase("$" + total.ToString()));
                            }
                            PdfPCell bottom = new PdfPCell(new Phrase(""));
                            bottom.Colspan = 2;
                            table.AddCell(bottom);
                            table.AddCell("Total Amount:");
                            table.AddCell("$" + dataOrder.GetString("totalAmount"));

                            DIS.Add(table);

                            PdfPTable remark = new PdfPTable(1);
                            remark.HorizontalAlignment = 1;
                            remark.AddCell("Remark: ");
                            try
                            {
                                remark.AddCell(dataOrder.GetString("remark"));
                            }
                            catch
                            {
                                remark.AddCell(" ");
                            }

                            DIS.Add(remark);

                            Paragraph end1 = new Paragraph("If you have any questions about this DIS, Please feel free to contact us.");
                            Paragraph end2 = new Paragraph("Thank you for Your Business!");
                            end1.Alignment = 1;
                            end2.Alignment = 1;

                            DIS.Add(end1);
                            DIS.Add(end2);

                            Paragraph sign1 = new Paragraph("Sign: \n\n\n", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 20f));
                            Paragraph sign2 = new Paragraph("_____________________________________________");
                            sign1.Alignment = 0;
                            sign2.Alignment = 0;

                            DIS.Add(sign1);
                            DIS.Add(sign2);

                            MessageBox.Show("DIS output successfully.");
                            DIS.Close();
                            fs.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);

                            MessageBox.Show("Please try again.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("The order status must be Shipping!");
                }
            }
            else
            {
                MessageBox.Show("Please select a order.");
            }

        }
    }
}
