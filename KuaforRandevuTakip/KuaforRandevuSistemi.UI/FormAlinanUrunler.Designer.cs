namespace KuaforRandevuSistemi.UI
{
	partial class FormAlinanUrunler
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlinanUrunler));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBoxAciklama = new System.Windows.Forms.TextBox();
			this.textBoxAlinanUrunTuru = new System.Windows.Forms.TextBox();
			this.textBoxAlinanUrunTipi = new System.Windows.Forms.TextBox();
			this.textBoxAlinanUrunMiktari = new System.Windows.Forms.TextBox();
			this.textBoxAlinanUrunMarkasi = new System.Windows.Forms.TextBox();
			this.textBoxAlinanUrunAdi = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonKaydet = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonSil = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonTemizle = new System.Windows.Forms.ToolStripButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridViewAlinanurunler = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlinanurunler)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxAciklama);
			this.groupBox1.Controls.Add(this.textBoxAlinanUrunTuru);
			this.groupBox1.Controls.Add(this.textBoxAlinanUrunTipi);
			this.groupBox1.Controls.Add(this.textBoxAlinanUrunMiktari);
			this.groupBox1.Controls.Add(this.textBoxAlinanUrunMarkasi);
			this.groupBox1.Controls.Add(this.textBoxAlinanUrunAdi);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(2, 34);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(828, 205);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Alınan Urunler Bilgileri";
			// 
			// textBoxAciklama
			// 
			this.textBoxAciklama.Location = new System.Drawing.Point(616, 114);
			this.textBoxAciklama.Multiline = true;
			this.textBoxAciklama.Name = "textBoxAciklama";
			this.textBoxAciklama.Size = new System.Drawing.Size(165, 78);
			this.textBoxAciklama.TabIndex = 12;
			// 
			// textBoxAlinanUrunTuru
			// 
			this.textBoxAlinanUrunTuru.Location = new System.Drawing.Point(183, 117);
			this.textBoxAlinanUrunTuru.Name = "textBoxAlinanUrunTuru";
			this.textBoxAlinanUrunTuru.Size = new System.Drawing.Size(165, 24);
			this.textBoxAlinanUrunTuru.TabIndex = 11;
			// 
			// textBoxAlinanUrunTipi
			// 
			this.textBoxAlinanUrunTipi.Location = new System.Drawing.Point(616, 33);
			this.textBoxAlinanUrunTipi.Name = "textBoxAlinanUrunTipi";
			this.textBoxAlinanUrunTipi.Size = new System.Drawing.Size(165, 24);
			this.textBoxAlinanUrunTipi.TabIndex = 10;
			// 
			// textBoxAlinanUrunMiktari
			// 
			this.textBoxAlinanUrunMiktari.Location = new System.Drawing.Point(616, 73);
			this.textBoxAlinanUrunMiktari.Name = "textBoxAlinanUrunMiktari";
			this.textBoxAlinanUrunMiktari.Size = new System.Drawing.Size(165, 24);
			this.textBoxAlinanUrunMiktari.TabIndex = 9;
			// 
			// textBoxAlinanUrunMarkasi
			// 
			this.textBoxAlinanUrunMarkasi.Location = new System.Drawing.Point(183, 79);
			this.textBoxAlinanUrunMarkasi.Name = "textBoxAlinanUrunMarkasi";
			this.textBoxAlinanUrunMarkasi.Size = new System.Drawing.Size(165, 24);
			this.textBoxAlinanUrunMarkasi.TabIndex = 8;
			// 
			// textBoxAlinanUrunAdi
			// 
			this.textBoxAlinanUrunAdi.Location = new System.Drawing.Point(183, 39);
			this.textBoxAlinanUrunAdi.Name = "textBoxAlinanUrunAdi";
			this.textBoxAlinanUrunAdi.Size = new System.Drawing.Size(165, 24);
			this.textBoxAlinanUrunAdi.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(22, 123);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(117, 18);
			this.label7.TabIndex = 6;
			this.label7.Text = "Alınan Ürün Türü";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(455, 39);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(110, 18);
			this.label6.TabIndex = 5;
			this.label6.Text = "Alınan Ürün Tipi";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(455, 79);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(131, 18);
			this.label5.TabIndex = 4;
			this.label5.Text = "Alınan Ürün Miktarı";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(455, 130);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Açıklama";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Alınan Ürün Markası";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Alınan Ürün Adı";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonKaydet,
            this.toolStripButtonGuncelle,
            this.toolStripButtonSil,
            this.toolStripButtonTemizle});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(831, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButtonKaydet
			// 
			this.toolStripButtonKaydet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonKaydet.Image")));
			this.toolStripButtonKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonKaydet.Name = "toolStripButtonKaydet";
			this.toolStripButtonKaydet.Size = new System.Drawing.Size(63, 22);
			this.toolStripButtonKaydet.Text = "Kaydet";
			this.toolStripButtonKaydet.Click += new System.EventHandler(this.toolStripButtonKaydet_Click);
			// 
			// toolStripButtonGuncelle
			// 
			this.toolStripButtonGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGuncelle.Image")));
			this.toolStripButtonGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonGuncelle.Name = "toolStripButtonGuncelle";
			this.toolStripButtonGuncelle.Size = new System.Drawing.Size(73, 22);
			this.toolStripButtonGuncelle.Text = "Güncelle";
			this.toolStripButtonGuncelle.Click += new System.EventHandler(this.toolStripButtonGuncelle_Click);
			// 
			// toolStripButtonSil
			// 
			this.toolStripButtonSil.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSil.Image")));
			this.toolStripButtonSil.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonSil.Name = "toolStripButtonSil";
			this.toolStripButtonSil.Size = new System.Drawing.Size(39, 22);
			this.toolStripButtonSil.Text = "Sil";
			this.toolStripButtonSil.Click += new System.EventHandler(this.toolStripButtonSil_Click);
			// 
			// toolStripButtonTemizle
			// 
			this.toolStripButtonTemizle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTemizle.Image")));
			this.toolStripButtonTemizle.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonTemizle.Name = "toolStripButtonTemizle";
			this.toolStripButtonTemizle.Size = new System.Drawing.Size(66, 22);
			this.toolStripButtonTemizle.Text = "Temizle";
			this.toolStripButtonTemizle.Click += new System.EventHandler(this.toolStripButtonTemizle_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridViewAlinanurunler);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox2.Location = new System.Drawing.Point(2, 258);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(845, 274);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Alınan Ürünler Listesi";
			// 
			// dataGridViewAlinanurunler
			// 
			this.dataGridViewAlinanurunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAlinanurunler.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewAlinanurunler.Location = new System.Drawing.Point(3, 20);
			this.dataGridViewAlinanurunler.Name = "dataGridViewAlinanurunler";
			this.dataGridViewAlinanurunler.Size = new System.Drawing.Size(839, 251);
			this.dataGridViewAlinanurunler.TabIndex = 0;
			this.dataGridViewAlinanurunler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlinanurunler_CellDoubleClick);
			// 
			// FormAlinanUrunler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Bisque;
			this.ClientSize = new System.Drawing.Size(831, 529);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormAlinanUrunler";
			this.Text = "FormAlinanUrunler";
			this.Load += new System.EventHandler(this.FormAlinanUrunler_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlinanurunler)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxAciklama;
		private System.Windows.Forms.TextBox textBoxAlinanUrunTuru;
		private System.Windows.Forms.TextBox textBoxAlinanUrunTipi;
		private System.Windows.Forms.TextBox textBoxAlinanUrunMiktari;
		private System.Windows.Forms.TextBox textBoxAlinanUrunMarkasi;
		private System.Windows.Forms.TextBox textBoxAlinanUrunAdi;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButtonKaydet;
		private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
		private System.Windows.Forms.ToolStripButton toolStripButtonSil;
		private System.Windows.Forms.ToolStripButton toolStripButtonTemizle;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridViewAlinanurunler;
	}
}