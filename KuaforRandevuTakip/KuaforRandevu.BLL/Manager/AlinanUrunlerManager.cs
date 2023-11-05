using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using KuaforRandevu.BLL.Interface;
using KuaforRandevu.DLL;
using KuaforRandevu.DLL.RepositoryFolder;

namespace KuaforRandevu.BLL.Manager
{
	public class AlinanUrunlerManager : IAlinanUrunler
	{
		KuaforRandevuDBEntities2 db = new KuaforRandevuDBEntities2();
		Repository<AlinanUrunler> repository;
        public AlinanUrunlerManager()
        {
				db=new KuaforRandevuDBEntities2();
			repository = new Repository<AlinanUrunler>(db);
        }

        public IEnumerable<AlinanUrunler> AlinanUrunleriListele()
		{
			return repository.Listele();
		}

		public AlinanUrunler Bul(int AlinanUrunlerid)
		{
			throw new NotImplementedException();
		}

		public string Guncelle(int AlinanUrunlerid, string ALinanurunadi, string Alinanurunmarkasi, string Alinanurunturu, string Alinanuruntipi, decimal Alinanurunmiktari, string aciklama)
		{
			try
			{
				var GuncellenecekVeri = repository.BulQuery(au => au.AlinanUrunlerID == AlinanUrunlerid).FirstOrDefault();
				if(GuncellenecekVeri==null)
				{
					return "Güncellencek veri bulunamadı";
				}
				else
				{
					GuncellenecekVeri.AlinanUrunAdi = ALinanurunadi;
					GuncellenecekVeri.AlinanUrunMarkasi = Alinanurunmarkasi;
					GuncellenecekVeri.AlinanUrunTuru = Alinanurunturu;
					GuncellenecekVeri.AlinanUrunTipi = Alinanuruntipi;
					GuncellenecekVeri.AlinanUrunMiktari = Alinanurunmiktari;
					GuncellenecekVeri.Aciklama = aciklama;

					int sonuc = repository.Guncelle(GuncellenecekVeri);
					if(sonuc>0)
					{
						return "Alinan ürünler Tablosundaki veri güncellendi";
					}
					else
					{
						return "Güncellem esnasında bir hata oluştu";
					}
				}

			}
			catch (Exception ex)
			{

				return "SİSTEMSEL BİR HATA OLUŞTU\nHata " + ex.Message;
			}
		}

		public string Kaydet(string Alinanurunadi, string Alinanurunmarkasi, string Alinanurunturu, string Alinanuruntipi, decimal Alinanurunmiktari, string aciklama)
		{
			db = new KuaforRandevuDBEntities2();
			repository = new Repository<AlinanUrunler>(db);

			try
			{
				var KayitedilecekVeri = repository.BulQuery(au => au.AlinanUrunAdi == Alinanurunadi).FirstOrDefault();
				if(KayitedilecekVeri!=null)
				{
					return "Aynı veri daha önce girilmiş, lütfen kontrol ediniz";
				}
				else
				{
					AlinanUrunler alinanurun = new AlinanUrunler();
					alinanurun.AlinanUrunAdi = Alinanurunadi;
					alinanurun.AlinanUrunMarkasi = Alinanurunmarkasi;
					alinanurun.AlinanUrunTuru = Alinanurunturu;
					alinanurun.AlinanUrunTipi = Alinanuruntipi;
					alinanurun.AlinanUrunMiktari = Alinanurunmiktari;
					alinanurun.Aciklama = aciklama;

					int sonuc = repository.Kaydet(alinanurun);
					if(sonuc>0)
					{
						return "Alinan ürünler tablosuna veri kayıt edildi";
					}
					else
					{
						return "Kayıt başarısız tekrar deneyin!!!";
					}
				}

			}
			catch (Exception ex)
			{

				return "SİSTEMSEL BİR  HATA OLUŞTU\nHATA " + ex.Message;
			}
		}

		public string Sil(int AlinanUrunlerid)
		{
			KuaforRandevuDBEntities2 db = new KuaforRandevuDBEntities2();

			try
			{
				var SilinecekVeri = repository.BulQuery(au => au.AlinanUrunlerID == AlinanUrunlerid).FirstOrDefault();

				if(SilinecekVeri==null)
				{
					return "Silinecek veri bulunamadı";
				}
				else
				{
					int sonuc = repository.Sil(SilinecekVeri);
					if(sonuc>0)
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

				return "SİSTEMSEL BİR  HATA OLUŞTU\n HATA" + ex.Message;
			}
		}
	}
}
