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
using KuaforRandevu.DLL;

namespace KuaforRandevuSistemi.UI
{
	
	public partial class FormKullanicilar : Form
	{
		
		KuaforRandevuDBEntities2 db=new KuaforRandevuDBEntities2 ();
		KullanicilarManager kullanicimngr = new KullanicilarManager(); 

		public FormKullanicilar()
		{
			InitializeComponent();
		}
		int KullanicilarID;
		private void FormKullanicilar_Load(object sender, EventArgs e)
		{
			KullanicilarListesiMethodu();
			comboBoxCalisanAdSoyad.ValueMember = "CalisanlarId";
			comboBoxCalisanAdSoyad.DisplayMember = "CalisanAdSoyad";
			var calisanliste = (from c in db.Calisanlar
								select new
								{
									CalisanlarId = c.CalisanlarId,
									CalisanAdSoyad = c.CalisanAdi + " " + c.CalisanSoyadi
								}
							  ).ToList();
			comboBoxCalisanAdSoyad.DataSource = calisanliste;
			comboBoxCalisanAdSoyad.SelectedIndex = -1;

			comboBoxYetkiid.ValueMember = "YetkilerID";
			comboBoxYetkiid.DisplayMember = "YetkiAdi";
			comboBoxYetkiid.DataSource = db.Yetkiler.ToList();
			comboBoxYetkiid.SelectedIndex= -1;
		}
		private void KullanicilarListesiMethodu()
		{
			dataGridViewKullanicilar.DataSource = kullanicimngr.SP_KullanicİLAR();
		}
		private void Temizle()
		{
			textBoxKullaniciAdi.Clear();
			textBoxKullaniciSifre.Clear();
			comboBoxYetkiid.SelectedValue = -1;
			comboBoxCalisanAdSoyad.SelectedValue = -1;
		}

		private void toolStripButtonKaydet_Click(object sender, EventArgs e)
		{
			string Kullanicikaydet = kullanicimngr.Kaydet(
				textBoxKullaniciAdi.Text,
				textBoxKullaniciSifre.Text,
				(int)comboBoxCalisanAdSoyad.SelectedValue,
				(int)comboBoxYetkiid.SelectedValue);
			KullanicilarListesiMethodu();
			MessageBox.Show(Kullanicikaydet);
		}
		
		private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
		{
			string kullanicig = kullanicimngr.Guncelle(
				KullanicilarID,
				textBoxKullaniciAdi.Text,
				textBoxKullaniciSifre.Text,
				(int)comboBoxCalisanAdSoyad.SelectedValue,
				(int)comboBoxYetkiid.SelectedValue
				);
			KullanicilarListesiMethodu();
			MessageBox.Show(kullanicig);
		}

		private void toolStripButtonSil_Click(object sender, EventArgs e)
		{
			string kullanicisil = kullanicimngr.Sil(KullanicilarID);
			KullanicilarListesiMethodu();
			MessageBox.Show(kullanicisil);
		}

		private void toolStripButtonTemizle_Click(object sender, EventArgs e)
		{
			Temizle();
		}

		private void dataGridViewKullanicilar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{

				KullanicilarID = (int)dataGridViewKullanicilar.Rows[e.RowIndex].Cells["KullanicilarID"].Value;
				textBoxKullaniciAdi.Text = dataGridViewKullanicilar.Rows[e.RowIndex].Cells["KullaniciAdi"].Value.ToString();
				textBoxKullaniciSifre.Text = dataGridViewKullanicilar.Rows[e.RowIndex].Cells["KullaniciSifre"].Value.ToString();
				comboBoxCalisanAdSoyad.Text = dataGridViewKullanicilar.Rows[e.RowIndex].Cells["CalisanAdi"].Value.ToString();
				comboBoxYetkiid.Text = dataGridViewKullanicilar.Rows[e.RowIndex].Cells["YetkiAdi"].Value.ToString();
			}
			catch (Exception ex)
			{

				MessageBox.Show("Sistemsel bir hata oluştu" + ex.Message);
			}
		}
	}
}
