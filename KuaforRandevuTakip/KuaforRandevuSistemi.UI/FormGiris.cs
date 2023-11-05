using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KuaforRandevu.BLL.Manager;

namespace KuaforRandevuSistemi.UI
{
	public partial class FormGiris : Form
	{
		public FormGiris()
		{
			InitializeComponent();
		}
		KullanicilarManager kullaniciMngr=new KullanicilarManager();	

		private void buttonGirisYap_Click(object sender, EventArgs e)
		{
			var sonuc = kullaniciMngr.Giris(textBoxKullaniciAdi.Text, textBoxSifre.Text);
			if(sonuc != null )
			{
				FormAnasayfa frmanasayfa=new FormAnasayfa();
				frmanasayfa.labelKullanici.Text = sonuc.Calisanlar.CalisanAdi + " " + sonuc.Calisanlar.CalisanSoyadi;
				this.Hide();
				frmanasayfa.Show();
				
			}
			else
			{
				MessageBox.Show("Kullanıcı adı ya da şifre hatalı");
			}

		}

		private void FormGiris_Load(object sender, EventArgs e)
		{

		}
	}
}
