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
	public partial class FormAlinanUrunler : Form
	{
		KuaforRandevuDBEntities2 db = new KuaforRandevuDBEntities2();
		AlinanUrunlerManager alinanurunmanager= new AlinanUrunlerManager();

		public FormAlinanUrunler()
		{
			InitializeComponent();
		}

		private void FormAlinanUrunler_Load(object sender, EventArgs e)
		{
			AlinanUrunleriListele();
		}
		public void AlinanUrunleriListele()
		{
			dataGridViewAlinanurunler.DataSource = alinanurunmanager.AlinanUrunleriListele();
		}
		public void Temizle()
		{
			textBoxAlinanUrunAdi.Clear();
			textBoxAlinanUrunMarkasi.Clear();
			textBoxAlinanUrunTuru.Clear();
			textBoxAlinanUrunTipi.Clear();
			textBoxAlinanUrunMiktari.Clear();
			textBoxAciklama.Clear();
		}

		private void toolStripButtonKaydet_Click(object sender, EventArgs e)
		{
			string Alinanurunalani = alinanurunmanager.Kaydet(
				textBoxAlinanUrunAdi.Text,
				textBoxAlinanUrunMarkasi.Text,
				textBoxAlinanUrunTuru.Text,
				textBoxAlinanUrunTipi.Text,
				Convert.ToDecimal(textBoxAlinanUrunMiktari.Text),
				textBoxAciklama.Text
				);
			AlinanUrunleriListele();
			MessageBox.Show(Alinanurunalani);
		}
		int AlinanUrunID;
		private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
		{
			string alinanurunguncelle = alinanurunmanager.Guncelle(
				AlinanUrunID,
				textBoxAlinanUrunAdi.Text,
				textBoxAlinanUrunMarkasi.Text,
				textBoxAlinanUrunTuru.Text,
				textBoxAlinanUrunTipi.Text,
				Convert.ToDecimal(textBoxAlinanUrunMiktari.Text),
				textBoxAciklama.Text
				);
			AlinanUrunleriListele();
			MessageBox.Show(alinanurunguncelle);
		}

		private void toolStripButtonSil_Click(object sender, EventArgs e)
		{
			string alinanurunsil = alinanurunmanager.Sil(AlinanUrunID);
			AlinanUrunleriListele();
			MessageBox.Show(alinanurunsil);
		}

		private void dataGridViewAlinanurunler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				AlinanUrunID = (int)dataGridViewAlinanurunler.Rows[e.RowIndex].Cells["AlinanUrunlerID"].Value;
				textBoxAlinanUrunAdi.Text = dataGridViewAlinanurunler.Rows[e.RowIndex].Cells["AlinanurunAdi"].Value.ToString();
				textBoxAlinanUrunMarkasi.Text = dataGridViewAlinanurunler.Rows[e.RowIndex].Cells["AlinanUrunMarkasi"].Value.ToString();
				textBoxAlinanUrunTuru.Text = dataGridViewAlinanurunler.Rows[e.RowIndex].Cells["AlinanurunTuru"].Value.ToString();
				textBoxAlinanUrunTipi.Text = dataGridViewAlinanurunler.Rows[e.RowIndex].Cells["AlinanurunTipi"].Value.ToString();
				textBoxAlinanUrunMiktari.Text = dataGridViewAlinanurunler.Rows[e.RowIndex].Cells["AlinanUrunMiktari"].Value.ToString();
			}
			catch (Exception ex)
			{

				MessageBox.Show("SİSTEMSEL BİR HATA OLUŞTU " + ex.Message);
			}
		}

		private void toolStripButtonTemizle_Click(object sender, EventArgs e)
		{
			Temizle();
		}
	}
}
