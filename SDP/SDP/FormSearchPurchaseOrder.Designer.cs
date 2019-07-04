namespace SDP
{
    partial class FormSearchPurchaseOrder
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
            this.lvOrder = new System.Windows.Forms.ListView();
            this.lvProduct = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvOrder
            // 
            this.lvOrder.HideSelection = false;
            this.lvOrder.Location = new System.Drawing.Point(12, 12);
            this.lvOrder.Name = "lvOrder";
            this.lvOrder.Size = new System.Drawing.Size(806, 132);
            this.lvOrder.TabIndex = 153;
            this.lvOrder.UseCompatibleStateImageBehavior = false;
            // 
            // lvProduct
            // 
            this.lvProduct.HideSelection = false;
            this.lvProduct.Location = new System.Drawing.Point(12, 150);
            this.lvProduct.Name = "lvProduct";
            this.lvProduct.Size = new System.Drawing.Size(806, 132);
            this.lvProduct.TabIndex = 154;
            this.lvProduct.UseCompatibleStateImageBehavior = false;
            // 
            // FormSearchPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.lvProduct);
            this.Controls.Add(this.lvOrder);
            this.Name = "FormSearchPurchaseOrder";
            this.Text = "FormSearchPurchaseOrder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvOrder;
        private System.Windows.Forms.ListView lvProduct;
    }
}