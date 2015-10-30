namespace WindowsFormsApplication1
{
    partial class ReturnBook
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.writerLabel = new System.Windows.Forms.Label();
            this.writerField = new System.Windows.Forms.TextBox();
            this.returnBtn = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.borrowerLabel = new System.Windows.Forms.Label();
            this.borrowerField = new System.Windows.Forms.TextBox();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.ISBNField = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.borrowDetail = new System.Windows.Forms.DataGridView();
            this.booknameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.now = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBNColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.borrowDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelBtn.Font = new System.Drawing.Font("TF Lanna", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(811, 648);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(116, 30);
            this.cancelBtn.TabIndex = 77;
            this.cancelBtn.Text = "ยกเลิก";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // writerLabel
            // 
            this.writerLabel.AutoSize = true;
            this.writerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.writerLabel.Location = new System.Drawing.Point(35, 119);
            this.writerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.writerLabel.Name = "writerLabel";
            this.writerLabel.Size = new System.Drawing.Size(47, 13);
            this.writerLabel.TabIndex = 82;
            this.writerLabel.Text = "ชื่อผู้แต่ง";
            // 
            // writerField
            // 
            this.writerField.Location = new System.Drawing.Point(93, 116);
            this.writerField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.writerField.Name = "writerField";
            this.writerField.Size = new System.Drawing.Size(378, 20);
            this.writerField.TabIndex = 71;
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.returnBtn.Font = new System.Drawing.Font("TF Lanna", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.Location = new System.Drawing.Point(811, 151);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(116, 30);
            this.returnBtn.TabIndex = 76;
            this.returnBtn.Text = "คืนหนังสือ";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerLabel.Font = new System.Drawing.Font("TF Lanna", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(32, 40);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(77, 28);
            this.headerLabel.TabIndex = 75;
            this.headerLabel.Text = "คืนหนังสือ";
            // 
            // borrowerLabel
            // 
            this.borrowerLabel.AutoSize = true;
            this.borrowerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowerLabel.Location = new System.Drawing.Point(492, 119);
            this.borrowerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.borrowerLabel.Name = "borrowerLabel";
            this.borrowerLabel.Size = new System.Drawing.Size(41, 13);
            this.borrowerLabel.TabIndex = 74;
            this.borrowerLabel.Text = "ชื่อผู้ยืม";
            // 
            // borrowerField
            // 
            this.borrowerField.Location = new System.Drawing.Point(549, 116);
            this.borrowerField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.borrowerField.Name = "borrowerField";
            this.borrowerField.Size = new System.Drawing.Size(378, 20);
            this.borrowerField.TabIndex = 74;
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ISBNLabel.Location = new System.Drawing.Point(491, 77);
            this.ISBNLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(119, 13);
            this.ISBNLabel.TabIndex = 72;
            this.ISBNLabel.Text = "เลขประจำหนังสือ (ISBN)";
            // 
            // ISBNField
            // 
            this.ISBNField.Location = new System.Drawing.Point(614, 74);
            this.ISBNField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ISBNField.Name = "ISBNField";
            this.ISBNField.Size = new System.Drawing.Size(313, 20);
            this.ISBNField.TabIndex = 70;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameLabel.Location = new System.Drawing.Point(35, 77);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 13);
            this.nameLabel.TabIndex = 70;
            this.nameLabel.Text = "ชื่อหนังสือ";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(93, 74);
            this.nameField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(378, 20);
            this.nameField.TabIndex = 69;
            // 
            // borrowDetail
            // 
            this.borrowDetail.AllowUserToAddRows = false;
            this.borrowDetail.AllowUserToDeleteRows = false;
            this.borrowDetail.AllowUserToOrderColumns = true;
            this.borrowDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.booknameColumn,
            this.borrower,
            this.borrowDateTime,
            this.now,
            this.ISBNColumn,
            this.writerColumn});
            this.borrowDetail.Location = new System.Drawing.Point(39, 204);
            this.borrowDetail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.borrowDetail.Name = "borrowDetail";
            this.borrowDetail.ReadOnly = true;
            this.borrowDetail.Size = new System.Drawing.Size(888, 424);
            this.borrowDetail.TabIndex = 78;
            // 
            // booknameColumn
            // 
            this.booknameColumn.HeaderText = "ชื่อหนังสือ";
            this.booknameColumn.Name = "booknameColumn";
            this.booknameColumn.ReadOnly = true;
            this.booknameColumn.Width = 200;
            // 
            // borrower
            // 
            this.borrower.HeaderText = "ผู้ยืม";
            this.borrower.Name = "borrower";
            this.borrower.ReadOnly = true;
            this.borrower.Width = 200;
            // 
            // borrowDateTime
            // 
            this.borrowDateTime.HeaderText = "วันที่ยืม";
            this.borrowDateTime.Name = "borrowDateTime";
            this.borrowDateTime.ReadOnly = true;
            this.borrowDateTime.Width = 140;
            // 
            // now
            // 
            this.now.HeaderText = "เวลาปัจจุบัน";
            this.now.Name = "now";
            this.now.ReadOnly = true;
            this.now.Width = 140;
            // 
            // ISBNColumn
            // 
            this.ISBNColumn.HeaderText = "เลขประจำหนังสือ (ISBN)";
            this.ISBNColumn.Name = "ISBNColumn";
            this.ISBNColumn.ReadOnly = true;
            this.ISBNColumn.Width = 200;
            // 
            // writerColumn
            // 
            this.writerColumn.HeaderText = "ผู้แต่ง";
            this.writerColumn.Name = "writerColumn";
            this.writerColumn.ReadOnly = true;
            this.writerColumn.Width = 150;
            // 
            // refshBtn
            // 
            this.refshBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.refshBtn.Font = new System.Drawing.Font("TF Lanna", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refshBtn.Location = new System.Drawing.Point(679, 151);
            this.refshBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.refshBtn.Name = "refshBtn";
            this.refshBtn.Size = new System.Drawing.Size(116, 30);
            this.refshBtn.TabIndex = 75;
            this.refshBtn.Text = "รีเฟรช";
            this.refshBtn.UseVisualStyleBackColor = false;
            this.refshBtn.Click += new System.EventHandler(this.refshBtn_Click);
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.borrowDetail);
            this.Controls.Add(this.refshBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.writerLabel);
            this.Controls.Add(this.writerField);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.borrowerLabel);
            this.Controls.Add(this.borrowerField);
            this.Controls.Add(this.ISBNLabel);
            this.Controls.Add(this.ISBNField);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameField);
            this.Name = "ReturnBook";
            this.Text = "คืนหนังสือ";
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.borrowDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label writerLabel;
        private System.Windows.Forms.TextBox writerField;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label borrowerLabel;
        private System.Windows.Forms.TextBox borrowerField;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.TextBox ISBNField;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.DataGridView borrowDetail;
        private System.Windows.Forms.Button refshBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booknameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrower;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn now;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBNColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn writerColumn;
    }
}