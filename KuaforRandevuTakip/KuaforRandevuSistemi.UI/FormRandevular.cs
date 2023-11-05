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
	public partial class FormRandevular : Form
	{
		KuaforRandevuDBEntities2 db = new KuaforRandevuDBEntities2();
		RandevularManager randevuMngr = new RandevularManager();

		public FormRandevular()
		{
			InitializeComponent();
		}

		private void FormRandevular_Load(object sender, EventArgs e)
		{
			RandevularListesiMetodu();
			comboBoxMusteriAdSoyad.ValueMember = "MusterilerID";
			comboBoxMusteriAdSoyad.DisplayMember = "MusteriAdSoyad";
			var musterilistesi = (from m in db.Musteriler
								  select new
								  {
									  MusterilerID = m.MusterilerID,
									  MusteriAdSoyad = m.MusteriAdi + " " + m.MusteriSoyadi
								  }
								).ToList();
			comboBoxMusteriAdSoyad.DataSource= musterilistesi;
			comboBoxMusteriAdSoyad.SelectedIndex = -1;

			comboBoxAdresAd.ValueMember = "AdreslerId";
			comboBoxAdresAd.DisplayMember = "Adres";
			comboBoxAdresAd.DataSource = db.Adresler.ToList();
			comboBoxAdresAd.SelectedIndex = -1;

			comboBoxCalisanAdSoyad.ValueMember = "CalisanlarId";
			comboBoxCalisanAdSoyad.DisplayMember = "CalisanAdSoyad";
			var calisanlistesi = (from c in db.Calisanlar
								  select new
								  {
									  CalisanlarId = c.CalisanlarId,
									  CalisanAdSoyad = c.CalisanAdi + " " + c.CalisanSoyadi
								  }
								).ToList();
			comboBoxCalisanAdSoyad .DataSource= calisanlistesi;
			comboBoxCalisanAdSoyad.SelectedIndex = -1;

			comboBoxKuaforAd.ValueMember = "KuaforlerId";
			comboBoxKuaforAd.DisplayMember = "KuaforAdi";
			comboBoxKuaforAd.DataSource = db.Kuaforler.ToList();
			comboBoxKuaforAd.SelectedIndex = -1;

		}
		private void RandevularListesiMetodu()
		{
			dataGridViewRandevular.DataSource = randevuMngr.SP_RANDEVULARLİSTE();
		}
		private void Temizle()
		{
			comboBoxAdresAd.SelectedValue=-1;
			comboBoxCalisanAdSoyad.SelectedValue = -1;
			comboBoxKuaforAd.SelectedValue = -1;
			comboBoxMusteriAdSoyad.SelectedValue= -1;
			textBoxRandevuİslemi.Clear();
			textBoxOdenenTutar.Clear();

		}

		private void toolStripButtonKaydet_Click(object sender, EventArgs e)
		{
			string randevukaydet = randevuMngr.Kaydet(
				Convert.ToDateTime(dateTimePickersaat.Text),
				Convert.ToDateTime(dateTimePickerRandevuTarihi.Text),
				(int)comboBoxMusteriAdSoyad.SelectedValue,
				(int)comboBoxAdresAd.SelectedValue,
				(int)comboBoxCalisanAdSoyad.SelectedValue,
				(int)comboBoxKuaforAd.SelectedValue,
				textBoxRandevuİslemi.Text,
				Convert.ToDecimal(textBoxOdenenTutar.Text)
				);
			RandevularListesiMetodu();
			MessageBox.Show(randevukaydet);
		}
		int RandevuID;
		private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
		{
			var randevuguncelle = randevuMngr.Guncelle(
				RandevuID,
				Convert.ToDateTime(dateTimePickersaat.Text),
				Convert.ToDateTime(dateTimePickerRandevuTarihi.Text),
				(int)comboBoxMusteriAdSoyad.SelectedValue,
				(int)comboBoxAdresAd.SelectedValue,
				(int)comboBoxCalisanAdSoyad.SelectedValue,
				(int)comboBoxKuaforAd.SelectedValue,
				textBoxRandevuİslemi.Text,
				Convert.ToDecimal(textBoxOdenenTutar.Text)
				);
			RandevularListesiMetodu();
			MessageBox.Show(randevuguncelle);
		}

		private void toolStripButtonTemizle_Click(object sender, EventArgs e)
		{
			Temizle();
		}

		private void toolStripButtonSil_Click(object sender, EventArgs e)
		{
			string randevusil = randevuMngr.Sil(RandevuID);
			RandevularListesiMetodu();
			MessageBox.Show(randevusil);
		}

		private void dataGridViewRandevular_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{

				RandevuID = (int)dataGridViewRandevular.Rows[e.RowIndex].Cells["RandevularID"].Value;
				comboBoxAdresAd.Text = dataGridViewRandevular.Rows[e.RowIndex].Cells["Adres"].Value.ToString();
				comboBoxCalisanAdSoyad.Text = dataGridViewRandevular.Rows[e.RowIndex].Cells["CalisanAdi"].Value.ToString();
				comboBoxKuaforAd.Text = dataGridViewRandevular.Rows[e.RowIndex].Cells["KuaforAdi"].Value.ToString();
				comboBoxMusteriAdSoyad.Text = dataGridViewRandevular.Rows[e.RowIndex].Cells["MusteriAdi"].Value.ToString();
				textBoxRandevuİslemi.Text = dataGridViewRandevular.Rows[e.RowIndex].Cells["Randevuİslemi"].Value.ToString();
				textBoxOdenenTutar.Text = dataGridViewRandevular.Rows[e.RowIndex].Cells["OdenenTutar"].Value.ToString();
			}
			catch (Exception ex)
			{

				MessageBox.Show("Sistemsel bir hata oluştu " + ex.Message);
			}

		}
	}
}
