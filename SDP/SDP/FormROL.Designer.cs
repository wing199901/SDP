namespace SDP
{
    partial class FormROL
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSKU = new System.Windows.Forms.Label();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSafety = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSafety = new System.Windows.Forms.Button();
            this.btnReorder = new System.Windows.Forms.Button();
            this.lblReorder = new System.Windows.Forms.Label();
            this.txtReorder = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 106);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(806, 132);
            this.textBox1.TabIndex = 145;
            // 
            // lblSKU
            // 
            this.lblSKU.AutoSize = true;
            this.lblSKU.Location = new System.Drawing.Point(94, 50);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Size = new System.Drawing.Size(30, 12);
            this.lblSKU.TabIndex = 146;
            this.lblSKU.Text = "SKU:";
            // 
            // txtSKU
            // 
            this.txtSKU.Location = new System.Drawing.Point(130, 47);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(100, 22);
            this.txtSKU.TabIndex = 147;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(264, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 148;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblSafety
            // 
            this.lblSafety.AutoSize = true;
            this.lblSafety.Location = new System.Drawing.Point(97, 267);
            this.lblSafety.Name = "lblSafety";
            this.lblSafety.Size = new System.Drawing.Size(66, 12);
            this.lblSafety.TabIndex = 149;
            this.lblSafety.Text = "Safety Level:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(181, 264);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 150;
            // 
            // btnSafety
            // 
            this.btnSafety.Location = new System.Drawing.Point(314, 262);
            this.btnSafety.Name = "btnSafety";
            this.btnSafety.Size = new System.Drawing.Size(75, 23);
            this.btnSafety.TabIndex = 151;
            this.btnSafety.Text = "Apply";
            this.btnSafety.UseVisualStyleBackColor = true;
            // 
            // btnReorder
            // 
            this.btnReorder.Location = new System.Drawing.Point(314, 309);
            this.btnReorder.Name = "btnReorder";
            this.btnReorder.Size = new System.Drawing.Size(75, 23);
            this.btnReorder.TabIndex = 152;
            this.btnReorder.Text = "Apply";
            this.btnReorder.UseVisualStyleBackColor = true;
            // 
            // lblReorder
            // 
            this.lblReorder.AutoSize = true;
            this.lblReorder.Location = new System.Drawing.Point(97, 314);
            this.lblReorder.Name = "lblReorder";
            this.lblReorder.Size = new System.Drawing.Size(75, 12);
            this.lblReorder.TabIndex = 153;
            this.lblReorder.Text = "Reorder Level:";
            // 
            // txtReorder
            // 
            this.txtReorder.Location = new System.Drawing.Point(181, 311);
            this.txtReorder.Name = "txtReorder";
            this.txtReorder.Size = new System.Drawing.Size(100, 22);
            this.txtReorder.TabIndex = 154;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(96, 375);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 155;
            this.btnSubmit.Text = "Sumbit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(244, 375);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 156;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormROL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtReorder);
            this.Controls.Add(this.lblReorder);
            this.Controls.Add(this.btnReorder);
            this.Controls.Add(this.btnSafety);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblSafety);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSKU);
            this.Controls.Add(this.lblSKU);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCompany);
            this.Name = "FormROL";
            this.Text = "Correct ROL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSKU;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSafety;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSafety;
        private System.Windows.Forms.Button btnReorder;
        private System.Windows.Forms.Label lblReorder;
        private System.Windows.Forms.TextBox txtReorder;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}