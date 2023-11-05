namespace KuaforRandevuSistemi.UI
{
	partial class FormKullanicilar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKullanicilar));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBoxYetkiid = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBoxCalisanAdSoyad = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxKullaniciSifre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridViewKullanicilar = new System.Windows.Forms.DataGridView();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonKaydet = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonSil = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonTemizle = new System.Windows.Forms.ToolStripButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanicilar)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBoxYetkiid);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.comboBoxCalisanAdSoyad);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.textBoxKullaniciSifre);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBoxKullaniciAdi);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(2, 36);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(801, 230);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kullanicilar";
			// 
			// comboBoxYetkiid
			// 
			this.comboBoxYetkiid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxYetkiid.FormattingEnabled = true;
			this.comboBoxYetkiid.Location = new System.Drawing.Point(339, 172);
			this.comboBoxYetkiid.Name = "comboBoxYetkiid";
			this.comboBoxYetkiid.Size = new System.Drawing.Size(161, 26);
			this.comboBoxYetkiid.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(188, 177);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 18);
			this.label4.TabIndex = 6;
			this.label4.Text = "YetkiID";
			// 
			// comboBoxCalisanAdSoyad
			// 
			this.comboBoxCalisanAdSoyad.FormattingEnabled = true;
			this.comboBoxCalisanAdSoyad.Location = new System.Drawing.Point(339, 131);
			this.comboBoxCalisanAdSoyad.Name = "comboBoxCalisanAdSoyad";
			this.comboBoxCalisanAdSoyad.Size = new System.Drawing.Size(161, 26);
			this.comboBoxCalisanAdSoyad.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(188, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 18);
			this.label3.TabIndex = 4;
			this.label3.Text = "Çalışan Adı Soyadı";
			// 
			// textBoxKullaniciSifre
			// 
			this.textBoxKullaniciSifre.Location = new System.Drawing.Point(339, 82);
			this.textBoxKullaniciSifre.Name = "textBoxKullaniciSifre";
			this.textBoxKullaniciSifre.Size = new System.Drawing.Size(161, 24);
			this.textBoxKullaniciSifre.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(188, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "Kullanıcı Şifre";
			// 
			// textBoxKullaniciAdi
			// 
			this.textBoxKullaniciAdi.Location = new System.Drawing.Point(339, 37);
			this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
			this.textBoxKullaniciAdi.Size = new System.Drawing.Size(161, 24);
			this.textBoxKullaniciAdi.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(188, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kullanıcı Adı";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridViewKullanicilar);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox2.Location = new System.Drawing.Point(2, 272);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(801, 240);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Kullanıcılar Listesi";
			// 
			// dataGridViewKullanicilar
			// 
			this.dataGridViewKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewKullanicilar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewKullanicilar.Location = new System.Drawing.Point(3, 20);
			this.dataGridViewKullanicilar.Name = "dataGridViewKullanicilar";
			this.dataGridViewKullanicilar.Size = new System.Drawing.Size(795, 217);
			this.dataGridViewKullanicilar.TabIndex = 0;
			this.dataGridViewKullanicilar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKullanicilar_CellDoubleClick);
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
			this.toolStripButtonTemizle.Size = new System.Drawing.Size(66, 22);
			this.toolStripButtonTemizle.Text = "Temizle";
			this.toolStripButtonTemizle.Click += new System.EventHandler(this.toolStripButtonTemizle_Click);
			// 
			// FormKullanicilar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.ClientSize = new System.Drawing.Size(800, 511);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormKullanicilar";
			this.Text = "FormKullanicilar";
			this.Load += new System.EventHandler(this.FormKullanicilar_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanicilar)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox comboBoxCalisanAdSoyad;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxKullaniciSifre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxKullaniciAdi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxYetkiid;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridViewKullanicilar;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButtonKaydet;
		private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
		private System.Windows.Forms.ToolStripButton toolStripButtonSil;
		private System.Windows.Forms.ToolStripButton toolStripButtonTemizle;
	}
}