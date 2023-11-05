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
	public class BakimlarManager : IBakimlar
	{
		KuaforRandevuDBEntities2 db = new KuaforRandevuDBEntities2();
		Repository<Bakimlar> repository;
        public BakimlarManager()
        {
			db = new KuaforRandevuDBEntities2();
			repository = new Repository<Bakimlar>(db);
        }

        public IEnumerable<Bakimlar> BakimlariListele()
		{
			return repository.Listele();
		}

		public Bakimlar Bul(int Bakimlarid)
		{
			throw new NotImplementedException();
		}

		public string Guncelle(int Bakimlarid, string Bakimadi, int alinanhizmetid, int bakimfiyati, string aciklama)
		{
			try
			{
				var Guncellenecekveri = repository.BulQuery(b => b.BakimlarId == Bakimlarid).FirstOrDefault();
				if(Guncellenecekveri==null)
				{
					return "Güncellencek verş bulunamadı";
				}
				else
				{
					Guncellenecekveri.BakimAdi = Bakimadi;
					Guncellenecekveri.AlinanHizmetId= alinanhizmetid;
					Guncellenecekveri.BakimFiyati= bakimfiyati;
					Guncellenecekveri.Aciklama = aciklama;
					int sonuc = repository.Guncelle(Guncellenecekveri);
					if(sonuc>0)
					{
						return "Veri Güncelleme başarılı";
					}
					else
					{
						return "Veri Güncelleme esnasında hata oluştu";
					}
				}
			}
			catch (Exception ex)
			{
				return "Sistemsel bir hata oluştu " + ex.Message;
				 
			}
		}

		public string Kaydet(string Bakimadi, int alinanhizmetid, int bakimfiyati, string aciklama)
		{
			try
			{
				var KayitedilecekVeri = repository.BulQuery(b => b.BakimAdi == Bakimadi).FirstOrDefault();
				if(KayitedilecekVeri!=null)
				{
					return "Aynı veri daha önce kayıt edilmiş, lütfen kontrol ediniz";
				}
				else
				{
					Bakimlar bakimlar = new Bakimlar();
					bakimlar.BakimAdi = Bakimadi;
					bakimlar.AlinanHizmetId = alinanhizmetid;
					bakimlar.BakimFiyati = bakimfiyati;
					bakimlar.Aciklama = aciklama;

					int sonuc = repository.Kaydet(bakimlar);
					if(sonuc>0)
					{
						return "Kayıt etme işlemi başarılı";
					}
					else
					{
						return "Veri kaydedilemedi";
					}
				}
			}
			catch (Exception ex)
			{

				return "SİSTEMSEL BİR HATA  OLUŞTU\nHATA: " + ex.Message;
			}
		}

		public string Sil(int Bakimlarid)
		{
			try
			{
				var Silinecekveri = repository.BulQuery(b => b.BakimlarId == Bakimlarid).FirstOrDefault();
				if(Silinecekveri==null)
				{
					return "Silinecek veri bulunamadı";
				}
				else
				{
					int sonuc = repository.Sil(Silinecekveri);
					if(sonuc>0)
					{
						return "Seçilen veri baaşarıyla silindi";
					}
					else
					{
						return "Veri silme esnasında hata oluştu, veri silinemedi!!!";
					}
				}
			}
			catch (Exception ex)
			{

				return "SİSTEMSEL BİR HATA OLUŞTU\nHATA: " + ex.Message;
			}
		}

		public IEnumerable<SP_Bakimlar_Result> SP_BAKİMLAR()
		{
			return db.SP_Bakimlar().ToList();
		}
	}
}
