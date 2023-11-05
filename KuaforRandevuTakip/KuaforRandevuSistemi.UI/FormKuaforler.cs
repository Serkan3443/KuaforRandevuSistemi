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
	public partial class FormKuaforler : Form
	{
		KuaforlerManager kuaformngr=new KuaforlerManager();
		KuaforRandevuDBEntities2 db = new KuaforRandevuDBEntities2();

		public FormKuaforler()
		{
			InitializeComponent();
		}

		private void FormKuaforler_Load(object sender, EventArgs e)
		{
			KuaforListeMetodu();
			comboBoxKuaforilceid.ValueMember = "id";
			comboBoxKuaforilceid.DisplayMember = "İlce";
			comboBoxKuaforilceid.DataSource = db.ilceler.ToList();
			comboBoxKuaforilceid.SelectedIndex = -1;
		}
		private void KuaforListeMetodu()
		{
			dataGridViewKuaforler.DataSource = kuaformngr.sp_KuaforListesi();
		}
		private void Temizle()
		{
			textBoxKuaforAdi.Clear();
			maskedTextBoxKuaforTelefon.Clear();
			textBoxKuaforAdres.Clear();
			comboBoxKuaforilceid.SelectedValue = -1;
		}

		private void toolStripButtonKaydet_Click(object sender, EventArgs e)
		{
			string kuaforkaydet = kuaformngr.Kaydet(
				textBoxKuaforAdi.Text,
				maskedTextBoxKuaforTelefon.Text,
				textBoxKuaforAdres.Text,
				(int)comboBoxKuaforilceid.SelectedValue);
			KuaforListeMetodu();
			MessageBox.Show(kuaforkaydet);
		}

		private void toolStripButtonTemizle_Click(object sender, EventArgs e)
		{
			Temizle();
		}
		int kuaforID;
		private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
		{
			string kuaforguncelle = kuaformngr.Guncelle(
				kuaforID,
				textBoxKuaforAdi.Text,
				maskedTextBoxKuaforTelefon.Text,
				textBoxKuaforAdres.Text,
				(int)comboBoxKuaforilceid.SelectedValue
				);
			KuaforListeMetodu();
			MessageBox.Show(kuaforguncelle);
		}

		private void toolStripButtonSil_Click(object sender, EventArgs e)
		{
			string kuaforsil = kuaformngr.Sil(kuaforID);
			KuaforListeMetodu();
			MessageBox.Show(kuaforsil);
		}

		private void dataGridViewKuaforler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				kuaforID = (int)dataGridViewKuaforler.Rows[e.RowIndex].Cells["KuaforlerID"].Value;
				textBoxKuaforAdi.Text = dataGridViewKuaforler.Rows[e.RowIndex].Cells["KuaforAdi"].Value.ToString();
				maskedTextBoxKuaforTelefon.Text = dataGridViewKuaforler.Rows[e.RowIndex].Cells["KuaforTelefon"].Value.ToString();
				textBoxKuaforAdres.Text = dataGridViewKuaforler.Rows[e.RowIndex].Cells["KuaforAdres"].Value.ToString();
				comboBoxKuaforilceid.Text = dataGridViewKuaforler.Rows[e.RowIndex].Cells["İlce"].Value.ToString();
			}
			catch (Exception ex)
			{

				MessageBox.Show("Hata" + ex.Message);
			}
		}
	}
}
