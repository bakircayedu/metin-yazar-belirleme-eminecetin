namespace MetinYazariBelirleme_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dosyatext = new System.Windows.Forms.TextBox();
            this.metinYukle = new System.Windows.Forms.Button();
            this.dtackeOku = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AgacaAktarBTN = new System.Windows.Forms.Button();
            this.HashtBTN = new System.Windows.Forms.Button();
            this.CumleBilgisi = new System.Windows.Forms.ListBox();
            this.KelimeBilgisi = new System.Windows.Forms.ListBox();
            this.KelimeYazdır = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dosyatext
            // 
            this.dosyatext.Location = new System.Drawing.Point(2, 32);
            this.dosyatext.Name = "dosyatext";
            this.dosyatext.Size = new System.Drawing.Size(178, 31);
            this.dosyatext.TabIndex = 0;
            // 
            // metinYukle
            // 
            this.metinYukle.Location = new System.Drawing.Point(2, 97);
            this.metinYukle.Name = "metinYukle";
            this.metinYukle.Size = new System.Drawing.Size(178, 47);
            this.metinYukle.TabIndex = 1;
            this.metinYukle.Text = "Metin Yükle";
            this.metinYukle.UseVisualStyleBackColor = true;
            this.metinYukle.Click += new System.EventHandler(this.metinYukle_Click);
            // 
            // dtackeOku
            // 
            this.dtackeOku.Location = new System.Drawing.Point(224, 97);
            this.dtackeOku.Name = "dtackeOku";
            this.dtackeOku.Size = new System.Drawing.Size(178, 47);
            this.dtackeOku.TabIndex = 2;
            this.dtackeOku.Text = "Stack\'e Oku";
            this.dtackeOku.UseVisualStyleBackColor = true;
            this.dtackeOku.Click += new System.EventHandler(this.dtackeOku_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 46);
            this.textBox1.TabIndex = 3;
            // 
            // AgacaAktarBTN
            // 
            this.AgacaAktarBTN.Location = new System.Drawing.Point(12, 262);
            this.AgacaAktarBTN.Name = "AgacaAktarBTN";
            this.AgacaAktarBTN.Size = new System.Drawing.Size(154, 39);
            this.AgacaAktarBTN.TabIndex = 4;
            this.AgacaAktarBTN.Text = "Ağaca Aktar";
            this.AgacaAktarBTN.UseVisualStyleBackColor = true;
            // 
            // HashtBTN
            // 
            this.HashtBTN.Location = new System.Drawing.Point(224, 262);
            this.HashtBTN.Name = "HashtBTN";
            this.HashtBTN.Size = new System.Drawing.Size(154, 39);
            this.HashtBTN.TabIndex = 7;
            this.HashtBTN.Text = "Hash Veri";
            this.HashtBTN.UseVisualStyleBackColor = true;
            this.HashtBTN.Click += new System.EventHandler(this.HashtBTN_Click);
            // 
            // CumleBilgisi
            // 
            this.CumleBilgisi.FormattingEnabled = true;
            this.CumleBilgisi.ItemHeight = 25;
            this.CumleBilgisi.Location = new System.Drawing.Point(424, 15);
            this.CumleBilgisi.Name = "CumleBilgisi";
            this.CumleBilgisi.Size = new System.Drawing.Size(180, 79);
            this.CumleBilgisi.TabIndex = 8;
            // 
            // KelimeBilgisi
            // 
            this.KelimeBilgisi.FormattingEnabled = true;
            this.KelimeBilgisi.ItemHeight = 25;
            this.KelimeBilgisi.Location = new System.Drawing.Point(424, 131);
            this.KelimeBilgisi.Name = "KelimeBilgisi";
            this.KelimeBilgisi.Size = new System.Drawing.Size(180, 79);
            this.KelimeBilgisi.TabIndex = 9;
            // 
            // KelimeYazdır
            // 
            this.KelimeYazdır.Location = new System.Drawing.Point(409, 269);
            this.KelimeYazdır.Name = "KelimeYazdır";
            this.KelimeYazdır.Size = new System.Drawing.Size(167, 45);
            this.KelimeYazdır.TabIndex = 10;
            this.KelimeYazdır.Text = "Kelime Yazdır";
            this.KelimeYazdır.UseVisualStyleBackColor = true;
            this.KelimeYazdır.Click += new System.EventHandler(this.KelimeYazdır_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 443);
            this.Controls.Add(this.KelimeYazdır);
            this.Controls.Add(this.KelimeBilgisi);
            this.Controls.Add(this.CumleBilgisi);
            this.Controls.Add(this.HashtBTN);
            this.Controls.Add(this.AgacaAktarBTN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtackeOku);
            this.Controls.Add(this.metinYukle);
            this.Controls.Add(this.dosyatext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox dosyatext;
        private Button metinYukle;
        private Button dtackeOku;
        private OpenFileDialog openFileDialog1;
        private TextBox textBox1;
        private Button AgacaAktarBTN;
        private Button HashtBTN;
        private ListBox CumleBilgisi;
        private ListBox KelimeBilgisi;
        private Button KelimeYazdır;
    }
}