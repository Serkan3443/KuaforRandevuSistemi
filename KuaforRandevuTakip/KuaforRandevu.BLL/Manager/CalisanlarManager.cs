using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using KuaforRandevu.BLL.Interface;
using KuaforRandevu.DLL;
using KuaforRandevu.DLL.RepositoryFolder;

namespace KuaforRandevu.BLL.Manager
{
	public class CalisanlarManager : ICalisanlar
	{
		KuaforRandevuDBEntities2 db = new KuaforRandevuDBEntities2();
		Repository<Calisanlar> repository;
        public CalisanlarManager()
        {
			db = new KuaforRandevuDBEntities2();
			repository = new Repository<Calisanlar>(db);
        }

        public Calisanlar Bul(int Calisanlarid)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Calisanlar> CalisanListesi()
		{
			db = new KuaforRandevuDBEntities2();
			repository = new Repository<Calisanlar>(db);

			return repository.Listele();
		}

		public string Guncelle(int calisanlarid, string calisanadi, string calisansoyadi, string calisantelefon, string calisanemail, string calisanadres, DateTime calisandogumtarihi, string calisancinsiyeti, string calisanpozisyonu, DateTime calisanbaslamatarihi, DateTime calisancikistarihi,int kuaforid)
		{
			try
			{
				var GuncellenecekVeri = repository.BulQuery(c => c.CalisanlarId == calisanlarid).FirstOrDefault();
				if(GuncellenecekVeri==null)
				{
					return "Güncellenecek veri bulunamadı";
				}
				else
				{
					GuncellenecekVeri.CalisanAdi = calisanadi;
					GuncellenecekVeri.CalisanSoyadi = calisansoyadi;
					GuncellenecekVeri.CalisanTelefon = calisantelefon;
					GuncellenecekVeri.CalisanEmail = calisanemail;
					GuncellenecekVeri.CalisanAdresi = calisanadres;
					GuncellenecekVeri.CalisanDogumTarihi = calisandogumtarihi;
					GuncellenecekVeri.CalisanCinsiyeti = calisancinsiyeti;
					GuncellenecekVeri.CalisanPozisyonu = calisanpozisyonu;
					GuncellenecekVeri.CalisanBaslamaTarihi = calisanbaslamatarihi;
					GuncellenecekVeri.CalisanCikisTarihi = calisancikistarihi;
					GuncellenecekVeri.KuaforID = kuaforid;
					

					int sonuc = repository.Guncelle(GuncellenecekVeri);
					if(sonuc>0)
					{
						return "Veri güncellendi";
					}
					else
					{
						return "Veri güncelleme esnasında hata oluştu";
					}
				}
			}
			catch (Exception ex)
			{

				return "SİSTEMSEL BİR HATA OLUŞTU" + ex.Message;
			}
		}

		public string Kaydet(string calisanadi, string calisansoyadi, string calisantelefon, string calisanemail, string calisanadres, DateTime calisandogumtarihi, string calisancinsiyeti, string calisanpozisyonu, DateTime calisanbaslamatarihi, DateTime calisancikistarihi, int kuaforid)
		{
			db = new KuaforRandevuDBEntities2();
			repository = new Repository<Calisanlar>(db);
			try
			{

				var KaydedilecekVeri = repository.BulQuery(c => c.CalisanAdi == calisanadi && c.CalisanSoyadi == calisansoyadi).FirstOrDefault();
				if (KaydedilecekVeri != null)
				{
					return "Girdiginiz bu veri daha önce kaydedilmiş";
				}
				else
				{
					Calisanlar calisan = new Calisanlar();
					calisan.CalisanAdi = calisanadi;
					calisan.CalisanSoyadi = calisansoyadi;
					calisan.CalisanTelefon = calisantelefon;
					calisan.CalisanEmail = calisanemail;
					calisan.CalisanAdresi = calisanadres;
					calisan.CalisanDogumTarihi = calisandogumtarihi;
					calisan.CalisanCinsiyeti = calisancinsiyeti;
					calisan.CalisanPozisyonu = calisanpozisyonu;
					calisan.CalisanBaslamaTarihi = calisanbaslamatarihi;
					calisan.CalisanCikisTarihi = calisancikistarihi;
					calisan.KuaforID = kuaforid;


					int sonuc = repository.Kaydet(calisan);
					if (sonuc > 0)
					{
						return "Kaydetme işlemi başarılıyla gerçekleşti";
					}
					else
					{
						return "Kaydetme esnasında bir hata oluştu, lütfen kontrol ediniz";
					}

				}
	
			}
			catch (Exception ex)
			{

				return "SİSTEMSEL BİR HATA" + ex.Message;


			}
		}

		public string Sil(int Calisanlarid)
		{
			db = new KuaforRandevuDBEntities2();
			repository = new Repository<Calisanlar>(db);

			try
			{
				var SilinecekVeri = repository.BulQuery(c => c.CalisanlarId == Calisanlarid).FirstOrDefault();
				if(SilinecekVeri==null)
				{
					return "Silinecek veri bulunamadı";
				}
				else
				{
					int sonuc = repository.Sil(SilinecekVeri);
					if(sonuc>0)
					{
						return "Veri baaşarıyla silindi";
					}
					else
					{
						return "Veri silme esnasında hata oluştu";
					}
				}
			}
			catch (Exception ex)
			{

				return "SİSTESMEL BİR  HATA OLUŞTU\nHata:" + ex.Message;
			}
		}

		public IEnumerable<sp_Calisanlar_Result> sp_Calisanlar_Listesi()
		{
			return db.sp_Calisanlar().ToList();
		}

		public IEnumerable<SP_CALİSANLAR1_Result> SP_CALİSANLAR()
		{
			return db.SP_CALİSANLAR1().ToList();
		}
	}
}
