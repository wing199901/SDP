namespace SDP
{
    partial class FormAdmin
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
            this.btnUser = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(118, 108);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(100, 23);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "Edit User";
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(118, 187);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(100, 23);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "Edit Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(118, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Edit Job Position";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnUser);
            this.Name = "FormAdmin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button button3;
    }
}