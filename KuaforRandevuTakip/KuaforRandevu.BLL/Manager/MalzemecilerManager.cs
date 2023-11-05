using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KuaforRandevu.BLL.Interface;
using KuaforRandevu.DLL;
using KuaforRandevu.DLL;
using KuaforRandevu.DLL.RepositoryFolder;

namespace KuaforRandevu.BLL.Manager
{
	public class MalzemecilerManager : IMalzemeciler
	{
		KuaforRandevuDBEntities2 db=new KuaforRandevuDBEntities2 ();
		Repository<Malzemeciler> repository;
        public MalzemecilerManager()
        {
			db = new KuaforRandevuDBEntities2();
			repository=new Repository<Malzemeciler> (db);
        }

        public string Guncelle(int malzemecilerid, int UrunID, string malzemeciadi, string isletmeturu, string malzemeciadres, string malzemecitelefon, string malzemeciemail, bool malzemeciaktifmi)
		{
			try
			{
				var guncellencekveri = repository.BulQuery(mlz => mlz.MalzemecilerID == malzemecilerid).FirstOrDefault();
				if(guncellencekveri==null)
				{
					return "Güncellenecek veri bulunamadı";
				}
				else
				{
					guncellencekveri.UrunID = UrunID;
					guncellencekveri.MalzemeciAdi = malzemeciadi;
					guncellencekveri.IsletmeTuru = isletmeturu;
					guncellencekveri.MalzemeciAdres= malzemeciadres;
					guncellencekveri.MalzemeciTelefonNo= malzemecitelefon;
					guncellencekveri.MalzemeciEmail = malzemeciemail;
					guncellencekveri.MalzemeciAktifMi = malzemeciaktifmi;

					int sonuc = repository.Guncelle(guncellencekveri);
					if(sonuc>0)
					{
						return "Malzemeci verisi güncellendi";
					}
					else
					{
						return "Malzeme verisi güncellenemedi";
					}
				}
			}
			catch (Exception ex)
			{

				return "SİSTEMSEL BİR HATA OLUŞTU " + ex.Message;
			}
		}

		public string Kaydet(int UrunID, string malzemeciadi, string isletmeturu, string malzemeciadres, string malzemecitelefon, string malzemeciemail, bool malzemeciaktifmi)
		{
			try
			{
				var kaydedilecekveri = repository.BulQuery(mlz => mlz.MalzemeciAdi == malzemeciadi).FirstOrDefault();
				if(kaydedilecekveri!=null)
				{
					return "Bu veri daha önce kayıtlı zaten";
				}
				else
				{
					Malzemeciler malzemeciler = new Malzemeciler();
					malzemeciler.UrunID = UrunID;
					malzemeciler.MalzemeciAdi = malzemeciadi;
					malzemeciler.IsletmeTuru = isletmeturu;
					malzemeciler.MalzemeciAdres=malzemeciadres;
					malzemeciler.MalzemeciTelefonNo = malzemecitelefon;
					malzemeciler.MalzemeciEmail = malzemeciemail;
					malzemeciler.MalzemeciAktifMi=malzemeciaktifmi;

					int sonuc = repository.Kaydet(malzemeciler);
					if(sonuc>0)
					{
						return "Malzemeci verisi kaydedildi";
					}
					else
					{
						return "Veri kaydedilemedi";
					}
					
				}
			}
			catch (Exception ex)
			{

				return "Sistemsel bir hata oluştu " + ex.Message;
			}
		}

		public string Sil(int malzemecilerid)
		{
			try
			{
				var silinecekveri = repository.BulQuery(mlz => mlz.MalzemecilerID == malzemecilerid).FirstOrDefault();
				if (silinecekveri == null)
				{
					return "Silinecek veri bulunamadı";
				}
				else
				{
					int sonuc = repository.Sil(silinecekveri);
					if (sonuc > 0)
					{
						return "Veri silindi";
					}
					else
					{
						return "Veri silinemedi";
					}
				}
	
			}
			catch (Exception ex)
			{

				return "Sistemsel bir hata oluştu " + ex.Message;
			}
		}

		public IEnumerable<sp_Malzemeciler_Result> sp_MalzemecilerListesi()
		{
			return db.sp_Malzemeciler().ToList();
		}
	}
}
