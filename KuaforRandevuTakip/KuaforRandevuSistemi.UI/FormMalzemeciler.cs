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
	public partial class FormMalzemeciler : Form
	{
		KuaforRandevuDBEntities2 db=new KuaforRandevuDBEntities2();
		MalzemecilerManager malzemecimngr=new MalzemecilerManager();

		public FormMalzemeciler()
		{
			InitializeComponent();
		}

		private void FormMalzemeciler_Load(object sender, EventArgs e)
		{
			MalzemecilerListesiMetodu();
			comboBoxUrunAdi.ValueMember = "AlinanUrunlerID";
			comboBoxUrunAdi.DisplayMember = "AlinanUrunAdi";
			comboBoxUrunAdi.DataSource = db.AlinanUrunler.ToList();
			comboBoxUrunAdi.SelectedIndex = -1;
		}
		private void MalzemecilerListesiMetodu()
		{
			dataGridViewMalzemeler.DataSource = malzemecimngr.sp_MalzemecilerListesi();
		}

		private void toolStripButtonKaydet_Click(object sender, EventArgs e)
		{
			string malzemecikaydet = malzemecimngr.Kaydet(
				(int)comboBoxUrunAdi.SelectedValue,
				textBoxMalzemeciAdi.Text,
				textBoxİsletmeTuru.Text,
				textBoxMalzemeciAdres.Text,
				maskedTextBoxMalzemeciTelefon.Text,
				textBoxMalzemeciEmail.Text,
				checkBoxEvet.Checked==true ? true:false);
			MalzemecilerListesiMetodu();
			MessageBox.Show(malzemecikaydet);
		}
		int MalzemecilerID;
		private void toolStripButtonTemizle_Click(object sender, EventArgs e)
		{
			Temizle();
		}

		private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
		{

			string malzemeciguncelle = malzemecimngr.Guncelle(
				MalzemecilerID,
				(int)comboBoxUrunAdi.SelectedValue,
				textBoxMalzemeciAdi.Text,
				textBoxİsletmeTuru.Text,
				textBoxMalzemeciAdres.Text,
				maskedTextBoxMalzemeciTelefon.Text,
				textBoxMalzemeciEmail.Text,
				checkBoxEvet.Checked == true ? true : false
				);
			MalzemecilerListesiMetodu();
			MessageBox.Show(malzemeciguncelle);
		}
		private void Temizle()
		{
			comboBoxUrunAdi.SelectedValue = -1;
			textBoxMalzemeciAdi.Clear();
			textBoxİsletmeTuru.Clear();
			textBoxMalzemeciAdres.Clear();
			maskedTextBoxMalzemeciTelefon.Clear();
			textBoxMalzemeciEmail.Clear();
			checkBoxEvet.Checked = false;
			checkBoxHayir.Checked = false;
		}

		private void toolStripButtonSil_Click(object sender, EventArgs e)
		{
			string malzemecisil = malzemecimngr.Sil(MalzemecilerID);
			MalzemecilerListesiMetodu();
			MessageBox.Show(malzemecisil);
		}

		private void dataGridViewMalzemeler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				MalzemecilerID = (int)dataGridViewMalzemeler.Rows[e.RowIndex].Cells["MalzemecilerID"].Value;
				comboBoxUrunAdi.Text = dataGridViewMalzemeler.Rows[e.RowIndex].Cells["AlinanUrunAdi"].Value.ToString();
				textBoxMalzemeciAdi.Text = dataGridViewMalzemeler.Rows[e.RowIndex].Cells["MalzemeciAdi"].Value.ToString();
				textBoxİsletmeTuru.Text = dataGridViewMalzemeler.Rows[e.RowIndex].Cells["IsletmeTuru"].Value.ToString();
				textBoxMalzemeciAdres.Text = dataGridViewMalzemeler.Rows[e.RowIndex].Cells["MalzemeciAdres"].Value.ToString();
				maskedTextBoxMalzemeciTelefon.Text = dataGridViewMalzemeler.Rows[e.RowIndex].Cells["MalzemeciTelefonNo"].Value.ToString();
				bool aktifmi = (bool)dataGridViewMalzemeler.Rows[e.RowIndex].Cells["MalzemeciAktifMi"].Value;
				if(aktifmi==true)
				{
					checkBoxEvet.Checked = true;
				}
				else
				{
					checkBoxHayir.Checked = true;
				}

			}
			catch (Exception ex)
			{

				MessageBox.Show("sistemsel bir hata oluştu" + ex.Message);
			}

		}
	}
}
