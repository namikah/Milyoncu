namespace Milyoner
{
    partial class frmreklam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmreklam));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblM = new System.Windows.Forms.Label();
            this.LblL = new System.Windows.Forms.Label();
            this.lblI = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblO = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblU = new System.Windows.Forms.Label();
            this.btgiris = new System.Windows.Forms.Button();
            this.txtadiniz = new System.Windows.Forms.TextBox();
            this.lbladiniz = new System.Windows.Forms.Label();
            this.pr1 = new System.Windows.Forms.ProgressBar();
            this.ppeleng = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mediaplayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.ppeleng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM.ForeColor = System.Drawing.Color.Red;
            this.lblM.Location = new System.Drawing.Point(-85, 418);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(125, 108);
            this.lblM.TabIndex = 0;
            this.lblM.Text = "M";
            // 
            // LblL
            // 
            this.LblL.AutoSize = true;
            this.LblL.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblL.ForeColor = System.Drawing.Color.Red;
            this.LblL.Location = new System.Drawing.Point(489, 780);
            this.LblL.Name = "LblL";
            this.LblL.Size = new System.Drawing.Size(98, 108);
            this.LblL.TabIndex = 1;
            this.LblL.Text = "L";
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblI.ForeColor = System.Drawing.Color.Red;
            this.lblI.Location = new System.Drawing.Point(412, -76);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(72, 108);
            this.lblI.TabIndex = 2;
            this.lblI.Text = "I";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.ForeColor = System.Drawing.Color.Red;
            this.lblY.Location = new System.Drawing.Point(1369, 163);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(109, 108);
            this.lblY.TabIndex = 3;
            this.lblY.Text = "Y";
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblO.ForeColor = System.Drawing.Color.Red;
            this.lblO.Location = new System.Drawing.Point(674, -76);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(120, 108);
            this.lblO.TabIndex = 4;
            this.lblO.Text = "O";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.ForeColor = System.Drawing.Color.Red;
            this.lblN.Location = new System.Drawing.Point(795, 780);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(114, 108);
            this.lblN.TabIndex = 5;
            this.lblN.Text = "N";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.ForeColor = System.Drawing.Color.Red;
            this.lblC.Location = new System.Drawing.Point(1370, 163);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(114, 108);
            this.lblC.TabIndex = 6;
            this.lblC.Text = "C";
            // 
            // lblU
            // 
            this.lblU.AutoSize = true;
            this.lblU.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblU.ForeColor = System.Drawing.Color.Red;
            this.lblU.Location = new System.Drawing.Point(974, -76);
            this.lblU.Name = "lblU";
            this.lblU.Size = new System.Drawing.Size(114, 108);
            this.lblU.TabIndex = 7;
            this.lblU.Text = "U";
            // 
            // btgiris
            // 
            this.btgiris.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btgiris.BackColor = System.Drawing.Color.Black;
            this.btgiris.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btgiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btgiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btgiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btgiris.Location = new System.Drawing.Point(582, 479);
            this.btgiris.Name = "btgiris";
            this.btgiris.Size = new System.Drawing.Size(92, 38);
            this.btgiris.TabIndex = 8;
            this.btgiris.Text = "Giris";
            this.btgiris.UseVisualStyleBackColor = false;
            this.btgiris.Visible = false;
            this.btgiris.Click += new System.EventHandler(this.btgiris_Click);
            // 
            // txtadiniz
            // 
            this.txtadiniz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtadiniz.BackColor = System.Drawing.Color.Black;
            this.txtadiniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadiniz.ForeColor = System.Drawing.Color.White;
            this.txtadiniz.Location = new System.Drawing.Point(548, 412);
            this.txtadiniz.Name = "txtadiniz";
            this.txtadiniz.Size = new System.Drawing.Size(161, 31);
            this.txtadiniz.TabIndex = 9;
            this.txtadiniz.Visible = false;
            // 
            // lbladiniz
            // 
            this.lbladiniz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbladiniz.AutoSize = true;
            this.lbladiniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladiniz.ForeColor = System.Drawing.Color.White;
            this.lbladiniz.Location = new System.Drawing.Point(590, 375);
            this.lbladiniz.Name = "lbladiniz";
            this.lbladiniz.Size = new System.Drawing.Size(71, 25);
            this.lbladiniz.TabIndex = 10;
            this.lbladiniz.Text = "Adiniz";
            this.lbladiniz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbladiniz.Visible = false;
            // 
            // pr1
            // 
            this.pr1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pr1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pr1.Location = new System.Drawing.Point(395, 468);
            this.pr1.Name = "pr1";
            this.pr1.Size = new System.Drawing.Size(519, 23);
            this.pr1.TabIndex = 11;
            this.pr1.Visible = false;
            // 
            // ppeleng
            // 
            this.ppeleng.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ppeleng.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ppeleng.Image = ((System.Drawing.Image)(resources.GetObject("ppeleng.Image")));
            this.ppeleng.Location = new System.Drawing.Point(379, 412);
            this.ppeleng.Name = "ppeleng";
            this.ppeleng.Size = new System.Drawing.Size(92, 50);
            this.ppeleng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ppeleng.TabIndex = 12;
            this.ppeleng.TabStop = false;
            this.ppeleng.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 563);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1383, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // mediaplayer
            // 
            this.mediaplayer.Enabled = true;
            this.mediaplayer.Location = new System.Drawing.Point(512, 324);
            this.mediaplayer.Name = "mediaplayer";
            this.mediaplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaplayer.OcxState")));
            this.mediaplayer.Size = new System.Drawing.Size(230, 29);
            this.mediaplayer.TabIndex = 30;
            this.mediaplayer.Visible = false;
            // 
            // frmreklam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1378, 780);
            this.Controls.Add(this.mediaplayer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ppeleng);
            this.Controls.Add(this.pr1);
            this.Controls.Add(this.lbladiniz);
            this.Controls.Add(this.txtadiniz);
            this.Controls.Add(this.btgiris);
            this.Controls.Add(this.lblU);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblO);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblI);
            this.Controls.Add(this.LblL);
            this.Controls.Add(this.lblM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmreklam";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmreklam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ppeleng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label LblL;
        private System.Windows.Forms.Label lblI;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblU;
        private System.Windows.Forms.Button btgiris;
        private System.Windows.Forms.Label lbladiniz;
        public System.Windows.Forms.TextBox txtadiniz;
        private System.Windows.Forms.PictureBox ppeleng;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ProgressBar pr1;
        public System.Windows.Forms.Timer timer2;
        public AxWMPLib.AxWindowsMediaPlayer mediaplayer;
    }
}