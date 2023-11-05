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
	public class HizmetlerManager : IHizmetler
	{
		KuaforRandevuDBEntities2 db=new KuaforRandevuDBEntities2();
		Repository<Hizmetler> repository;
        public HizmetlerManager()
        {
				db=new KuaforRandevuDBEntities2();
			repository = new Repository<Hizmetler>(db);
        }

        public Hizmetler Bul(int Hizmetlerid)
		{
			throw new NotImplementedException();
		}

		public string Guncelle(int Hizmetlerid, string hizmetadi, int randevuid, decimal hizmetfiyati, int musteriid, int calisanid, int kuaforid, string musteriyorumu)
		{
			try
			{
				var guncellencekVeri = repository.BulQuery(h => h.AlinanHizmetlerId == Hizmetlerid).FirstOrDefault();
				if(guncellencekVeri==null)
				{
					return "Güncellencek veri bulunamadı";
				}
				else
				{
					guncellencekVeri.HizmetAdi= hizmetadi;
					guncellencekVeri.RandevuId = randevuid;
					guncellencekVeri.AlinanHizmetFiyati = hizmetfiyati;
					guncellencekVeri.MusteriID = musteriid;
					guncellencekVeri.CalisanID = calisanid;
					guncellencekVeri.KuaforID = kuaforid;
					guncellencekVeri.Aciklama = musteriyorumu;

					int sonuc = repository.Guncelle(guncellencekVeri);
					if(sonuc>0)
					{
						return "Veri başarıyla güncellendi";
					}
					else
					{
						return "Güncelleme esnasında bir hata oluştu";
					}
				}
			}
			catch (Exception ex)
			{

				return "SİSTEMSEL BİR HATA OLUŞTU " + ex.Message;
			}
		}

		public IEnumerable<Hizmetler> HizmetlerListesi()
		{
			return repository.Listele();
		}

		public string Kaydet(string hizmetadi, int randevuid, decimal hizmetfiyati, int musteriid, int calisanid, int kuaforid, string musteriyorumu)
		{
			db = new KuaforRandevuDBEntities2();
			repository = new Repository<Hizmetler>(db);
			try
			{
				var kaydedilecekVeri = repository.BulQuery(h => h.HizmetAdi == hizmetadi).FirstOrDefault();
				if(kaydedilecekVeri!=null)
				{
					return "Aynı veri daha önce kaydedilmiş";
				}
				else
				{
					Hizmetler hizmetler = new Hizmetler();
					hizmetler.HizmetAdi= hizmetadi;
					hizmetler.RandevuId = randevuid;
					hizmetler.AlinanHizmetFiyati = hizmetfiyati;
					hizmetler.MusteriID = musteriid;
					hizmetler.CalisanID = calisanid;
					hizmetler.KuaforID = kuaforid;
					hizmetler.Aciklama = musteriyorumu;

					int sonuc = repository.Kaydet(hizmetler);
					if(sonuc>0)
					{
						return "Veri kaydedildi";
					}
					else
					{
						return "Veri kaydedilemedi!!!";
					}
				}
			}
			catch (Exception ex)
			{

				return "SİSTEMSEL BİR HATA OLUŞTU: " + ex.Message;
			}
		}

		public string Sil(int Hizmetlerid)
		{
			try
			{
				var silinecekVeri=repository.BulQuery(h=>h.AlinanHizmetlerId==Hizmetlerid).FirstOrDefault();
				int sonuc = repository.Sil(silinecekVeri);
				if(sonuc>0)
				{
					return "Veri silindi";
				}
				else
				{
					return "Veri silinemedi";
				}

			}
			catch (Exception ex)
			{

				return "SİSTEMSEL BİR HATA OLUŞTU " + ex.Message;
			}
		}

		public IEnumerable<SP_HizmetLER3_Result> SP_HizmetLER()
		{
			return db.SP_HizmetLER3().ToList();
		}

		public IEnumerable<Sp_Hizmetler_Result> Sp_HizmetlerListe()
		{
			return db.Sp_Hizmetler().ToList();
		}

		

		
	}
}
