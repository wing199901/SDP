namespace SDP
{
    partial class FormSearchResult
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lvResult = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtResult.Location = new System.Drawing.Point(16, 154);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(806, 132);
            this.txtResult.TabIndex = 186;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(120, 292);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(200, 22);
            this.txtKeyword.TabIndex = 189;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 12);
            this.label10.TabIndex = 188;
            this.label10.Text = "Keyword:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(120, 320);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 187;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // lvResult
            // 
            this.lvResult.Location = new System.Drawing.Point(16, 12);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(806, 132);
            this.lvResult.TabIndex = 190;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            // 
            // FormSearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.lvResult);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtResult);
            this.Name = "FormSearchResult";
            this.Text = "Search result";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lvResult;
    }
}