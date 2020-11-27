namespace PizzaKulesiCodeFirst
{
    partial class DuzenleForm
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
            this.lstPizzalar = new System.Windows.Forms.ListBox();
            this.txtPizzaCesidi = new System.Windows.Forms.TextBox();
            this.btnPizzaEkle = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnPizzaSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEkstraMalzemeSil = new System.Windows.Forms.Button();
            this.btnEkstraMalzemeEkle = new System.Windows.Forms.Button();
            this.txtMalzeme = new System.Windows.Forms.TextBox();
            this.lstMalzemeler = new System.Windows.Forms.ListBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPizzalar
            // 
            this.lstPizzalar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstPizzalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.lstPizzalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstPizzalar.FormattingEnabled = true;
            this.lstPizzalar.ItemHeight = 24;
            this.lstPizzalar.Location = new System.Drawing.Point(12, 66);
            this.lstPizzalar.Name = "lstPizzalar";
            this.lstPizzalar.Size = new System.Drawing.Size(337, 484);
            this.lstPizzalar.TabIndex = 0;
            // 
            // txtPizzaCesidi
            // 
            this.txtPizzaCesidi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.txtPizzaCesidi.Location = new System.Drawing.Point(12, 40);
            this.txtPizzaCesidi.Name = "txtPizzaCesidi";
            this.txtPizzaCesidi.Size = new System.Drawing.Size(219, 20);
            this.txtPizzaCesidi.TabIndex = 1;
            // 
            // btnPizzaEkle
            // 
            this.btnPizzaEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(135)))));
            this.btnPizzaEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(194)))), ((int)(((byte)(121)))));
            this.btnPizzaEkle.Location = new System.Drawing.Point(237, 36);
            this.btnPizzaEkle.Name = "btnPizzaEkle";
            this.btnPizzaEkle.Size = new System.Drawing.Size(55, 26);
            this.btnPizzaEkle.TabIndex = 44;
            this.btnPizzaEkle.Text = "Ekle";
            this.btnPizzaEkle.UseVisualStyleBackColor = false;
            this.btnPizzaEkle.Click += new System.EventHandler(this.btnPizzaEkle_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(135)))));
            this.btnDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(194)))), ((int)(((byte)(121)))));
            this.btnDuzenle.Location = new System.Drawing.Point(12, 569);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(720, 45);
            this.btnDuzenle.TabIndex = 47;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnPizzaSil
            // 
            this.btnPizzaSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(135)))));
            this.btnPizzaSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(194)))), ((int)(((byte)(121)))));
            this.btnPizzaSil.Location = new System.Drawing.Point(298, 36);
            this.btnPizzaSil.Name = "btnPizzaSil";
            this.btnPizzaSil.Size = new System.Drawing.Size(51, 26);
            this.btnPizzaSil.TabIndex = 46;
            this.btnPizzaSil.Text = "Sil";
            this.btnPizzaSil.UseVisualStyleBackColor = false;
            this.btnPizzaSil.Click += new System.EventHandler(this.btnPizzaSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 48;
            this.label1.Text = "Pizza";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(362, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 26);
            this.label2.TabIndex = 53;
            this.label2.Text = "Ekstra Malzeme";
            // 
            // btnEkstraMalzemeSil
            // 
            this.btnEkstraMalzemeSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkstraMalzemeSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(135)))));
            this.btnEkstraMalzemeSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(194)))), ((int)(((byte)(121)))));
            this.btnEkstraMalzemeSil.Location = new System.Drawing.Point(681, 36);
            this.btnEkstraMalzemeSil.Name = "btnEkstraMalzemeSil";
            this.btnEkstraMalzemeSil.Size = new System.Drawing.Size(51, 26);
            this.btnEkstraMalzemeSil.TabIndex = 52;
            this.btnEkstraMalzemeSil.Text = "Sil";
            this.btnEkstraMalzemeSil.UseVisualStyleBackColor = false;
            this.btnEkstraMalzemeSil.Click += new System.EventHandler(this.btnMalzemeSil_Click);
            // 
            // btnEkstraMalzemeEkle
            // 
            this.btnEkstraMalzemeEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkstraMalzemeEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(135)))));
            this.btnEkstraMalzemeEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(194)))), ((int)(((byte)(121)))));
            this.btnEkstraMalzemeEkle.Location = new System.Drawing.Point(620, 36);
            this.btnEkstraMalzemeEkle.Name = "btnEkstraMalzemeEkle";
            this.btnEkstraMalzemeEkle.Size = new System.Drawing.Size(55, 26);
            this.btnEkstraMalzemeEkle.TabIndex = 51;
            this.btnEkstraMalzemeEkle.Text = "Ekle";
            this.btnEkstraMalzemeEkle.UseVisualStyleBackColor = false;
            this.btnEkstraMalzemeEkle.Click += new System.EventHandler(this.btnMalzemeEkle_Click);
            // 
            // txtMalzeme
            // 
            this.txtMalzeme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMalzeme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.txtMalzeme.Location = new System.Drawing.Point(362, 40);
            this.txtMalzeme.Name = "txtMalzeme";
            this.txtMalzeme.Size = new System.Drawing.Size(252, 20);
            this.txtMalzeme.TabIndex = 50;
            // 
            // lstMalzemeler
            // 
            this.lstMalzemeler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMalzemeler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.lstMalzemeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstMalzemeler.FormattingEnabled = true;
            this.lstMalzemeler.ItemHeight = 24;
            this.lstMalzemeler.Location = new System.Drawing.Point(362, 66);
            this.lstMalzemeler.Name = "lstMalzemeler";
            this.lstMalzemeler.Size = new System.Drawing.Size(370, 484);
            this.lstMalzemeler.TabIndex = 49;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(135)))));
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(194)))), ((int)(((byte)(121)))));
            this.btnKaydet.Location = new System.Drawing.Point(12, 569);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(337, 45);
            this.btnKaydet.TabIndex = 54;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Visible = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(135)))));
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(194)))), ((int)(((byte)(121)))));
            this.btnIptal.Location = new System.Drawing.Point(395, 569);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(337, 45);
            this.btnIptal.TabIndex = 55;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // DuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(759, 636);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEkstraMalzemeSil);
            this.Controls.Add(this.btnEkstraMalzemeEkle);
            this.Controls.Add(this.txtMalzeme);
            this.Controls.Add(this.lstMalzemeler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnPizzaSil);
            this.Controls.Add(this.btnPizzaEkle);
            this.Controls.Add(this.txtPizzaCesidi);
            this.Controls.Add(this.lstPizzalar);
            this.MinimumSize = new System.Drawing.Size(775, 675);
            this.Name = "DuzenleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PizzaCesidiDuzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPizzalar;
        private System.Windows.Forms.TextBox txtPizzaCesidi;
        private System.Windows.Forms.Button btnPizzaEkle;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnPizzaSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkstraMalzemeSil;
        private System.Windows.Forms.Button btnEkstraMalzemeEkle;
        private System.Windows.Forms.TextBox txtMalzeme;
        private System.Windows.Forms.ListBox lstMalzemeler;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
    }
}