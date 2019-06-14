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
            this.lvResult = new System.Windows.Forms.ListView();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvResult
            // 
            this.lvResult.Location = new System.Drawing.Point(16, 126);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(806, 132);
            this.lvResult.TabIndex = 194;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvResult_MouseDoubleClick);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(124, 264);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(200, 22);
            this.txtKeyword.TabIndex = 193;
            this.txtKeyword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtKeyword_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 12);
            this.label10.TabIndex = 192;
            this.label10.Text = "Keyword:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(124, 292);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 191;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // FormSearchStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.lvResult);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSearch);
            this.Name = "FormSearchStock";
            this.Text = "FormSearchStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvResult;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSearch;
    }
}