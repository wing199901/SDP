namespace SDP
{
    partial class FormStaff
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
            this.lvUser = new System.Windows.Forms.ListView();
            this.lblSID = new System.Windows.Forms.Label();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.lblRID = new System.Windows.Forms.Label();
            this.txtRID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbAvailable = new System.Windows.Forms.CheckBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblPWD = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvUser
            // 
            this.lvUser.HideSelection = false;
            this.lvUser.Location = new System.Drawing.Point(18, 77);
            this.lvUser.Name = "lvUser";
            this.lvUser.Size = new System.Drawing.Size(806, 132);
            this.lvUser.TabIndex = 0;
            this.lvUser.UseCompatibleStateImageBehavior = false;
            // 
            // lblSID
            // 
            this.lblSID.AutoSize = true;
            this.lblSID.Location = new System.Drawing.Point(100, 237);
            this.lblSID.Name = "lblSID";
            this.lblSID.Size = new System.Drawing.Size(45, 12);
            this.lblSID.TabIndex = 1;
            this.lblSID.Text = "Staff ID:";
            // 
            // txtSID
            // 
            this.txtSID.Location = new System.Drawing.Point(200, 234);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(200, 22);
            this.txtSID.TabIndex = 0;
            // 
            // lblRID
            // 
            this.lblRID.AutoSize = true;
            this.lblRID.Location = new System.Drawing.Point(100, 261);
            this.lblRID.Name = "lblRID";
            this.lblRID.Size = new System.Drawing.Size(45, 12);
            this.lblRID.TabIndex = 3;
            this.lblRID.Text = "Role ID:";
            // 
            // txtRID
            // 
            this.txtRID.Location = new System.Drawing.Point(200, 258);
            this.txtRID.Name = "txtRID";
            this.txtRID.Size = new System.Drawing.Size(200, 22);
            this.txtRID.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(100, 285);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 12);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Staff Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(199, 282);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 2;
            // 
            // cbAvailable
            // 
            this.cbAvailable.AutoSize = true;
            this.cbAvailable.Checked = true;
            this.cbAvailable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAvailable.Location = new System.Drawing.Point(199, 339);
            this.cbAvailable.Name = "cbAvailable";
            this.cbAvailable.Size = new System.Drawing.Size(15, 14);
            this.cbAvailable.TabIndex = 4;
            this.cbAvailable.UseVisualStyleBackColor = true;
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(100, 339);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(52, 12);
            this.lblAvailable.TabIndex = 8;
            this.lblAvailable.Text = "Available:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(100, 365);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(262, 365);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(181, 365);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblPWD
            // 
            this.lblPWD.AutoSize = true;
            this.lblPWD.Location = new System.Drawing.Point(100, 313);
            this.lblPWD.Name = "lblPWD";
            this.lblPWD.Size = new System.Drawing.Size(51, 12);
            this.lblPWD.TabIndex = 9;
            this.lblPWD.Text = "Password:";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(199, 310);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(200, 22);
            this.txtPwd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 18F);
            this.label1.Location = new System.Drawing.Point(414, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Smart && Luxury Motor Company (Spares)";
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lblPWD);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.cbAvailable);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtRID);
            this.Controls.Add(this.lblRID);
            this.Controls.Add(this.txtSID);
            this.Controls.Add(this.lblSID);
            this.Controls.Add(this.lvUser);
            this.Name = "FormStaff";
            this.Text = "Staff Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvUser;
        private System.Windows.Forms.Label lblSID;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.Label lblRID;
        private System.Windows.Forms.TextBox txtRID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox cbAvailable;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblPWD;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label1;
    }
}