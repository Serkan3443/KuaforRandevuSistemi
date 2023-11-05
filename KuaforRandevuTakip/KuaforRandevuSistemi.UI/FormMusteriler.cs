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
	public partial class FormMusteriler : Form
	{
		MusterilerManager musterimngr = new MusterilerManager();
		KuaforRandevuDBEntities2 db=new KuaforRandevuDBEntities2();

		public FormMusteriler()
		{
			InitializeComponent();
		}

		private void FormMusteriler_Load(object sender, EventArgs e)
		{
			MusterilerListesiMetodu();
			comboBoxİlceAdi.ValueMember = "id";
			comboBoxİlceAdi.DisplayMember = "İlce";
			comboBoxİlceAdi.DataSource = db.ilceler.ToList();
			comboBoxİlceAdi.SelectedIndex = -1;
		}
		private void MusterilerListesiMetodu()
		{
			dataGridViewMusteriler.DataSource = musterimngr.SP_MUSTERİLER();
		}
		private void Temizle()
		{
			textBoxMusteriAdi.Clear();
			textBoxMusteriSoyadi.Clear();
			maskedTextBoxMusteriTelefon.Clear();
			textBoxMusteriAdres.Clear();
			checkBoxErkek.Checked = false;
			checkBoxKadin.Checked = false;
			dateTimePickerMusteriDogumTarihi.Checked = false;
			comboBoxİlceAdi.SelectedValue = -1;
		}

		private void toolStripButtonKaydet_Click(object sender, EventArgs e)
		{
			string musterikaydet = musterimngr.Kaydet(
				textBoxMusteriAdi.Text,
				textBoxMusteriSoyadi.Text,
				maskedTextBoxMusteriTelefon.Text,
				textBoxMusteriAdres.Text,
				checkBoxErkek.Checked==true ? "Erkek" : "Kadın",
				Convert.ToDateTime(dateTimePickerMusteriDogumTarihi.Text),
				(int)comboBoxİlceAdi.SelectedValue
				);
			MusterilerListesiMetodu();
			MessageBox.Show(musterikaydet);

		}
		int MusterID;
		private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
		{
			string musteriGuncelle = musterimngr.Guncelle(
				MusterID,
				textBoxMusteriAdi.Text,
				textBoxMusteriSoyadi.Text,
				maskedTextBoxMusteriTelefon.Text,
				textBoxMusteriAdres.Text,
				checkBoxErkek.Checked == true ? "Erkek" : "Kadın",
				Convert.ToDateTime(dateTimePickerMusteriDogumTarihi.Text),
				(int)comboBoxİlceAdi.SelectedValue
				);
			MusterilerListesiMetodu();
			MessageBox.Show(musteriGuncelle);

		}

		private void toolStripButtonSil_Click(object sender, EventArgs e)
		{
			string MusteriSil = musterimngr.Sil(MusterID);
			MusterilerListesiMetodu();
			MessageBox.Show(MusteriSil);
		}

		private void toolStripButtonTemizle_Click(object sender, EventArgs e)
		{
			Temizle();
		}

		private void dataGridViewMusteriler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				MusterID = (int)dataGridViewMusteriler.Rows[e.RowIndex].Cells["MusterilerID"].Value;
				textBoxMusteriAdi.Text = dataGridViewMusteriler.Rows[e.RowIndex].Cells["MusteriAdi"].Value.ToString();
				textBoxMusteriSoyadi.Text = dataGridViewMusteriler.Rows[e.RowIndex].Cells["MusteriSoyadi"].Value.ToString();
				maskedTextBoxMusteriTelefon.Text = dataGridViewMusteriler.Rows[e.RowIndex].Cells["MusteriTelefon"].Value.ToString();
				textBoxMusteriAdres.Text = dataGridViewMusteriler.Rows[e.RowIndex].Cells["MusteriAdres"].Value.ToString();
				checkBoxErkek.Text = dataGridViewMusteriler.Rows[e.RowIndex].Cells["MusteriCinsiyet"].Value.ToString();
				checkBoxKadin.Text = dataGridViewMusteriler.Rows[e.RowIndex].Cells["MusteriCinsiyet"].Value.ToString();
				dateTimePickerMusteriDogumTarihi.Text = dataGridViewMusteriler.Rows[e.RowIndex].Cells["MusteriDogumTarihi"].Value.ToString();
				comboBoxİlceAdi.Text = dataGridViewMusteriler.Rows[e.RowIndex].Cells["İlce"].Value.ToString();
			}
			catch (Exception ex)
			{

				MessageBox.Show("Sistemsel hata mesajı " + ex.Message);
			}
		}
	}
}
