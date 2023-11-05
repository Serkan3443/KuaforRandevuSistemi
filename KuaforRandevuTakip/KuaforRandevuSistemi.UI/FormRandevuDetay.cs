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
	public partial class FormRandevuDetay : Form
	{

		RandevuDetayManager detayMngr=new RandevuDetayManager();
		KuaforRandevuDBEntities2 db = new KuaforRandevuDBEntities2();

		public FormRandevuDetay()
		{
			InitializeComponent();
		}
		private void FormRandevuDetay_Load(object sender, EventArgs e)
		{
			RandevuDetayListesiMetodu();
			comboBoxRandevuID.ValueMember = "RandevularID";
			comboBoxRandevuID.DisplayMember = "Randevuİslemi";
			comboBoxRandevuID.DataSource = db.Randevular.ToList();
			comboBoxRandevuID.SelectedIndex = -1;
		}
		private void RandevuDetayListesiMetodu()
		{
			dataGridViewRandevuDetay.DataSource = detayMngr.SP_RandevudetaylarListe();
		}

		private void toolStripButtonKaydet_Click(object sender, EventArgs e)
		{
			string detaykaydet = detayMngr.Kaydet(
				textBoxİslemDetayi.Text,
				radioButtonEvet.Checked == true ? true : false,
				Convert.ToDateTime(comboBoxRandevuSaatleri.Text),
				radioButtonEvetİptal.Checked==true ? true : false,
				textBoxİptalNedeni.Text
				);
			RandevuDetayListesiMetodu();
			MessageBox.Show(detaykaydet);
		}
		int RandevuID;
		private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
		{
			string detayguncelle = detayMngr.Guncelle(
				RandevuID,
				textBoxİslemDetayi.Text,
				radioButtonEvet.Checked == true ? true : false,
				Convert.ToDateTime(comboBoxRandevuSaatleri.Text),
				radioButtonEvetİptal.Checked == true ? true : false,
				textBoxİptalNedeni.Text
				);
			RandevuDetayListesiMetodu();
			MessageBox.Show(detayguncelle);

		}

		private void toolStripButtonSil_Click(object sender, EventArgs e)
		{
			string detaysil = detayMngr.Sil(RandevuID);
			RandevuDetayListesiMetodu();
			MessageBox.Show(detaysil);
		}

		private void toolStripButtonTemizle_Click(object sender, EventArgs e)
		{
			Temizle();
		}
		private void Temizle()
		{
			textBoxİslemDetayi.Clear();
			radioButtonEvet.Checked = false;
			comboBoxRandevuID.SelectedValue = -1;
			radioButtonEvetİptal.Checked= false;
			textBoxİptalNedeni.Clear();


		}

		private void dataGridViewRandevuDetay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{

				RandevuID = (int)dataGridViewRandevuDetay.Rows[e.RowIndex].Cells["RandevularId"].Value;
				textBoxİslemDetayi.Text = dataGridViewRandevuDetay.Rows[e.RowIndex].Cells["İslemDetay"].Value.ToString();
				bool aktifmi = (bool)dataGridViewRandevuDetay.Rows[e.RowIndex].Cells["RandevuAktifMi"].Value;
				if (aktifmi == true)
				{
					radioButtonEvet.Checked = false;
				}
				else
				{
					radioButtonEvet.Checked = false;
				}
				bool iptalMi = (bool)dataGridViewRandevuDetay.Rows[e.RowIndex].Cells["Randevuİptal"].Value;
				if (iptalMi == true)
				{
					radioButtonEvetİptal.Checked = false;

				}
				else
				{
					radioButtonHayirİptal.Checked = false;
				}
				textBoxİptalNedeni.Text = dataGridViewRandevuDetay.Rows[e.RowIndex].Cells["Aciklama"].Value.ToString();
			}
			catch (Exception ex)
			{

				MessageBox.Show("Sistemsel bir hata oluştu");
			}
		}
	}
}
