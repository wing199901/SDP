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
            this.label12 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
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
            this.lvOrder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LvOrder_MouseClick);
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(123, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 163;
            this.label12.Text = "Order Status:";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Creation",
            "Pending",
            "Finish"});
            this.cboStatus.Location = new System.Drawing.Point(226, 316);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(200, 20);
            this.cboStatus.TabIndex = 160;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(226, 342);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(200, 22);
            this.txtOrderID.TabIndex = 161;
            this.txtOrderID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtOrderID_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 12);
            this.label1.TabIndex = 162;
            this.label1.Text = "Order ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(226, 370);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 164;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(583, 314);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 165;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // FormSearchPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvProduct);
            this.Controls.Add(this.lvOrder);
            this.Name = "FormSearchPurchaseOrder";
            this.Text = "Search Purchasing Order";
            this.Load += new System.EventHandler(this.FormSearchPurchaseOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvOrder;
        private System.Windows.Forms.ListView lvProduct;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnConfirm;
    }
}