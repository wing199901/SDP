namespace SDP
{
    partial class FormNewPurchaseOrder
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
            this.lvPOrder = new System.Windows.Forms.ListView();
            this.lblOID = new System.Windows.Forms.Label();
            this.lblSID = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvPOrder
            // 
            this.lvPOrder.HideSelection = false;
            this.lvPOrder.Location = new System.Drawing.Point(20, 72);
            this.lvPOrder.Name = "lvPOrder";
            this.lvPOrder.Size = new System.Drawing.Size(806, 132);
            this.lvPOrder.TabIndex = 0;
            this.lvPOrder.UseCompatibleStateImageBehavior = false;
            // 
            // lblOID
            // 
            this.lblOID.AutoSize = true;
            this.lblOID.Location = new System.Drawing.Point(90, 248);
            this.lblOID.Name = "lblOID";
            this.lblOID.Size = new System.Drawing.Size(50, 12);
            this.lblOID.TabIndex = 1;
            this.lblOID.Text = "Order ID:";
            // 
            // lblSID
            // 
            this.lblSID.AutoSize = true;
            this.lblSID.Location = new System.Drawing.Point(90, 289);
            this.lblSID.Name = "lblSID";
            this.lblSID.Size = new System.Drawing.Size(45, 12);
            this.lblSID.TabIndex = 2;
            this.lblSID.Text = "Staff ID:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(180, 245);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(200, 22);
            this.txtOrderID.TabIndex = 0;
            // 
            // txtSID
            // 
            this.txtSID.Location = new System.Drawing.Point(180, 286);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(200, 22);
            this.txtSID.TabIndex = 1;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(447, 245);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(59, 12);
            this.lblOrderDate.TabIndex = 5;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(537, 242);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(200, 22);
            this.txtDate.TabIndex = 2;
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Location = new System.Drawing.Point(447, 286);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(51, 12);
            this.lblKeyword.TabIndex = 7;
            this.lblKeyword.Text = "Keyword:";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(537, 283);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(200, 22);
            this.txtKeyword.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(111, 344);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(262, 344);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormNewPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.txtSID);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lblSID);
            this.Controls.Add(this.lblOID);
            this.Controls.Add(this.lvPOrder);
            this.Name = "FormNewPurchaseOrder";
            this.Text = "New Purchase Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPOrder;
        private System.Windows.Forms.Label lblOID;
        private System.Windows.Forms.Label lblSID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
    }
}