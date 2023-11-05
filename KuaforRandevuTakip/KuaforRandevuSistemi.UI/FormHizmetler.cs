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
	public partial class FormHizmetler : Form
	{
		HizmetlerManager hizmetMngr=new HizmetlerManager();
		KuaforRandevuDBEntities2 db = new KuaforRandevuDBEntities2();

		public FormHizmetler()
		{
			InitializeComponent();
			
			
		}

		private void FormHizmetler_Load(object sender, EventArgs e)
		{
			HizmetlerListeMetodu();

			comboBoxRandevuAdi.ValueMember = "RandevularID";
			comboBoxRandevuAdi.DisplayMember = "RandevuSaati";
			comboBoxRandevuAdi.DataSource = db.Randevular.ToList();



			comboBoxMusteriAdSoyad.ValueMember = "MusterilerID";
			comboBoxMusteriAdSoyad.DisplayMember = "MusteriAdSoyad";
			var musterilistesi = (from m in db.Musteriler
								  select new
								  {
									  MusterilerID = m.MusterilerID,
									  MusteriAdSoyad = m.MusteriAdi + " " + m.MusteriSoyadi
								  }
								).ToList();
			comboBoxMusteriAdSoyad.DataSource = musterilistesi;
			comboBoxMusteriAdSoyad.SelectedValue = -1;

			comboBoxCalisanAdSoyad.ValueMember = "CalisanlarId";
			comboBoxCalisanAdSoyad.DisplayMember = "CalisanAdSoyad";
			var calisanlistesi = (from c in db.Calisanlar
								  select new
								  {
									  CalisanlarId = c.CalisanlarId,
									  CalisanAdSoyad = c.CalisanAdi + " " + c.CalisanSoyadi

								  }
								).ToList();
			comboBoxCalisanAdSoyad.DataSource = calisanlistesi;
			comboBoxCalisanAdSoyad.SelectedIndex = -1;

			comboBoxKuaforAdi.ValueMember = "KuaforlerId";
			comboBoxKuaforAdi.DisplayMember = "KuaforAdi";
			comboBoxKuaforAdi.DataSource = db.Kuaforler.ToList();
			comboBoxKuaforAdi.SelectedIndex = -1;


		}
		private void HizmetlerListeMetodu()
		{
			dataGridViewHizmetler.DataSource = hizmetMngr.SP_HizmetLER();
		}

		private void toolStripButtonKaydet_Click(object sender, EventArgs e)
		{
			string hizmetkaydet = hizmetMngr.Kaydet(
				textBoxHizmetAdi.Text,
				(int)comboBoxRandevuAdi.SelectedValue,
				Convert.ToDecimal(textBoxAlinanHizmetFiyati.Text),
				(int)comboBoxMusteriAdSoyad.SelectedValue,
				(int)comboBoxCalisanAdSoyad.SelectedValue,
				(int)comboBoxKuaforAdi.SelectedValue,
				textBoxMusteriYorumu.Text);
			HizmetlerListeMetodu();
			MessageBox.Show(hizmetkaydet);
		}

		int HizmetID;
		private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
		{
			string hizmetGuncelle = hizmetMngr.Guncelle(
				HizmetID,
				textBoxHizmetAdi.Text,
				(int)comboBoxRandevuAdi.SelectedValue,
				Convert.ToDecimal(textBoxAlinanHizmetFiyati.Text),
				(int)comboBoxMusteriAdSoyad.SelectedValue,
				(int)comboBoxCalisanAdSoyad.SelectedValue,
				(int)comboBoxKuaforAdi.SelectedValue,
				textBoxMusteriYorumu.Text
				);
			HizmetlerListeMetodu();
			MessageBox.Show(hizmetGuncelle);

		}

		private void toolStripButtonSil_Click(object sender, EventArgs e)
		{
			string HizmetSil = hizmetMngr.Sil(HizmetID);
			HizmetlerListeMetodu();
			MessageBox.Show(HizmetSil);
		}
		private void Temizle()
		{
			textBoxHizmetAdi.Clear();
			comboBoxCalisanAdSoyad.SelectedValue = -1;
			comboBoxKuaforAdi.SelectedValue = -1;
			comboBoxMusteriAdSoyad.SelectedValue = -1;
			comboBoxRandevuAdi.SelectedValue = -1;
			textBoxAlinanHizmetFiyati.Clear();
			textBoxMusteriYorumu.Clear();
		}

		private void toolStripButtonTemizle_Click(object sender, EventArgs e)
		{
			Temizle();
		}

		private void dataGridViewHizmetler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				HizmetID = (int)dataGridViewHizmetler.Rows[e.RowIndex].Cells["AlinanHizmetlerId"].Value;
				textBoxHizmetAdi.Text = dataGridViewHizmetler.Rows[e.RowIndex].Cells["HizmetAdi"].Value.ToString();
				comboBoxCalisanAdSoyad.Text = dataGridViewHizmetler.Rows[e.RowIndex].Cells["CalisanAdi"].Value.ToString();
				comboBoxKuaforAdi.Text = dataGridViewHizmetler.Rows[e.RowIndex].Cells["KuaforAdi"].Value.ToString();
				comboBoxRandevuAdi.Text = dataGridViewHizmetler.Rows[e.RowIndex].Cells["Randevuİslemi"].Value.ToString();
				comboBoxMusteriAdSoyad.Text = dataGridViewHizmetler.Rows[e.RowIndex].Cells["MusteriAdi"].Value.ToString();
				textBoxAlinanHizmetFiyati.Text = dataGridViewHizmetler.Rows[e.RowIndex].Cells["AlinanHizmetFiyati"].Value.ToString();
				textBoxMusteriYorumu.Text = dataGridViewHizmetler.Rows[e.RowIndex].Cells["Aciklama"].Value.ToString();
			}
			catch (Exception ex)
			{

				MessageBox.Show("SİSTEMSEL BİR HATA OLUŞTU " + ex.Message);
			}
		}
	}
}
