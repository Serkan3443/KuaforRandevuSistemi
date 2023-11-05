namespace KuaforRandevuSistemi.UI
{
	partial class FormKuaforler
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKuaforler));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBoxKuaforilceid = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxKuaforAdres = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.maskedTextBoxKuaforTelefon = new System.Windows.Forms.MaskedTextBox();
			this.textBoxKuaforAdi = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridViewKuaforler = new System.Windows.Forms.DataGridView();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonKaydet = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonTemizle = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonSil = new System.Windows.Forms.ToolStripButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewKuaforler)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBoxKuaforilceid);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBoxKuaforAdres);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.maskedTextBoxKuaforTelefon);
			this.groupBox1.Controls.Add(this.textBoxKuaforAdi);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(3, 33);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(797, 254);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kuaför Bilgisi";
			// 
			// comboBoxKuaforilceid
			// 
			this.comboBoxKuaforilceid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxKuaforilceid.FormattingEnabled = true;
			this.comboBoxKuaforilceid.Location = new System.Drawing.Point(144, 128);
			this.comboBoxKuaforilceid.Name = "comboBoxKuaforilceid";
			this.comboBoxKuaforilceid.Size = new System.Drawing.Size(156, 26);
			this.comboBoxKuaforilceid.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(33, 137);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 18);
			this.label4.TabIndex = 6;
			this.label4.Text = "Kuaför İlçe Adı";
			// 
			// textBoxKuaforAdres
			// 
			this.textBoxKuaforAdres.Location = new System.Drawing.Point(144, 171);
			this.textBoxKuaforAdres.Multiline = true;
			this.textBoxKuaforAdres.Name = "textBoxKuaforAdres";
			this.textBoxKuaforAdres.Size = new System.Drawing.Size(156, 67);
			this.textBoxKuaforAdres.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 194);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 18);
			this.label3.TabIndex = 4;
			this.label3.Text = "Kuaför Adres";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "Kuaför Telefon";
			// 
			// maskedTextBoxKuaforTelefon
			// 
			this.maskedTextBoxKuaforTelefon.Location = new System.Drawing.Point(144, 80);
			this.maskedTextBoxKuaforTelefon.Mask = "(999) 000-0000";
			this.maskedTextBoxKuaforTelefon.Name = "maskedTextBoxKuaforTelefon";
			this.maskedTextBoxKuaforTelefon.Size = new System.Drawing.Size(156, 24);
			this.maskedTextBoxKuaforTelefon.TabIndex = 2;
			// 
			// textBoxKuaforAdi
			// 
			this.textBoxKuaforAdi.Location = new System.Drawing.Point(144, 36);
			this.textBoxKuaforAdi.Name = "textBoxKuaforAdi";
			this.textBoxKuaforAdi.Size = new System.Drawing.Size(156, 24);
			this.textBoxKuaforAdi.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kuaför Adı";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridViewKuaforler);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox2.Location = new System.Drawing.Point(3, 293);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(797, 256);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Kuaför Listesi";
			// 
			// dataGridViewKuaforler
			// 
			this.dataGridViewKuaforler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewKuaforler.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewKuaforler.Location = new System.Drawing.Point(3, 20);
			this.dataGridViewKuaforler.Name = "dataGridViewKuaforler";
			this.dataGridViewKuaforler.Size = new System.Drawing.Size(791, 233);
			this.dataGridViewKuaforler.TabIndex = 0;
			this.dataGridViewKuaforler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKuaforler_CellDoubleClick);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonKaydet,
            this.toolStripButtonTemizle,
            this.toolStripButtonGuncelle,
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
			// toolStripButtonTemizle
			// 
			this.toolStripButtonTemizle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTemizle.Image")));
			this.toolStripButtonTemizle.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonTemizle.Name = "toolStripButtonTemizle";
			this.toolStripButtonTemizle.Size = new System.Drawing.Size(66, 22);
			this.toolStripButtonTemizle.Text = "Temizle";
			this.toolStripButtonTemizle.Click += new System.EventHandler(this.toolStripButtonTemizle_Click);
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
			// FormKuaforler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Orchid;
			this.ClientSize = new System.Drawing.Size(800, 551);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormKuaforler";
			this.Text = "FormKuaforler";
			this.Load += new System.EventHandler(this.FormKuaforler_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewKuaforler)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBoxKuaforAdres;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxKuaforTelefon;
		private System.Windows.Forms.TextBox textBoxKuaforAdi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxKuaforilceid;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridViewKuaforler;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButtonKaydet;
		private System.Windows.Forms.ToolStripButton toolStripButtonTemizle;
		private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
		private System.Windows.Forms.ToolStripButton toolStripButtonSil;
	}
}