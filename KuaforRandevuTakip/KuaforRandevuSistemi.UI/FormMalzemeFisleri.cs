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
	public partial class FormMalzemeFisleri : Form
	{
		KuaforRandevuDBEntities2 db=new KuaforRandevuDBEntities2();
		MalzemeFisleriManager malzemefisMngr=new MalzemeFisleriManager();

		public FormMalzemeFisleri()
		{
			InitializeComponent();
			comboBoxKuaforAdi.ValueMember = "KuaforlerID";
			comboBoxKuaforAdi.DisplayMember = "KuaforAdi";
			comboBoxKuaforAdi.DataSource = db.Kuaforler.ToList();
			comboBoxKuaforAdi.SelectedIndex = -1;

			comboBoxUrunAdi.ValueMember = "AlinanUrunlerID";
			comboBoxUrunAdi.DisplayMember = "AlinanUrunAdi";
			comboBoxUrunAdi.DataSource=db.AlinanUrunler.ToList();
			comboBoxUrunAdi.SelectedIndex = -1;

			comboBoxMalzemeAdi.ValueMember = "MalzemecilerID";
			comboBoxMalzemeAdi.DisplayMember = "MalzemeciAdi";
			comboBoxMalzemeAdi.DataSource=db.Malzemeciler.ToList();


		}
		int FisID;
		private void FormMalzemeFisleri_Load(object sender, EventArgs e)
		{
			MalzemefisleriMetodu();

		}
		private void MalzemefisleriMetodu()
		{
			dataGridViewMalzemeFisleri.DataSource = malzemefisMngr.sp_MalzemeFisleriListesi();
		}

		private void toolStripButtonKaydet_Click(object sender, EventArgs e)
		{
			string fiskaydet = malzemefisMngr.Kaydet(
				(int)comboBoxKuaforAdi.SelectedValue,
				(int)comboBoxUrunAdi.SelectedValue,
				(int)comboBoxMalzemeAdi.SelectedValue,
				Convert.ToDecimal(textBoxFisTutari.Text),
				Convert.ToDateTime(dateTimePickerFisKesimTarihi.Text),
				textBoxFisKesimAdresi.Text);
			MalzemefisleriMetodu();
			MessageBox.Show(fiskaydet);
		}

		private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
		{
			string fisguncelle = malzemefisMngr.Guncelle(
				FisID,
				(int)comboBoxKuaforAdi.SelectedValue,
				(int)comboBoxUrunAdi.SelectedValue,
				(int)comboBoxMalzemeAdi.SelectedValue,
				Convert.ToDecimal(textBoxFisTutari.Text),
				Convert.ToDateTime(dateTimePickerFisKesimTarihi.Text),
				textBoxFisKesimAdresi.Text
				);
			MalzemefisleriMetodu();
			MessageBox.Show(fisguncelle);
		}

		private void toolStripButtonSil_Click(object sender, EventArgs e)
		{
			string fissil = malzemefisMngr.Sil(FisID);
			MalzemefisleriMetodu();
			MessageBox.Show(fissil);
		}
		private void Temizle()
		{
			comboBoxKuaforAdi.SelectedValue = -1;
			comboBoxMalzemeAdi.SelectedValue = -1;
			comboBoxUrunAdi.SelectedValue = -1;
			textBoxFisTutari.Clear();
			textBoxFisKesimAdresi.Clear();
			dateTimePickerFisKesimTarihi.Checked = false;
		}

		private void toolStripButtonTemizle_Click(object sender, EventArgs e)
		{
			Temizle();
		}

		private void dataGridViewMalzemeFisleri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				FisID = (int)dataGridViewMalzemeFisleri.Rows[e.RowIndex].Cells["FislerID"].Value;
				comboBoxKuaforAdi.Text = dataGridViewMalzemeFisleri.Rows[e.RowIndex].Cells["KuaforAdi"].Value.ToString();
				comboBoxMalzemeAdi.Text = dataGridViewMalzemeFisleri.Rows[e.RowIndex].Cells["MalzemeciAdi"].Value.ToString();
				comboBoxUrunAdi.Text = dataGridViewMalzemeFisleri.Rows[e.RowIndex].Cells["AlinanUrunAdi"].Value.ToString();
				textBoxFisTutari.Text = dataGridViewMalzemeFisleri.Rows[e.RowIndex].Cells["FisTutari"].Value.ToString();
				textBoxFisKesimAdresi.Text = dataGridViewMalzemeFisleri.Rows[e.RowIndex].Cells["FisKesimAdresi"].Value.ToString();
				dateTimePickerFisKesimTarihi.Text = dataGridViewMalzemeFisleri.Rows[e.RowIndex].Cells["FisKesimTarihi"].Value.ToString();
			}
			catch (Exception ex)
			{

				MessageBox.Show("SİSTEMSEL BİR HATA OLUŞTU\nHATA:" + ex.Message);
			}
		}
	}
}
