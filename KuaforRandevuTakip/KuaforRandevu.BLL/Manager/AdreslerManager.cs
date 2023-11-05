using KuaforRandevu.BLL.Interface;
using KuaforRandevu.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KuaforRandevu.DLL;
using KuaforRandevu.DLL.RepositoryFolder;

namespace KuaforRandevu.BLL.Manager
{
	public class AdreslerManager : IAdresler
	{
		KuaforRandevuDBEntities2 db;
		Repository<Adresler> repository;
        public AdreslerManager()
        {
			db = new KuaforRandevuDBEntities2();
			repository = new Repository<Adresler>(db);
        }

        public IEnumerable<Adresler> AdresListele()
		{
			return repository.Listele();
		}

		public Adresler Bul(int adresid)
		{
			throw new NotImplementedException();
		}

		public string Guncelle(int adreslerid, string adresbasligi, int musteriid, int ilceid, string adres)
		{
			try
			{
				var guncellenecekVeri = repository.BulQuery(a => a.AdreslerId == adreslerid).FirstOrDefault();
				if(guncellenecekVeri == null)
				{
					return "Adres bulunamadı";
				}
				else
				{
					guncellenecekVeri.AdresBasligi = adresbasligi;
					guncellenecekVeri.MusteriID = musteriid;
					guncellenecekVeri.İlceID = ilceid;
					guncellenecekVeri.Adres = adres;

					int sonuc=repository.Guncelle(guncellenecekVeri);
					if(sonuc>0)
					{
						return "Adres güncellendi";
					}
					else
					{
						return "Adres güncellem Başarısız!!!!!";
					}

				}
			}
			catch (Exception ex)
			{

				return "SİSTEMSEL BİR  HATA OLUŞTU\n HATA:" + ex.Message;
			}
		}

		public string Kaydet(string adresbasligi, int musteriid, int ilceid, string adres)
		{
			db = new KuaforRandevuDBEntities2();
			repository = new Repository<Adresler>(db);
			try
			{
				var KayitedilecekVeri = repository.BulQuery(a => a.AdresBasligi == adresbasligi).FirstOrDefault();
				if(KayitedilecekVeri!=null)
				{
					return "Ayni veri daha önce kayıt edilmiş zaten";
				}
				else
				{
					Adresler adresler = new Adresler();
					adresler.AdresBasligi = adresbasligi;
					adresler.MusteriID = musteriid;
					adresler.İlceID = ilceid;
					adresler.Adres = adres;
					int sonuc = repository.Kaydet(adresler);
					if(sonuc>0)
					{
						return "Adres Kaydedildi";
					}
					else
					{
						return "Adres kayıt aşamasında hata oluştu!!!";
					}

				}
			}
			catch (Exception ex)
			{

				return "SİSTEMSEL BİR HATA OLUŞTU\nHATA " + ex.Message;
			}
			
		}

		public string Sil(int adreslerid)
		{
			KuaforRandevuDBEntities2 db = new KuaforRandevuDBEntities2();
			try
			{
				var SilinecekVeri = repository.BulQuery(a => a.AdreslerId == adreslerid).FirstOrDefault();
				if(SilinecekVeri==null)
				{
					return "Silinecek veri bulunamadı";
				}
				else
				{
					int sonuc = repository.Sil(SilinecekVeri);
					 
					if(sonuc>0)
					{
						return "Adres Silindi";
					}
					else
					{
						return "Adres Silinemedi";
					}
				}
			}
			catch (Exception ex)
			{

				return "HATA OLUŞTU" + ex.Message;
			}
		}

		public IEnumerable<sp_Adresler_Result> sp_AdreslerListesi()
		{
			return db.sp_Adresler().ToList();
		}

		public IEnumerable<SP_Adresler2_Result> SP_ADRESLERR()
		{
			return db.SP_Adresler2().ToList();
		}
	}
}
