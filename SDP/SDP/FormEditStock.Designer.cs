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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAtHandMix = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
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
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(194, 715);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 48);
            this.btnSearch.TabIndex = 145;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(388, 715);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 48);
            this.btnCancel.TabIndex = 146;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Location = new System.Drawing.Point(189, 487);
            this.lblPID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(118, 25);
            this.lblPID.TabIndex = 147;
            this.lblPID.Text = "Product ID:";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(189, 539);
            this.lblCategories.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(105, 25);
            this.lblCategories.TabIndex = 148;
            this.lblCategories.Text = "Category:";
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Location = new System.Drawing.Point(189, 593);
            this.lblKeyword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(75, 25);
            this.lblKeyword.TabIndex = 149;
            this.lblKeyword.Text = "Brand:";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(387, 539);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(396, 31);
            this.txtCategory.TabIndex = 151;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(387, 593);
            this.txtKeyword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(396, 31);
            this.txtKeyword.TabIndex = 152;
            // 
            // txtPID
            // 
            this.txtPID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPID.Location = new System.Drawing.Point(387, 481);
            this.txtPID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(396, 31);
            this.txtPID.TabIndex = 153;
            this.txtPID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPID_KeyDown);
            // 
            // lviSearch
            // 
            this.lviSearch.Location = new System.Drawing.Point(24, 154);
            this.lviSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lviSearch.Name = "lviSearch";
            this.lviSearch.Size = new System.Drawing.Size(1608, 271);
            this.lviSearch.TabIndex = 154;
            this.lviSearch.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(1232, 750);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(396, 31);
            this.textBox1.TabIndex = 160;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1030, 593);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(396, 31);
            this.textBox2.TabIndex = 159;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1137, 683);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(396, 31);
            this.textBox3.TabIndex = 158;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(832, 593);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 157;
            this.label1.Text = "In Hand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(832, 539);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 156;
            this.label2.Text = "On Hand:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(832, 487);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 155;
            this.label3.Text = "At Hand:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(388, 647);
            this.textBox4.Margin = new System.Windows.Forms.Padding(6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(396, 31);
            this.textBox4.TabIndex = 162;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 647);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 161;
            this.label4.Text = "Keyword:";
            // 
            // txtAtHandMix
            // 
            this.txtAtHandMix.Location = new System.Drawing.Point(1030, 481);
            this.txtAtHandMix.Name = "txtAtHandMix";
            this.txtAtHandMix.Size = new System.Drawing.Size(190, 31);
            this.txtAtHandMix.TabIndex = 163;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1236, 481);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(190, 31);
            this.textBox5.TabIndex = 164;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1236, 539);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(190, 31);
            this.textBox6.TabIndex = 166;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1030, 539);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(190, 31);
            this.textBox7.TabIndex = 165;
            // 
            // FormSearchStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1676, 919);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtAtHandMix);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormSearchStock";
            this.Text = "Search stock";
            this.Load += new System.EventHandler(this.FormSearchStock_Load);
            this.Click += new System.EventHandler(this.BtnSearch_Click);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAtHandMix;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
    }
}