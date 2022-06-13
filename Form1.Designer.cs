
namespace AdresYazici
{
    partial class KargoOtomasyon
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KargoOtomasyon));
            this.btnYazdir = new System.Windows.Forms.Button();
            this.txtIl = new System.Windows.Forms.ComboBox();
            this.txtIlce = new System.Windows.Forms.ComboBox();
            this.lblAliciAdi = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblIl = new System.Windows.Forms.Label();
            this.lblIlce = new System.Windows.Forms.Label();
            this.txtMahalle = new System.Windows.Forms.TextBox();
            this.lblMahalle = new System.Windows.Forms.Label();
            this.lblCaddeSokak = new System.Windows.Forms.Label();
            this.txtBinaNo = new System.Windows.Forms.TextBox();
            this.lblBinaNo = new System.Windows.Forms.Label();
            this.lblKat = new System.Windows.Forms.Label();
            this.lblDaire = new System.Windows.Forms.Label();
            this.numKat = new System.Windows.Forms.NumericUpDown();
            this.numDaire = new System.Windows.Forms.NumericUpDown();
            this.lblAliciTelefon = new System.Windows.Forms.Label();
            this.lblMahalle2 = new System.Windows.Forms.Label();
            this.lblCaddeSokak2 = new System.Windows.Forms.Label();
            this.lblBinaNo2 = new System.Windows.Forms.Label();
            this.lblKat2 = new System.Windows.Forms.Label();
            this.lblDaireNo = new System.Windows.Forms.Label();
            this.lblIl2 = new System.Windows.Forms.Label();
            this.lblIlce2 = new System.Windows.Forms.Label();
            this.grpOnizle = new System.Windows.Forms.GroupBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOnizle = new System.Windows.Forms.Button();
            this.dokumaniYazdir = new System.Drawing.Printing.PrintDocument();
            this.dokumaniOnizle = new System.Windows.Forms.PrintPreviewDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGonderici = new System.Windows.Forms.TextBox();
            this.txtCaddeSokak = new System.Windows.Forms.TextBox();
            this.yazdirmaSecenekleri = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numKat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDaire)).BeginInit();
            this.grpOnizle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYazdir
            // 
            this.btnYazdir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazdir.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.Location = new System.Drawing.Point(678, 542);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(197, 56);
            this.btnYazdir.TabIndex = 11;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // txtIl
            // 
            this.txtIl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtIl.DropDownHeight = 350;
            this.txtIl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtIl.DropDownWidth = 265;
            this.txtIl.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIl.FormattingEnabled = true;
            this.txtIl.IntegralHeight = false;
            this.txtIl.ItemHeight = 23;
            this.txtIl.Location = new System.Drawing.Point(145, 359);
            this.txtIl.Name = "txtIl";
            this.txtIl.Size = new System.Drawing.Size(290, 31);
            this.txtIl.TabIndex = 4;
            this.txtIl.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtIlce
            // 
            this.txtIlce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtIlce.DropDownHeight = 350;
            this.txtIlce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtIlce.DropDownWidth = 265;
            this.txtIlce.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIlce.FormattingEnabled = true;
            this.txtIlce.IntegralHeight = false;
            this.txtIlce.Location = new System.Drawing.Point(145, 396);
            this.txtIlce.Name = "txtIlce";
            this.txtIlce.Size = new System.Drawing.Size(290, 31);
            this.txtIlce.TabIndex = 5;
            this.txtIlce.SelectedIndexChanged += new System.EventHandler(this.txtIlce_SelectedIndexChanged);
            // 
            // lblAliciAdi
            // 
            this.lblAliciAdi.AutoSize = true;
            this.lblAliciAdi.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAliciAdi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAliciAdi.Location = new System.Drawing.Point(60, 31);
            this.lblAliciAdi.Name = "lblAliciAdi";
            this.lblAliciAdi.Size = new System.Drawing.Size(83, 23);
            this.lblAliciAdi.TabIndex = 3;
            this.lblAliciAdi.Text = "Alıcı Adı:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(97, 256);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(48, 25);
            this.lblAd.TabIndex = 4;
            this.lblAd.Text = "Ad: ";
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.SystemColors.Window;
            this.txtAd.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(145, 251);
            this.txtAd.MaxLength = 25;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(290, 30);
            this.txtAd.TabIndex = 1;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HarfDenetimiAd);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(145, 287);
            this.txtSoyad.MaxLength = 20;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(290, 30);
            this.txtSoyad.TabIndex = 2;
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HarfDenetimiSoyad);
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(67, 292);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(79, 25);
            this.lblSoyad.TabIndex = 6;
            this.lblSoyad.Text = "Soyad: ";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.Location = new System.Drawing.Point(56, 328);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(84, 25);
            this.lblTelefon.TabIndex = 8;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblIl
            // 
            this.lblIl.AutoSize = true;
            this.lblIl.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIl.Location = new System.Drawing.Point(111, 365);
            this.lblIl.Name = "lblIl";
            this.lblIl.Size = new System.Drawing.Size(29, 25);
            this.lblIl.TabIndex = 10;
            this.lblIl.Text = "İl:";
            // 
            // lblIlce
            // 
            this.lblIlce.AutoSize = true;
            this.lblIlce.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIlce.Location = new System.Drawing.Point(90, 402);
            this.lblIlce.Name = "lblIlce";
            this.lblIlce.Size = new System.Drawing.Size(50, 25);
            this.lblIlce.TabIndex = 11;
            this.lblIlce.Text = "İlçe:";
            // 
            // txtMahalle
            // 
            this.txtMahalle.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMahalle.Location = new System.Drawing.Point(145, 433);
            this.txtMahalle.Name = "txtMahalle";
            this.txtMahalle.Size = new System.Drawing.Size(290, 30);
            this.txtMahalle.TabIndex = 6;
            this.txtMahalle.TextChanged += new System.EventHandler(this.txtMahalle_TextChanged);
            this.txtMahalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HarfDenetimiAdres);
            // 
            // lblMahalle
            // 
            this.lblMahalle.AutoSize = true;
            this.lblMahalle.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMahalle.Location = new System.Drawing.Point(50, 438);
            this.lblMahalle.Name = "lblMahalle";
            this.lblMahalle.Size = new System.Drawing.Size(90, 25);
            this.lblMahalle.TabIndex = 12;
            this.lblMahalle.Text = "Mahalle:";
            // 
            // lblCaddeSokak
            // 
            this.lblCaddeSokak.AutoSize = true;
            this.lblCaddeSokak.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCaddeSokak.Location = new System.Drawing.Point(2, 474);
            this.lblCaddeSokak.Name = "lblCaddeSokak";
            this.lblCaddeSokak.Size = new System.Drawing.Size(140, 25);
            this.lblCaddeSokak.TabIndex = 14;
            this.lblCaddeSokak.Text = "Cadde/Sokak:";
            // 
            // txtBinaNo
            // 
            this.txtBinaNo.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBinaNo.Location = new System.Drawing.Point(100, 611);
            this.txtBinaNo.MaxLength = 6;
            this.txtBinaNo.Name = "txtBinaNo";
            this.txtBinaNo.Size = new System.Drawing.Size(75, 30);
            this.txtBinaNo.TabIndex = 8;
            this.txtBinaNo.TextChanged += new System.EventHandler(this.txtBinaNo_TextChanged);
            this.txtBinaNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HarfDenetimiBinaNo);
            // 
            // lblBinaNo
            // 
            this.lblBinaNo.AutoSize = true;
            this.lblBinaNo.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBinaNo.Location = new System.Drawing.Point(17, 615);
            this.lblBinaNo.Name = "lblBinaNo";
            this.lblBinaNo.Size = new System.Drawing.Size(80, 23);
            this.lblBinaNo.TabIndex = 16;
            this.lblBinaNo.Text = "Bina No:";
            // 
            // lblKat
            // 
            this.lblKat.AutoSize = true;
            this.lblKat.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKat.Location = new System.Drawing.Point(182, 615);
            this.lblKat.Name = "lblKat";
            this.lblKat.Size = new System.Drawing.Size(42, 23);
            this.lblKat.TabIndex = 18;
            this.lblKat.Text = "Kat:";
            // 
            // lblDaire
            // 
            this.lblDaire.AutoSize = true;
            this.lblDaire.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDaire.Location = new System.Drawing.Point(303, 615);
            this.lblDaire.Name = "lblDaire";
            this.lblDaire.Size = new System.Drawing.Size(59, 23);
            this.lblDaire.TabIndex = 19;
            this.lblDaire.Text = "Daire:";
            // 
            // numKat
            // 
            this.numKat.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numKat.Location = new System.Drawing.Point(228, 610);
            this.numKat.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.numKat.Name = "numKat";
            this.numKat.Size = new System.Drawing.Size(69, 33);
            this.numKat.TabIndex = 9;
            this.numKat.ValueChanged += new System.EventHandler(this.numKat_ValueChanged);
            // 
            // numDaire
            // 
            this.numDaire.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numDaire.Location = new System.Drawing.Point(366, 611);
            this.numDaire.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numDaire.Name = "numDaire";
            this.numDaire.Size = new System.Drawing.Size(69, 33);
            this.numDaire.TabIndex = 10;
            this.numDaire.ValueChanged += new System.EventHandler(this.numDaire_ValueChanged);
            // 
            // lblAliciTelefon
            // 
            this.lblAliciTelefon.AutoSize = true;
            this.lblAliciTelefon.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAliciTelefon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAliciTelefon.Location = new System.Drawing.Point(26, 58);
            this.lblAliciTelefon.Name = "lblAliciTelefon";
            this.lblAliciTelefon.Size = new System.Drawing.Size(117, 23);
            this.lblAliciTelefon.TabIndex = 22;
            this.lblAliciTelefon.Text = "Alıcı Telefon:";
            // 
            // lblMahalle2
            // 
            this.lblMahalle2.AutoSize = true;
            this.lblMahalle2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMahalle2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMahalle2.Location = new System.Drawing.Point(61, 86);
            this.lblMahalle2.Name = "lblMahalle2";
            this.lblMahalle2.Size = new System.Drawing.Size(82, 23);
            this.lblMahalle2.TabIndex = 23;
            this.lblMahalle2.Text = "Mahalle:";
            // 
            // lblCaddeSokak2
            // 
            this.lblCaddeSokak2.AutoSize = true;
            this.lblCaddeSokak2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaddeSokak2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCaddeSokak2.Location = new System.Drawing.Point(17, 114);
            this.lblCaddeSokak2.Name = "lblCaddeSokak2";
            this.lblCaddeSokak2.Size = new System.Drawing.Size(126, 23);
            this.lblCaddeSokak2.TabIndex = 24;
            this.lblCaddeSokak2.Text = "Cadde/Sokak:";
            // 
            // lblBinaNo2
            // 
            this.lblBinaNo2.AutoSize = true;
            this.lblBinaNo2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinaNo2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBinaNo2.Location = new System.Drawing.Point(63, 141);
            this.lblBinaNo2.Name = "lblBinaNo2";
            this.lblBinaNo2.Size = new System.Drawing.Size(80, 23);
            this.lblBinaNo2.TabIndex = 25;
            this.lblBinaNo2.Text = "Bina No:";
            // 
            // lblKat2
            // 
            this.lblKat2.AutoSize = true;
            this.lblKat2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKat2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKat2.Location = new System.Drawing.Point(102, 166);
            this.lblKat2.Name = "lblKat2";
            this.lblKat2.Size = new System.Drawing.Size(62, 23);
            this.lblKat2.TabIndex = 26;
            this.lblKat2.Text = "Kat:  0";
            // 
            // lblDaireNo
            // 
            this.lblDaireNo.AutoSize = true;
            this.lblDaireNo.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaireNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDaireNo.Location = new System.Drawing.Point(57, 193);
            this.lblDaireNo.Name = "lblDaireNo";
            this.lblDaireNo.Size = new System.Drawing.Size(107, 23);
            this.lblDaireNo.TabIndex = 27;
            this.lblDaireNo.Text = "Daire No:  0";
            // 
            // lblIl2
            // 
            this.lblIl2.AutoSize = true;
            this.lblIl2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIl2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIl2.Location = new System.Drawing.Point(119, 220);
            this.lblIl2.Name = "lblIl2";
            this.lblIl2.Size = new System.Drawing.Size(25, 23);
            this.lblIl2.TabIndex = 28;
            this.lblIl2.Text = "İl:";
            // 
            // lblIlce2
            // 
            this.lblIlce2.AutoSize = true;
            this.lblIlce2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIlce2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIlce2.Location = new System.Drawing.Point(100, 244);
            this.lblIlce2.Name = "lblIlce2";
            this.lblIlce2.Size = new System.Drawing.Size(44, 23);
            this.lblIlce2.TabIndex = 29;
            this.lblIlce2.Text = "İlçe:";
            // 
            // grpOnizle
            // 
            this.grpOnizle.Controls.Add(this.lblAliciAdi);
            this.grpOnizle.Controls.Add(this.lblBinaNo2);
            this.grpOnizle.Controls.Add(this.lblIlce2);
            this.grpOnizle.Controls.Add(this.lblKat2);
            this.grpOnizle.Controls.Add(this.lblCaddeSokak2);
            this.grpOnizle.Controls.Add(this.lblAliciTelefon);
            this.grpOnizle.Controls.Add(this.lblDaireNo);
            this.grpOnizle.Controls.Add(this.lblMahalle2);
            this.grpOnizle.Controls.Add(this.lblIl2);
            this.grpOnizle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpOnizle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpOnizle.Location = new System.Drawing.Point(472, 251);
            this.grpOnizle.Name = "grpOnizle";
            this.grpOnizle.Size = new System.Drawing.Size(403, 281);
            this.grpOnizle.TabIndex = 30;
            this.grpOnizle.TabStop = false;
            this.grpOnizle.Text = "Önizleme";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.Location = new System.Drawing.Point(145, 323);
            this.txtTelefon.Mask = "(999) 000 00 00";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(290, 30);
            this.txtTelefon.TabIndex = 3;
            this.txtTelefon.Click += new System.EventHandler(this.txtTelefon_Click);
            this.txtTelefon.TextChanged += new System.EventHandler(this.txtTelefon_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AtasunOptikKargoOtomasyonu.Properties.Resources.AtasunOptikLogo;
            this.pictureBox1.Location = new System.Drawing.Point(219, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btnOnizle
            // 
            this.btnOnizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnizle.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnizle.Location = new System.Drawing.Point(472, 542);
            this.btnOnizle.Name = "btnOnizle";
            this.btnOnizle.Size = new System.Drawing.Size(200, 56);
            this.btnOnizle.TabIndex = 32;
            this.btnOnizle.Text = "Önizle";
            this.btnOnizle.UseVisualStyleBackColor = true;
            this.btnOnizle.Click += new System.EventHandler(this.btnOnizle_Click);
            // 
            // dokumaniYazdir
            // 
            this.dokumaniYazdir.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.dokumaniYazdir_PrintPage);
            // 
            // dokumaniOnizle
            // 
            this.dokumaniOnizle.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.dokumaniOnizle.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.dokumaniOnizle.ClientSize = new System.Drawing.Size(400, 300);
            this.dokumaniOnizle.Document = this.dokumaniYazdir;
            this.dokumaniOnizle.Enabled = true;
            this.dokumaniOnizle.Icon = ((System.Drawing.Icon)(resources.GetObject("dokumaniOnizle.Icon")));
            this.dokumaniOnizle.Name = "printPreviewDialog1";
            this.dokumaniOnizle.Text = "Baskı önizleme";
            this.dokumaniOnizle.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(467, 610);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Gönderici:";
            // 
            // txtGonderici
            // 
            this.txtGonderici.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGonderici.Location = new System.Drawing.Point(578, 609);
            this.txtGonderici.Name = "txtGonderici";
            this.txtGonderici.Size = new System.Drawing.Size(297, 30);
            this.txtGonderici.TabIndex = 34;
            this.txtGonderici.Text = "Atasun Optik";
            // 
            // txtCaddeSokak
            // 
            this.txtCaddeSokak.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCaddeSokak.Location = new System.Drawing.Point(145, 469);
            this.txtCaddeSokak.Multiline = true;
            this.txtCaddeSokak.Name = "txtCaddeSokak";
            this.txtCaddeSokak.Size = new System.Drawing.Size(290, 129);
            this.txtCaddeSokak.TabIndex = 7;
            this.txtCaddeSokak.TextChanged += new System.EventHandler(this.txtCaddeSokak_TextChanged);
            this.txtCaddeSokak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HarfDenetimiAdres);
            // 
            // yazdirmaSecenekleri
            // 
            this.yazdirmaSecenekleri.Document = this.dokumaniYazdir;
            this.yazdirmaSecenekleri.UseEXDialog = true;
            // 
            // KargoOtomasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(890, 661);
            this.Controls.Add(this.txtGonderici);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOnizle);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.grpOnizle);
            this.Controls.Add(this.numDaire);
            this.Controls.Add(this.numKat);
            this.Controls.Add(this.lblDaire);
            this.Controls.Add(this.lblKat);
            this.Controls.Add(this.txtBinaNo);
            this.Controls.Add(this.lblBinaNo);
            this.Controls.Add(this.txtCaddeSokak);
            this.Controls.Add(this.lblCaddeSokak);
            this.Controls.Add(this.txtMahalle);
            this.Controls.Add(this.lblMahalle);
            this.Controls.Add(this.lblIlce);
            this.Controls.Add(this.lblIl);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtIlce);
            this.Controls.Add(this.txtIl);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KargoOtomasyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atasun Optik Kargo Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numKat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDaire)).EndInit();
            this.grpOnizle.ResumeLayout(false);
            this.grpOnizle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.ComboBox txtIl;
        private System.Windows.Forms.ComboBox txtIlce;
        private System.Windows.Forms.Label lblAliciAdi;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblIl;
        private System.Windows.Forms.Label lblIlce;
        private System.Windows.Forms.TextBox txtMahalle;
        private System.Windows.Forms.Label lblMahalle;
        private System.Windows.Forms.Label lblCaddeSokak;
        private System.Windows.Forms.TextBox txtBinaNo;
        private System.Windows.Forms.Label lblBinaNo;
        private System.Windows.Forms.Label lblKat;
        private System.Windows.Forms.Label lblDaire;
        private System.Windows.Forms.NumericUpDown numKat;
        private System.Windows.Forms.NumericUpDown numDaire;
        private System.Windows.Forms.Label lblAliciTelefon;
        private System.Windows.Forms.Label lblMahalle2;
        private System.Windows.Forms.Label lblCaddeSokak2;
        private System.Windows.Forms.Label lblBinaNo2;
        private System.Windows.Forms.Label lblKat2;
        private System.Windows.Forms.Label lblDaireNo;
        private System.Windows.Forms.Label lblIl2;
        private System.Windows.Forms.Label lblIlce2;
        private System.Windows.Forms.GroupBox grpOnizle;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOnizle;
        private System.Drawing.Printing.PrintDocument dokumaniYazdir;
        private System.Windows.Forms.PrintPreviewDialog dokumaniOnizle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGonderici;
        private System.Windows.Forms.TextBox txtCaddeSokak;
        private System.Windows.Forms.PrintDialog yazdirmaSecenekleri;
    }
}

