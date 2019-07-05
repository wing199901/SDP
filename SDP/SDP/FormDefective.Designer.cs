namespace SDP
{
    partial class FormDefective
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
            this.lblDid = new System.Windows.Forms.Label();
            this.txtDid = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSid = new System.Windows.Forms.Label();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.lblPID = new System.Windows.Forms.Label();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.lblQTY = new System.Windows.Forms.Label();
            this.txtQTY = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpDefective = new System.Windows.Forms.DateTimePicker();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDid
            // 
            this.lblDid.AutoSize = true;
            this.lblDid.Location = new System.Drawing.Point(114, 41);
            this.lblDid.Name = "lblDid";
            this.lblDid.Size = new System.Drawing.Size(67, 12);
            this.lblDid.TabIndex = 0;
            this.lblDid.Text = "Defective ID:";
            // 
            // txtDid
            // 
            this.txtDid.Location = new System.Drawing.Point(204, 38);
            this.txtDid.Name = "txtDid";
            this.txtDid.Size = new System.Drawing.Size(200, 22);
            this.txtDid.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(114, 86);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(29, 12);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // lblSid
            // 
            this.lblSid.AutoSize = true;
            this.lblSid.Location = new System.Drawing.Point(114, 123);
            this.lblSid.Name = "lblSid";
            this.lblSid.Size = new System.Drawing.Size(45, 12);
            this.lblSid.TabIndex = 4;
            this.lblSid.Text = "Staff ID:";
            // 
            // txtSid
            // 
            this.txtSid.Location = new System.Drawing.Point(204, 120);
            this.txtSid.Name = "txtSid";
            this.txtSid.Size = new System.Drawing.Size(200, 22);
            this.txtSid.TabIndex = 2;
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Location = new System.Drawing.Point(114, 164);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(59, 12);
            this.lblPID.TabIndex = 6;
            this.lblPID.Text = "Product ID:";
            // 
            // txtSKU
            // 
            this.txtSKU.Location = new System.Drawing.Point(204, 161);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(200, 22);
            this.txtSKU.TabIndex = 3;
            // 
            // lblQTY
            // 
            this.lblQTY.AutoSize = true;
            this.lblQTY.Location = new System.Drawing.Point(114, 205);
            this.lblQTY.Name = "lblQTY";
            this.lblQTY.Size = new System.Drawing.Size(48, 12);
            this.lblQTY.TabIndex = 8;
            this.lblQTY.Text = "Quantity:";
            // 
            // txtQTY
            // 
            this.txtQTY.Location = new System.Drawing.Point(204, 202);
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.Size = new System.Drawing.Size(200, 22);
            this.txtQTY.TabIndex = 4;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(435, 41);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(54, 12);
            this.lblReason.TabIndex = 10;
            this.lblReason.Text = "Reason(s):";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(435, 123);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(45, 12);
            this.lblRemark.TabIndex = 12;
            this.lblRemark.Text = "Remark:";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(526, 120);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(200, 67);
            this.txtRemark.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(116, 377);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(269, 377);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // dtpDefective
            // 
            this.dtpDefective.Location = new System.Drawing.Point(204, 79);
            this.dtpDefective.Name = "dtpDefective";
            this.dtpDefective.Size = new System.Drawing.Size(200, 22);
            this.dtpDefective.TabIndex = 1;
            this.dtpDefective.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DtpDefective_KeyDown);
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(526, 38);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(200, 67);
            this.txtReason.TabIndex = 5;
            // 
            // FormDefective
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.dtpDefective);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.txtQTY);
            this.Controls.Add(this.lblQTY);
            this.Controls.Add(this.txtSKU);
            this.Controls.Add(this.lblPID);
            this.Controls.Add(this.txtSid);
            this.Controls.Add(this.lblSid);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtDid);
            this.Controls.Add(this.lblDid);
            this.Name = "FormDefective";
            this.Text = "s";
            this.Load += new System.EventHandler(this.FormDefective_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDid;
        private System.Windows.Forms.TextBox txtDid;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSid;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.Label lblQTY;
        private System.Windows.Forms.TextBox txtQTY;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpDefective;
        private System.Windows.Forms.TextBox txtReason;
    }
}