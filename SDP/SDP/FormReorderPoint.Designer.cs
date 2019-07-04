namespace SDP
{
    partial class FormReorderPoint
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
            this.lvResult = new System.Windows.Forms.ListView();
            this.btnUpdateAll = new System.Windows.Forms.Button();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblSafetyStock = new System.Windows.Forms.Label();
            this.txtSafetyStock = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvResult
            // 
            this.lvResult.HideSelection = false;
            this.lvResult.Location = new System.Drawing.Point(40, 225);
            this.lvResult.Margin = new System.Windows.Forms.Padding(6);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(1608, 271);
            this.lvResult.TabIndex = 159;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.Click += new System.EventHandler(this.LvResult_Click);
            // 
            // btnUpdateAll
            // 
            this.btnUpdateAll.Location = new System.Drawing.Point(464, 685);
            this.btnUpdateAll.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdateAll.Name = "btnUpdateAll";
            this.btnUpdateAll.Size = new System.Drawing.Size(150, 48);
            this.btnUpdateAll.TabIndex = 156;
            this.btnUpdateAll.Text = "Update All";
            this.btnUpdateAll.UseVisualStyleBackColor = true;
            this.btnUpdateAll.Click += new System.EventHandler(this.BtnUpdateAll_Click);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCompany.Location = new System.Drawing.Point(828, 835);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(800, 48);
            this.lblCompany.TabIndex = 157;
            this.lblCompany.Text = "Smart && Luxury Motor Company (Spares)";
            // 
            // lblSafetyStock
            // 
            this.lblSafetyStock.AutoSize = true;
            this.lblSafetyStock.Location = new System.Drawing.Point(270, 583);
            this.lblSafetyStock.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSafetyStock.Name = "lblSafetyStock";
            this.lblSafetyStock.Size = new System.Drawing.Size(139, 25);
            this.lblSafetyStock.TabIndex = 158;
            this.lblSafetyStock.Text = "Safety Stock:";
            // 
            // txtSafetyStock
            // 
            this.txtSafetyStock.Location = new System.Drawing.Point(464, 577);
            this.txtSafetyStock.Margin = new System.Windows.Forms.Padding(6);
            this.txtSafetyStock.Name = "txtSafetyStock";
            this.txtSafetyStock.Size = new System.Drawing.Size(396, 31);
            this.txtSafetyStock.TabIndex = 155;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(275, 685);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 48);
            this.btnUpdate.TabIndex = 160;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // FormReorderPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1676, 919);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lvResult);
            this.Controls.Add(this.btnUpdateAll);
            this.Controls.Add(this.txtSafetyStock);
            this.Controls.Add(this.lblSafetyStock);
            this.Controls.Add(this.lblCompany);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormReorderPoint";
            this.Text = "FormReorderPoint";
            this.Load += new System.EventHandler(this.FormROL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvResult;
        private System.Windows.Forms.Button btnUpdateAll;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblSafetyStock;
        private System.Windows.Forms.TextBox txtSafetyStock;
        private System.Windows.Forms.Button btnUpdate;
    }
}