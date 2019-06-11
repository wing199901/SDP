namespace SDP
{
    partial class FormGenerate
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
            this.lblReport = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCompany.Location = new System.Drawing.Point(414, 396);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(399, 24);
            this.lblCompany.TabIndex = 144;
            this.lblCompany.Text = "Smart && Luxury Motor Company (Spares)";
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Location = new System.Drawing.Point(76, 58);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(67, 12);
            this.lblReport.TabIndex = 145;
            this.lblReport.Text = "Report Type:";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(168, 55);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 20);
            this.cboType.TabIndex = 146;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(168, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 147;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(76, 107);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(53, 12);
            this.lblStart.TabIndex = 148;
            this.lblStart.Text = "Start Date:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(411, 107);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(18, 12);
            this.lblTo.TabIndex = 149;
            this.lblTo.Text = "To";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(483, 107);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(51, 12);
            this.lblEnd.TabIndex = 150;
            this.lblEnd.Text = "End Date:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(560, 100);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 151;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(20, 190);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(806, 132);
            this.listView1.TabIndex = 152;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FormGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.lblCompany);
            this.Name = "FormGenerate";
            this.Text = "Generate report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ListView listView1;
    }
}