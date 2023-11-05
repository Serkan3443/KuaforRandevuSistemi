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
	public class MalzemeFisleriManager : IMalzemeFisleri
	{
		KuaforRandevuDBEntities2 db=new KuaforRandevuDBEntities2();
		Repository<MalzemeFisleri> repository;
        public MalzemeFisleriManager()
        {
		   db=new KuaforRandevuDBEntities2();
			repository=new Repository<MalzemeFisleri> (db);
        }

        public string Guncelle(int fislerid, int kuaforid, int urunid, int malzemeciid, decimal fistutari, DateTime fiskesimtarihi, string fiskesimadresi)
		{
			try
			{
				var guncellenecekveri = repository.BulQuery(mf => mf.FislerID == fislerid).FirstOrDefault();
				if(guncellenecekveri==null)
				{
					return "alınmış bir malzeme fişi henüz yok";
				}
				else
				{
					guncellenecekveri.KuaforID= kuaforid;
					guncellenecekveri.UrunID= urunid;
					guncellenecekveri.MalzemeciID= malzemeciid;
					guncellenecekveri.FisTutari= fistutari;
					guncellenecekveri.FisKesimTarihi= fiskesimtarihi;
					guncellenecekveri.FisKesimAdresi = fiskesimadresi;

					int sonuc = repository.Guncelle(guncellenecekveri);
					if(sonuc>0)
					{
						return "Alınan malzeme fişi güncellendi";
					}
					else
					{
						return "Alınmış malzeme fişi güncellenemedi";
					}
				}
			}
			catch (Exception ex)
			{

				return "Sistemsel bir hata meydana geldi " + ex.Message;
			}
		}

		public string Kaydet(int kuaforid, int urunid, int malzemeciid, decimal fistutari, DateTime fiskesimtarihi, string fiskesimadresi)
		{
			try
			{
				var kaydedilecekveri = repository.BulQuery(mf => mf.FisKesimAdresi == fiskesimadresi).FirstOrDefault();
				if(kaydedilecekveri!=null)
				{
					return " bu Malzemenin fişi kayıt edilmiş zaten";
				}
				else
				{
					MalzemeFisleri malzemefisi=new MalzemeFisleri();
					malzemefisi.KuaforID = kuaforid;
					malzemefisi.UrunID = urunid;
					malzemefisi.MalzemeciID = malzemeciid;
					malzemefisi.FisTutari = fistutari;
					malzemefisi.FisKesimTarihi = fiskesimtarihi;
					malzemefisi.FisKesimAdresi = fiskesimadresi;

					int sonuc = repository.Kaydet(malzemefisi);
					if(sonuc>0)
					{
						return "Alınan malzeme faturası kaydedildi";

					}
					else
					{
						return "Malzeme faturası  kaydedilemedi";
					}
				}
			}
			catch (Exception ex)
			{

				return "Sistemsel bir hata oluştu";
			}
		}

		public string Sil(int fislerid)
		{
			try
			{
				var silinecekveri = repository.BulQuery(mf => mf.FislerID == fislerid).FirstOrDefault();
				if (silinecekveri == null)
				{
					return "Silinecek herhangi bir fatura bulunamadı";
				}
				else
				{
					int sonuc = repository.Sil(silinecekveri);
					if (sonuc > 0)
					{
						return "Malzeme faturası silindi";
					}
					else
					{
						return "Fatura silinemedi";
					}
				}
			}
			catch (Exception ex)
			{

				return "Sistemsel bir hata meydana geldi";
			}
		}

		public IEnumerable<sp_Malzemefisleri_Result> sp_MalzemeFisleriListesi()
		{
			return db.sp_Malzemefisleri().ToList();
		}
	}
}
