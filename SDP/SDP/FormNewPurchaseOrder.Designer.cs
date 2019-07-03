namespace SDP
{
    partial class FormNewPurchaseOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHide = new System.Windows.Forms.TextBox();
            this.lvResult = new System.Windows.Forms.ListView();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpDelivery = new System.Windows.Forms.DateTimePicker();
            this.txtStaffId = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.dtpDay = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtHide
            // 
            this.txtHide.Location = new System.Drawing.Point(714, 337);
            this.txtHide.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtHide.Name = "txtHide";
            this.txtHide.Size = new System.Drawing.Size(396, 31);
            this.txtHide.TabIndex = 208;
            this.txtHide.Visible = false;
            this.txtHide.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHide_KeyPress);
            // 
            // lvResult
            // 
            this.lvResult.HideSelection = false;
            this.lvResult.Location = new System.Drawing.Point(34, 506);
            this.lvResult.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(1608, 271);
            this.lvResult.TabIndex = 232;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvResult_MouseDoubleClick);
            // 
            // txtRemark
            // 
            this.txtRemark.ForeColor = System.Drawing.Color.Silver;
            this.txtRemark.Location = new System.Drawing.Point(34, 846);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(1608, 135);
            this.txtRemark.TabIndex = 209;
            this.txtRemark.Text = "Remark";
            this.txtRemark.Enter += new System.EventHandler(this.TxtRemark_Enter);
            this.txtRemark.Leave += new System.EventHandler(this.TxtRemark_Leave);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(196, 998);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 48);
            this.btnCancel.TabIndex = 211;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(34, 998);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 48);
            this.btnSubmit.TabIndex = 210;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(30, 815);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 25);
            this.label17.TabIndex = 231;
            this.label17.Text = "Remark:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(1246, 794);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(396, 31);
            this.txtAmount.TabIndex = 230;
            this.txtAmount.Text = "$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1040, 800);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 25);
            this.label13.TabIndex = 229;
            this.label13.Text = "Total Amount:";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(1246, 202);
            this.txtKeyword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(396, 31);
            this.txtKeyword.TabIndex = 206;
            this.txtKeyword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtKeyword_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1040, 208);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 25);
            this.label10.TabIndex = 228;
            this.label10.Text = "Keyword:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1040, 90);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 25);
            this.label9.TabIndex = 227;
            this.label9.Text = "Qty:";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(1246, 83);
            this.txtQty.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(396, 31);
            this.txtQty.TabIndex = 203;
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtQty_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1246, 265);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 48);
            this.btnSearch.TabIndex = 207;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1408, 142);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 48);
            this.btnDelete.TabIndex = 205;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(1246, 25);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(396, 31);
            this.txtProductID.TabIndex = 202;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1040, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 25);
            this.label8.TabIndex = 226;
            this.label8.Text = "Product ID:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1246, 142);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 48);
            this.btnAdd.TabIndex = 204;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 344);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 25);
            this.label14.TabIndex = 225;
            this.label14.Text = "Delivery day:";
            // 
            // dtpDelivery
            // 
            this.dtpDelivery.Location = new System.Drawing.Point(236, 329);
            this.dtpDelivery.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpDelivery.Name = "dtpDelivery";
            this.dtpDelivery.Size = new System.Drawing.Size(396, 31);
            this.dtpDelivery.TabIndex = 201;
            // 
            // txtStaffId
            // 
            this.txtStaffId.Location = new System.Drawing.Point(236, 269);
            this.txtStaffId.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.ReadOnly = true;
            this.txtStaffId.Size = new System.Drawing.Size(396, 31);
            this.txtStaffId.TabIndex = 223;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 275);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 25);
            this.label16.TabIndex = 222;
            this.label16.Text = "Staff ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 217);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 25);
            this.label11.TabIndex = 221;
            this.label11.Text = "Date:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(236, 33);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(396, 31);
            this.txtNumber.TabIndex = 192;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 40);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(150, 25);
            this.label15.TabIndex = 220;
            this.label15.Text = "Order number:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 98);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 25);
            this.label12.TabIndex = 219;
            this.label12.Text = "Order Status:";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Creation"});
            this.cboStatus.Location = new System.Drawing.Point(236, 92);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(396, 33);
            this.cboStatus.TabIndex = 193;
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(236, 146);
            this.txtAddr.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(396, 31);
            this.txtAddr.TabIndex = 196;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 215;
            this.label4.Text = "Address:";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCompany.Location = new System.Drawing.Point(822, 1042);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(800, 48);
            this.lblCompany.TabIndex = 212;
            this.lblCompany.Text = "Smart && Luxury Motor Company (Spares)";
            // 
            // dtpDay
            // 
            this.dtpDay.Location = new System.Drawing.Point(236, 202);
            this.dtpDay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpDay.Name = "dtpDay";
            this.dtpDay.Size = new System.Drawing.Size(396, 31);
            this.dtpDay.TabIndex = 233;
            // 
            // FormNewPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1676, 1127);
            this.Controls.Add(this.dtpDay);
            this.Controls.Add(this.txtHide);
            this.Controls.Add(this.lvResult);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dtpDelivery);
            this.Controls.Add(this.txtStaffId);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtAddr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCompany);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormNewPurchaseOrder";
            this.Text = "New Purchase Order";
            this.Load += new System.EventHandler(this.FormNewPurchaseOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHide;
        private System.Windows.Forms.ListView lvResult;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpDelivery;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.DateTimePicker dtpDay;
    }
}