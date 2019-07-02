namespace SDP
{
    partial class FormRole
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
            this.lvRole = new System.Windows.Forms.ListView();
            this.lblRID = new System.Windows.Forms.Label();
            this.lblRName = new System.Windows.Forms.Label();
            this.txtRID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvRole
            // 
            this.lvRole.HideSelection = false;
            this.lvRole.Location = new System.Drawing.Point(18, 77);
            this.lvRole.Name = "lvRole";
            this.lvRole.Size = new System.Drawing.Size(806, 132);
            this.lvRole.TabIndex = 0;
            this.lvRole.UseCompatibleStateImageBehavior = false;
            // 
            // lblRID
            // 
            this.lblRID.AutoSize = true;
            this.lblRID.Location = new System.Drawing.Point(100, 237);
            this.lblRID.Name = "lblRID";
            this.lblRID.Size = new System.Drawing.Size(45, 12);
            this.lblRID.TabIndex = 1;
            this.lblRID.Text = "Role ID:";
            // 
            // lblRName
            // 
            this.lblRName.AutoSize = true;
            this.lblRName.Location = new System.Drawing.Point(100, 273);
            this.lblRName.Name = "lblRName";
            this.lblRName.Size = new System.Drawing.Size(60, 12);
            this.lblRName.TabIndex = 2;
            this.lblRName.Text = "Role Name:";
            // 
            // txtRID
            // 
            this.txtRID.Location = new System.Drawing.Point(200, 234);
            this.txtRID.Name = "txtRID";
            this.txtRID.Size = new System.Drawing.Size(200, 22);
            this.txtRID.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(200, 273);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(100, 309);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(181, 309);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(262, 309);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 18F);
            this.label1.Location = new System.Drawing.Point(414, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Smart && Luxury Motor Company (Spares)";
            // 
            // FormRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtRID);
            this.Controls.Add(this.lblRName);
            this.Controls.Add(this.lblRID);
            this.Controls.Add(this.lvRole);
            this.Name = "FormRole";
            this.Text = "Role Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvRole;
        private System.Windows.Forms.Label lblRID;
        private System.Windows.Forms.Label lblRName;
        private System.Windows.Forms.TextBox txtRID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
    }
}