
namespace StudentManagementWinform
{
    partial class StudentAdd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.StudentEmailBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentIDBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DOBPicker = new System.Windows.Forms.DateTimePicker();
            this.StudentPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GenerateBttn = new System.Windows.Forms.Button();
            this.StudentLogin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Female);
            this.groupBox1.Controls.Add(this.Male);
            this.groupBox1.Location = new System.Drawing.Point(160, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 44);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(101, 13);
            this.Female.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(47, 21);
            this.Female.TabIndex = 4;
            this.Female.Text = "Nữ";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(32, 13);
            this.Male.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(58, 21);
            this.Male.TabIndex = 3;
            this.Male.Text = "Nam";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // StudentEmailBox
            // 
            this.StudentEmailBox.Location = new System.Drawing.Point(160, 219);
            this.StudentEmailBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentEmailBox.Name = "StudentEmailBox";
            this.StudentEmailBox.Size = new System.Drawing.Size(199, 22);
            this.StudentEmailBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ngày Sinh";
            // 
            // StudentNameBox
            // 
            this.StudentNameBox.Location = new System.Drawing.Point(160, 90);
            this.StudentNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentNameBox.Name = "StudentNameBox";
            this.StudentNameBox.Size = new System.Drawing.Size(199, 22);
            this.StudentNameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Họ và Tên";
            // 
            // StudentIDBox
            // 
            this.StudentIDBox.Location = new System.Drawing.Point(160, 54);
            this.StudentIDBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentIDBox.Name = "StudentIDBox";
            this.StudentIDBox.Size = new System.Drawing.Size(199, 22);
            this.StudentIDBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã số sinh viên";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(296, 390);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 27);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Hủy";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(215, 390);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 27);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Đặt lại";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(134, 390);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 27);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Thêm";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DOBPicker
            // 
            this.DOBPicker.Location = new System.Drawing.Point(159, 130);
            this.DOBPicker.Name = "DOBPicker";
            this.DOBPicker.Size = new System.Drawing.Size(200, 22);
            this.DOBPicker.TabIndex = 23;
            // 
            // StudentPassword
            // 
            this.StudentPassword.Location = new System.Drawing.Point(159, 296);
            this.StudentPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentPassword.Name = "StudentPassword";
            this.StudentPassword.Size = new System.Drawing.Size(199, 22);
            this.StudentPassword.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Mật Khẩu";
            // 
            // GenerateBttn
            // 
            this.GenerateBttn.Location = new System.Drawing.Point(159, 323);
            this.GenerateBttn.Name = "GenerateBttn";
            this.GenerateBttn.Size = new System.Drawing.Size(111, 23);
            this.GenerateBttn.TabIndex = 27;
            this.GenerateBttn.Text = "Tạo Mật Khẩu";
            this.GenerateBttn.UseVisualStyleBackColor = true;
            this.GenerateBttn.Click += new System.EventHandler(this.GenerateBttn_Click);
            // 
            // StudentLogin
            // 
            this.StudentLogin.Location = new System.Drawing.Point(159, 255);
            this.StudentLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentLogin.Name = "StudentLogin";
            this.StudentLogin.Size = new System.Drawing.Size(199, 22);
            this.StudentLogin.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Tên Đăng Nhập";
            // 
            // StudentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 450);
            this.Controls.Add(this.StudentLogin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GenerateBttn);
            this.Controls.Add(this.StudentPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DOBPicker);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StudentEmailBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StudentNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudentIDBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StudentAdd";
            this.ShowInTaskbar = false;
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.StudentAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.TextBox StudentEmailBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StudentNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StudentIDBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DateTimePicker DOBPicker;
        private System.Windows.Forms.TextBox StudentPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button GenerateBttn;
        private System.Windows.Forms.TextBox StudentLogin;
        private System.Windows.Forms.Label label7;
    }
}