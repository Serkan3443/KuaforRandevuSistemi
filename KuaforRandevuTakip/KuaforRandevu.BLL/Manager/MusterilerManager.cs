using KuaforRandevu.BLL.Interface;
using KuaforRandevu.DLL;
using KuaforRandevu.DLL.RepositoryFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuaforRandevu.BLL.Manager
{
	public class MusterilerManager : IMusteriler
	{
		KuaforRandevuDBEntities2 db = new KuaforRandevuDBEntities2();
		Repository<Musteriler> repository;
        public MusterilerManager()
        {
			db = new KuaforRandevuDBEntities2();
			repository = new Repository<Musteriler>(db);
        }

        public string Guncelle(int musterilerid, string Musteriadi, string musterisoyadi, string musteritelefon, string musteriadres, string mustericinsiyet, DateTime musteridogumtarihi, int ilceid)
		{
			try
			{
				var guncellencekveri = repository.BulQuery(m => m.MusterilerID == musterilerid).FirstOrDefault();
				if(guncellencekveri==null)
				{
					return "Güncellenecek müşteri bulunamadı";
				}
				else
				{
					guncellencekveri.MusteriAdi = Musteriadi;
					guncellencekveri.MusteriSoyadi = musterisoyadi;
					guncellencekveri.MusteriTelefon = musteritelefon;
					guncellencekveri.MusteriAdres = musteriadres;
					guncellencekveri.MusteriCinsiyet = mustericinsiyet;
					guncellencekveri.MusteriDogumTarihi = musteridogumtarihi;
					guncellencekveri.İlceID = ilceid;
					int sonuc = repository.Guncelle(guncellencekveri);
					if(sonuc>0)
					{
						return "Müşteri verisi güncellendi";
					}
					else
					{
						return "Müşteri güncellenemedi";
					}
				}
			}
			catch (Exception ex)
			{

				return "Sistemsel bir hata oluştu" + ex.Message;
			}
		}

		public string Kaydet(string Musteriadi, string musterisoyadi, string musteritelefon, string musteriadres, string mustericinsiyet, DateTime musteridogumtarihi, int ilceid)
		{
			try
			{
				var kaydedilecekveri = repository.BulQuery(m => m.MusteriAdi == Musteriadi).FirstOrDefault();
				if(kaydedilecekveri!=null)
				{
					return "Bu müteri randevuya daha önce kaydedilmiş";
				}
				else
				{
					Musteriler musteriler = new Musteriler();
					musteriler.MusteriAdi= Musteriadi;
					musteriler.MusteriSoyadi = musterisoyadi;
					musteriler.MusteriTelefon = musteritelefon;
					musteriler.MusteriAdres = musteriadres;
					musteriler.MusteriCinsiyet = mustericinsiyet;
					musteriler.MusteriDogumTarihi = musteridogumtarihi;
					musteriler.İlceID = ilceid;
					int sonuc = repository.Kaydet(musteriler);
					if(sonuc>0)
					{
						return "Müşteri kaydedildi";
					}
					else
					{
						return "Müşteri kaydedilemedi";
					}
				}
			}
			catch (Exception ex)
			{

				return "Sistemsel bir hata oluştu" + ex.Message;
			}
		}

		public string Sil(int musterilerid)
		{
			try
			{
				var silinecekveri = repository.BulQuery(m => m.MusterilerID == musterilerid).FirstOrDefault();
				if (silinecekveri == null)
				{
					return "Silinecek müşteri bulunamadı";
				}
				else
				{
					int sonuc = repository.Sil(silinecekveri);
					if (sonuc > 0)
					{
						return "Müşteri silindi";
					}
					else
					{
						return "Müşteri silinemedi";
					}
				}
			}
			catch (Exception ex)
			{

				return "Sistemsel bir hata oluştu" + ex.Message;
			}
		}

		

		public IEnumerable<sp_MUSTERİLER1_Result> SP_MUSTERİLER()
		{
			return db.sp_MUSTERİLER1().ToList();
		}
	}
}
