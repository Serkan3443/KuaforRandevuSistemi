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
namespace KuaforRandevuSistemi.UI
{
	public partial class FormResimler : Form
	{
		public FormResimler()
		{
			InitializeComponent();
		}

		string resim1, resim2, resim3, resim4, resim5, resim6, resim7, resim8, resim9, resim10, resim11, resim12, resim13, resim14, resim15;

		
		public int ModelID;
		private void FormResimler_Load(object sender, EventArgs e)
		{
			
		}
		ResimlerManager resimManager = new ResimlerManager();

		private void toolStripButtonKaydet_Click(object sender, EventArgs e)
		{
			if(!string.IsNullOrWhiteSpace(resim1))
			{
				bool aktiflik = radioButtonSec1.Checked == true ? true : false;
				string kaydet = resimManager.ResimKaydet("Resim-1", resim1, DateTime.Now, ModelID, aktiflik, "");
				labelResim1.Text += "Durum: " + kaydet;
				
			}
			if (!string.IsNullOrWhiteSpace(resim2))
			{
				bool aktiflik = radioButton2.Checked == true ? true : false;
				string kaydet = resimManager.ResimKaydet("Resim-1", resim2, DateTime.Now, ModelID, aktiflik, "");
				labelResim2.Text += "Durum: " + kaydet;

			}
			if (!string.IsNullOrWhiteSpace(resim3))
			{
				bool aktiflik = radioButton3.Checked == true ? true : false;
				string kaydet = resimManager.ResimKaydet("Resim-1", resim3, DateTime.Now, ModelID, aktiflik, "");
				labelResim3.Text += "Durum: " + kaydet;

			}
			if (!string.IsNullOrWhiteSpace(resim4))
			{
				bool aktiflik = radioButton4.Checked == true ? true : false;
				string kaydet = resimManager.ResimKaydet("Resim-1", resim4, DateTime.Now, ModelID, aktiflik, "");
				labelResim4.Text += "Durum: " + kaydet;

			}
			if (!string.IsNullOrWhiteSpace(resim5))
			{
				bool aktiflik = radioButton5.Checked == true ? true : false;
				string kaydet = resimManager.ResimKaydet("Resim-1", resim5, DateTime.Now, ModelID, aktiflik, "");
				labelResim5.Text += "Durum: " + kaydet;

			}
			if (!string.IsNullOrWhiteSpace(resim6))
			{
				bool aktiflik = radioButton6.Checked == true ? true : false;
				string kaydet = resimManager.ResimKaydet("Resim-1", resim6, DateTime.Now, ModelID, aktiflik, "");
				labelResim6.Text += "Durum: " + kaydet;

			}
			if (!string.IsNullOrWhiteSpace(resim7))
			{
				bool aktiflik = radioButton7.Checked == true ? true : false;
				string kaydet = resimManager.ResimKaydet("Resim-1", resim7, DateTime.Now, ModelID, aktiflik, "");
				labelResim7.Text += "Durum: " + kaydet;

			}
			if (!string.IsNullOrWhiteSpace(resim8))
			{
				bool aktiflik = radioButton8.Checked == true ? true : false;
				string kaydet = resimManager.ResimKaydet("Resim-1", resim8, DateTime.Now, ModelID, aktiflik, "");
				labelResim8.Text += "Durum: " + kaydet;

			}
			if (!string.IsNullOrWhiteSpace(resim9))
			{
				bool aktiflik = radioButton9.Checked == true ? true : false;
				string kaydet = resimManager.ResimKaydet("Resim-1", resim9, DateTime.Now, ModelID, aktiflik, "");
				labelResim9.Text += "Durum: " + kaydet;

			}
			if (!string.IsNullOrWhiteSpace(resim10))
			{
				bool aktiflik = radioButton10.Checked == true ? true : false;
				string kaydet = resimManager.ResimKaydet("Resim-1", resim10, DateTime.Now, ModelID, aktiflik, "");
				labelResim10.Text += "Durum: " + kaydet;

			}
			if (!string.IsNullOrWhiteSpace(resim11))
			{
				bool aktiflik = radioButton11.Checked == true ? true : false;
				string kaydet = resimManager.ResimKaydet("Resim-1", resim11, DateTime.Now, ModelID, aktiflik, "");
				labelResim11.Text += "Durum: " + kaydet;

			}
			if (!string.IsNullOrWhiteSpace(resim12))
			{
				bool aktiflik = radioButton12.Checked == true ? true : false;
				string kaydet = resimManager.ResimKaydet("Resim-1", resim12, DateTime.Now, ModelID, aktiflik, "");
				labelResim12.Text += "Durum: " + kaydet;

			}
			if (!string.IsNullOrWhiteSpace(resim13))
			{
				bool aktiflik = radioButton13.Checked == true ? true : false;
				string kaydet = resimManager.ResimKaydet("Resim-1", resim13, DateTime.Now, ModelID, aktiflik, "");
				labelResim13.Text += "Durum: " + kaydet;

			}
			if (!string.IsNullOrWhiteSpace(resim14))
			{
				bool aktiflik = radioButton14.Checked == true ? true : false;
				string kaydet = resimManager.ResimKaydet("Resim-1", resim14, DateTime.Now, ModelID, aktiflik, "");
				labelResim14.Text += "Durum: " + kaydet;

			}
			if (!string.IsNullOrWhiteSpace(resim15))
			{
				bool aktiflik = radioButton15.Checked == true ? true : false;
				string kaydet = resimManager.ResimKaydet("Resim-1", resim15, DateTime.Now, ModelID, aktiflik, "");
				labelResim15.Text += "Durum: " + kaydet;

			}
		}
		string ResimSec(PictureBox pictureBox)
		{
			OpenFileDialog dosyaac = new OpenFileDialog();
			dosyaac.Filter = "Resim doyası  |*.jpg;*.png;*.jpeg;*.nef;*.gif";
			dosyaac.ShowDialog();
			string alinanresimyolu = dosyaac.FileName;
			pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox.ImageLocation = alinanresimyolu;
			return alinanresimyolu;
		}
		private void linkLabelResim10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			resim10 = ResimSec(pictureBox10);
		}

