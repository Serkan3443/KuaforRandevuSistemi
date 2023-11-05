namespace KuaforRandevuSistemi.UI
{
	partial class FormBakimlar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBakimlar));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBoxAciklama = new System.Windows.Forms.TextBox();
			this.textBoxBakimFiyati = new System.Windows.Forms.TextBox();
			this.comboBoxAlinanHizmet = new System.Windows.Forms.ComboBox();
			this.textBoxBakimAdi = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridViewBakimlar = new System.Windows.Forms.DataGridView();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonKaydet = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonTemizle = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonSil = new System.Windows.Forms.ToolStripButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBakimlar)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxAciklama);
			this.groupBox1.Controls.Add(this.textBoxBakimFiyati);
			this.groupBox1.Controls.Add(this.comboBoxAlinanHizmet);
			this.groupBox1.Controls.Add(this.textBoxBakimAdi);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(0, 29);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(802, 234);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Bakımlar Bilgisi";
			// 
			// textBoxAciklama
			// 
			this.textBoxAciklama.Location = new System.Drawing.Point(125, 157);
			this.textBoxAciklama.Multiline = true;
			this.textBoxAciklama.Name = "textBoxAciklama";
			this.textBoxAciklama.Size = new System.Drawing.Size(163, 71);
			this.textBoxAciklama.TabIndex = 7;
			// 
			// textBoxBakimFiyati
			// 
			this.textBoxBakimFiyati.Location = new System.Drawing.Point(125, 121);
			this.textBoxBakimFiyati.Name = "textBoxBakimFiyati";
			this.textBoxBakimFiyati.Size = new System.Drawing.Size(163, 24);
			this.textBoxBakimFiyati.TabIndex = 6;
			// 
			// comboBoxAlinanHizmet
			// 
			this.comboBoxAlinanHizmet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxAlinanHizmet.FormattingEnabled = true;
			this.comboBoxAlinanHizmet.Location = new System.Drawing.Point(125, 80);
			this.comboBoxAlinanHizmet.Name = "comboBoxAlinanHizmet";
			this.comboBoxAlinanHizmet.Size = new System.Drawing.Size(163, 26);
			this.comboBoxAlinanHizmet.TabIndex = 5;
			// 
			// textBoxBakimAdi
			// 
			this.textBoxBakimAdi.Location = new System.Drawing.Point(125, 37);
			this.textBoxBakimAdi.Name = "textBoxBakimAdi";
			this.textBoxBakimAdi.Size = new System.Drawing.Size(163, 24);
			this.textBoxBakimAdi.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Bakım Fiyatı";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 160);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Açıklama";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Alınan Hizmet";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bakım Adı";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridViewBakimlar);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox2.Location = new System.Drawing.Point(0, 281);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(802, 275);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Bakımlar Listesi";
			// 
			// dataGridViewBakimlar
			// 
			this.dataGridViewBakimlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewBakimlar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewBakimlar.Location = new System.Drawing.Point(3, 20);
			this.dataGridViewBakimlar.Name = "dataGridViewBakimlar";
			this.dataGridViewBakimlar.Size = new System.Drawing.Size(796, 252);
			this.dataGridViewBakimlar.TabIndex = 0;
			this.dataGridViewBakimlar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBakimlar_CellDoubleClick);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonKaydet,
            this.toolStripButtonGuncelle,
            this.toolStripButtonTemizle,
            this.toolStripButtonSil});
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
			// toolStripButtonTemizle
			// 
			this.toolStripButtonTemizle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTemizle.Image")));
			this.toolStripButtonTemizle.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonTemizle.Name = "toolStripButtonTemizle";
			this.toolStripButtonTemizle.Size = new System.Drawing.Size(66, 22);
			this.toolStripButtonTemizle.Text = "Temizle";
			this.toolStripButtonTemizle.Click += new System.EventHandler(this.toolStripButtonTemizle_Click);
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
			// FormBakimlar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Wheat;
			this.ClientSize = new System.Drawing.Size(800, 548);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormBakimlar";
			this.Text = "FormBakimlar";
			this.Load += new System.EventHandler(this.FormBakimlar_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBakimlar)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox comboBoxAlinanHizmet;
		private System.Windows.Forms.TextBox textBoxBakimAdi;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxAciklama;
		private System.Windows.Forms.TextBox textBoxBakimFiyati;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridViewBakimlar;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButtonKaydet;
		private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
		private System.Windows.Forms.ToolStripButton toolStripButtonTemizle;
		private System.Windows.Forms.ToolStripButton toolStripButtonSil;
	}
}