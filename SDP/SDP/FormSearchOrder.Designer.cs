namespace SDP
{
    partial class FormSearchOrder
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
            this.lblOrderId = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lvResult_order = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.txtStaffId = new System.Windows.Forms.TextBox();
            this.lblSID = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.cboOrderStatus = new System.Windows.Forms.ComboBox();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnGenDIS = new System.Windows.Forms.Button();
            this.btnGenIN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCompany.Location = new System.Drawing.Point(414, 396);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(399, 24);
            this.lblCompany.TabIndex = 144;
            this.lblCompany.Text = "Smart && Luxury Motor Company (Spares)";
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(114, 237);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(50, 12);
            this.lblOrderId.TabIndex = 148;
            this.lblOrderId.Text = "Order ID:";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(197, 235);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(200, 22);
            this.txtOrderId.TabIndex = 0;
            this.txtOrderId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(197, 328);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(522, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lvResult_order
            // 
            this.lvResult_order.HideSelection = false;
            this.lvResult_order.Location = new System.Drawing.Point(20, 72);
            this.lvResult_order.Name = "lvResult_order";
            this.lvResult_order.Size = new System.Drawing.Size(806, 132);
            this.lvResult_order.TabIndex = 156;
            this.lvResult_order.UseCompatibleStateImageBehavior = false;
            this.lvResult_order.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LvResult_order_MouseClick);
            this.lvResult_order.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvResult_order_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 290);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 157;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(114, 303);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(59, 12);
            this.lblOrderDate.TabIndex = 158;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Location = new System.Drawing.Point(114, 276);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(65, 12);
            this.lblOrderStatus.TabIndex = 160;
            this.lblOrderStatus.Text = "Order Status:";
            // 
            // txtStaffId
            // 
            this.txtStaffId.Location = new System.Drawing.Point(197, 256);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(200, 22);
            this.txtStaffId.TabIndex = 1;
            this.txtStaffId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // lblSID
            // 
            this.lblSID.AutoSize = true;
            this.lblSID.Location = new System.Drawing.Point(114, 257);
            this.lblSID.Name = "lblSID";
            this.lblSID.Size = new System.Drawing.Size(45, 12);
            this.lblSID.TabIndex = 162;
            this.lblSID.Text = "Staff ID:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(197, 300);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpStartDate.TabIndex = 5;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(418, 301);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEndDate.TabIndex = 6;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.DtpEndDate_ValueChanged);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(399, 303);
            this.lblTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(14, 12);
            this.lblTo.TabIndex = 168;
            this.lblTo.Text = "to";
            // 
            // cboOrderStatus
            // 
            this.cboOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderStatus.FormattingEnabled = true;
            this.cboOrderStatus.Items.AddRange(new object[] {
            "            ",
            "Creation",
            "Reservation",
            "Shipping",
            "Deletion",
            "Finish"});
            this.cboOrderStatus.Location = new System.Drawing.Point(197, 275);
            this.cboOrderStatus.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cboOrderStatus.Name = "cboOrderStatus";
            this.cboOrderStatus.Size = new System.Drawing.Size(200, 20);
            this.cboOrderStatus.TabIndex = 2;
            // 
            // txtCustId
            // 
            this.txtCustId.Location = new System.Drawing.Point(505, 256);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(200, 22);
            this.txtCustId.TabIndex = 3;
            this.txtCustId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 170;
            this.label2.Text = "Customer ID:";
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Location = new System.Drawing.Point(505, 275);
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(200, 22);
            this.txtCustPhone.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 172;
            this.label3.Text = "Customer Tel:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(441, 328);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnGenDIS
            // 
            this.btnGenDIS.Location = new System.Drawing.Point(278, 328);
            this.btnGenDIS.Name = "btnGenDIS";
            this.btnGenDIS.Size = new System.Drawing.Size(75, 23);
            this.btnGenDIS.TabIndex = 8;
            this.btnGenDIS.Text = "Gen. DIS";
            this.btnGenDIS.UseVisualStyleBackColor = true;
            // 
            // btnGenIN
            // 
            this.btnGenIN.Location = new System.Drawing.Point(360, 328);
            this.btnGenIN.Name = "btnGenIN";
            this.btnGenIN.Size = new System.Drawing.Size(75, 23);
            this.btnGenIN.TabIndex = 9;
            this.btnGenIN.Text = "Gen. Invoice";
            this.btnGenIN.UseVisualStyleBackColor = true;
            this.btnGenIN.Click += new System.EventHandler(this.BtnGenIN_Click);
            // 
            // FormSearchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.btnGenIN);
            this.Controls.Add(this.btnGenDIS);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtCustPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboOrderStatus);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.txtStaffId);
            this.Controls.Add(this.lblSID);
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvResult_order);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.lblOrderId);
            this.Controls.Add(this.lblCompany);
            this.Name = "FormSearchOrder";
            this.Text = "Search order";
            this.Load += new System.EventHandler(this.FormSearchOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView lvResult_order;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.Label lblSID;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.ComboBox cboOrderStatus;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustPhone;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGenDIS;
        private System.Windows.Forms.Button btnGenIN;
    }
}