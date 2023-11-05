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
	public class KullanicilarManager : IKullanicilar
	{
		KuaforRandevuDBEntities2 db=new KuaforRandevuDBEntities2();
		Repository<Kullanicilar> repository;
        public KullanicilarManager()
        {
			db = new KuaforRandevuDBEntities2();
			repository = new Repository<Kullanicilar>(db);
        }

		public Kullanicilar Giris(string kullaniciadi, string giris)
		{
			try
			{
				var girisdurum = repository.BulQuery(k => k.KullaniciAdi == kullaniciadi && k.KullaniciSifre == giris).FirstOrDefault();
				if(girisdurum != null )
				{
					return girisdurum;
				}
				else
				{
					return null;
				}
			}
			catch (Exception)
			{

				throw;
			}
		}

		public string Guncelle(int kullanicilarid, string Kullaniciadi, string kullanicisifre, int calisanid, int yetkiid)
		{
			try
			{
				var guncellenecekveri = repository.BulQuery(kl => kl.KullanicilarID == kullanicilarid).FirstOrDefault();
				if(guncellenecekveri==null)
				{
					return "Güncellenecek veri bulunamadı";
				}
				else
				{
					guncellenecekveri.KullaniciAdi = Kullaniciadi;
					guncellenecekveri.KullaniciSifre = kullanicisifre;
					guncellenecekveri.CalisanID = calisanid;
					guncellenecekveri.YetkiID = yetkiid;

					int sonuc = repository.Guncelle(guncellenecekveri);
					if(sonuc>0)
					{
						return "Veri güncellendi";
					}
					else
					{
						return "Veri güncellenemedi";
					}
				}
			}
			catch (Exception ex)
			{

				return "Sistemsel bir hata oluştu " + ex.Message;
			}
		}

		public string Kaydet(string Kullaniciadi, string kullanicisifre, int calisanid, int yetkiid)
		{
			try
			{
				var kaydedilecekveri = repository.BulQuery(kl => kl.KullaniciAdi == Kullaniciadi && kl.KullaniciSifre==kullanicisifre).FirstOrDefault();
				if(kaydedilecekveri!=null)
				{
					return "Bu kullanıcı adı daha önce kayıt edilmiş";
				}
				else
				{
					Kullanicilar kullanicilar = new Kullanicilar();
					kullanicilar.KullaniciAdi=Kullaniciadi;
					kullanicilar.KullaniciSifre=kullanicisifre;
					kullanicilar.CalisanID = calisanid;
					kullanicilar.YetkiID = yetkiid;

					int sonuc = repository.Kaydet(kullanicilar);
					if(sonuc>0)
					{
						return "Kullanıcı adı kaydedildi";
					}
					else
					{
						return "Kullanıcı adı kaydedilemedi";
					}
				}
			}
			catch (Exception ex)
			{

				return "SİSTEMSEL BİR HATA OLUŞTU " + ex.Message;
			}
		}

		public string Sil(int kullanicilarid)
		{
			try
			{
				var silinecekveri = repository.BulQuery(kl => kl.KullanicilarID == kullanicilarid).FirstOrDefault();
				if (silinecekveri == null)
				{
					return "Silinecek veri bulunamadı";
				}
				else
				{
					int sonuc = repository.Sil(silinecekveri);
					if (sonuc > 0)
					{
						return "Kullanıcı silindi";
					}
					else
					{
						return "Kullanıcı silinemedi";
					}
				}
	
			}
			catch (Exception ex)
			{

				return "SİSTEMSEL BİR HATA OLUŞTU " + ex.Message;
			}
		}

		public IEnumerable<SP_KullanicİLAR4_Result> SP_KullanicİLAR()
		{
			return db.SP_KullanicİLAR4().ToList();
		}
	}
}
