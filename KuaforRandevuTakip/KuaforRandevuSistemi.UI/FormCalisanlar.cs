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
	public partial class FormCalisanlar : Form
	{
		CalisanlarManager calisanMngr = new CalisanlarManager();
		KuaforRandevuDBEntities2 db = new KuaforRandevuDBEntities2();

		public FormCalisanlar()
		{
			InitializeComponent();

		}

		private void FormCalisanlar_Load(object sender, EventArgs e)
		{
			CalisanlariListele();
			comboBoxKuaforAdi.ValueMember = "KuaforlerID";
			comboBoxKuaforAdi.DisplayMember = "KuaforAdi";
			comboBoxKuaforAdi.DataSource = db.Kuaforler.ToList();
			comboBoxKuaforAdi.SelectedIndex = -1;

		}
		public void CalisanlariListele()
		{
			dataGridViewCalisanlar.DataSource = calisanMngr.SP_CALİSANLAR();
		}

		private void toolStripButtonKaydet_Click(object sender, EventArgs e)
		{
			string calisankaydet = calisanMngr.Kaydet(
				textBoxCalisanAdi.Text,
				textBoxCalisanSoyadi.Text,
				maskedTextBoxCalisanTelefon.Text,
				textBoxCalisanEmail.Text,
				textBoxCalisanAdres.Text,
				Convert.ToDateTime(dateTimePickerCalisanDTarihi.Text),
				radioButtonErkek.Checked == true ? "Erkek": "Kadın",
				comboBoxCalisanPozisyonu.Text,
				Convert.ToDateTime(dateTimePickerCalisanBaslamaTarihi.Text),
				Convert.ToDateTime(dateTimePickerCalisanCikisTarihi.Text),
				(int)comboBoxKuaforAdi.SelectedValue
				) ;
			CalisanlariListele();
			MessageBox.Show(calisankaydet);
		}
		int CalisanID;
		private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
		{
			string CalisanGuncelle = calisanMngr.Guncelle(
				CalisanID,
				textBoxCalisanAdi.Text,
				textBoxCalisanSoyadi.Text,
				maskedTextBoxCalisanTelefon.Text,
				textBoxCalisanEmail.Text,
				textBoxCalisanAdres.Text,
				Convert.ToDateTime(dateTimePickerCalisanDTarihi.Text),
				radioButtonErkek.Checked == true ? "Erkek" : "Kadın",
				comboBoxCalisanPozisyonu.Text,
				Convert.ToDateTime(dateTimePickerCalisanBaslamaTarihi.Text),
				Convert.ToDateTime(dateTimePickerCalisanCikisTarihi.Text),
				(int)comboBoxKuaforAdi.SelectedValue
				);
			CalisanlariListele();
			MessageBox.Show(CalisanGuncelle);

		}

		private void toolStripButtonSil_Click(object sender, EventArgs e)
		{
			string CalisanSil = calisanMngr.Sil(CalisanID);
			CalisanlariListele();
			MessageBox.Show(CalisanSil);
		}

		private void dataGridViewCalisanlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			CalisanID =(int) dataGridViewCalisanlar.Rows[e.RowIndex].Cells["CalisanlarId"].Value;
			textBoxCalisanAdi.Text = dataGridViewCalisanlar.Rows[e.RowIndex].Cells["CalisanAdi"].Value.ToString();
			textBoxCalisanSoyadi.Text = dataGridViewCalisanlar.Rows[e.RowIndex].Cells["CalisanSoyadi"].Value.ToString();
			maskedTextBoxCalisanTelefon.Text = dataGridViewCalisanlar.Rows[e.RowIndex].Cells["CalisanTelefon"].Value.ToString();
			textBoxCalisanEmail.Text = dataGridViewCalisanlar.Rows[e.RowIndex].Cells["CalisanEmail"].Value.ToString();
			textBoxCalisanAdres.Text = dataGridViewCalisanlar.Rows[e.RowIndex].Cells["CalisanAdresi"].Value.ToString();
			dateTimePickerCalisanDTarihi.Text = dataGridViewCalisanlar.Rows[e.RowIndex].Cells["CalisanDogumTarihi"].Value.ToString();
			radioButtonErkek.Text= dataGridViewCalisanlar.Rows[e.RowIndex].Cells["CalisanCinsiyeti"].Value.ToString();
			radioButtonKadin.Text = dataGridViewCalisanlar.Rows[e.RowIndex].Cells["CalisanCinsiyeti"].Value.ToString();
			comboBoxCalisanPozisyonu.Text = dataGridViewCalisanlar.Rows[e.RowIndex].Cells["CalisanPozisyonu"].Value.ToString();
			dateTimePickerCalisanBaslamaTarihi.Text = dataGridViewCalisanlar.Rows[e.RowIndex].Cells["CalisanBaslamaTarihi"].Value.ToString();
			comboBoxKuaforAdi.Text = dataGridViewCalisanlar.Rows[e.RowIndex].Cells["KuaforAdi"].Value.ToString();
			
		}

		private void toolStripButtonTemizle_Click(object sender, EventArgs e)
		{
			Temizle();
		}
		public void Temizle()
		{
			textBoxCalisanAdi.Clear();
			textBoxCalisanSoyadi.Clear();
			maskedTextBoxCalisanTelefon.Clear();
			textBoxCalisanEmail.Clear();
			textBoxCalisanAdres.Clear();
			radioButtonErkek.Checked = false;
			radioButtonKadin.Checked = false;
			comboBoxCalisanPozisyonu.SelectedValue=-1;
			comboBoxKuaforAdi.SelectedValue = -1;
			
			
		}
	}
}
