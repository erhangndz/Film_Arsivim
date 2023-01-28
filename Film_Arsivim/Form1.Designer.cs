
namespace Film_Arsivim
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblLink = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnNormal = new System.Windows.Forms.Button();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.BtnRenkDegistir = new System.Windows.Forms.Button();
            this.BtnHakkimizda = new System.Windows.Forms.Button();
            this.BtnTamEkran = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.TxtFilmlinki = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilmAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblLink);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1540, 84);
            this.panel1.TabIndex = 0;
            // 
            // LblLink
            // 
            this.LblLink.AutoSize = true;
            this.LblLink.Location = new System.Drawing.Point(293, 45);
            this.LblLink.Name = "LblLink";
            this.LblLink.Size = new System.Drawing.Size(35, 19);
            this.LblLink.TabIndex = 3;
            this.LblLink.Text = "Link";
            this.LblLink.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(592, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "SİNEMA FİLMLERİ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::Film_Arsivim.Properties.Resources.classic_film_reel_countdown;
            this.pictureBox2.Location = new System.Drawing.Point(1398, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Film_Arsivim.Properties.Resources.movie_icon_6;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(317, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 577);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(322, 551);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnNormal);
            this.groupBox2.Controls.Add(this.chromiumWebBrowser1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(642, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(898, 577);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ekran";
            // 
            // BtnNormal
            // 
            this.BtnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNormal.BackColor = System.Drawing.Color.DarkGray;
            this.BtnNormal.BackgroundImage = global::Film_Arsivim.Properties.Resources.Minimize_icon;
            this.BtnNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNormal.Location = new System.Drawing.Point(858, 6);
            this.BtnNormal.Name = "BtnNormal";
            this.BtnNormal.Size = new System.Drawing.Size(40, 40);
            this.BtnNormal.TabIndex = 7;
            this.BtnNormal.UseVisualStyleBackColor = false;
            this.BtnNormal.Click += new System.EventHandler(this.BtnNormal_Click);
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(3, 23);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(892, 551);
            this.chromiumWebBrowser1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.BtnKaydet);
            this.groupBox3.Controls.Add(this.TxtFilmlinki);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtKategori);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtFilmAd);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(0, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 577);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yeni Film";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnCikis);
            this.groupBox4.Controls.Add(this.BtnRenkDegistir);
            this.groupBox4.Controls.Add(this.BtnHakkimizda);
            this.groupBox4.Controls.Add(this.BtnTamEkran);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(3, 410);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(305, 164);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İşlemler";
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackColor = System.Drawing.Color.DarkGray;
            this.BtnCikis.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCikis.Location = new System.Drawing.Point(3, 125);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(299, 34);
            this.BtnCikis.TabIndex = 10;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // BtnRenkDegistir
            // 
            this.BtnRenkDegistir.BackColor = System.Drawing.Color.DarkGray;
            this.BtnRenkDegistir.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRenkDegistir.Location = new System.Drawing.Point(3, 91);
            this.BtnRenkDegistir.Name = "BtnRenkDegistir";
            this.BtnRenkDegistir.Size = new System.Drawing.Size(299, 34);
            this.BtnRenkDegistir.TabIndex = 9;
            this.BtnRenkDegistir.Text = "Renk Değiştir";
            this.BtnRenkDegistir.UseVisualStyleBackColor = false;
            this.BtnRenkDegistir.Click += new System.EventHandler(this.BtnRenkDegistir_Click);
            // 
            // BtnHakkimizda
            // 
            this.BtnHakkimizda.BackColor = System.Drawing.Color.DarkGray;
            this.BtnHakkimizda.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHakkimizda.Location = new System.Drawing.Point(3, 57);
            this.BtnHakkimizda.Name = "BtnHakkimizda";
            this.BtnHakkimizda.Size = new System.Drawing.Size(299, 34);
            this.BtnHakkimizda.TabIndex = 8;
            this.BtnHakkimizda.Text = "Hakkımızda";
            this.BtnHakkimizda.UseVisualStyleBackColor = false;
            this.BtnHakkimizda.Click += new System.EventHandler(this.BtnHakkimizda_Click);
            // 
            // BtnTamEkran
            // 
            this.BtnTamEkran.BackColor = System.Drawing.Color.DarkGray;
            this.BtnTamEkran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnTamEkran.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTamEkran.Location = new System.Drawing.Point(3, 23);
            this.BtnTamEkran.Name = "BtnTamEkran";
            this.BtnTamEkran.Size = new System.Drawing.Size(299, 34);
            this.BtnTamEkran.TabIndex = 7;
            this.BtnTamEkran.Text = "Tam Ekran";
            this.BtnTamEkran.UseVisualStyleBackColor = false;
            this.BtnTamEkran.Click += new System.EventHandler(this.BtnTamEkran_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.DarkGray;
            this.BtnKaydet.Location = new System.Drawing.Point(74, 133);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(164, 34);
            this.BtnKaydet.TabIndex = 6;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtFilmlinki
            // 
            this.TxtFilmlinki.Location = new System.Drawing.Point(74, 100);
            this.TxtFilmlinki.Name = "TxtFilmlinki";
            this.TxtFilmlinki.Size = new System.Drawing.Size(205, 27);
            this.TxtFilmlinki.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Film Linki:";
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(74, 67);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(205, 27);
            this.txtKategori.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategori:";
            // 
            // txtFilmAd
            // 
            this.txtFilmAd.Location = new System.Drawing.Point(74, 34);
            this.txtFilmAd.Name = "txtFilmAd";
            this.txtFilmAd.Size = new System.Drawing.Size(205, 27);
            this.txtFilmAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Film Adı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1540, 661);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SineFilm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Button BtnRenkDegistir;
        private System.Windows.Forms.Button BtnHakkimizda;
        private System.Windows.Forms.Button BtnTamEkran;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.TextBox TxtFilmlinki;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilmAd;
        private System.Windows.Forms.Label label2;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private System.Windows.Forms.Label LblLink;
        private System.Windows.Forms.Button BtnNormal;
    }
}