		string resimyolu;
		private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
		{	
			if(radioButtonSec1.Checked)
			{
				if(!string.IsNullOrEmpty(resim1))
				{
					pictureBox1.Image=Image.FromFile(resim1);
					labelResim1.Text = "Resim Güncellendi";
				}
			}
			if (radioButton2.Checked)
			{
				if (!string.IsNullOrEmpty(resim2))
				{
					pictureBox2.Image = Image.FromFile(resim2);
					labelResim2.Text = "Resim Güncellendi";
				}
			}
			if (radioButton3.Checked)
			{
				if (!string.IsNullOrEmpty(resim3))
				{
					pictureBox3.Image = Image.FromFile(resim3);
					labelResim3.Text = "Resim Güncellendi";
				}
			}
			if (radioButton4.Checked)
			{
				if (!string.IsNullOrEmpty(resim4))
				{
					pictureBox4.Image = Image.FromFile(resim4);
					labelResim4.Text = "Resim Güncellendi";
				}
			}
			if (radioButton5.Checked)
			{
				if (!string.IsNullOrEmpty(resim5))
				{
					pictureBox5.Image = Image.FromFile(resim5);
					labelResim5.Text = "Resim Güncellendi";
				}
			}
			if (radioButton6.Checked)
			{
				if (!string.IsNullOrEmpty(resim6))
				{
					pictureBox6.Image = Image.FromFile(resim6);
					labelResim6.Text = "Resim Güncellendi";
				}
			}
			if (radioButton7.Checked)
			{
				if (!string.IsNullOrEmpty(resim7))
				{
					pictureBox7.Image = Image.FromFile(resim7);
					labelResim7.Text = "Resim Güncellendi";
				}
			}
			if (radioButton8.Checked)
			{
				if (!string.IsNullOrEmpty(resim8))
				{
					pictureBox8.Image = Image.FromFile(resim8);
					labelResim8.Text = "Resim Güncellendi";
				}
			}
			if (radioButton9.Checked)
			{
				if (!string.IsNullOrEmpty(resim9))
				{
					pictureBox9.Image = Image.FromFile(resim9);
					labelResim9.Text = "Resim Güncellendi";
				}
			}
			if (radioButton10.Checked)
			{
				if (!string.IsNullOrEmpty(resim10))
				{
					pictureBox10.Image = Image.FromFile(resim10);
					labelResim10.Text = "Resim Güncellendi";
				}
			}
			if (radioButton11.Checked)
			{
				if (!string.IsNullOrEmpty(resim11))
				{
					pictureBox11.Image = Image.FromFile(resim11);
					labelResim11.Text = "Resim Güncellendi";
				}
			}
			if (radioButton12.Checked)
			{
				if (!string.IsNullOrEmpty(resim12))
				{
					pictureBox12.Image = Image.FromFile(resim12);
					labelResim12.Text = "Resim Güncellendi";
				}
			}
			if (radioButton13.Checked)
			{
				if (!string.IsNullOrEmpty(resim13))
				{
					pictureBox13.Image = Image.FromFile(resim13);
					labelResim13.Text = "Resim Güncellendi";
				}
			}
			if (radioButton14.Checked)
			{
				if (!string.IsNullOrEmpty(resim14))
				{
					pictureBox14.Image = Image.FromFile(resim14);
					labelResim14.Text = "Resim Güncellendi";
				}
			}
			if (radioButton15.Checked)
			{
				if (!string.IsNullOrEmpty(resim15))
				{
					pictureBox15.Image = Image.FromFile(resim15);
					labelResim15.Text = "Resim Güncellendi";
				}
			}

		}

