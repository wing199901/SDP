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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.txtStaffId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.cboOrderStatus = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCompany.Location = new System.Drawing.Point(828, 825);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(800, 48);
            this.lblCompany.TabIndex = 144;
            this.lblCompany.Text = "Smart && Luxury Motor Company (Spares)";
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(227, 493);
            this.lblOrderId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(98, 25);
            this.lblOrderId.TabIndex = 148;
            this.lblOrderId.Text = "Order ID:";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(394, 490);
            this.txtOrderId.Margin = new System.Windows.Forms.Padding(6);
            this.txtOrderId.Multiline = true;
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(396, 31);
            this.txtOrderId.TabIndex = 151;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(394, 684);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 48);
            this.btnSearch.TabIndex = 154;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(574, 684);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 48);
            this.btnCancel.TabIndex = 155;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(40, 150);
            this.listView1.Margin = new System.Windows.Forms.Padding(6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1608, 271);
            this.listView1.TabIndex = 156;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(892, 604);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 157;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(227, 633);
            this.lblOrderDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(123, 25);
            this.lblOrderDate.TabIndex = 158;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Location = new System.Drawing.Point(227, 585);
            this.lblOrderStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(139, 25);
            this.lblOrderStatus.TabIndex = 160;
            this.lblOrderStatus.Text = "Order Status:";
            // 
            // txtStaffId
            // 
            this.txtStaffId.Location = new System.Drawing.Point(394, 536);
            this.txtStaffId.Margin = new System.Windows.Forms.Padding(6);
            this.txtStaffId.Multiline = true;
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(396, 31);
            this.txtStaffId.TabIndex = 163;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 539);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 162;
            this.label4.Text = "Staff ID:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(394, 628);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(396, 31);
            this.dtpStartDate.TabIndex = 165;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(832, 628);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(396, 31);
            this.dtpEndDate.TabIndex = 166;
            // 
            // cboOrderStatus
            // 
            this.cboOrderStatus.FormattingEnabled = true;
            this.cboOrderStatus.Items.AddRange(new object[] {
            "Creation",
            "Reservation",
            "Shipping",
            "Deletion",
            "Finish"});
            this.cboOrderStatus.Location = new System.Drawing.Point(394, 582);
            this.cboOrderStatus.Name = "cboOrderStatus";
            this.cboOrderStatus.Size = new System.Drawing.Size(396, 33);
            this.cboOrderStatus.TabIndex = 167;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(796, 633);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(30, 25);
            this.lblTo.TabIndex = 168;
            this.lblTo.Text = "to";
            // 
            // FormSearchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1676, 919);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.cboOrderStatus);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.txtStaffId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.lblOrderId);
            this.Controls.Add(this.lblCompany);
            this.Margin = new System.Windows.Forms.Padding(6);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.ComboBox cboOrderStatus;
        private System.Windows.Forms.Label lblTo;
    }
}