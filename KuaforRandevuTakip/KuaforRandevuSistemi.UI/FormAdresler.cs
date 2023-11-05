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
	
	public partial class FormAdresler : Form
	{
		KuaforRandevuDBEntities2 db=new KuaforRandevuDBEntities2();
		AdreslerManager adresler = new AdreslerManager();

		public FormAdresler()
		{
			InitializeComponent();
		}
		public void AdreslerListesi()
		{
			dataGridViewAdresler.DataSource = adresler.SP_ADRESLERR();
		}

		private void FormAdresler_Load(object sender, EventArgs e)
		{
			AdreslerListesi();
			comboBoxMusteriAdisoyadi.ValueMember = "MusterilerId";
			comboBoxMusteriAdisoyadi.DisplayMember = "MusterilerAdSoyad";
			var musteriListesi=(from
				m in db.Musteriler
				select new
				{
					MusterilerId=m.MusterilerID,
					MusterilerAdSoyad=m.MusteriAdi + " " + m.MusteriSoyadi,
				}
				).ToList();
			
			comboBoxMusteriAdisoyadi.DataSource = musteriListesi;
			comboBoxMusteriAdisoyadi.SelectedIndex = -1;

			comboBoxİlceAdi.ValueMember = "id";
			comboBoxİlceAdi.DisplayMember = "İlce";
			comboBoxİlceAdi.DataSource = db.ilceler.ToList();
			comboBoxİlceAdi.SelectedIndex = -1;
		}
		public void Temizle()
		{
			textBoxAdresBasligi.Clear();
			comboBoxMusteriAdisoyadi.SelectedValue = -1;
			comboBoxİlceAdi.SelectedValue = -1;
			textBoxAdres.Clear();
		}

		private void toolStripButtonKaydet_Click(object sender, EventArgs e)
		{
			string adresAlani = adresler.Kaydet(
				textBoxAdresBasligi.Text,
				(int)comboBoxMusteriAdisoyadi.SelectedValue,
				(int)comboBoxİlceAdi.SelectedValue,
				textBoxAdres.Text);
			AdreslerListesi();
			MessageBox.Show(adresAlani);
		}
		int AdresID;
		private void toolStripButtonSil_Click(object sender, EventArgs e)
		{
			string adresSil = adresler.Sil(AdresID);
			AdreslerListesi();
			MessageBox.Show(adresSil);
		}

		private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
		{
			string AdresGuncelle = adresler.Guncelle(
				AdresID,
				textBoxAdresBasligi.Text,
				(int)comboBoxMusteriAdisoyadi.SelectedValue,
				(int)comboBoxİlceAdi.SelectedValue,
				textBoxAdres.Text);
			AdreslerListesi();
			MessageBox.Show(AdresGuncelle);
		}

		private void toolStripButtonTemizle_Click(object sender, EventArgs e)
		{
			Temizle();
		}

		private void dataGridViewAdresler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				AdresID = (int)dataGridViewAdresler.Rows[e.RowIndex].Cells["AdreslerId"].Value;
				textBoxAdresBasligi.Text = dataGridViewAdresler.Rows[e.RowIndex].Cells["AdresBasligi"].Value.ToString();
				comboBoxMusteriAdisoyadi.Text = dataGridViewAdresler.Rows[e.RowIndex].Cells["MusteriAdi"].Value.ToString();
				comboBoxİlceAdi.Text = dataGridViewAdresler.Rows[e.RowIndex].Cells["İlce"].Value.ToString();
				textBoxAdres.Text = dataGridViewAdresler.Rows[e.RowIndex].Cells["Adres"].Value.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Sistemsel Bir Hata oluştu" + ex.Message);
			}
		}
	}
}
