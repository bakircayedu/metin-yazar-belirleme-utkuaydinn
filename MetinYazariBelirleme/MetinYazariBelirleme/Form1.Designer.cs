namespace MetinYazariBelirleme
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
            this.richTextBoxMetin = new System.Windows.Forms.RichTextBox();
            this.btnMetinYukle = new System.Windows.Forms.Button();
            this.openFileDialogMetin = new System.Windows.Forms.OpenFileDialog();
            this.textBoxUzanti = new System.Windows.Forms.TextBox();
            this.btnStackOku = new System.Windows.Forms.Button();
            this.btnAgacaAktar = new System.Windows.Forms.Button();
            this.btnSikKullan = new System.Windows.Forms.Button();
            this.txtSikKullan = new System.Windows.Forms.TextBox();
            this.lblSikKullan = new System.Windows.Forms.Label();
            this.btnHashTabloOlustur = new System.Windows.Forms.Button();
            this.richTextBoxOzellikler = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSikKullan = new System.Windows.Forms.RichTextBox();
            this.lblOzellik = new System.Windows.Forms.Label();
            this.lblUzanti = new System.Windows.Forms.Label();
            this.lblSikKullanilanlar = new System.Windows.Forms.Label();
            this.lblUyari = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxMetin
            // 
            this.richTextBoxMetin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBoxMetin.Location = new System.Drawing.Point(12, 51);
            this.richTextBoxMetin.Name = "richTextBoxMetin";
            this.richTextBoxMetin.ReadOnly = true;
            this.richTextBoxMetin.Size = new System.Drawing.Size(453, 542);
            this.richTextBoxMetin.TabIndex = 0;
            this.richTextBoxMetin.Text = "";
            // 
            // btnMetinYukle
            // 
            this.btnMetinYukle.Location = new System.Drawing.Point(169, 595);
            this.btnMetinYukle.Name = "btnMetinYukle";
            this.btnMetinYukle.Size = new System.Drawing.Size(100, 41);
            this.btnMetinYukle.TabIndex = 1;
            this.btnMetinYukle.Text = "Metin Yükle";
            this.btnMetinYukle.UseVisualStyleBackColor = true;
            this.btnMetinYukle.Click += new System.EventHandler(this.btnMetinYukle_Click);
            // 
            // openFileDialogMetin
            // 
            this.openFileDialogMetin.FileName = ".Txt Dosya";
            // 
            // textBoxUzanti
            // 
            this.textBoxUzanti.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxUzanti.Enabled = false;
            this.textBoxUzanti.Location = new System.Drawing.Point(12, 25);
            this.textBoxUzanti.Name = "textBoxUzanti";
            this.textBoxUzanti.ReadOnly = true;
            this.textBoxUzanti.Size = new System.Drawing.Size(453, 20);
            this.textBoxUzanti.TabIndex = 2;
            // 
            // btnStackOku
            // 
            this.btnStackOku.Location = new System.Drawing.Point(626, 595);
            this.btnStackOku.Name = "btnStackOku";
            this.btnStackOku.Size = new System.Drawing.Size(100, 41);
            this.btnStackOku.TabIndex = 4;
            this.btnStackOku.Text = "Stack\'e Oku";
            this.btnStackOku.UseVisualStyleBackColor = true;
            this.btnStackOku.Click += new System.EventHandler(this.btnStackOku_Click);
            // 
            // btnAgacaAktar
            // 
            this.btnAgacaAktar.Location = new System.Drawing.Point(887, 342);
            this.btnAgacaAktar.Name = "btnAgacaAktar";
            this.btnAgacaAktar.Size = new System.Drawing.Size(100, 41);
            this.btnAgacaAktar.TabIndex = 5;
            this.btnAgacaAktar.Text = "Ağaca Aktar";
            this.btnAgacaAktar.UseVisualStyleBackColor = true;
            this.btnAgacaAktar.Click += new System.EventHandler(this.btnAgacaAktar_Click);
            // 
            // btnSikKullan
            // 
            this.btnSikKullan.Location = new System.Drawing.Point(1034, 342);
            this.btnSikKullan.Name = "btnSikKullan";
            this.btnSikKullan.Size = new System.Drawing.Size(100, 40);
            this.btnSikKullan.TabIndex = 6;
            this.btnSikKullan.Text = "Sık Kullanılan Kelimeleri Getir";
            this.btnSikKullan.UseVisualStyleBackColor = true;
            this.btnSikKullan.Click += new System.EventHandler(this.btnSikKullan_Click);
            // 
            // txtSikKullan
            // 
            this.txtSikKullan.BackColor = System.Drawing.SystemColors.Window;
            this.txtSikKullan.Location = new System.Drawing.Point(1034, 278);
            this.txtSikKullan.Name = "txtSikKullan";
            this.txtSikKullan.Size = new System.Drawing.Size(57, 20);
            this.txtSikKullan.TabIndex = 8;
            // 
            // lblSikKullan
            // 
            this.lblSikKullan.AutoSize = true;
            this.lblSikKullan.Location = new System.Drawing.Point(904, 281);
            this.lblSikKullan.Name = "lblSikKullan";
            this.lblSikKullan.Size = new System.Drawing.Size(124, 13);
            this.lblSikKullan.TabIndex = 9;
            this.lblSikKullan.Text = "Getirilecek Kelime Sayısı:";
            // 
            // btnHashTabloOlustur
            // 
            this.btnHashTabloOlustur.Location = new System.Drawing.Point(966, 423);
            this.btnHashTabloOlustur.Name = "btnHashTabloOlustur";
            this.btnHashTabloOlustur.Size = new System.Drawing.Size(100, 41);
            this.btnHashTabloOlustur.TabIndex = 11;
            this.btnHashTabloOlustur.Text = "Hash Tablosu Oluştur";
            this.btnHashTabloOlustur.UseVisualStyleBackColor = true;
            this.btnHashTabloOlustur.Click += new System.EventHandler(this.btnHashTabloOlustur_Click);
            // 
            // richTextBoxOzellikler
            // 
            this.richTextBoxOzellikler.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBoxOzellikler.Location = new System.Drawing.Point(488, 51);
            this.richTextBoxOzellikler.Name = "richTextBoxOzellikler";
            this.richTextBoxOzellikler.ReadOnly = true;
            this.richTextBoxOzellikler.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxOzellikler.Size = new System.Drawing.Size(373, 542);
            this.richTextBoxOzellikler.TabIndex = 12;
            this.richTextBoxOzellikler.Text = "";
            // 
            // richTextBoxSikKullan
            // 
            this.richTextBoxSikKullan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBoxSikKullan.Location = new System.Drawing.Point(887, 51);
            this.richTextBoxSikKullan.Name = "richTextBoxSikKullan";
            this.richTextBoxSikKullan.ReadOnly = true;
            this.richTextBoxSikKullan.Size = new System.Drawing.Size(258, 209);
            this.richTextBoxSikKullan.TabIndex = 13;
            this.richTextBoxSikKullan.Text = "";
            // 
            // lblOzellik
            // 
            this.lblOzellik.AutoSize = true;
            this.lblOzellik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblOzellik.Location = new System.Drawing.Point(485, 15);
            this.lblOzellik.Name = "lblOzellik";
            this.lblOzellik.Size = new System.Drawing.Size(69, 18);
            this.lblOzellik.TabIndex = 14;
            this.lblOzellik.Tag = "";
            this.lblOzellik.Text = "Özellikler";
            // 
            // lblUzanti
            // 
            this.lblUzanti.AutoSize = true;
            this.lblUzanti.Location = new System.Drawing.Point(12, 9);
            this.lblUzanti.Name = "lblUzanti";
            this.lblUzanti.Size = new System.Drawing.Size(80, 13);
            this.lblUzanti.TabIndex = 15;
            this.lblUzanti.Text = "Dosya Uzantısı:";
            // 
            // lblSikKullanilanlar
            // 
            this.lblSikKullanilanlar.AutoSize = true;
            this.lblSikKullanilanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblSikKullanilanlar.Location = new System.Drawing.Point(884, 15);
            this.lblSikKullanilanlar.Name = "lblSikKullanilanlar";
            this.lblSikKullanilanlar.Size = new System.Drawing.Size(160, 18);
            this.lblSikKullanilanlar.TabIndex = 16;
            this.lblSikKullanilanlar.Text = "Sık Kullanılan Kelimeler";
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.Location = new System.Drawing.Point(-1, 649);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(694, 13);
            this.lblUyari.TabIndex = 17;
            this.lblUyari.Text = "Değerler tekil olarak dizi vb. yapılarda saklandığı için doğru sonuç almak için u" +
    "ygulamayı çalıştırdıktan sonra tekrar başlatmanız tavsiye edilmektedir.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 662);
            this.Controls.Add(this.lblUyari);
            this.Controls.Add(this.lblSikKullanilanlar);
            this.Controls.Add(this.lblUzanti);
            this.Controls.Add(this.lblOzellik);
            this.Controls.Add(this.richTextBoxSikKullan);
            this.Controls.Add(this.richTextBoxOzellikler);
            this.Controls.Add(this.btnHashTabloOlustur);
            this.Controls.Add(this.lblSikKullan);
            this.Controls.Add(this.txtSikKullan);
            this.Controls.Add(this.btnSikKullan);
            this.Controls.Add(this.btnAgacaAktar);
            this.Controls.Add(this.btnStackOku);
            this.Controls.Add(this.textBoxUzanti);
            this.Controls.Add(this.btnMetinYukle);
            this.Controls.Add(this.richTextBoxMetin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxMetin;
        private System.Windows.Forms.Button btnMetinYukle;
        private System.Windows.Forms.OpenFileDialog openFileDialogMetin;
        private System.Windows.Forms.TextBox textBoxUzanti;
        private System.Windows.Forms.Button btnStackOku;
        private System.Windows.Forms.Button btnAgacaAktar;
        private System.Windows.Forms.Button btnSikKullan;
        private System.Windows.Forms.TextBox txtSikKullan;
        private System.Windows.Forms.Label lblSikKullan;
        private System.Windows.Forms.Button btnHashTabloOlustur;
        private System.Windows.Forms.RichTextBox richTextBoxOzellikler;
        private System.Windows.Forms.RichTextBox richTextBoxSikKullan;
        private System.Windows.Forms.Label lblOzellik;
        private System.Windows.Forms.Label lblUzanti;
        private System.Windows.Forms.Label lblSikKullanilanlar;
        private System.Windows.Forms.Label lblUyari;
    }
}

