namespace KuaforRandevuSistemi.UI
{
	partial class FormFiyatlar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFiyatlar));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBoxAlinanHizmet = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.comboBoxBakimAdi = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBoxKuaforAdi = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dateTimePickerFiyatBitisTarihi = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePickerFiyatBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
			this.textBoxFiyat = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridViewFiyatlar = new System.Windows.Forms.DataGridView();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonKaydet = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonSil = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonTemizle = new System.Windows.Forms.ToolStripButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiyatlar)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBoxAlinanHizmet);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.comboBoxBakimAdi);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.comboBoxKuaforAdi);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.dateTimePickerFiyatBitisTarihi);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.dateTimePickerFiyatBaslangicTarihi);
			this.groupBox1.Controls.Add(this.textBoxFiyat);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(3, 51);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(775, 236);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Fiyat Bilgileri";
			// 
			// comboBoxAlinanHizmet
			// 
			this.comboBoxAlinanHizmet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxAlinanHizmet.FormattingEnabled = true;
			this.comboBoxAlinanHizmet.Location = new System.Drawing.Point(569, 186);
			this.comboBoxAlinanHizmet.Name = "comboBoxAlinanHizmet";
			this.comboBoxAlinanHizmet.Size = new System.Drawing.Size(194, 26);
			this.comboBoxAlinanHizmet.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(453, 189);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(98, 18);
			this.label7.TabIndex = 13;
			this.label7.Text = "Alinan Hizmet";
			// 
			// comboBoxBakimAdi
			// 
			this.comboBoxBakimAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxBakimAdi.FormattingEnabled = true;
			this.comboBoxBakimAdi.Location = new System.Drawing.Point(569, 138);
			this.comboBoxBakimAdi.Name = "comboBoxBakimAdi";
			this.comboBoxBakimAdi.Size = new System.Drawing.Size(194, 26);
			this.comboBoxBakimAdi.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(453, 146);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 18);
			this.label6.TabIndex = 11;
			this.label6.Text = "Bakim Adi";
			// 
			// comboBoxKuaforAdi
			// 
			this.comboBoxKuaforAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxKuaforAdi.FormattingEnabled = true;
			this.comboBoxKuaforAdi.Location = new System.Drawing.Point(569, 84);
			this.comboBoxKuaforAdi.Name = "comboBoxKuaforAdi";
			this.comboBoxKuaforAdi.Size = new System.Drawing.Size(194, 26);
			this.comboBoxKuaforAdi.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(453, 90);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 18);
			this.label5.TabIndex = 8;
			this.label5.Text = "Kuafor Adi";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 152);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 18);
			this.label3.TabIndex = 5;
			this.label3.Text = "Fiyat Bitiş Tarihi";
			// 
			// dateTimePickerFiyatBitisTarihi
			// 
			this.dateTimePickerFiyatBitisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerFiyatBitisTarihi.Location = new System.Drawing.Point(162, 147);
			this.dateTimePickerFiyatBitisTarihi.Name = "dateTimePickerFiyatBitisTarihi";
			this.dateTimePickerFiyatBitisTarihi.Size = new System.Drawing.Size(166, 24);
			this.dateTimePickerFiyatBitisTarihi.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(147, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "Fiyat Başlangıç Tarihi";
			// 
			// dateTimePickerFiyatBaslangicTarihi
			// 
			this.dateTimePickerFiyatBaslangicTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerFiyatBaslangicTarihi.Location = new System.Drawing.Point(162, 106);
			this.dateTimePickerFiyatBaslangicTarihi.Name = "dateTimePickerFiyatBaslangicTarihi";
			this.dateTimePickerFiyatBaslangicTarihi.Size = new System.Drawing.Size(166, 24);
			this.dateTimePickerFiyatBaslangicTarihi.TabIndex = 2;
			// 
			// textBoxFiyat
			// 
			this.textBoxFiyat.Location = new System.Drawing.Point(162, 62);
			this.textBoxFiyat.Name = "textBoxFiyat";
			this.textBoxFiyat.Size = new System.Drawing.Size(166, 24);
			this.textBoxFiyat.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Fiyat";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridViewFiyatlar);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox2.Location = new System.Drawing.Point(3, 293);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(775, 281);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Fiyat listesi";
			// 
			// dataGridViewFiyatlar
			// 
			this.dataGridViewFiyatlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewFiyatlar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewFiyatlar.Location = new System.Drawing.Point(3, 20);
			this.dataGridViewFiyatlar.Name = "dataGridViewFiyatlar";
			this.dataGridViewFiyatlar.Size = new System.Drawing.Size(769, 258);
			this.dataGridViewFiyatlar.TabIndex = 0;
			this.dataGridViewFiyatlar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFiyatlar_CellDoubleClick);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonKaydet,
            this.toolStripButtonSil,
            this.toolStripButtonGuncelle,
            this.toolStripButtonTemizle});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(778, 25);
			this.toolStrip1.TabIndex = 3;
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
			// toolStripButtonSil
			// 
			this.toolStripButtonSil.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSil.Image")));
			this.toolStripButtonSil.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonSil.Name = "toolStripButtonSil";
			this.toolStripButtonSil.Size = new System.Drawing.Size(39, 22);
			this.toolStripButtonSil.Text = "Sil";
			this.toolStripButtonSil.Click += new System.EventHandler(this.toolStripButtonSil_Click);
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
			// toolStripButtonTemizle
			// 
			this.toolStripButtonTemizle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTemizle.Image")));
			this.toolStripButtonTemizle.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonTemizle.Name = "toolStripButtonTemizle";
			this.toolStripButtonTemizle.Size = new System.Drawing.Size(66, 22);
			this.toolStripButtonTemizle.Text = "Temizle";
			this.toolStripButtonTemizle.Click += new System.EventHandler(this.toolStripButtonTemizle_Click);
			// 
			// FormFiyatlar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(778, 572);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormFiyatlar";
			this.Text = "FormFiyatlar";
			this.Load += new System.EventHandler(this.FormFiyatlar_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiyatlar)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dateTimePickerFiyatBitisTarihi;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePickerFiyatBaslangicTarihi;
		private System.Windows.Forms.TextBox textBoxFiyat;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxKuaforAdi;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBoxAlinanHizmet;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboBoxBakimAdi;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridViewFiyatlar;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButtonKaydet;
		private System.Windows.Forms.ToolStripButton toolStripButtonSil;
		private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
		private System.Windows.Forms.ToolStripButton toolStripButtonTemizle;
	}
}