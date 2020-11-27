namespace PizzaKulesiCodeFirst
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
            if (disposing)
            {
                db.Dispose();
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
            this.chkTeslimEdilenleriGizle = new System.Windows.Forms.CheckBox();
            this.chkTeslimDurumu = new System.Windows.Forms.CheckBox();
            this.dgvSiparis = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEkstraMalzeme = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnPizzaCesidi = new System.Windows.Forms.Button();
            this.cboPizzaCesidi = new System.Windows.Forms.ComboBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtMusteriAdSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clbMalzeme = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMusteri = new System.Windows.Forms.ComboBox();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnMusteriDuzenle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparis)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkTeslimEdilenleriGizle
            // 
            this.chkTeslimEdilenleriGizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTeslimEdilenleriGizle.AutoSize = true;
            this.chkTeslimEdilenleriGizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkTeslimEdilenleriGizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.chkTeslimEdilenleriGizle.Location = new System.Drawing.Point(858, 18);
            this.chkTeslimEdilenleriGizle.Name = "chkTeslimEdilenleriGizle";
            this.chkTeslimEdilenleriGizle.Size = new System.Drawing.Size(204, 24);
            this.chkTeslimEdilenleriGizle.TabIndex = 37;
            this.chkTeslimEdilenleriGizle.Text = "Teslim Edilenleri Gizle";
            this.chkTeslimEdilenleriGizle.UseVisualStyleBackColor = true;
            this.chkTeslimEdilenleriGizle.CheckedChanged += new System.EventHandler(this.chkTeslimEdilenleriGizle_CheckedChanged);
            // 
            // chkTeslimDurumu
            // 
            this.chkTeslimDurumu.AutoSize = true;
            this.chkTeslimDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkTeslimDurumu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.chkTeslimDurumu.Location = new System.Drawing.Point(18, 284);
            this.chkTeslimDurumu.Name = "chkTeslimDurumu";
            this.chkTeslimDurumu.Size = new System.Drawing.Size(128, 24);
            this.chkTeslimDurumu.TabIndex = 36;
            this.chkTeslimDurumu.Text = "Teslim Edildi";
            this.chkTeslimDurumu.UseVisualStyleBackColor = true;
            // 
            // dgvSiparis
            // 
            this.dgvSiparis.AllowUserToAddRows = false;
            this.dgvSiparis.AllowUserToDeleteRows = false;
            this.dgvSiparis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSiparis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSiparis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(93)))));
            this.dgvSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6});
            this.dgvSiparis.Location = new System.Drawing.Point(287, 48);
            this.dgvSiparis.MultiSelect = false;
            this.dgvSiparis.Name = "dgvSiparis";
            this.dgvSiparis.ReadOnly = true;
            this.dgvSiparis.RowHeadersVisible = false;
            this.dgvSiparis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparis.Size = new System.Drawing.Size(775, 559);
            this.dgvSiparis.TabIndex = 35;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Id";
            this.Column4.FillWeight = 27.71928F;
            this.Column4.HeaderText = "Id";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Musteri";
            this.Column1.FillWeight = 76.18088F;
            this.Column1.HeaderText = "Müşteri Ad Soyad";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Pizza";
            this.Column2.FillWeight = 85.40462F;
            this.Column2.HeaderText = "Pizzalar";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "VirgulluMalzeme";
            this.Column3.FillWeight = 125.8822F;
            this.Column3.HeaderText = "Ekstra Malzemeler";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TeslimDurumu";
            this.Column5.FillWeight = 41.1582F;
            this.Column5.HeaderText = "Teslim Durumu";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "AdresiYaz";
            this.Column6.FillWeight = 243.6548F;
            this.Column6.HeaderText = "Adres";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnEkstraMalzeme
            // 
            this.btnEkstraMalzeme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnEkstraMalzeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkstraMalzeme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(30)))), ((int)(((byte)(102)))));
            this.btnEkstraMalzeme.Location = new System.Drawing.Point(167, 149);
            this.btnEkstraMalzeme.Name = "btnEkstraMalzeme";
            this.btnEkstraMalzeme.Size = new System.Drawing.Size(23, 23);
            this.btnEkstraMalzeme.TabIndex = 31;
            this.btnEkstraMalzeme.Text = "+";
            this.btnEkstraMalzeme.UseVisualStyleBackColor = false;
            this.btnEkstraMalzeme.Click += new System.EventHandler(this.btnEkstraMalzeme_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(135)))));
            this.btnDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(194)))), ((int)(((byte)(121)))));
            this.btnDuzenle.Location = new System.Drawing.Point(880, 613);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(182, 39);
            this.btnDuzenle.TabIndex = 30;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(135)))));
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(194)))), ((int)(((byte)(121)))));
            this.btnSil.Location = new System.Drawing.Point(691, 613);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(183, 39);
            this.btnSil.TabIndex = 29;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(135)))));
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(194)))), ((int)(((byte)(121)))));
            this.btnEkle.Location = new System.Drawing.Point(167, 312);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 47);
            this.btnEkle.TabIndex = 28;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnPizzaCesidi
            // 
            this.btnPizzaCesidi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnPizzaCesidi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPizzaCesidi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(30)))), ((int)(((byte)(102)))));
            this.btnPizzaCesidi.Location = new System.Drawing.Point(126, 94);
            this.btnPizzaCesidi.Name = "btnPizzaCesidi";
            this.btnPizzaCesidi.Size = new System.Drawing.Size(23, 23);
            this.btnPizzaCesidi.TabIndex = 27;
            this.btnPizzaCesidi.Text = "+";
            this.btnPizzaCesidi.UseVisualStyleBackColor = false;
            this.btnPizzaCesidi.Click += new System.EventHandler(this.btnPizzaCesidi_Click);
            // 
            // cboPizzaCesidi
            // 
            this.cboPizzaCesidi.DisplayMember = "Pizza";
            this.cboPizzaCesidi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPizzaCesidi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.cboPizzaCesidi.FormattingEnabled = true;
            this.cboPizzaCesidi.Location = new System.Drawing.Point(17, 123);
            this.cboPizzaCesidi.Name = "cboPizzaCesidi";
            this.cboPizzaCesidi.Size = new System.Drawing.Size(225, 26);
            this.cboPizzaCesidi.TabIndex = 26;
            // 
            // txtAdres
            // 
            this.txtAdres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.txtAdres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.txtAdres.Location = new System.Drawing.Point(15, 77);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(225, 131);
            this.txtAdres.TabIndex = 25;
            // 
            // txtMusteriAdSoyad
            // 
            this.txtMusteriAdSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.txtMusteriAdSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.txtMusteriAdSoyad.Location = new System.Drawing.Point(15, 36);
            this.txtMusteriAdSoyad.Name = "txtMusteriAdSoyad";
            this.txtMusteriAdSoyad.Size = new System.Drawing.Size(225, 26);
            this.txtMusteriAdSoyad.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.label4.Location = new System.Drawing.Point(13, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Teslimat Adresi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.label3.Location = new System.Drawing.Point(14, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Eksta Malzemeler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.label2.Location = new System.Drawing.Point(14, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Pizza Çeşidi";
            // 
            // clbMalzeme
            // 
            this.clbMalzeme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.clbMalzeme.CheckOnClick = true;
            this.clbMalzeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clbMalzeme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.clbMalzeme.FormattingEnabled = true;
            this.clbMalzeme.Location = new System.Drawing.Point(18, 177);
            this.clbMalzeme.Name = "clbMalzeme";
            this.clbMalzeme.Size = new System.Drawing.Size(224, 99);
            this.clbMalzeme.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.label5.Location = new System.Drawing.Point(14, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Müşteri Adı Soyadı";
            // 
            // cboMusteri
            // 
            this.cboMusteri.DisplayMember = "AdSoyad";
            this.cboMusteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMusteri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.cboMusteri.FormattingEnabled = true;
            this.cboMusteri.Location = new System.Drawing.Point(17, 66);
            this.cboMusteri.Name = "cboMusteri";
            this.cboMusteri.Size = new System.Drawing.Size(225, 26);
            this.cboMusteri.TabIndex = 40;
            this.cboMusteri.ValueMember = "Id";
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(135)))));
            this.btnMusteriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(194)))), ((int)(((byte)(121)))));
            this.btnMusteriEkle.Location = new System.Drawing.Point(14, 209);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(114, 37);
            this.btnMusteriEkle.TabIndex = 41;
            this.btnMusteriEkle.Text = "EKLE";
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.label6.Location = new System.Drawing.Point(13, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Ad Soyad";
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(135)))));
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(194)))), ((int)(((byte)(121)))));
            this.btnIptal.Location = new System.Drawing.Point(83, 312);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(78, 47);
            this.btnIptal.TabIndex = 43;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnMusteriDuzenle
            // 
            this.btnMusteriDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(135)))));
            this.btnMusteriDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriDuzenle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(194)))), ((int)(((byte)(121)))));
            this.btnMusteriDuzenle.Location = new System.Drawing.Point(174, 9);
            this.btnMusteriDuzenle.Name = "btnMusteriDuzenle";
            this.btnMusteriDuzenle.Size = new System.Drawing.Size(86, 56);
            this.btnMusteriDuzenle.TabIndex = 44;
            this.btnMusteriDuzenle.Text = "Müşteri Bilgisi Düzenle";
            this.btnMusteriDuzenle.UseVisualStyleBackColor = false;
            this.btnMusteriDuzenle.Click += new System.EventHandler(this.btnMusteriDuzenle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMusteriSil);
            this.groupBox1.Controls.Add(this.txtMusteriAdSoyad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.btnMusteriEkle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.BlueViolet;
            this.groupBox1.Location = new System.Drawing.Point(3, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 251);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Ekle";
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(135)))));
            this.btnMusteriSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(194)))), ((int)(((byte)(121)))));
            this.btnMusteriSil.Location = new System.Drawing.Point(134, 209);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(108, 36);
            this.btnMusteriSil.TabIndex = 43;
            this.btnMusteriSil.Text = "SİL";
            this.btnMusteriSil.UseVisualStyleBackColor = false;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMusteriDuzenle);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnIptal);
            this.groupBox2.Controls.Add(this.cboPizzaCesidi);
            this.groupBox2.Controls.Add(this.cboMusteri);
            this.groupBox2.Controls.Add(this.btnPizzaCesidi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.clbMalzeme);
            this.groupBox2.Controls.Add(this.btnEkstraMalzeme);
            this.groupBox2.Controls.Add(this.chkTeslimDurumu);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.BlueViolet;
            this.groupBox2.Location = new System.Drawing.Point(3, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 400);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pizza Sipariş Ekle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(197)))), ((int)(((byte)(137)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkTeslimEdilenleriGizle);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgvSiparis);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Kulesi (Pizza Sipariş Takip Sistemi)";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparis)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkTeslimEdilenleriGizle;
        private System.Windows.Forms.CheckBox chkTeslimDurumu;
        private System.Windows.Forms.DataGridView dgvSiparis;
        private System.Windows.Forms.Button btnEkstraMalzeme;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnPizzaCesidi;
        private System.Windows.Forms.ComboBox cboPizzaCesidi;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtMusteriAdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clbMalzeme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMusteri;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnMusteriDuzenle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnMusteriSil;
    }
}

