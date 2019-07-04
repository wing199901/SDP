namespace SDP
{
    partial class FormEditStock
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
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPID = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(367, 194);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 22);
            this.txtProductName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 183;
            this.label4.Text = "Product  Name:";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(367, 166);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(200, 22);
            this.txtBrand.TabIndex = 2;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(367, 138);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(200, 22);
            this.txtType.TabIndex = 1;
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Location = new System.Drawing.Point(271, 169);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(37, 12);
            this.lblKeyword.TabIndex = 172;
            this.lblKeyword.Text = "Brand:";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(271, 141);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(32, 12);
            this.lblCategories.TabIndex = 171;
            this.lblCategories.Text = "Type:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(354, 307);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(273, 307);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCompany.Location = new System.Drawing.Point(414, 396);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(399, 24);
            this.lblCompany.TabIndex = 167;
            this.lblCompany.Text = "Smart && Luxury Motor Company (Spares)";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(367, 222);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 22);
            this.txtPrice.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 191;
            this.label1.Text = "Price:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(367, 250);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 46);
            this.txtDescription.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 12);
            this.label6.TabIndex = 193;
            this.label6.Text = "Description:";
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Location = new System.Drawing.Point(271, 113);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(59, 12);
            this.lblPID.TabIndex = 170;
            this.lblPID.Text = "Product ID:";
            // 
            // txtProductId
            // 
            this.txtProductId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductId.Location = new System.Drawing.Point(367, 110);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(200, 22);
            this.txtProductId.TabIndex = 0;
            // 
            // FormEditStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.lblPID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblCompany);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "FormEditStock";
            this.Text = "Edit stock";
            this.Load += new System.EventHandler(this.FormEditStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.TextBox txtProductId;
    }
}