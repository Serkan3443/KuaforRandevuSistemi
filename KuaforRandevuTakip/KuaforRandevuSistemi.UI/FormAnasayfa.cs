using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KuaforRandevuSistemi;

namespace KuaforRandevuSistemi.UI
{
	public partial class FormAnasayfa : Form
	{
		public FormAnasayfa()
		{
			InitializeComponent();
		}
		public FormModeller formModeller;

		FormHizmetler frmhizmetler;
		private void hizmetlerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmhizmetler = new FormHizmetler();
			frmhizmetler.MdiParent = this;
			frmhizmetler.Show();
		}

		FormFiyatlar frmfiyat;
		private void fiyatlarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmfiyat = new FormFiyatlar();
			frmfiyat.MdiParent = this;
			frmfiyat.Show();
		}

		

		FormBakimlar frmbakimlar;
		private void bakimlarToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			frmbakimlar=new FormBakimlar();
			frmbakimlar.MdiParent = this;
			frmbakimlar.Show();
		}
		private void NewFormShow(Form form)
		{
			if(form==null)
			{
				form=new Form();
				form.MdiParent = this;
				form.Show();
			}
		}

		
		private void ModellerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(formModeller==null)
			{
				formModeller=new FormModeller();
				formModeller.MdiParent = this;
				formModeller.Show();
			}
			else if(formModeller.frmModelVarmi==false)
			{
				formModeller=new FormModeller();
				formModeller.MdiParent = this;
				formModeller.Show();
			}
		}

		FormAlinanUrunler formalinanurunler;
		private void AlinanUrunlerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			formalinanurunler=new FormAlinanUrunler();
			formalinanurunler.MdiParent = this;
			formalinanurunler.Show();

		}

		FormKullanicilar frmkullanicilar;
		private void kullanıcılarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmkullanicilar = new FormKullanicilar();
			frmkullanicilar.MdiParent = this;
			frmkullanicilar.Show();
		}

		FormCalisanlar formCalisanlar;
		private void CalisanlarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			formCalisanlar = new FormCalisanlar();
			formCalisanlar=new FormCalisanlar();
			formCalisanlar.Show();
		}


		FormMusteriler formmusteriler;
		private void MusterilerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			formmusteriler=new FormMusteriler();
			formmusteriler.MdiParent= this;
			formmusteriler.Show();
		}

		FormRandevuDetay formRandevuDetay;
		private void randevuDetaylarıToolStripMenuItem_Click(object sender, EventArgs e)
		{
			formRandevuDetay = new FormRandevuDetay();	
			formRandevuDetay.MdiParent= this;
			formRandevuDetay.Show();
		}

		FormRandevular formrandevular;
		private void randevularToolStripMenuItem_Click(object sender, EventArgs e)
		{
			formrandevular=new FormRandevular();
			formrandevular.MdiParent = this;
			formrandevular.Show();
		}

		

		FormAdresler frmadres;
		private void adreslerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmadres = new FormAdresler();
			frmadres.MdiParent = this;
			frmadres.Show();
		}
		FormMalzemeciler formMalzemeciler;
		private void malzemecilerToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			formMalzemeciler = new FormMalzemeciler();
			formMalzemeciler.MdiParent = this;
			formMalzemeciler.Show();
		}

		private void FormAnasayfa_Load(object sender, EventArgs e)
		{
			this.IsMdiContainer = true;
		}

		FormMalzemeFisleri frmmalzemefisleri;
		private void malzemeFisleriToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmmalzemefisleri = new FormMalzemeFisleri();
			frmmalzemefisleri.MdiParent = this;
			frmmalzemefisleri.Show();
		}
		FormKuaforler frmkuafor;
		private void kuaforlerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmkuafor=new FormKuaforler();
			frmkuafor.MdiParent = this;
			frmkuafor.Show();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			DialogResult cikisyap = new DialogResult();
			cikisyap = MessageBox.Show("Sayfadan Çıkış yapmak istiyor musunuz?", "ÇIKIŞ ONAYI",MessageBoxButtons.YesNo);
			if(cikisyap == DialogResult.Yes)
			{
				FormGiris formgiris=new FormGiris();
				this.Hide();
				formgiris.Show();
			}

		}
	}
}
