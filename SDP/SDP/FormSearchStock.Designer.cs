namespace SDP
{
    partial class FormSearchStock
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPID = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.lviSearch = new System.Windows.Forms.ListView();
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
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(97, 343);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 145;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(194, 343);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 146;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Location = new System.Drawing.Point(95, 252);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(59, 12);
            this.lblPID.TabIndex = 147;
            this.lblPID.Text = "Product ID:";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(95, 277);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(51, 12);
            this.lblCategories.TabIndex = 148;
            this.lblCategories.Text = "Category:";
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Location = new System.Drawing.Point(95, 303);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(51, 12);
            this.lblKeyword.TabIndex = 149;
            this.lblKeyword.Text = "Keyword:";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(194, 277);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(200, 22);
            this.txtCategory.TabIndex = 151;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(194, 303);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(200, 22);
            this.txtKeyword.TabIndex = 152;
            // 
            // txtPID
            // 
            this.txtPID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPID.Location = new System.Drawing.Point(194, 249);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(200, 22);
            this.txtPID.TabIndex = 153;
            // 
            // lviSearch
            // 
            this.lviSearch.Location = new System.Drawing.Point(12, 74);
            this.lviSearch.Name = "lviSearch";
            this.lviSearch.Size = new System.Drawing.Size(806, 132);
            this.lviSearch.TabIndex = 154;
            this.lviSearch.UseCompatibleStateImageBehavior = false;
            // 
            // FormSearchStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.lviSearch);
            this.Controls.Add(this.txtPID);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.lblPID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblCompany);
            this.Name = "FormSearchStock";
            this.Text = "Search stock";
            this.Load += new System.EventHandler(this.FormSearchStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.ListView lviSearch;
    }
}