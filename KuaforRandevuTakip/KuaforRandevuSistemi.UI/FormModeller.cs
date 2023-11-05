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
	public partial class FormModeller : Form
	{
		ModellerManager modelMngr = new ModellerManager();
		KuaforRandevuDBEntities2 db=new KuaforRandevuDBEntities2();
		

		public FormModeller()
		{
			InitializeComponent();
		}
		
		private void FormModeller_Load(object sender, EventArgs e)
		{
			ModellerListesiMetodu();
			comboBoxCalisanAdSoyad.ValueMember = "CalisanlarId";
			comboBoxCalisanAdSoyad.DisplayMember = "CalisanAdSoyad";
			var calisanlistesi = (from c in db.Calisanlar
								  select new
								  {
									  CalisanlarId = c.CalisanlarId,
									  CalisanAdSoyad = c.CalisanAdi + " " + c.CalisanSoyadi
								  }
								).ToList();
			comboBoxCalisanAdSoyad.DataSource= calisanlistesi;
			comboBoxCalisanAdSoyad.SelectedIndex = -1;
		}
		private void ModellerListesiMetodu()
		{
			dataGridViewModeller.DataSource = modelMngr.sp_Modellerlistesi();
		}
		
		private void Temizle()
		{
			textBoxModelAdi.Clear();
			textBoxModelTipi.Clear();
			comboBoxCalisanAdSoyad.SelectedValue=-1;
			textBoxİslemSuresi.Clear();
			radioButtonEvet.Checked = false;
			radioButtonHayir.Checked = false;
			textBoxModelFiyati.Clear();
			textBoxMusteriYorumu.Clear();
			
		}

		private void toolStripButtonKaydet_Click(object sender, EventArgs e)
		{
			string modelkaydet = modelMngr.Kaydet(
				textBoxModelAdi.Text,
				textBoxModelTipi.Text,
				(int)comboBoxCalisanAdSoyad.SelectedValue,
				Convert.ToDecimal(textBoxİslemSuresi.Text),
				radioButtonEvet.Checked = true ? true : false,
				Convert.ToDecimal(textBoxModelFiyati.Text),
				textBoxMusteriYorumu.Text);
			ModellerListesiMetodu();
			MessageBox.Show(modelkaydet);
		}
		int ModelID;
		private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
		{
			string modelguncelle = modelMngr.Guncelle(
				ModelID,
				textBoxModelAdi.Text,
				textBoxModelTipi.Text,
				(int)comboBoxCalisanAdSoyad.SelectedValue,
				Convert.ToDecimal(textBoxİslemSuresi.Text),
				radioButtonEvet.Checked = true ? true : false,
				Convert.ToDecimal(textBoxModelFiyati.Text),
				textBoxMusteriYorumu.Text
				);
			
			ModellerListesiMetodu();
			MessageBox.Show(modelguncelle);
		}

		private void toolStripButtonSil_Click(object sender, EventArgs e)
		{
			string modelsil = modelMngr.Sil(ModelID);
			ModellerListesiMetodu();
			MessageBox.Show(modelsil);
		}
		
		
		private void toolStripButtonTemizle_Click(object sender, EventArgs e)
		{
			Temizle();
		}

		private void dataGridViewModeller_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{

				ModelID = (int)dataGridViewModeller.Rows[e.RowIndex].Cells["ModellerID"].Value;
				textBoxModelAdi.Text = dataGridViewModeller.Rows[e.RowIndex].Cells["ModelAdi"].Value.ToString();
				textBoxModelTipi.Text = dataGridViewModeller.Rows[e.RowIndex].Cells["ModelTipi"].Value.ToString();
				comboBoxCalisanAdSoyad.Text = dataGridViewModeller.Rows[e.RowIndex].Cells["CalisanID"].Value.ToString();
				textBoxİslemSuresi.Text = dataGridViewModeller.Rows[e.RowIndex].Cells["ModelYapilisSuresi"].Value.ToString();
				bool musteribegendimi = (bool)dataGridViewModeller.Rows[e.RowIndex].Cells["MusteriBegendiMi"].Value;
				if (musteribegendimi == true)
				{
					radioButtonEvet.Checked = true;
				}
				else
				{
					radioButtonHayir.Checked = true;
				}
				textBoxMusteriYorumu.Text = dataGridViewModeller.Rows[e.RowIndex].Cells["Aciklama"].Value.ToString();
			}
			catch (Exception ex)
			{

				MessageBox.Show("Sistemsel bir hata oluştu" + ex.Message);
			}
		}
		public bool frmModelVarmi = true;
		private void FormModeller_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmModelVarmi = false;
		}

		private void toolStripResimEkle_Click(object sender, EventArgs e)
		{
			DialogResult mesaj = new DialogResult();
			var devam = MessageBox.Show("Uyarı resim eklensin mi", "Uyarı mesajı ",MessageBoxButtons.OKCancel);
			if(devam == DialogResult.OK && !string.IsNullOrWhiteSpace(textBoxModelAdi.Text))
			{

						FormResimler frmresim = new FormResimler();
				        frmresim.ModelID = ModelID;
						frmresim.ShowDialog();
			}
			else
			{
				MessageBox.Show("Model Adını boş giremezsiniz");
			}
			
		}
	}
}
