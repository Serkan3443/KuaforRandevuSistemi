namespace KuaforRandevuSistemi.UI
{
	partial class FormMusteriler
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMusteriler));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBoxİlceAdi = new System.Windows.Forms.ComboBox();
			this.dateTimePickerMusteriDogumTarihi = new System.Windows.Forms.DateTimePicker();
			this.checkBoxKadin = new System.Windows.Forms.CheckBox();
			this.checkBoxErkek = new System.Windows.Forms.CheckBox();
			this.textBoxMusteriAdres = new System.Windows.Forms.TextBox();
			this.maskedTextBoxMusteriTelefon = new System.Windows.Forms.MaskedTextBox();
			this.textBoxMusteriSoyadi = new System.Windows.Forms.TextBox();
			this.textBoxMusteriAdi = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridViewMusteriler = new System.Windows.Forms.DataGridView();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonKaydet = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonSil = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonTemizle = new System.Windows.Forms.ToolStripButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteriler)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBoxİlceAdi);
			this.groupBox1.Controls.Add(this.dateTimePickerMusteriDogumTarihi);
			this.groupBox1.Controls.Add(this.checkBoxKadin);
			this.groupBox1.Controls.Add(this.checkBoxErkek);
			this.groupBox1.Controls.Add(this.textBoxMusteriAdres);
			this.groupBox1.Controls.Add(this.maskedTextBoxMusteriTelefon);
			this.groupBox1.Controls.Add(this.textBoxMusteriSoyadi);
			this.groupBox1.Controls.Add(this.textBoxMusteriAdi);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(0, 48);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(799, 256);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Müşteriler";
			// 
			// comboBoxİlceAdi
			// 
			this.comboBoxİlceAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxİlceAdi.FormattingEnabled = true;
			this.comboBoxİlceAdi.Location = new System.Drawing.Point(556, 135);
			this.comboBoxİlceAdi.Name = "comboBoxİlceAdi";
			this.comboBoxİlceAdi.Size = new System.Drawing.Size(200, 26);
			this.comboBoxİlceAdi.TabIndex = 14;
			// 
			// dateTimePickerMusteriDogumTarihi
			// 
			this.dateTimePickerMusteriDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerMusteriDogumTarihi.Location = new System.Drawing.Point(556, 87);
			this.dateTimePickerMusteriDogumTarihi.Name = "dateTimePickerMusteriDogumTarihi";
			this.dateTimePickerMusteriDogumTarihi.Size = new System.Drawing.Size(200, 24);
			this.dateTimePickerMusteriDogumTarihi.TabIndex = 13;
			// 
			// checkBoxKadin
			// 
			this.checkBoxKadin.AutoSize = true;
			this.checkBoxKadin.Location = new System.Drawing.Point(692, 32);
			this.checkBoxKadin.Name = "checkBoxKadin";
			this.checkBoxKadin.Size = new System.Drawing.Size(64, 22);
			this.checkBoxKadin.TabIndex = 12;
			this.checkBoxKadin.Text = "Kadın";
			this.checkBoxKadin.UseVisualStyleBackColor = true;
			// 
			// checkBoxErkek
			// 
			this.checkBoxErkek.AutoSize = true;
			this.checkBoxErkek.Location = new System.Drawing.Point(575, 32);
			this.checkBoxErkek.Name = "checkBoxErkek";
			this.checkBoxErkek.Size = new System.Drawing.Size(66, 22);
			this.checkBoxErkek.TabIndex = 11;
			this.checkBoxErkek.Text = "Erkek";
			this.checkBoxErkek.UseVisualStyleBackColor = true;
			// 
			// textBoxMusteriAdres
			// 
			this.textBoxMusteriAdres.Location = new System.Drawing.Point(137, 143);
			this.textBoxMusteriAdres.Multiline = true;
			this.textBoxMusteriAdres.Name = "textBoxMusteriAdres";
			this.textBoxMusteriAdres.Size = new System.Drawing.Size(201, 93);
			this.textBoxMusteriAdres.TabIndex = 10;
			// 
			// maskedTextBoxMusteriTelefon
			// 
			this.maskedTextBoxMusteriTelefon.Location = new System.Drawing.Point(137, 105);
			this.maskedTextBoxMusteriTelefon.Mask = "(999) 000-0000";
			this.maskedTextBoxMusteriTelefon.Name = "maskedTextBoxMusteriTelefon";
			this.maskedTextBoxMusteriTelefon.Size = new System.Drawing.Size(201, 24);
			this.maskedTextBoxMusteriTelefon.TabIndex = 9;
			// 
			// textBoxMusteriSoyadi
			// 
			this.textBoxMusteriSoyadi.Location = new System.Drawing.Point(137, 69);
			this.textBoxMusteriSoyadi.Name = "textBoxMusteriSoyadi";
			this.textBoxMusteriSoyadi.Size = new System.Drawing.Size(201, 24);
			this.textBoxMusteriSoyadi.TabIndex = 8;
			// 
			// textBoxMusteriAdi
			// 
			this.textBoxMusteriAdi.Location = new System.Drawing.Point(137, 30);
			this.textBoxMusteriAdi.Name = "textBoxMusteriAdi";
			this.textBoxMusteriAdi.Size = new System.Drawing.Size(201, 24);
			this.textBoxMusteriAdi.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(23, 71);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(106, 18);
			this.label7.TabIndex = 6;
			this.label7.Text = "Müşteri Soyadı";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(23, 105);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(110, 18);
			this.label6.TabIndex = 5;
			this.label6.Text = "Müşteri Telefon";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(23, 143);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(99, 18);
			this.label5.TabIndex = 4;
			this.label5.Text = "Müşteri Adres";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(399, 33);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Müşteri Cinsiyet";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(399, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(150, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Müşteri Doğum Tarihi";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(399, 135);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "İlçe Adı";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Müşteri Adı";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridViewMusteriler);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox2.Location = new System.Drawing.Point(0, 327);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(799, 242);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Müşteriler Listesi";
			// 
			// dataGridViewMusteriler
			// 
			this.dataGridViewMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewMusteriler.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewMusteriler.Location = new System.Drawing.Point(3, 20);
			this.dataGridViewMusteriler.Name = "dataGridViewMusteriler";
			this.dataGridViewMusteriler.Size = new System.Drawing.Size(793, 219);
			this.dataGridViewMusteriler.TabIndex = 0;
			this.dataGridViewMusteriler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMusteriler_CellDoubleClick);
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
			// FormMusteriler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SpringGreen;
			this.ClientSize = new System.Drawing.Size(800, 550);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormMusteriler";
			this.Text = "FormMusteriler";
			this.Load += new System.EventHandler(this.FormMusteriler_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteriler)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox comboBoxİlceAdi;
		private System.Windows.Forms.DateTimePicker dateTimePickerMusteriDogumTarihi;
		private System.Windows.Forms.CheckBox checkBoxKadin;
		private System.Windows.Forms.CheckBox checkBoxErkek;
		private System.Windows.Forms.TextBox textBoxMusteriAdres;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxMusteriTelefon;
		private System.Windows.Forms.TextBox textBoxMusteriSoyadi;
		private System.Windows.Forms.TextBox textBoxMusteriAdi;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridViewMusteriler;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButtonKaydet;
		private System.Windows.Forms.ToolStripButton toolStripButtonSil;
		private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
		private System.Windows.Forms.ToolStripButton toolStripButtonTemizle;
	}
}