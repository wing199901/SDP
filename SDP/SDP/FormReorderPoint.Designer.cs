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
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtSafetyStock = new System.Windows.Forms.TextBox();
            this.lblSafetyStock = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvResult
            // 
            this.lvResult.HideSelection = false;
            this.lvResult.Location = new System.Drawing.Point(20, 108);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(806, 132);
            this.lvResult.TabIndex = 159;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(269, 329);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 156;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtSafetyStock
            // 
            this.txtSafetyStock.Location = new System.Drawing.Point(232, 277);
            this.txtSafetyStock.Name = "txtSafetyStock";
            this.txtSafetyStock.Size = new System.Drawing.Size(200, 22);
            this.txtSafetyStock.TabIndex = 155;
            // 
            // lblSafetyStock
            // 
            this.lblSafetyStock.AutoSize = true;
            this.lblSafetyStock.Location = new System.Drawing.Point(135, 280);
            this.lblSafetyStock.Name = "lblSafetyStock";
            this.lblSafetyStock.Size = new System.Drawing.Size(66, 12);
            this.lblSafetyStock.TabIndex = 158;
            this.lblSafetyStock.Text = "Safety Stock:";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCompany.Location = new System.Drawing.Point(414, 401);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(399, 24);
            this.lblCompany.TabIndex = 157;
            this.lblCompany.Text = "Smart && Luxury Motor Company (Spares)";
            // 
            // FormReorderPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.lvResult);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtSafetyStock);
            this.Controls.Add(this.lblSafetyStock);
            this.Controls.Add(this.lblCompany);
            this.Name = "FormReorderPoint";
            this.Text = "FormReorderPoint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvResult;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSafetyStock;
        private System.Windows.Forms.Label lblSafetyStock;
        private System.Windows.Forms.Label lblCompany;
    }
}