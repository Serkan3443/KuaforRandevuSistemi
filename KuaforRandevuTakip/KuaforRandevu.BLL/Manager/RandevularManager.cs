using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KuaforRandevu.BLL.Interface;
using KuaforRandevu.DLL;
using KuaforRandevu.DLL.RepositoryFolder;

namespace KuaforRandevu.BLL.Manager
{
	public class RandevularManager : IRandevular
	{
		KuaforRandevuDBEntities2 db = new KuaforRandevuDBEntities2();
		Repository<Randevular> repository;
        public RandevularManager()
        {
			db = new KuaforRandevuDBEntities2();
			repository = new Repository<Randevular>(db);
        }

        public string Guncelle(int randevularid, DateTime randevusaati, DateTime randevutarihi, int musteriid, int adresid, int calisanid, int kuaforid, string randevuislemi, decimal odenentutar)
		{
			try
			{
				var guncellenecekveri = repository.BulQuery(r => r.RandevularID == randevularid).FirstOrDefault();
				if(guncellenecekveri==null)
				{
					return "Güncellenecek randevu bulunamadı";
				}
				else
				{
					
					guncellenecekveri.RandevuSaati = randevusaati;
					guncellenecekveri.RandevuTarihi = randevutarihi;
					guncellenecekveri.MusteriID = musteriid;
					guncellenecekveri.AdresID = adresid;
					guncellenecekveri.CalisanID = calisanid;
					guncellenecekveri.KuaforID = kuaforid;
					guncellenecekveri.Randevuİslemi = randevuislemi;
					guncellenecekveri.OdenenTutar=odenentutar;
					int sonuc = repository.Guncelle(guncellenecekveri);
					if(sonuc>0)
					{
						return "Randevu Güncellendi";
					}
					else
					{
						return "Randevu Güncellenemedi";
					}
					
				}
			}
			catch (Exception ex)
			{

				return "Sistemsel bir hata oluştu" + ex.Message;
			}
		}

		public string Kaydet(DateTime randevusaati, DateTime randevutarihi, int musteriid, int adresid, int calisanid, int kuaforid, string randevuislemi, decimal odenentutar)
		{
			try
			{
				var kaydedilecekveri = repository.BulQuery(r => r.Randevuİslemi == randevuislemi).FirstOrDefault();
				if(kaydedilecekveri!=null) 
				{
					return "Bu randevu daha önce kaydedilmiş";
				}
				else
				{
					Randevular randevular=new Randevular();
					randevular.RandevuSaati=randevusaati;
					randevular.RandevuTarihi = randevutarihi;
					randevular.MusteriID = musteriid;
					randevular.AdresID = adresid;
					randevular.CalisanID = calisanid;
					randevular.KuaforID = kuaforid;
					randevular.Randevuİslemi = randevuislemi;
					randevular.OdenenTutar = odenentutar;

					int sonuc = repository.Kaydet(randevular);
					if(sonuc>0)
					{
						return "Randevu kaydedildi";
					}
					else
					{
						return "Randevu kaydedilemedi";
					}
					  
				}
			}
			catch (Exception ex)
			{

				return "Sistemsel bir hata oluştu"  + ex.Message;	
			}
		}

		public string Sil(int randevularid)
		{
			try
			{
				var silinecekveri = repository.BulQuery(r => r.RandevularID == randevularid).FirstOrDefault();
				if (silinecekveri == null)
				{
					return "Silinecek randevu bulunamadı";
				}
				else
				{
					int sonuc = repository.Sil(silinecekveri);
					if (sonuc > 0)
					{
						return "Randevu silindi";
					}
					else
					{
						return "randevu silinemedi";
					}
				}
			}
			catch (Exception ex)
			{

				return "Sistemsel bir hata oluştu" + ex.Message;
			}
		}

		public IEnumerable<sp_Randevular_Result> sp_RandevularListesi()
		{
			return db.sp_Randevular().ToList();
		}

		public IEnumerable<SP_RANDEVULAR1_Result> SP_RANDEVULARLİSTE()
		{
			return db.SP_RANDEVULAR1().ToList();
		}
	}
}
