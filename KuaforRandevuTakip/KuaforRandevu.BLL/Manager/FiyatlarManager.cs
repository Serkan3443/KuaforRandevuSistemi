using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using KuaforRandevu.BLL.Interface;
using KuaforRandevu.DLL;
using KuaforRandevu.DLL.RepositoryFolder;

namespace KuaforRandevu.BLL.Manager
{
	public class FiyatlarManager : IFiyatlar
	{
		KuaforRandevuDBEntities2 db = new KuaforRandevuDBEntities2();
		Repository<Fiyatlar> repository;
        public FiyatlarManager()
        {
			db = new KuaforRandevuDBEntities2();
			repository = new Repository<Fiyatlar>(db);
        }

        public Fiyatlar Bul(int fiyatlarid)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Fiyatlar> FiyatlarListesi()
		{
			return repository.Listele();
		}

		public string Guncelle(int fiyatlarid, decimal fiyat, DateTime fiyatbaslangictarihi, DateTime fiyatbitistarihi,int kuaforid, int bakimlarid, int alinanhizmetid)
		{
			try
			{
				var GuncellenecekVeri = repository.BulQuery(f => f.FiyatlarID == fiyatlarid).FirstOrDefault();
				if(GuncellenecekVeri==null)
				{
					return "Güncellenecek veri bulunamadı";
				}
				else
				{
					GuncellenecekVeri.Fiyat = fiyat;
					GuncellenecekVeri.FiyatBaslangicTarihi= fiyatbaslangictarihi;
					GuncellenecekVeri.FiyatBitisTarihi = fiyatbitistarihi;
					GuncellenecekVeri.KuaforID = kuaforid;
					GuncellenecekVeri.BakimlarID = bakimlarid;
					GuncellenecekVeri.AlinanHizmetID = alinanhizmetid;

					int sonuc = repository.Guncelle(GuncellenecekVeri);
					if(sonuc>0)
					{
						return "Güncelleme işlemi başarıyla gerçekleşti";
					}
					else
					{
						return "Güncelleme esnasında hata oluştu";
					}
				}
			}
			catch (Exception ex)
			{

				return "SİSTEMSEL BİR HATA OLUŞTU\nHATA:" + ex.Message;
			}
		}

		public string Kaydet(decimal fiyat, DateTime fiyatbaslangictarihi, DateTime fiyatbitistarihi, int kuaforid, int bakimlarid, int alinanhizmetid)
		{
			try
			{
				var KaydedilecekVeri = repository.BulQuery(f => f.Fiyat == fiyat).FirstOrDefault();
				if (KaydedilecekVeri != null)
				{
					return "Aynı veri daha önce kaydedilmiş, lütfen verinizi kontrol ediniz";
				}
				else
				{
					Fiyatlar fiyatlar = new Fiyatlar();
					fiyatlar.Fiyat = fiyat;
					fiyatlar.FiyatBaslangicTarihi = fiyatbaslangictarihi;
					fiyatlar.FiyatBitisTarihi = fiyatbitistarihi;
					fiyatlar.KuaforID = kuaforid;
					fiyatlar.BakimlarID = bakimlarid;
					fiyatlar.AlinanHizmetID = alinanhizmetid;

					int sonuc = repository.Kaydet(fiyatlar);
					if (sonuc > 0)
					{
						return "Veri başarıyla kaydedildi";
					}
					else
					{
						return "Veri kaydetmede sorun oldu";

					}
				}
			}
			catch (Exception ex)
			{

				return "SİSTEMSEL BİR HATA OLUŞTU\nHata " + ex.Message;
			}
		}

		public string Sil(int fiyatlarid)
		{
			try
			{
				var SilinecekVeri = repository.BulQuery(f => f.FiyatlarID == fiyatlarid).FirstOrDefault();
				if(SilinecekVeri==null)
				{
					return "Silinecek veri bulunamadı";
				}
				else
				{
					int sonuc = repository.Sil(SilinecekVeri);
					if(sonuc>0)
					{
						return "Veri başarılı bir şekilde silindi";
					}
					else
					{
						return "Veri Silinemedi!!!";
					}
				}
			}
			catch (Exception ex)
			{

				return "SİSTEMSEL BİR  HATA OLUŞTU\nHATA:" + ex.Message;
			}
		}

		public IEnumerable<Sp_Fiyatlar1_Result> sp_FiyatlarListesi()
		{
			return db.Sp_Fiyatlar1().ToList();
		}

		public IEnumerable<sp_FİYATLAR_Result> sp_fiyat_Listele()
		{
			return db.sp_FİYATLAR().ToList();
		}
	}
}
