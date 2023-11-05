using KuaforRandevu.DLL;
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
using KuaforRandevu.DLL.RepositoryFolder;

namespace KuaforRandevuSistemi.UI
{
	public partial class FormBakimlar : Form
	{
		BakimlarManager bakimlarMngr = new BakimlarManager();
		KuaforRandevuDBEntities2 db=new KuaforRandevuDBEntities2();

		public FormBakimlar()
		{
			InitializeComponent();
		}

		private void FormBakimlar_Load(object sender, EventArgs e)
		{
			BakimTablosuListele();
			comboBoxAlinanHizmet.ValueMember = "AlinanHizmetlerId";
			comboBoxAlinanHizmet.DisplayMember = "HizmetAdi";
			comboBoxAlinanHizmet.DataSource = db.Hizmetler.ToList();
			comboBoxAlinanHizmet.SelectedIndex = -1;
		}
		public void BakimTablosuListele()
		{
			dataGridViewBakimlar.DataSource = bakimlarMngr.SP_BAKİMLAR();
		}
		public void Temizle()
		{
			textBoxBakimAdi.Clear();
			textBoxAciklama.Clear();
			textBoxBakimFiyati.Clear();
			comboBoxAlinanHizmet.SelectedValue = -1;
			textBoxAciklama.Clear();
		}
		private void toolStripButtonKaydet_Click(object sender, EventArgs e)
		{

			string bakimKaydet = bakimlarMngr.Kaydet(
				textBoxBakimAdi.Text,
				(int)comboBoxAlinanHizmet.SelectedValue,
				Convert.ToInt32(textBoxBakimFiyati.Text),
				textBoxAciklama.Text);
			BakimTablosuListele();
			MessageBox.Show(bakimKaydet);
		}
		int BakimlarID;
		private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
		{

			string BakimGuncelle = bakimlarMngr.Guncelle(
				BakimlarID,
				textBoxBakimAdi.Text,
				(int)comboBoxAlinanHizmet.SelectedValue,
				Convert.ToInt32(textBoxBakimFiyati.Text),
				textBoxAciklama.Text);
			BakimTablosuListele();
			MessageBox.Show(BakimGuncelle);
		}

		private void toolStripButtonTemizle_Click(object sender, EventArgs e)
		{
			Temizle();
		}

		private void toolStripButtonSil_Click(object sender, EventArgs e)
		{
			string BakimSil = bakimlarMngr.Sil(
				BakimlarID
				);
			BakimTablosuListele();
			MessageBox.Show(BakimSil);
		}

		private void dataGridViewBakimlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				BakimlarID = (int)dataGridViewBakimlar.Rows[e.RowIndex].Cells["BakimlarId"].Value;
				textBoxBakimAdi.Text = dataGridViewBakimlar.Rows[e.RowIndex].Cells["BakimAdi"].Value.ToString();
				comboBoxAlinanHizmet.Text = dataGridViewBakimlar.Rows[e.RowIndex].Cells["HizmetAdi"].Value.ToString();
				textBoxBakimFiyati.Text = dataGridViewBakimlar.Rows[e.RowIndex].Cells["BakimFiyati"].Value.ToString();
				textBoxAciklama.Text = dataGridViewBakimlar.Rows[e.RowIndex].Cells["Aciklama"].Value.ToString();
			}
			catch (Exception ex)
			{

				MessageBox.Show("SİSTEMSEL BİR  HATA OLUŞTU:\nHATA" + ex.Message);
			}
		}
	}
}
