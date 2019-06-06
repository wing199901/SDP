namespace SDP
{
    partial class FormMenu
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
            this.btnROL = new System.Windows.Forms.Button();
            this.btnGoods = new System.Windows.Forms.Button();
            this.btnGenReport = new System.Windows.Forms.Button();
            this.btnDefective = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.lblCompany = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnROL
            // 
            this.btnROL.Location = new System.Drawing.Point(26, 324);
            this.btnROL.Name = "btnROL";
            this.btnROL.Size = new System.Drawing.Size(93, 23);
            this.btnROL.TabIndex = 153;
            this.btnROL.Text = "Correct ROL";
            this.btnROL.UseVisualStyleBackColor = true;
            // 
            // btnGoods
            // 
            this.btnGoods.Location = new System.Drawing.Point(26, 232);
            this.btnGoods.Name = "btnGoods";
            this.btnGoods.Size = new System.Drawing.Size(93, 23);
            this.btnGoods.TabIndex = 152;
            this.btnGoods.Text = "Receive Goods";
            this.btnGoods.UseVisualStyleBackColor = true;
            // 
            // btnGenReport
            // 
            this.btnGenReport.Location = new System.Drawing.Point(26, 278);
            this.btnGenReport.Name = "btnGenReport";
            this.btnGenReport.Size = new System.Drawing.Size(93, 23);
            this.btnGenReport.TabIndex = 151;
            this.btnGenReport.Text = "Generate Report";
            this.btnGenReport.UseVisualStyleBackColor = true;
            // 
            // btnDefective
            // 
            this.btnDefective.Location = new System.Drawing.Point(26, 140);
            this.btnDefective.Name = "btnDefective";
            this.btnDefective.Size = new System.Drawing.Size(93, 23);
            this.btnDefective.TabIndex = 150;
            this.btnDefective.Text = "Report Defective";
            this.btnDefective.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(26, 370);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(93, 23);
            this.btnLogout.TabIndex = 149;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(26, 186);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(93, 23);
            this.btnStock.TabIndex = 148;
            this.btnStock.Text = "Search Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.Location = new System.Drawing.Point(26, 94);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(93, 23);
            this.btnSearchOrder.TabIndex = 147;
            this.btnSearchOrder.Text = "Search Order";
            this.btnSearchOrder.UseVisualStyleBackColor = true;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(26, 48);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(93, 23);
            this.btnNewOrder.TabIndex = 146;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.BtnNewOrder_Click);
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
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.btnROL);
            this.Controls.Add(this.btnGoods);
            this.Controls.Add(this.btnGenReport);
            this.Controls.Add(this.btnDefective);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnSearchOrder);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.lblCompany);
            this.Name = "FormMenu";
            this.Text = "Meun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnROL;
        private System.Windows.Forms.Button btnGoods;
        private System.Windows.Forms.Button btnGenReport;
        private System.Windows.Forms.Button btnDefective;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnSearchOrder;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Label lblCompany;
    }
}