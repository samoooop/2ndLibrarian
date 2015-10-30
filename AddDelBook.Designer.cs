namespace WindowsFormsApplication1
{
    partial class AddDelBook
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.publishedYrLabel = new System.Windows.Forms.Label();
            this.publishedYrBox = new System.Windows.Forms.ComboBox();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.publisherField = new System.Windows.Forms.TextBox();
            this.translatorLabel = new System.Windows.Forms.Label();
            this.translatorField = new System.Windows.Forms.TextBox();
            this.writerLabel = new System.Windows.Forms.Label();
            this.writerField = new System.Windows.Forms.TextBox();
            this.subNameLabel = new System.Windows.Forms.Label();
            this.subNameField = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.subwriterLabel = new System.Windows.Forms.Label();
            this.subwriterField = new System.Windows.Forms.TextBox();
            this.editionLabel = new System.Windows.Forms.Label();
            this.editionField = new System.Windows.Forms.TextBox();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.ISBNField = new System.Windows.Forms.TextBox();
            this.deweylabel = new System.Windows.Forms.Label();
            this.deweyField = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountField = new System.Windows.Forms.TextBox();
            this.piece = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.delnameLabel = new System.Windows.Forms.Label();
            this.delnameField = new System.Windows.Forms.TextBox();
            this.delpieceLabel = new System.Windows.Forms.Label();
            this.delamountLabel = new System.Windows.Forms.Label();
            this.delamountField = new System.Windows.Forms.TextBox();
            this.delISBNLabel = new System.Windows.Forms.Label();
            this.delISBNField = new System.Windows.Forms.TextBox();
            this.delBtn = new System.Windows.Forms.Button();
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
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerLabel.Font = new System.Drawing.Font("TF Lanna", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(32, 40);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(83, 28);
            this.headerLabel.TabIndex = 32;
            this.headerLabel.Text = "เพิ่มหนังสือ";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryLabel.Location = new System.Drawing.Point(484, 153);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(34, 13);
            this.categoryLabel.TabIndex = 31;
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
            this.categoryBox.Location = new System.Drawing.Point(549, 147);
            this.categoryBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(377, 21);
            this.categoryBox.TabIndex = 23;
            // 
            // publishedYrLabel
            // 
            this.publishedYrLabel.AutoSize = true;
            this.publishedYrLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.publishedYrLabel.Location = new System.Drawing.Point(608, 187);
            this.publishedYrLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.publishedYrLabel.Name = "publishedYrLabel";
            this.publishedYrLabel.Size = new System.Drawing.Size(44, 13);
            this.publishedYrLabel.TabIndex = 29;
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
            this.publishedYrBox.Location = new System.Drawing.Point(672, 182);
            this.publishedYrBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.publishedYrBox.Name = "publishedYrBox";
            this.publishedYrBox.Size = new System.Drawing.Size(72, 21);
            this.publishedYrBox.TabIndex = 26;
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.publisherLabel.Location = new System.Drawing.Point(34, 187);
            this.publisherLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(56, 13);
            this.publisherLabel.TabIndex = 27;
            this.publisherLabel.Text = "สำนักพิมพ์";
            // 
            // publisherField
            // 
            this.publisherField.Location = new System.Drawing.Point(92, 184);
            this.publisherField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.publisherField.Name = "publisherField";
            this.publisherField.Size = new System.Drawing.Size(378, 20);
            this.publisherField.TabIndex = 24;
            // 
            // translatorLabel
            // 
            this.translatorLabel.AutoSize = true;
            this.translatorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.translatorLabel.Location = new System.Drawing.Point(35, 151);
            this.translatorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.translatorLabel.Name = "translatorLabel";
            this.translatorLabel.Size = new System.Drawing.Size(48, 13);
            this.translatorLabel.TabIndex = 25;
            this.translatorLabel.Text = "ชื่อผู้แปล";
            // 
            // translatorField
            // 
            this.translatorField.Location = new System.Drawing.Point(92, 148);
            this.translatorField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.translatorField.Name = "translatorField";
            this.translatorField.Size = new System.Drawing.Size(378, 20);
            this.translatorField.TabIndex = 22;
            // 
            // writerLabel
            // 
            this.writerLabel.AutoSize = true;
            this.writerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.writerLabel.Location = new System.Drawing.Point(34, 115);
            this.writerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.writerLabel.Name = "writerLabel";
            this.writerLabel.Size = new System.Drawing.Size(47, 13);
            this.writerLabel.TabIndex = 23;
            this.writerLabel.Text = "ชื่อผู้แต่ง";
            // 
            // writerField
            // 
            this.writerField.Location = new System.Drawing.Point(92, 112);
            this.writerField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.writerField.Name = "writerField";
            this.writerField.Size = new System.Drawing.Size(378, 20);
            this.writerField.TabIndex = 20;
            // 
            // subNameLabel
            // 
            this.subNameLabel.AutoSize = true;
            this.subNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subNameLabel.Location = new System.Drawing.Point(484, 79);
            this.subNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subNameLabel.Name = "subNameLabel";
            this.subNameLabel.Size = new System.Drawing.Size(59, 13);
            this.subNameLabel.TabIndex = 21;
            this.subNameLabel.Text = "ชื่อเรื่องรอง";
            // 
            // subNameField
            // 
            this.subNameField.Location = new System.Drawing.Point(548, 76);
            this.subNameField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.subNameField.Name = "subNameField";
            this.subNameField.Size = new System.Drawing.Size(378, 20);
            this.subNameField.TabIndex = 19;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameLabel.Location = new System.Drawing.Point(34, 79);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 13);
            this.nameLabel.TabIndex = 19;
            this.nameLabel.Text = "ชื่อหนังสือ";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(92, 76);
            this.nameField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(378, 20);
            this.nameField.TabIndex = 18;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addBtn.Font = new System.Drawing.Font("TF Lanna", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(810, 245);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(116, 30);
            this.addBtn.TabIndex = 30;
            this.addBtn.Text = "เพิ่มหนังสือ";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // subwriterLabel
            // 
            this.subwriterLabel.AutoSize = true;
            this.subwriterLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subwriterLabel.Location = new System.Drawing.Point(484, 115);
            this.subwriterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subwriterLabel.Name = "subwriterLabel";
            this.subwriterLabel.Size = new System.Drawing.Size(64, 13);
            this.subwriterLabel.TabIndex = 34;
            this.subwriterLabel.Text = "ชื่อผู้แต่งรอง";
            // 
            // subwriterField
            // 
            this.subwriterField.Location = new System.Drawing.Point(549, 112);
            this.subwriterField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.subwriterField.Name = "subwriterField";
            this.subwriterField.Size = new System.Drawing.Size(377, 20);
            this.subwriterField.TabIndex = 21;
            // 
            // editionLabel
            // 
            this.editionLabel.AutoSize = true;
            this.editionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editionLabel.Location = new System.Drawing.Point(484, 186);
            this.editionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editionLabel.Name = "editionLabel";
            this.editionLabel.Size = new System.Drawing.Size(55, 13);
            this.editionLabel.TabIndex = 36;
            this.editionLabel.Text = "ครั้งที่พิมพ์";
            // 
            // editionField
            // 
            this.editionField.Location = new System.Drawing.Point(549, 183);
            this.editionField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.editionField.Name = "editionField";
            this.editionField.Size = new System.Drawing.Size(45, 20);
            this.editionField.TabIndex = 25;
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ISBNLabel.Location = new System.Drawing.Point(34, 222);
            this.ISBNLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(119, 13);
            this.ISBNLabel.TabIndex = 38;
            this.ISBNLabel.Text = "เลขประจำหนังสือ (ISBN)";
            // 
            // ISBNField
            // 
            this.ISBNField.Location = new System.Drawing.Point(157, 219);
            this.ISBNField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ISBNField.Name = "ISBNField";
            this.ISBNField.Size = new System.Drawing.Size(313, 20);
            this.ISBNField.TabIndex = 27;
            // 
            // deweylabel
            // 
            this.deweylabel.AutoSize = true;
            this.deweylabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deweylabel.Location = new System.Drawing.Point(483, 222);
            this.deweylabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deweylabel.Name = "deweylabel";
            this.deweylabel.Size = new System.Drawing.Size(144, 13);
            this.deweylabel.TabIndex = 40;
            this.deweylabel.Text = "เลขเรียกหนังสือตามระบบดิวอี้";
            // 
            // deweyField
            // 
            this.deweyField.Location = new System.Drawing.Point(631, 219);
            this.deweyField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deweyField.Name = "deweyField";
            this.deweyField.Size = new System.Drawing.Size(295, 20);
            this.deweyField.TabIndex = 28;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.amountLabel.Location = new System.Drawing.Point(35, 253);
            this.amountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(40, 13);
            this.amountLabel.TabIndex = 42;
            this.amountLabel.Text = "จำนวน";
            // 
            // amountField
            // 
            this.amountField.Location = new System.Drawing.Point(92, 250);
            this.amountField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.amountField.Name = "amountField";
            this.amountField.Size = new System.Drawing.Size(89, 20);
            this.amountField.TabIndex = 29;
            // 
            // piece
            // 
            this.piece.AutoSize = true;
            this.piece.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.piece.Location = new System.Drawing.Point(202, 253);
            this.piece.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.piece.Name = "piece";
            this.piece.Size = new System.Drawing.Size(25, 13);
            this.piece.TabIndex = 43;
            this.piece.Text = "เล่ม";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelBtn.Font = new System.Drawing.Font("TF Lanna", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(810, 657);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(116, 30);
            this.cancelBtn.TabIndex = 36;
            this.cancelBtn.Text = "ยกเลิก";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteLabel.Font = new System.Drawing.Font("TF Lanna", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLabel.Location = new System.Drawing.Point(32, 311);
            this.deleteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(76, 28);
            this.deleteLabel.TabIndex = 47;
            this.deleteLabel.Text = "ลบหนังสือ";
            // 
            // delnameLabel
            // 
            this.delnameLabel.AutoSize = true;
            this.delnameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delnameLabel.Location = new System.Drawing.Point(34, 350);
            this.delnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.delnameLabel.Name = "delnameLabel";
            this.delnameLabel.Size = new System.Drawing.Size(52, 13);
            this.delnameLabel.TabIndex = 46;
            this.delnameLabel.Text = "ชื่อหนังสือ";
            // 
            // delnameField
            // 
            this.delnameField.Location = new System.Drawing.Point(92, 347);
            this.delnameField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.delnameField.Name = "delnameField";
            this.delnameField.Size = new System.Drawing.Size(378, 20);
            this.delnameField.TabIndex = 31;
            // 
            // delpieceLabel
            // 
            this.delpieceLabel.AutoSize = true;
            this.delpieceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delpieceLabel.Location = new System.Drawing.Point(202, 382);
            this.delpieceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.delpieceLabel.Name = "delpieceLabel";
            this.delpieceLabel.Size = new System.Drawing.Size(25, 13);
            this.delpieceLabel.TabIndex = 52;
            this.delpieceLabel.Text = "เล่ม";
            // 
            // delamountLabel
            // 
            this.delamountLabel.AutoSize = true;
            this.delamountLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delamountLabel.Location = new System.Drawing.Point(35, 382);
            this.delamountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.delamountLabel.Name = "delamountLabel";
            this.delamountLabel.Size = new System.Drawing.Size(40, 13);
            this.delamountLabel.TabIndex = 51;
            this.delamountLabel.Text = "จำนวน";
            // 
            // delamountField
            // 
            this.delamountField.Location = new System.Drawing.Point(92, 379);
            this.delamountField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.delamountField.Name = "delamountField";
            this.delamountField.Size = new System.Drawing.Size(89, 20);
            this.delamountField.TabIndex = 33;
            // 
            // delISBNLabel
            // 
            this.delISBNLabel.AutoSize = true;
            this.delISBNLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delISBNLabel.Location = new System.Drawing.Point(490, 350);
            this.delISBNLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.delISBNLabel.Name = "delISBNLabel";
            this.delISBNLabel.Size = new System.Drawing.Size(119, 13);
            this.delISBNLabel.TabIndex = 49;
            this.delISBNLabel.Text = "เลขประจำหนังสือ (ISBN)";
            // 
            // delISBNField
            // 
            this.delISBNField.Location = new System.Drawing.Point(613, 347);
            this.delISBNField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.delISBNField.Name = "delISBNField";
            this.delISBNField.Size = new System.Drawing.Size(313, 20);
            this.delISBNField.TabIndex = 32;
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.delBtn.Font = new System.Drawing.Font("TF Lanna", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.Location = new System.Drawing.Point(810, 374);
            this.delBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(116, 30);
            this.delBtn.TabIndex = 34;
            this.delBtn.Text = "ลบหนังสือ";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
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
            this.bookDetail.Location = new System.Drawing.Point(38, 421);
            this.bookDetail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bookDetail.Name = "bookDetail";
            this.bookDetail.ReadOnly = true;
            this.bookDetail.Size = new System.Drawing.Size(888, 230);
            this.bookDetail.TabIndex = 35;
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
            // AddDelBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.bookDetail);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.delpieceLabel);
            this.Controls.Add(this.delamountLabel);
            this.Controls.Add(this.delamountField);
            this.Controls.Add(this.delISBNLabel);
            this.Controls.Add(this.delISBNField);
            this.Controls.Add(this.deleteLabel);
            this.Controls.Add(this.delnameLabel);
            this.Controls.Add(this.delnameField);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.piece);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.amountField);
            this.Controls.Add(this.deweylabel);
            this.Controls.Add(this.deweyField);
            this.Controls.Add(this.ISBNLabel);
            this.Controls.Add(this.ISBNField);
            this.Controls.Add(this.editionLabel);
            this.Controls.Add(this.editionField);
            this.Controls.Add(this.subwriterLabel);
            this.Controls.Add(this.subwriterField);
            this.Controls.Add(this.headerLabel);
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
            this.Controls.Add(this.addBtn);
            this.Name = "AddDelBook";
            this.Text = "เพิ่ม / ลบหนังสือ";
            this.Load += new System.EventHandler(this.AddDelBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Label publishedYrLabel;
        private System.Windows.Forms.ComboBox publishedYrBox;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.TextBox publisherField;
        private System.Windows.Forms.Label translatorLabel;
        private System.Windows.Forms.TextBox translatorField;
        private System.Windows.Forms.Label writerLabel;
        private System.Windows.Forms.TextBox writerField;
        private System.Windows.Forms.Label subNameLabel;
        private System.Windows.Forms.TextBox subNameField;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label subwriterLabel;
        private System.Windows.Forms.TextBox subwriterField;
        private System.Windows.Forms.Label editionLabel;
        private System.Windows.Forms.TextBox editionField;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.TextBox ISBNField;
        private System.Windows.Forms.Label deweylabel;
        private System.Windows.Forms.TextBox deweyField;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox amountField;
        private System.Windows.Forms.Label piece;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label deleteLabel;
        private System.Windows.Forms.Label delnameLabel;
        private System.Windows.Forms.TextBox delnameField;
        private System.Windows.Forms.Label delpieceLabel;
        private System.Windows.Forms.Label delamountLabel;
        private System.Windows.Forms.TextBox delamountField;
        private System.Windows.Forms.Label delISBNLabel;
        private System.Windows.Forms.TextBox delISBNField;
        private System.Windows.Forms.Button delBtn;
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