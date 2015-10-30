namespace WindowsFormsApplication1
{
    partial class BorrowBook
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
            this.borrowerLabel = new System.Windows.Forms.Label();
            this.borrowerField = new System.Windows.Forms.TextBox();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.ISBNField = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.editionLabel = new System.Windows.Forms.Label();
            this.editionField = new System.Windows.Forms.TextBox();
            this.publishedYrLabel = new System.Windows.Forms.Label();
            this.publishedYrBox = new System.Windows.Forms.ComboBox();
            this.borrowBtn = new System.Windows.Forms.Button();
            this.writerLabel = new System.Windows.Forms.Label();
            this.writerField = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.bookDetail = new System.Windows.Forms.DataGridView();
            this.booknameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.translatorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishedYrColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBNColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deweyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // borrowerLabel
            // 
            this.borrowerLabel.AutoSize = true;
            this.borrowerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowerLabel.Location = new System.Drawing.Point(36, 159);
            this.borrowerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.borrowerLabel.Name = "borrowerLabel";
            this.borrowerLabel.Size = new System.Drawing.Size(41, 13);
            this.borrowerLabel.TabIndex = 58;
            this.borrowerLabel.Text = "ชื่อผู้ยืม";
            // 
            // borrowerField
            // 
            this.borrowerField.Location = new System.Drawing.Point(93, 156);
            this.borrowerField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.borrowerField.Name = "borrowerField";
            this.borrowerField.Size = new System.Drawing.Size(378, 20);
            this.borrowerField.TabIndex = 58;
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ISBNLabel.Location = new System.Drawing.Point(491, 77);
            this.ISBNLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(119, 13);
            this.ISBNLabel.TabIndex = 56;
            this.ISBNLabel.Text = "เลขประจำหนังสือ (ISBN)";
            // 
            // ISBNField
            // 
            this.ISBNField.Location = new System.Drawing.Point(614, 74);
            this.ISBNField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ISBNField.Name = "ISBNField";
            this.ISBNField.Size = new System.Drawing.Size(313, 20);
            this.ISBNField.TabIndex = 54;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameLabel.Location = new System.Drawing.Point(35, 77);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 13);
            this.nameLabel.TabIndex = 54;
            this.nameLabel.Text = "ชื่อหนังสือ";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(93, 74);
            this.nameField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(378, 20);
            this.nameField.TabIndex = 53;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerLabel.Font = new System.Drawing.Font("TF Lanna", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(32, 40);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(76, 28);
            this.headerLabel.TabIndex = 60;
            this.headerLabel.Text = "ยืมหนังสือ";
            // 
            // editionLabel
            // 
            this.editionLabel.AutoSize = true;
            this.editionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editionLabel.Location = new System.Drawing.Point(491, 120);
            this.editionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editionLabel.Name = "editionLabel";
            this.editionLabel.Size = new System.Drawing.Size(55, 13);
            this.editionLabel.TabIndex = 64;
            this.editionLabel.Text = "ครั้งที่พิมพ์";
            // 
            // editionField
            // 
            this.editionField.Location = new System.Drawing.Point(556, 117);
            this.editionField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.editionField.Name = "editionField";
            this.editionField.Size = new System.Drawing.Size(45, 20);
            this.editionField.TabIndex = 56;
            // 
            // publishedYrLabel
            // 
            this.publishedYrLabel.AutoSize = true;
            this.publishedYrLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.publishedYrLabel.Location = new System.Drawing.Point(615, 121);
            this.publishedYrLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.publishedYrLabel.Name = "publishedYrLabel";
            this.publishedYrLabel.Size = new System.Drawing.Size(44, 13);
            this.publishedYrLabel.TabIndex = 62;
            this.publishedYrLabel.Text = "ปีที่พิมพ์";
            // 
            // publishedYrBox
            // 
            this.publishedYrBox.FormattingEnabled = true;
            this.publishedYrBox.Items.AddRange(new object[] {
            "2580",
            "2579",
            "2578",
            "2577",
            "2576",
            "2575",
            "2574",
            "2573",
            "2572",
            "2571",
            "2570",
            "2569",
            "2568",
            "2567",
            "2566",
            "2565",
            "2564",
            "2563",
            "2562",
            "2561",
            "2560",
            "2559",
            "2558",
            "2557",
            "2556",
            "2555",
            "2554",
            "2553",
            "2552",
            "2551",
            "2550",
            "2549",
            "2548",
            "2547",
            "2546",
            "2545",
            "2544",
            "2543",
            "2542",
            "2541",
            "2540",
            "2539",
            "2538",
            "2537",
            "2536",
            "2535",
            "2534",
            "2533",
            "2532",
            "2531",
            "2530",
            "2529",
            "2528",
            "2527",
            "2526",
            "2525",
            "2524",
            "2523",
            "2522",
            "2521",
            "2520",
            "2519",
            "2518",
            "2517",
            "2516",
            "2515",
            "2514",
            "2513",
            "2512",
            "2511",
            "2510",
            "2509",
            "2508",
            "2507",
            "2506",
            "2505",
            "2504",
            "2503",
            "2502",
            "2501",
            "2500"});
            this.publishedYrBox.Location = new System.Drawing.Point(679, 116);
            this.publishedYrBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.publishedYrBox.Name = "publishedYrBox";
            this.publishedYrBox.Size = new System.Drawing.Size(72, 21);
            this.publishedYrBox.TabIndex = 57;
            // 
            // borrowBtn
            // 
            this.borrowBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.borrowBtn.Font = new System.Drawing.Font("TF Lanna", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowBtn.Location = new System.Drawing.Point(811, 151);
            this.borrowBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.borrowBtn.Name = "borrowBtn";
            this.borrowBtn.Size = new System.Drawing.Size(116, 30);
            this.borrowBtn.TabIndex = 60;
            this.borrowBtn.Text = "ยืมหนังสือ";
            this.borrowBtn.UseVisualStyleBackColor = false;
            this.borrowBtn.Click += new System.EventHandler(this.borrowBtn_Click);
            // 
            // writerLabel
            // 
            this.writerLabel.AutoSize = true;
            this.writerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.writerLabel.Location = new System.Drawing.Point(35, 119);
            this.writerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.writerLabel.Name = "writerLabel";
            this.writerLabel.Size = new System.Drawing.Size(47, 13);
            this.writerLabel.TabIndex = 67;
            this.writerLabel.Text = "ชื่อผู้แต่ง";
            // 
            // writerField
            // 
            this.writerField.Location = new System.Drawing.Point(93, 116);
            this.writerField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.writerField.Name = "writerField";
            this.writerField.Size = new System.Drawing.Size(378, 20);
            this.writerField.TabIndex = 55;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelBtn.Font = new System.Drawing.Font("TF Lanna", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(811, 648);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(116, 30);
            this.cancelBtn.TabIndex = 61;
            this.cancelBtn.Text = "ยกเลิก";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchBtn.Font = new System.Drawing.Font("TF Lanna", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(679, 151);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(116, 30);
            this.searchBtn.TabIndex = 59;
            this.searchBtn.Text = "ค้นหา";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // bookDetail
            // 
            this.bookDetail.AllowUserToAddRows = false;
            this.bookDetail.AllowUserToDeleteRows = false;
            this.bookDetail.AllowUserToOrderColumns = true;
            this.bookDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.booknameColumn,
            this.total,
            this.categoryColumn,
            this.writerColumn,
            this.translatorColumn,
            this.publisherColumn,
            this.publishedYrColumn,
            this.editionColumn,
            this.ISBNColumn,
            this.deweyColumn});
            this.bookDetail.Location = new System.Drawing.Point(39, 204);
            this.bookDetail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bookDetail.Name = "bookDetail";
            this.bookDetail.ReadOnly = true;
            this.bookDetail.Size = new System.Drawing.Size(888, 424);
            this.bookDetail.TabIndex = 62;
            // 
            // booknameColumn
            // 
            this.booknameColumn.HeaderText = "ชื่อหนังสือ";
            this.booknameColumn.Name = "booknameColumn";
            this.booknameColumn.ReadOnly = true;
            this.booknameColumn.Width = 200;
            // 
            // total
            // 
            this.total.HeaderText = "จำนวน";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 45;
            // 
            // categoryColumn
            // 
            this.categoryColumn.HeaderText = "หมวด";
            this.categoryColumn.Name = "categoryColumn";
            this.categoryColumn.ReadOnly = true;
            this.categoryColumn.Width = 120;
            // 
            // writerColumn
            // 
            this.writerColumn.HeaderText = "ผู้แต่ง";
            this.writerColumn.Name = "writerColumn";
            this.writerColumn.ReadOnly = true;
            this.writerColumn.Width = 150;
            // 
            // translatorColumn
            // 
            this.translatorColumn.HeaderText = "ผู้แปล";
            this.translatorColumn.Name = "translatorColumn";
            this.translatorColumn.ReadOnly = true;
            this.translatorColumn.Width = 150;
            // 
            // publisherColumn
            // 
            this.publisherColumn.HeaderText = "สำนักพิมพ์";
            this.publisherColumn.Name = "publisherColumn";
            this.publisherColumn.ReadOnly = true;
            // 
            // publishedYrColumn
            // 
            this.publishedYrColumn.HeaderText = "ปีที่พิมพ์";
            this.publishedYrColumn.Name = "publishedYrColumn";
            this.publishedYrColumn.ReadOnly = true;
            this.publishedYrColumn.Width = 50;
            // 
            // editionColumn
            // 
            this.editionColumn.HeaderText = "พิมพ์ครั้งที่";
            this.editionColumn.Name = "editionColumn";
            this.editionColumn.ReadOnly = true;
            this.editionColumn.Width = 50;
            // 
            // ISBNColumn
            // 
            this.ISBNColumn.HeaderText = "เลขประจำหนังสือ (ISBN)";
            this.ISBNColumn.Name = "ISBNColumn";
            this.ISBNColumn.ReadOnly = true;
            // 
            // deweyColumn
            // 
            this.deweyColumn.HeaderText = "เลขเรียกหนังสือตามระบบดิวอี้";
            this.deweyColumn.Name = "deweyColumn";
            this.deweyColumn.ReadOnly = true;
            // 
            // BorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.bookDetail);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.writerLabel);
            this.Controls.Add(this.writerField);
            this.Controls.Add(this.borrowBtn);
            this.Controls.Add(this.editionLabel);
            this.Controls.Add(this.editionField);
            this.Controls.Add(this.publishedYrLabel);
            this.Controls.Add(this.publishedYrBox);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.borrowerLabel);
            this.Controls.Add(this.borrowerField);
            this.Controls.Add(this.ISBNLabel);
            this.Controls.Add(this.ISBNField);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameField);
            this.Name = "BorrowBook";
            this.Text = "ยืมหนังสือ";
            this.Load += new System.EventHandler(this.BorrowBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label borrowerLabel;
        private System.Windows.Forms.TextBox borrowerField;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.TextBox ISBNField;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label editionLabel;
        private System.Windows.Forms.TextBox editionField;
        private System.Windows.Forms.Label publishedYrLabel;
        private System.Windows.Forms.ComboBox publishedYrBox;
        private System.Windows.Forms.Button borrowBtn;
        private System.Windows.Forms.Label writerLabel;
        private System.Windows.Forms.TextBox writerField;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView bookDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn booknameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn writerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn translatorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishedYrColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBNColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deweyColumn;
    }
}