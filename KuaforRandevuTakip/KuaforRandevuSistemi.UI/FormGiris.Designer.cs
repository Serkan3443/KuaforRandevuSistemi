namespace KuaforRandevuSistemi.UI
{
	partial class FormGiris
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
			this.textBoxSifre = new System.Windows.Forms.TextBox();
			this.buttonGirisYap = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::KuaforRandevuSistemi.UI.Properties.Resources.indir;
			this.pictureBox1.Location = new System.Drawing.Point(114, 44);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(518, 270);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.ForestGreen;
			this.label1.Location = new System.Drawing.Point(110, 340);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(163, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Kullanıcı Adı";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.ForestGreen;
			this.label2.Location = new System.Drawing.Point(110, 393);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Şifre";
			// 
			// textBoxKullaniciAdi
			// 
			this.textBoxKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBoxKullaniciAdi.Location = new System.Drawing.Point(310, 334);
			this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
			this.textBoxKullaniciAdi.Size = new System.Drawing.Size(279, 26);
			this.textBoxKullaniciAdi.TabIndex = 3;
			// 
			// textBoxSifre
			// 
			this.textBoxSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBoxSifre.Location = new System.Drawing.Point(310, 390);
			this.textBoxSifre.Name = "textBoxSifre";
			this.textBoxSifre.PasswordChar = '*';
			this.textBoxSifre.Size = new System.Drawing.Size(279, 26);
			this.textBoxSifre.TabIndex = 4;
			// 
			// buttonGirisYap
			// 
			this.buttonGirisYap.BackColor = System.Drawing.Color.Linen;
			this.buttonGirisYap.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonGirisYap.ForeColor = System.Drawing.Color.ForestGreen;
			this.buttonGirisYap.Location = new System.Drawing.Point(114, 450);
			this.buttonGirisYap.Name = "buttonGirisYap";
			this.buttonGirisYap.Size = new System.Drawing.Size(518, 41);
			this.buttonGirisYap.TabIndex = 5;
			this.buttonGirisYap.Text = "Giriş Yap";
			this.buttonGirisYap.UseVisualStyleBackColor = false;
			this.buttonGirisYap.Click += new System.EventHandler(this.buttonGirisYap_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.Color.SteelBlue;
			this.label3.Location = new System.Drawing.Point(234, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(300, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Kuaför Randevu Sistemine Hoşgeldiniz";
			// 
			// FormGiris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.BackgroundImage = global::KuaforRandevuSistemi.UI.Properties.Resources.desktop_wallpaper_light_colour_backgrounds_2560x1600_line_llight_color_background;
			this.ClientSize = new System.Drawing.Size(994, 511);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.buttonGirisYap);
			this.Controls.Add(this.textBoxSifre);
			this.Controls.Add(this.textBoxKullaniciAdi);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "FormGiris";
			this.Text = "FormGiris";
			this.Load += new System.EventHandler(this.FormGiris_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxKullaniciAdi;
		private System.Windows.Forms.TextBox textBoxSifre;
		private System.Windows.Forms.Button buttonGirisYap;
		private System.Windows.Forms.Label label3;
	}
}