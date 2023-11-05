namespace KuaforRandevuSistemi.UI
{
	partial class FormMalzemeFisleri
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMalzemeFisleri));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBoxFisKesimAdresi = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dateTimePickerFisKesimTarihi = new System.Windows.Forms.DateTimePicker();
			this.textBoxFisTutari = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBoxMalzemeAdi = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxUrunAdi = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxKuaforAdi = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridViewMalzemeFisleri = new System.Windows.Forms.DataGridView();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonKaydet = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonSil = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonTemizle = new System.Windows.Forms.ToolStripButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMalzemeFisleri)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxFisKesimAdresi);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.dateTimePickerFisKesimTarihi);
			this.groupBox1.Controls.Add(this.textBoxFisTutari);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.comboBoxMalzemeAdi);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.comboBoxUrunAdi);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.comboBoxKuaforAdi);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(1, 29);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(798, 197);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Mazleme Fisleri";
			// 
			// textBoxFisKesimAdresi
			// 
			this.textBoxFisKesimAdresi.Location = new System.Drawing.Point(501, 133);
			this.textBoxFisKesimAdresi.Multiline = true;
			this.textBoxFisKesimAdresi.Name = "textBoxFisKesimAdresi";
			this.textBoxFisKesimAdresi.Size = new System.Drawing.Size(151, 58);
			this.textBoxFisKesimAdresi.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(382, 136);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(119, 18);
			this.label6.TabIndex = 10;
			this.label6.Text = "Fiş Kesim Adresi";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(381, 92);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(114, 18);
			this.label5.TabIndex = 9;
			this.label5.Text = "Fiş Kesim Tarihi";
			// 
			// dateTimePickerFisKesimTarihi
			// 
			this.dateTimePickerFisKesimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerFisKesimTarihi.Location = new System.Drawing.Point(501, 86);
			this.dateTimePickerFisKesimTarihi.Name = "dateTimePickerFisKesimTarihi";
			this.dateTimePickerFisKesimTarihi.Size = new System.Drawing.Size(151, 24);
			this.dateTimePickerFisKesimTarihi.TabIndex = 8;
			// 
			// textBoxFisTutari
			// 
			this.textBoxFisTutari.Location = new System.Drawing.Point(501, 37);
			this.textBoxFisTutari.Name = "textBoxFisTutari";
			this.textBoxFisTutari.Size = new System.Drawing.Size(151, 24);
			this.textBoxFisTutari.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(405, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 18);
			this.label4.TabIndex = 6;
			this.label4.Text = "FişTutarı";
			// 
			// comboBoxMalzemeAdi
			// 
			this.comboBoxMalzemeAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMalzemeAdi.FormattingEnabled = true;
			this.comboBoxMalzemeAdi.Location = new System.Drawing.Point(110, 131);
			this.comboBoxMalzemeAdi.Name = "comboBoxMalzemeAdi";
			this.comboBoxMalzemeAdi.Size = new System.Drawing.Size(151, 26);
			this.comboBoxMalzemeAdi.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 139);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 18);
			this.label3.TabIndex = 4;
			this.label3.Text = "Malzeme Adı";
			// 
			// comboBoxUrunAdi
			// 
			this.comboBoxUrunAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxUrunAdi.FormattingEnabled = true;
			this.comboBoxUrunAdi.Location = new System.Drawing.Point(110, 84);
			this.comboBoxUrunAdi.Name = "comboBoxUrunAdi";
			this.comboBoxUrunAdi.Size = new System.Drawing.Size(151, 26);
			this.comboBoxUrunAdi.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "Ürün Adı";
			// 
			// comboBoxKuaforAdi
			// 
			this.comboBoxKuaforAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxKuaforAdi.FormattingEnabled = true;
			this.comboBoxKuaforAdi.Location = new System.Drawing.Point(110, 35);
			this.comboBoxKuaforAdi.Name = "comboBoxKuaforAdi";
			this.comboBoxKuaforAdi.Size = new System.Drawing.Size(151, 26);
			this.comboBoxKuaforAdi.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kuaför Adı";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridViewMalzemeFisleri);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox2.Location = new System.Drawing.Point(1, 232);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(798, 259);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Mlazeme Fiş Listesi";
			// 
			// dataGridViewMalzemeFisleri
			// 
			this.dataGridViewMalzemeFisleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewMalzemeFisleri.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewMalzemeFisleri.Location = new System.Drawing.Point(3, 20);
			this.dataGridViewMalzemeFisleri.Name = "dataGridViewMalzemeFisleri";
			this.dataGridViewMalzemeFisleri.Size = new System.Drawing.Size(792, 236);
			this.dataGridViewMalzemeFisleri.TabIndex = 0;
			this.dataGridViewMalzemeFisleri.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMalzemeFisleri_CellDoubleClick);
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
			this.toolStrip1.Size = new System.Drawing.Size(800, 25);
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
			this.toolStripButtonTemizle.Size = new System.Drawing.Size(108, 22);
			this.toolStripButtonTemizle.Text = "Bilgileri Temizle";
			this.toolStripButtonTemizle.Click += new System.EventHandler(this.toolStripButtonTemizle_Click);
			// 
			// FormMalzemeFisleri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SeaGreen;
			this.ClientSize = new System.Drawing.Size(800, 491);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormMalzemeFisleri";
			this.Text = "FormMalzemeFisleri";
			this.Load += new System.EventHandler(this.FormMalzemeFisleri_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMalzemeFisleri)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox comboBoxMalzemeAdi;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxUrunAdi;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxKuaforAdi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxFisKesimAdresi;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dateTimePickerFisKesimTarihi;
		private System.Windows.Forms.TextBox textBoxFisTutari;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridViewMalzemeFisleri;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButtonKaydet;
		private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
		private System.Windows.Forms.ToolStripButton toolStripButtonSil;
		private System.Windows.Forms.ToolStripButton toolStripButtonTemizle;
	}
}