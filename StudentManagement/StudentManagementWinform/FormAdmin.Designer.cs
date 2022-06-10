
namespace StudentManagementWinform
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
            this.label1 = new System.Windows.Forms.Label();
            this.LoginNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RetypeBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // LoginNameBox
            // 
            this.LoginNameBox.Location = new System.Drawing.Point(171, 82);
            this.LoginNameBox.Name = "LoginNameBox";
            this.LoginNameBox.Size = new System.Drawing.Size(193, 22);
            this.LoginNameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thông Tin Đăng Nhập";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(171, 139);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(128, 22);
            this.PasswordBox.TabIndex = 4;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật Khẩu";
            // 
            // RetypeBox
            // 
            this.RetypeBox.Location = new System.Drawing.Point(171, 188);
            this.RetypeBox.Name = "RetypeBox";
            this.RetypeBox.Size = new System.Drawing.Size(128, 22);
            this.RetypeBox.TabIndex = 6;
            this.RetypeBox.UseSystemPasswordChar = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(36, 191);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(129, 17);
            this.label.TabIndex = 5;
            this.label.Text = "Nhập Lại Mật Khẩu";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(171, 232);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Đặt Lại";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(252, 232);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Hủy";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 304);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.RetypeBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginNameBox);
            this.Controls.Add(this.label1);
            this.Name = "FormAdmin";
            this.Text = "Thông Tin ";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RetypeBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button CancelButton;
    }
}