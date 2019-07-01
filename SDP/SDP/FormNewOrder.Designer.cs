namespace SDP
{
    partial class FormNewOrder
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
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtShipAddr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.choShipAddr = new System.Windows.Forms.CheckBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtStaffId = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpDelivery = new System.Windows.Forms.DateTimePicker();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lvResult = new System.Windows.Forms.ListView();
            this.txtHide = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCompany.Location = new System.Drawing.Point(414, 496);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(399, 24);
            this.lblCompany.TabIndex = 144;
            this.lblCompany.Text = "Smart && Luxury Motor Company (Spares)";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(121, 12);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(200, 22);
            this.txtNumber.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 12);
            this.label15.TabIndex = 160;
            this.label15.Text = "Order number:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 159;
            this.label12.Text = "Order Status:";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Creation",
            "Reservation"});
            this.cboStatus.Location = new System.Drawing.Point(121, 40);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(200, 20);
            this.cboStatus.TabIndex = 1;
            // 
            // txtShipAddr
            // 
            this.txtShipAddr.Location = new System.Drawing.Point(121, 148);
            this.txtShipAddr.Name = "txtShipAddr";
            this.txtShipAddr.Size = new System.Drawing.Size(200, 22);
            this.txtShipAddr.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 12);
            this.label7.TabIndex = 156;
            this.label7.Text = "Shipping Address:";
            // 
            // choShipAddr
            // 
            this.choShipAddr.AutoSize = true;
            this.choShipAddr.Location = new System.Drawing.Point(336, 122);
            this.choShipAddr.Name = "choShipAddr";
            this.choShipAddr.Size = new System.Drawing.Size(106, 16);
            this.choShipAddr.TabIndex = 155;
            this.choShipAddr.Text = "Shipping Address";
            this.choShipAddr.UseVisualStyleBackColor = true;
            this.choShipAddr.Click += new System.EventHandler(this.ChoShipAddr_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(121, 206);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 22);
            this.txtPhone.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(121, 176);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(121, 120);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(200, 22);
            this.txtAddr.TabIndex = 4;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(121, 94);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(200, 22);
            this.txtCompany.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 12);
            this.label6.TabIndex = 149;
            this.label6.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 148;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 147;
            this.label4.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 146;
            this.label2.Text = "Company:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 145;
            this.label1.Text = "Name:";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.Info;
            this.txtDate.Location = new System.Drawing.Point(626, 12);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(200, 22);
            this.txtDate.TabIndex = 165;
            // 
            // txtStaffId
            // 
            this.txtStaffId.Location = new System.Drawing.Point(626, 40);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.ReadOnly = true;
            this.txtStaffId.Size = new System.Drawing.Size(200, 22);
            this.txtStaffId.TabIndex = 164;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(523, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 12);
            this.label16.TabIndex = 163;
            this.label16.Text = "Staff ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(523, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 162;
            this.label11.Text = "Date:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(523, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 12);
            this.label14.TabIndex = 167;
            this.label14.Text = "Delivery day:";
            // 
            // dtpDelivery
            // 
            this.dtpDelivery.Location = new System.Drawing.Point(626, 69);
            this.dtpDelivery.Name = "dtpDelivery";
            this.dtpDelivery.Size = new System.Drawing.Size(200, 22);
            this.dtpDelivery.TabIndex = 8;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(626, 182);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(200, 22);
            this.txtKeyword.TabIndex = 13;
            this.txtKeyword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtKeyword_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(523, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 12);
            this.label10.TabIndex = 175;
            this.label10.Text = "Keyword:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(523, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 12);
            this.label9.TabIndex = 174;
            this.label9.Text = "Qty:";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(626, 125);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(200, 22);
            this.txtQty.TabIndex = 10;
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtQty_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(626, 210);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(707, 153);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(626, 97);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(200, 22);
            this.txtProductID.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(523, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 169;
            this.label8.Text = "Product ID:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(626, 153);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(626, 377);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(200, 22);
            this.txtAmount.TabIndex = 179;
            this.txtAmount.Text = "$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(523, 380);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 12);
            this.label13.TabIndex = 178;
            this.label13.Text = "Total Amount:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 387);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 12);
            this.label17.TabIndex = 181;
            this.label17.Text = "Remark:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(101, 475);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(20, 475);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.ForeColor = System.Drawing.Color.Silver;
            this.txtRemark.Location = new System.Drawing.Point(20, 402);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(806, 67);
            this.txtRemark.TabIndex = 16;
            this.txtRemark.Text = "Remark";
            this.txtRemark.Enter += new System.EventHandler(this.TxtRemark_Enter);
            this.txtRemark.Leave += new System.EventHandler(this.TxtRemark_Leave);
            // 
            // lvResult
            // 
            this.lvResult.HideSelection = false;
            this.lvResult.Location = new System.Drawing.Point(20, 239);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(806, 132);
            this.lvResult.TabIndex = 191;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvResult_MouseDoubleClick);
            // 
            // txtHide
            // 
            this.txtHide.Location = new System.Drawing.Point(368, 210);
            this.txtHide.Name = "txtHide";
            this.txtHide.Size = new System.Drawing.Size(200, 22);
            this.txtHide.TabIndex = 15;
            this.txtHide.Visible = false;
            this.txtHide.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHide_KeyPress);
            // 
            // FormNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 541);
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
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtStaffId);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtShipAddr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddr);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choShipAddr);
            this.Controls.Add(this.lblCompany);
            this.Name = "FormNewOrder";
            this.Text = "New order";
            this.Load += new System.EventHandler(this.FormNewOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtShipAddr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox choShipAddr;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpDelivery;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.ListView lvResult;
        private System.Windows.Forms.TextBox txtHide;
    }
}