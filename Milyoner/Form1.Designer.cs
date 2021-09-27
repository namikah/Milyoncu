namespace Milyoner
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoyaQayitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neticelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btyari = new System.Windows.Forms.Button();
            this.btsuallar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bta = new System.Windows.Forms.Button();
            this.btb = new System.Windows.Forms.Button();
            this.btc = new System.Windows.Forms.Button();
            this.btd = new System.Windows.Forms.Button();
            this.btvaxt = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lblad = new System.Windows.Forms.Button();
            this.mediaplayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btsualsayi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.ForeColor = System.Drawing.Color.Red;
            this.listBox1.Location = new System.Drawing.Point(361, 703);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(34, 43);
            this.listBox1.TabIndex = 5;
            this.listBox1.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.BackColor = System.Drawing.Color.Black;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox2.Enabled = false;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.listBox2.ItemHeight = 39;
            this.listBox2.Items.AddRange(new object[] {
            "100 000  Manat ------- 15",
            "  50 000  Manat ------- 14",
            "  25 000  Manat ------- 13",
            "  10 000  Manat ------- 12",
            "    5 000  Manat ------- 11",
            "    2 500  Manat ------- 10",
            "    1 000  Manat ------- 09",
            "       750  Manat ------- 08",
            "       500  Manat ------- 07",
            "       250  Manat ------- 06",
            "       100  Manat ------- 05",
            "         50  Manat ------- 04",
            "         25  Manat ------- 03",
            "         10  Manat ------- 02",
            "           5  Manat ------- 01"});
            this.listBox2.Location = new System.Drawing.Point(951, 28);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(407, 702);
            this.listBox2.TabIndex = 6;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Milyoner.Properties.Resources.milyonc3a7u;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(945, 763);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.sesToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1378, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.logoyaQayitToolStripMenuItem,
            this.neticelerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.fileToolStripMenuItem.Text = "Fayl";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.newToolStripMenuItem.Text = "Yeni Oyun";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // logoyaQayitToolStripMenuItem
            // 
            this.logoyaQayitToolStripMenuItem.Name = "logoyaQayitToolStripMenuItem";
            this.logoyaQayitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.logoyaQayitToolStripMenuItem.Text = "Logoya Qayit";
            this.logoyaQayitToolStripMenuItem.Click += new System.EventHandler(this.logoyaQayitToolStripMenuItem_Click);
            // 
            // neticelerToolStripMenuItem
            // 
            this.neticelerToolStripMenuItem.Name = "neticelerToolStripMenuItem";
            this.neticelerToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.neticelerToolStripMenuItem.Text = "Neticeler";
            this.neticelerToolStripMenuItem.Click += new System.EventHandler(this.neticelerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "Cixis";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.aboutToolStripMenuItem.Text = "Haqqinda";
            // 
            // sesToolStripMenuItem
            // 
            this.sesToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.sesToolStripMenuItem.Name = "sesToolStripMenuItem";
            this.sesToolStripMenuItem.Size = new System.Drawing.Size(43, 21);
            this.sesToolStripMenuItem.Text = "Ses";
            this.sesToolStripMenuItem.Click += new System.EventHandler(this.sesToolStripMenuItem_Click);
            // 
            // btyari
            // 
            this.btyari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btyari.BackColor = System.Drawing.Color.Black;
            this.btyari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btyari.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btyari.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btyari.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btyari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btyari.ForeColor = System.Drawing.Color.Red;
            this.btyari.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btyari.Location = new System.Drawing.Point(814, 28);
            this.btyari.Name = "btyari";
            this.btyari.Size = new System.Drawing.Size(87, 39);
            this.btyari.TabIndex = 16;
            this.btyari.Text = "50/50";
            this.btyari.UseVisualStyleBackColor = false;
            this.btyari.Click += new System.EventHandler(this.button2_Click);
            // 
            // btsuallar
            // 
            this.btsuallar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btsuallar.BackColor = System.Drawing.Color.Teal;
            this.btsuallar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btsuallar.BackgroundImage")));
            this.btsuallar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btsuallar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btsuallar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btsuallar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btsuallar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btsuallar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsuallar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsuallar.ForeColor = System.Drawing.Color.Black;
            this.btsuallar.Location = new System.Drawing.Point(54, 467);
            this.btsuallar.Name = "btsuallar";
            this.btsuallar.Size = new System.Drawing.Size(651, 129);
            this.btsuallar.TabIndex = 17;
            this.btsuallar.Text = "Salam eziz oyuncular. Bu program Heydarov Namiq terefinden duzeldilib...";
            this.btsuallar.UseVisualStyleBackColor = false;
            this.btsuallar.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(421, 703);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 27);
            this.label4.TabIndex = 21;
            this.label4.Text = "D)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.UseCompatibleTextRendering = true;
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(60, 703);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 27);
            this.label3.TabIndex = 20;
            this.label3.Text = "C)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.UseCompatibleTextRendering = true;
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(422, 629);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = "B)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseCompatibleTextRendering = true;
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(61, 629);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 27);
            this.label1.TabIndex = 18;
            this.label1.Text = "A)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Visible = false;
            // 
            // bta
            // 
            this.bta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bta.BackColor = System.Drawing.Color.Black;
            this.bta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bta.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bta.Location = new System.Drawing.Point(93, 614);
            this.bta.Name = "bta";
            this.bta.Size = new System.Drawing.Size(250, 55);
            this.bta.TabIndex = 22;
            this.bta.Text = "button1";
            this.bta.UseVisualStyleBackColor = false;
            this.bta.Visible = false;
            this.bta.Click += new System.EventHandler(this.button3_Click);
            // 
            // btb
            // 
            this.btb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btb.BackColor = System.Drawing.Color.Black;
            this.btb.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btb.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btb.Location = new System.Drawing.Point(455, 614);
            this.btb.Name = "btb";
            this.btb.Size = new System.Drawing.Size(250, 55);
            this.btb.TabIndex = 23;
            this.btb.Text = "button2";
            this.btb.UseVisualStyleBackColor = false;
            this.btb.Visible = false;
            this.btb.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btc
            // 
            this.btc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btc.BackColor = System.Drawing.Color.Black;
            this.btc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btc.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btc.Location = new System.Drawing.Point(93, 688);
            this.btc.Name = "btc";
            this.btc.Size = new System.Drawing.Size(250, 54);
            this.btc.TabIndex = 24;
            this.btc.Text = "button3";
            this.btc.UseVisualStyleBackColor = false;
            this.btc.Visible = false;
            this.btc.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btd
            // 
            this.btd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btd.BackColor = System.Drawing.Color.Black;
            this.btd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btd.Location = new System.Drawing.Point(455, 688);
            this.btd.Name = "btd";
            this.btd.Size = new System.Drawing.Size(250, 54);
            this.btd.TabIndex = 25;
            this.btd.Text = "button4";
            this.btd.UseVisualStyleBackColor = false;
            this.btd.Visible = false;
            this.btd.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // btvaxt
            // 
            this.btvaxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btvaxt.BackgroundImage = global::Milyoner.Properties.Resources.milyonc3a7u;
            this.btvaxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btvaxt.Enabled = false;
            this.btvaxt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btvaxt.FlatAppearance.BorderSize = 0;
            this.btvaxt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btvaxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btvaxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvaxt.ForeColor = System.Drawing.Color.White;
            this.btvaxt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btvaxt.Location = new System.Drawing.Point(0, 103);
            this.btvaxt.Name = "btvaxt";
            this.btvaxt.Size = new System.Drawing.Size(298, 36);
            this.btvaxt.TabIndex = 27;
            this.btvaxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btvaxt.UseVisualStyleBackColor = false;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lblad
            // 
            this.lblad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblad.BackgroundImage = global::Milyoner.Properties.Resources.milyonc3a7u;
            this.lblad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lblad.Enabled = false;
            this.lblad.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.lblad.FlatAppearance.BorderSize = 0;
            this.lblad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblad.ForeColor = System.Drawing.Color.White;
            this.lblad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblad.Location = new System.Drawing.Point(0, 61);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(298, 36);
            this.lblad.TabIndex = 28;
            this.lblad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblad.UseVisualStyleBackColor = false;
            // 
            // mediaplayer
            // 
            this.mediaplayer.Enabled = true;
            this.mediaplayer.Location = new System.Drawing.Point(3, 28);
            this.mediaplayer.Name = "mediaplayer";
            this.mediaplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaplayer.OcxState")));
            this.mediaplayer.Size = new System.Drawing.Size(230, 47);
            this.mediaplayer.TabIndex = 29;
            this.mediaplayer.Visible = false;
            this.mediaplayer.Enter += new System.EventHandler(this.mediaplayer_Enter);
            // 
            // btsualsayi
            // 
            this.btsualsayi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btsualsayi.BackgroundImage = global::Milyoner.Properties.Resources.milyonc3a7u;
            this.btsualsayi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btsualsayi.Enabled = false;
            this.btsualsayi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btsualsayi.FlatAppearance.BorderSize = 0;
            this.btsualsayi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btsualsayi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsualsayi.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsualsayi.ForeColor = System.Drawing.Color.White;
            this.btsualsayi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsualsayi.Location = new System.Drawing.Point(0, 145);
            this.btsualsayi.Name = "btsualsayi";
            this.btsualsayi.Size = new System.Drawing.Size(298, 36);
            this.btsualsayi.TabIndex = 30;
            this.btsualsayi.Text = "Itirilməyən məbləğ:  0 manat";
            this.btsualsayi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsualsayi.UseVisualStyleBackColor = false;
            this.btsualsayi.Click += new System.EventHandler(this.btsualsayi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1378, 780);
            this.Controls.Add(this.btsualsayi);
            this.Controls.Add(this.mediaplayer);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.btvaxt);
            this.Controls.Add(this.btd);
            this.Controls.Add(this.btc);
            this.Controls.Add(this.btb);
            this.Controls.Add(this.bta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btsuallar);
            this.Controls.Add(this.btyari);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem neticelerToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btyari;
        private System.Windows.Forms.Button btsuallar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bta;
        private System.Windows.Forms.Button btb;
        private System.Windows.Forms.Button btc;
        private System.Windows.Forms.Button btd;
        /*private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
         */
        private System.Windows.Forms.ToolStripMenuItem logoyaQayitToolStripMenuItem;
        private System.Windows.Forms.Button btvaxt;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button lblad;
        public AxWMPLib.AxWindowsMediaPlayer mediaplayer;
        private System.Windows.Forms.ToolStripMenuItem sesToolStripMenuItem;
        private System.Windows.Forms.Button btsualsayi;
    }
}