		private void toolStripButtonSil_Click(object sender, EventArgs e)
		{
			if(radioButtonSec1.Checked)
			{
				if(!string.IsNullOrEmpty(resim1))
				{
					pictureBox1.Image = null;
					labelResim1.Text = "Resim Silindi";
				}
			}
			if (radioButton2.Checked)
			{
				if (!string.IsNullOrEmpty(resim2))
				{
					pictureBox2.Image = null;
					labelResim2.Text = "Resim Silindi";
				}
			}
			if (radioButton3.Checked)
			{
				if (!string.IsNullOrEmpty(resim3))
				{
					pictureBox3.Image = null;
					labelResim3.Text = "Resim Silindi";
				}
			}
			if (radioButton4.Checked)
			{
				if (!string.IsNullOrEmpty(resim4))
				{
					pictureBox4.Image = null;
					labelResim4.Text = "Resim Silindi";
				}
			}
			if (radioButton5.Checked)
			{
				if (!string.IsNullOrEmpty(resim5))
				{
					pictureBox5.Image = null;
					labelResim5.Text = "Resim Silindi";
				}
			}
			if (radioButton6.Checked)
			{
				if (!string.IsNullOrEmpty(resim6))
				{
					pictureBox6.Image = null;
					labelResim6.Text = "Resim Silindi";
				}
			}
			if (radioButton7.Checked)
			{
				if (!string.IsNullOrEmpty(resim7))
				{
					pictureBox7.Image = null;
					labelResim7.Text = "Resim Silindi";
				}
			}
			if (radioButton8.Checked)
			{
				if (!string.IsNullOrEmpty(resim8))
				{
					pictureBox8.Image = null;
					labelResim8.Text = "Resim Silindi";
				}
			}
			if (radioButton9.Checked)
			{
				if (!string.IsNullOrEmpty(resim9))
				{
					pictureBox9.Image = null;
					labelResim9.Text = "Resim Silindi";
				}
			}
			if (radioButton10.Checked)
			{
				if (!string.IsNullOrEmpty(resim10))
				{
					pictureBox10.Image = null;
					labelResim10.Text = "Resim Silindi";
				}
			}
			if (radioButton11.Checked)
			{
				if (!string.IsNullOrEmpty(resim11))
				{
					pictureBox11.Image = null;
					labelResim11.Text = "Resim Silindi";
				}
			}
			if (radioButton12.Checked)
			{
				if (!string.IsNullOrEmpty(resim12))
				{
					pictureBox12.Image = null;
					labelResim12.Text = "Resim Silindi";
				}
			}
			if (radioButton13.Checked)
			{
				if (!string.IsNullOrEmpty(resim13))
				{
					pictureBox13.Image = null;
					labelResim13.Text = "Resim Silindi";
				}
			}
			if (radioButton14.Checked)
			{
				if (!string.IsNullOrEmpty(resim14))
				{
					pictureBox14.Image = null;
					labelResim14.Text = "Resim Silindi";
				}
			}
			if (radioButton15.Checked)
			{
				if (!string.IsNullOrEmpty(resim15))
				{
					pictureBox15.Image = null;
					labelResim15.Text = "Resim Silindi";
				}
			}
		}

		private void linkLabelResim11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			resim11 = ResimSec(pictureBox11);
		}

		private void linkLabelResim12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			resim12 = ResimSec(pictureBox12);
		}

		private void linkLabelResim13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			resim13 = ResimSec(pictureBox13);
		}

		private void linkLabelResim14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			resim14 = ResimSec(pictureBox14);
		}

		private void linkLabelResim15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			resim15 = ResimSec(pictureBox15);
		}

		private void linkLabelResim9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			resim9 = ResimSec(pictureBox9);
		}

		private void linkLabelResim8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			resim8 = ResimSec(pictureBox8);
		}

		private void linkLabelResim7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			resim7 = ResimSec(pictureBox7);
		}

		private void linkLabelResim6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			resim6 = ResimSec(pictureBox6);
		}

		private void linkLabelResim5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			resim5 = ResimSec(pictureBox5);
		}

		private void linkLabelResim4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			resim4 = ResimSec(pictureBox4);
		}

		private void linkLabelResim3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			resim3 = ResimSec(pictureBox3);
		}

		private void linkLabelResim2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			resim2 = ResimSec(pictureBox2);
		}

		private void linkLabelResim1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			resim1 = ResimSec(pictureBox1);
		}


	}
}
