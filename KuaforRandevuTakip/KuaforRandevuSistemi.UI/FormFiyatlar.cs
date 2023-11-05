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

	public partial class FormFiyatlar : Form
	{
		
		KuaforRandevuDBEntities2 db = new KuaforRandevuDBEntities2();
		FiyatlarManager fiyatMngr = new FiyatlarManager();

		public FormFiyatlar()
		{
			InitializeComponent();
		}

		private void FormFiyatlar_Load(object sender, EventArgs e)
		{
			FiyatlariListeleMethodu();
			comboBoxKuaforAdi.ValueMember = "KuaforlerID";
			comboBoxKuaforAdi.DisplayMember = "KuaforAdi";
			comboBoxKuaforAdi.DataSource = db.Kuaforler.ToList();
			comboBoxKuaforAdi.SelectedIndex = -1;

			comboBoxBakimAdi.ValueMember = "BakimlarId";
			comboBoxBakimAdi.DisplayMember = "BakimAdi";
			comboBoxBakimAdi.DataSource = db.Bakimlar.ToList();
			comboBoxBakimAdi.SelectedIndex = -1;

			comboBoxAlinanHizmet.ValueMember = "AlinanHizmetlerId";
			comboBoxAlinanHizmet.DisplayMember = "HizmetAdi";
			comboBoxAlinanHizmet.DataSource = db.Hizmetler.ToList();
			comboBoxAlinanHizmet.SelectedIndex = -1;
		}
		private void FiyatlariListeleMethodu()
		{
			dataGridViewFiyatlar.DataSource = fiyatMngr.sp_FiyatlarListesi();
		}
		private void Temizle()
		{
			textBoxFiyat.Clear();
			comboBoxKuaforAdi.SelectedValue = -1;
			comboBoxAlinanHizmet.SelectedValue = -1;
			comboBoxBakimAdi.SelectedValue = -1;
		}

		private void toolStripButtonKaydet_Click(object sender, EventArgs e)
		{
			string fiyatkaydet = fiyatMngr.Kaydet(
				Convert.ToDecimal(textBoxFiyat.Text),
				Convert.ToDateTime(dateTimePickerFiyatBaslangicTarihi.Text),
				Convert.ToDateTime(dateTimePickerFiyatBitisTarihi.Text),
				(int)comboBoxKuaforAdi.SelectedValue,
				(int)comboBoxBakimAdi.SelectedValue,
				(int)comboBoxAlinanHizmet.SelectedValue);
			FiyatlariListeleMethodu();
			MessageBox.Show(fiyatkaydet);
		}
		int FiyatlarId;
		private void toolStripButtonSil_Click(object sender, EventArgs e)
		{
			string fiyatsil = fiyatMngr.Sil(FiyatlarId);
			FiyatlariListeleMethodu();
			MessageBox.Show(fiyatsil);
				
		}

		private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
		{
			string fiyatguncelle = fiyatMngr.Guncelle(
				FiyatlarId,
				Convert.ToDecimal(textBoxFiyat.Text),
				Convert.ToDateTime(dateTimePickerFiyatBaslangicTarihi.Text),
				Convert.ToDateTime(dateTimePickerFiyatBitisTarihi.Text),
				(int)comboBoxKuaforAdi.SelectedValue,
				(int)comboBoxBakimAdi.SelectedValue,
				(int)comboBoxAlinanHizmet.SelectedValue
				);
			FiyatlariListeleMethodu();
			MessageBox.Show(fiyatguncelle);
		}

		private void toolStripButtonTemizle_Click(object sender, EventArgs e)
		{
			Temizle();
		}

		private void dataGridViewFiyatlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{

				FiyatlarId = (int)dataGridViewFiyatlar.Rows[e.RowIndex].Cells["FiyatlarID"].Value;
				textBoxFiyat.Text = dataGridViewFiyatlar.Rows[e.RowIndex].Cells["Fiyat"].Value.ToString();
				dateTimePickerFiyatBaslangicTarihi.Text = dataGridViewFiyatlar.Rows[e.RowIndex].Cells["FiyatBaslangicTarihi"].Value.ToString();
				dateTimePickerFiyatBitisTarihi.Text = dataGridViewFiyatlar.Rows[e.RowIndex].Cells["FiyatBitisTarihi"].Value.ToString();
				comboBoxKuaforAdi.Text = dataGridViewFiyatlar.Rows[e.RowIndex].Cells["KuaforAdi"].Value.ToString();
				comboBoxBakimAdi.Text = dataGridViewFiyatlar.Rows[e.RowIndex].Cells["BakimAdi"].Value.ToString();
				comboBoxAlinanHizmet.Text = dataGridViewFiyatlar.Rows[e.RowIndex].Cells["HizmetAdi"].Value.ToString();
			}
			catch (Exception ex)
			{

				MessageBox.Show("SİSTEMSEL BİR HATA OLUŞTU: " + ex.Message);
			}
			
		}
	}
}
