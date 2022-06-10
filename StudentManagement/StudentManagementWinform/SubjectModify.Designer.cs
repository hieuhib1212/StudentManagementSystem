
namespace StudentManagementWinform
{
    partial class SubjectModify
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubjectTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SubjectIDBox = new System.Windows.Forms.TextBox();
            this.SubjectNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ApplyChangeBttn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SubjectTable);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 469);
            this.panel1.TabIndex = 0;
            // 
            // SubjectTable
            // 
            this.SubjectTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectTable.Location = new System.Drawing.Point(15, 13);
            this.SubjectTable.Name = "SubjectTable";
            this.SubjectTable.RowHeadersWidth = 51;
            this.SubjectTable.RowTemplate.Height = 24;
            this.SubjectTable.Size = new System.Drawing.Size(422, 440);
            this.SubjectTable.TabIndex = 0;
            this.SubjectTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubjectTable_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Môn";
            // 
            // SubjectIDBox
            // 
            this.SubjectIDBox.Location = new System.Drawing.Point(571, 90);
            this.SubjectIDBox.Name = "SubjectIDBox";
            this.SubjectIDBox.ReadOnly = true;
            this.SubjectIDBox.Size = new System.Drawing.Size(100, 22);
            this.SubjectIDBox.TabIndex = 2;
            // 
            // SubjectNameBox
            // 
            this.SubjectNameBox.Location = new System.Drawing.Point(571, 148);
            this.SubjectNameBox.Name = "SubjectNameBox";
            this.SubjectNameBox.Size = new System.Drawing.Size(160, 22);
            this.SubjectNameBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Môn Học";
            // 
            // ApplyChangeBttn
            // 
            this.ApplyChangeBttn.Location = new System.Drawing.Point(571, 192);
            this.ApplyChangeBttn.Name = "ApplyChangeBttn";
            this.ApplyChangeBttn.Size = new System.Drawing.Size(100, 37);
            this.ApplyChangeBttn.TabIndex = 5;
            this.ApplyChangeBttn.Text = "Thay Đổi";
            this.ApplyChangeBttn.UseVisualStyleBackColor = true;
            this.ApplyChangeBttn.Click += new System.EventHandler(this.ApplyChangeBttn_Click);
            // 
            // SubjectModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 493);
            this.Controls.Add(this.ApplyChangeBttn);
            this.Controls.Add(this.SubjectNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SubjectIDBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SubjectModify";
            this.Text = "Tùy Chỉnh";
            this.Load += new System.EventHandler(this.SubjectModify_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView SubjectTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SubjectIDBox;
        private System.Windows.Forms.TextBox SubjectNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ApplyChangeBttn;
    }
}