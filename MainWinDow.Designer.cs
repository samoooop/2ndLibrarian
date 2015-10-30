namespace WindowsFormsApplication1
{
    partial class MainWindow
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
            this.searchBtn = new System.Windows.Forms.Button();
            this.nameField = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.subNameLabel = new System.Windows.Forms.Label();
            this.subNameField = new System.Windows.Forms.TextBox();
            this.writerLabel = new System.Windows.Forms.Label();
            this.writerField = new System.Windows.Forms.TextBox();
            this.translatorLabel = new System.Windows.Forms.Label();
            this.translatorField = new System.Windows.Forms.TextBox();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.publisherField = new System.Windows.Forms.TextBox();
            this.publishedYrBox = new System.Windows.Forms.ComboBox();
            this.publishedYrLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.returnBtn = new System.Windows.Forms.Button();
            this.adddelBookBtn = new System.Windows.Forms.Button();
            this.borrowBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchBtn.Font = new System.Drawing.Font("TF Lanna", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(810, 185);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(116, 30);
            this.searchBtn.TabIndex = 8;
            this.searchBtn.Text = "ค้นหา";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(92, 76);
            this.nameField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(378, 20);
            this.nameField.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameLabel.Location = new System.Drawing.Point(34, 79);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "ชื่อหนังสือ";
            // 
            // subNameLabel
            // 
            this.subNameLabel.AutoSize = true;
            this.subNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subNameLabel.Location = new System.Drawing.Point(484, 79);
            this.subNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subNameLabel.Name = "subNameLabel";
            this.subNameLabel.Size = new System.Drawing.Size(59, 13);
            this.subNameLabel.TabIndex = 4;
            this.subNameLabel.Text = "ชื่อเรื่องรอง";
            // 
            // subNameField
            // 
            this.subNameField.Location = new System.Drawing.Point(548, 76);
            this.subNameField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.subNameField.Name = "subNameField";
            this.subNameField.Size = new System.Drawing.Size(378, 20);
            this.subNameField.TabIndex = 2;
            // 
            // writerLabel
            // 
            this.writerLabel.AutoSize = true;
            this.writerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.writerLabel.Location = new System.Drawing.Point(34, 115);
            this.writerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.writerLabel.Name = "writerLabel";
            this.writerLabel.Size = new System.Drawing.Size(47, 13);
            this.writerLabel.TabIndex = 6;
            this.writerLabel.Text = "ชื่อผู้แต่ง";
            // 
            // writerField
            // 
            this.writerField.Location = new System.Drawing.Point(92, 112);
            this.writerField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.writerField.Name = "writerField";
            this.writerField.Size = new System.Drawing.Size(378, 20);
            this.writerField.TabIndex = 3;
            // 
            // translatorLabel
            // 
            this.translatorLabel.AutoSize = true;
            this.translatorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.translatorLabel.Location = new System.Drawing.Point(484, 116);
            this.translatorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.translatorLabel.Name = "translatorLabel";
            this.translatorLabel.Size = new System.Drawing.Size(48, 13);
            this.translatorLabel.TabIndex = 8;
            this.translatorLabel.Text = "ชื่อผู้แปล";
            // 
            // translatorField
            // 
            this.translatorField.Location = new System.Drawing.Point(548, 113);
            this.translatorField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.translatorField.Name = "translatorField";
            this.translatorField.Size = new System.Drawing.Size(378, 20);
            this.translatorField.TabIndex = 4;
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.publisherLabel.Location = new System.Drawing.Point(34, 151);
            this.publisherLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(56, 13);
            this.publisherLabel.TabIndex = 10;
            this.publisherLabel.Text = "สำนักพิมพ์";
            // 
            // publisherField
            // 
            this.publisherField.Location = new System.Drawing.Point(92, 148);
            this.publisherField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.publisherField.Name = "publisherField";
            this.publisherField.Size = new System.Drawing.Size(378, 20);
            this.publisherField.TabIndex = 5;
            // 
            // publishedYrBox
            // 
            this.publishedYrBox.FormattingEnabled = true;
            this.publishedYrBox.IntegralHeight = false;
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
            this.publishedYrBox.Location = new System.Drawing.Point(548, 147);
            this.publishedYrBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.publishedYrBox.Name = "publishedYrBox";
            this.publishedYrBox.Size = new System.Drawing.Size(72, 21);
            this.publishedYrBox.TabIndex = 6;
            // 
            // publishedYrLabel
            // 
            this.publishedYrLabel.AutoSize = true;
            this.publishedYrLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.publishedYrLabel.Location = new System.Drawing.Point(484, 152);
            this.publishedYrLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.publishedYrLabel.Name = "publishedYrLabel";
            this.publishedYrLabel.Size = new System.Drawing.Size(44, 13);
            this.publishedYrLabel.TabIndex = 12;
            this.publishedYrLabel.Text = "ปีที่พิมพ์";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryLabel.Location = new System.Drawing.Point(642, 152);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(34, 13);
            this.categoryLabel.TabIndex = 14;
            this.categoryLabel.Text = "หมวด";
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "   000 เบ็ตเตล็ดหรือความรู้ทั่วไป (Generalities)  ​",
            "   100 ปรัชญา (Philosophy)  ​",
            "   200 ศาสนา (Religion)  ​",
            "   300 สังคมศาสตร์ (Social sciences)  ​",
            "   400 ภาษาศาสตร์ (Language)  ​",
            "   500 วิทยาศาสตร์ (Science)  ​",
            "   600 วิทยาศาสตร์ประยุกต์ หรือเทคโนโลยี (Technology)  ​",
            "   700 ศิลปกรรมและการบันเทิง (Arts and recreation)  ​",
            "   800 วรรณคดี (Literature)  ​",
            "   900 ประวัติศาสตร์และภูมิศาสตร์ (History and geography)  ​"});
            this.categoryBox.Location = new System.Drawing.Point(694, 147);
            this.categoryBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(234, 21);
            this.categoryBox.TabIndex = 7;
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
            this.bookDetail.Location = new System.Drawing.Point(26, 230);
            this.bookDetail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bookDetail.Name = "bookDetail";
            this.bookDetail.ReadOnly = true;
            this.bookDetail.Size = new System.Drawing.Size(900, 400);
            this.bookDetail.TabIndex = 9;
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
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerLabel.Font = new System.Drawing.Font("TF Lanna", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(32, 40);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(95, 28);
            this.headerLabel.TabIndex = 16;
            this.headerLabel.Text = "ค้นหาหนังสือ";
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.returnBtn.Font = new System.Drawing.Font("TF Lanna", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.Location = new System.Drawing.Point(678, 661);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(116, 30);
            this.returnBtn.TabIndex = 11;
            this.returnBtn.Text = " คืนหนังสือ";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // adddelBookBtn
            // 
            this.adddelBookBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.adddelBookBtn.Font = new System.Drawing.Font("TF Lanna", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adddelBookBtn.Location = new System.Drawing.Point(812, 661);
            this.adddelBookBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.adddelBookBtn.Name = "adddelBookBtn";
            this.adddelBookBtn.Size = new System.Drawing.Size(116, 30);
            this.adddelBookBtn.TabIndex = 12;
            this.adddelBookBtn.Text = "เพิ่ม / ลบหนังสือ";
            this.adddelBookBtn.UseVisualStyleBackColor = false;
            this.adddelBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // borrowBtn
            // 
            this.borrowBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.borrowBtn.Font = new System.Drawing.Font("TF Lanna", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowBtn.Location = new System.Drawing.Point(542, 661);
            this.borrowBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.borrowBtn.Name = "borrowBtn";
            this.borrowBtn.Size = new System.Drawing.Size(116, 30);
            this.borrowBtn.TabIndex = 10;
            this.borrowBtn.Text = "ยืมหนังสือ";
            this.borrowBtn.UseVisualStyleBackColor = false;
            this.borrowBtn.Click += new System.EventHandler(this.borrowBtn_Click_1);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.borrowBtn);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.adddelBookBtn);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.bookDetail);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.publishedYrLabel);
            this.Controls.Add(this.publishedYrBox);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.publisherField);
            this.Controls.Add(this.translatorLabel);
            this.Controls.Add(this.translatorField);
            this.Controls.Add(this.writerLabel);
            this.Controls.Add(this.writerField);
            this.Controls.Add(this.subNameLabel);
            this.Controls.Add(this.subNameField);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.searchBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainWindow";
            this.Text = "ห้องสมุดโรงเรียนบ้านธารทองแดง";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label subNameLabel;
        private System.Windows.Forms.TextBox subNameField;
        private System.Windows.Forms.Label writerLabel;
        private System.Windows.Forms.TextBox writerField;
        private System.Windows.Forms.Label translatorLabel;
        private System.Windows.Forms.TextBox translatorField;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.TextBox publisherField;
        private System.Windows.Forms.ComboBox publishedYrBox;
        private System.Windows.Forms.Label publishedYrLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button adddelBookBtn;
        private System.Windows.Forms.Button borrowBtn;
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
        private System.Windows.Forms.DataGridView bookDetail;
    }
}

