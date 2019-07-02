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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtEditStock = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnCust = new System.Windows.Forms.Button();
            this.btnJPos = new System.Windows.Forms.Button();
            this.btnNewPO = new System.Windows.Forms.Button();
            this.btnNStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnROL
            // 
            this.btnROL.Location = new System.Drawing.Point(142, 302);
            this.btnROL.Name = "btnROL";
            this.btnROL.Size = new System.Drawing.Size(123, 23);
            this.btnROL.TabIndex = 7;
            this.btnROL.Text = "Correct ROL";
            this.btnROL.UseVisualStyleBackColor = true;
            this.btnROL.Click += new System.EventHandler(this.BtnROL_Click);
            // 
            // btnGoods
            // 
            this.btnGoods.Location = new System.Drawing.Point(366, 253);
            this.btnGoods.Name = "btnGoods";
            this.btnGoods.Size = new System.Drawing.Size(123, 23);
            this.btnGoods.TabIndex = 5;
            this.btnGoods.Text = "Receive Goods";
            this.btnGoods.UseVisualStyleBackColor = true;
            this.btnGoods.Click += new System.EventHandler(this.BtnGoods_Click);
            // 
            // btnGenReport
            // 
            this.btnGenReport.Location = new System.Drawing.Point(142, 253);
            this.btnGenReport.Name = "btnGenReport";
            this.btnGenReport.Size = new System.Drawing.Size(123, 23);
            this.btnGenReport.TabIndex = 6;
            this.btnGenReport.Text = "Generate Report";
            this.btnGenReport.UseVisualStyleBackColor = true;
            this.btnGenReport.Click += new System.EventHandler(this.BtnGenReport_Click);
            // 
            // btnDefective
            // 
            this.btnDefective.Location = new System.Drawing.Point(588, 253);
            this.btnDefective.Name = "btnDefective";
            this.btnDefective.Size = new System.Drawing.Size(123, 23);
            this.btnDefective.TabIndex = 2;
            this.btnDefective.Text = "Report Defective";
            this.btnDefective.UseVisualStyleBackColor = true;
            this.btnDefective.Click += new System.EventHandler(this.BtnDefective_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(662, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(123, 23);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(588, 204);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(123, 23);
            this.btnStock.TabIndex = 3;
            this.btnStock.Text = "Search Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.BtnStock_Click);
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.Location = new System.Drawing.Point(588, 155);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(123, 23);
            this.btnSearchOrder.TabIndex = 1;
            this.btnSearchOrder.Text = "Search Order";
            this.btnSearchOrder.UseVisualStyleBackColor = true;
            this.btnSearchOrder.Click += new System.EventHandler(this.BtnSearchOrder_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(366, 155);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(123, 23);
            this.btnNewOrder.TabIndex = 0;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.BtnNewOrder_Click);
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
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWelcome.Location = new System.Drawing.Point(205, 36);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(399, 24);
            this.lblWelcome.TabIndex = 154;
            this.lblWelcome.Text = "Welcome, ";
            this.lblWelcome.Click += new System.EventHandler(this.LblWelcome_Click);
            // 
            // txtEditStock
            // 
            this.txtEditStock.Location = new System.Drawing.Point(366, 204);
            this.txtEditStock.Name = "txtEditStock";
            this.txtEditStock.Size = new System.Drawing.Size(123, 23);
            this.txtEditStock.TabIndex = 4;
            this.txtEditStock.Text = "Edit Stock";
            this.txtEditStock.UseVisualStyleBackColor = true;
            this.txtEditStock.Click += new System.EventHandler(this.TxtEditStock_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Location = new System.Drawing.Point(366, 106);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(123, 23);
            this.btnStaff.TabIndex = 10;
            this.btnStaff.Text = "Staff Management";
            this.btnStaff.UseVisualStyleBackColor = true;
            // 
            // btnCust
            // 
            this.btnCust.Location = new System.Drawing.Point(142, 106);
            this.btnCust.Name = "btnCust";
            this.btnCust.Size = new System.Drawing.Size(123, 23);
            this.btnCust.TabIndex = 9;
            this.btnCust.Text = "Customer Management";
            this.btnCust.UseVisualStyleBackColor = true;
            // 
            // btnJPos
            // 
            this.btnJPos.Location = new System.Drawing.Point(588, 106);
            this.btnJPos.Name = "btnJPos";
            this.btnJPos.Size = new System.Drawing.Size(123, 23);
            this.btnJPos.TabIndex = 11;
            this.btnJPos.Text = "Role Control";
            this.btnJPos.UseVisualStyleBackColor = true;
            // 
            // btnNewPO
            // 
            this.btnNewPO.Location = new System.Drawing.Point(142, 155);
            this.btnNewPO.Name = "btnNewPO";
            this.btnNewPO.Size = new System.Drawing.Size(123, 23);
            this.btnNewPO.TabIndex = 155;
            this.btnNewPO.Text = "New Purchase Order";
            this.btnNewPO.UseVisualStyleBackColor = true;
            // 
            // btnNStock
            // 
            this.btnNStock.Location = new System.Drawing.Point(142, 204);
            this.btnNStock.Name = "btnNStock";
            this.btnNStock.Size = new System.Drawing.Size(123, 23);
            this.btnNStock.TabIndex = 156;
            this.btnNStock.Text = "New Stock";
            this.btnNStock.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.btnNStock);
            this.Controls.Add(this.btnNewPO);
            this.Controls.Add(this.btnJPos);
            this.Controls.Add(this.btnCust);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.txtEditStock);
            this.Controls.Add(this.lblWelcome);
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
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenu_FormClosing);
            this.Load += new System.EventHandler(this.FormMenu_Load);
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
        private System.Windows.Forms.Label lblWelcome;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button txtEditStock;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnCust;
        private System.Windows.Forms.Button btnJPos;
        private System.Windows.Forms.Button btnNewPO;
        private System.Windows.Forms.Button btnNStock;
    }
}