using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KuaforRandevu.BLL.Interface;
using KuaforRandevu.DLL;
using KuaforRandevu.DLL.RepositoryFolder;

namespace KuaforRandevu.BLL.Manager
{
	public class ResimlerManager : IResimler
	{
		KuaforRandevuDBEntities2 db=new KuaforRandevuDBEntities2 ();
		Repository<Resimler> repository;
        public ResimlerManager()
        {
			db = new KuaforRandevuDBEntities2();
			repository = new Repository<Resimler>(db);
        }

        public string ResimGuncelle(int resimlerid, string resimadi, string resimyolu, DateTime eklenmetarihi, int modelid, bool aktifmi,string aciklama)
		{
			try
			{
				var guncellenecekveri = repository.BulQuery(r => r.ResimlerID == resimlerid).FirstOrDefault();
				if(guncellenecekveri==null)
				{
					return "Güncellencek resim bulunamadı";
				}
				else
				{
					guncellenecekveri.ResimAdi = resimadi;
					guncellenecekveri.ResimYolu = resimyolu;
					guncellenecekveri.EklenmeTarihi = eklenmetarihi;
					guncellenecekveri.ModelID = modelid;
					guncellenecekveri.AktifMi = Convert.ToInt32(aktifmi);
					guncellenecekveri.Aciklama = aciklama;
					int sonuc = repository.Guncelle(guncellenecekveri);
					if(sonuc>0)
					{
						return "Resim güncellendi";
					}
					else
					{
						return "Resim güncellenemedi";
					}
				}
			}
			catch (Exception ex)
			{

				return "Sistemsel bir hata oluştu" + ex.Message;
			}
		}
		public string ResimKaydet(string resimadi, string resimyolu, DateTime eklenmetarihi, int modelid, bool aktifmi,string aciklama)
		{
			try
			{
					Resimler resim = new Resimler();
					resim.ResimAdi= resimadi;
					resim.ResimYolu = resimyolu;
					resim.EklenmeTarihi= eklenmetarihi;
					resim.ModelID = modelid;
					resim.AktifMi = Convert.ToInt32(aktifmi);
					resim.Aciklama = aciklama;
					int sonuc = repository.Kaydet(resim);
					if(sonuc>0)
					{
						return "Resim kaydedildi";
					}
					else
					{
						return "Resim kaydedilemedi";
					}
				
			}
			catch (Exception ex)
			{

				return "Resim eklenirken bir hata oluştu" + ex.Message;
			}
		}

		public string ResimSil(int resimlerid, bool aktifmi)
		{
			try
			{

				var silinecekveri = repository.BulQuery(r => r.ResimlerID == resimlerid).FirstOrDefault();
				if (silinecekveri == null)
				{
					return "Silinecek resim bulunamadı";
				}
				else
				{
					int sonuc = repository.Sil(silinecekveri);
					if (sonuc > 0)
					{
						return "Resim silindi";
					}
					else
					{
						return "Resim silinemedi";
					}
				}
			}
			catch (Exception ex)
			{

				return "Sistemsel bir hata oluştu" + ex.Message;
			}
		}
	}
}
