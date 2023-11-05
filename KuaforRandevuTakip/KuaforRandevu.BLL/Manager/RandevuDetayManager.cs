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
	public class RandevuDetayManager : IRandevuDetay
	{
		KuaforRandevuDBEntities2 db = new KuaforRandevuDBEntities2();
		Repository<RandevuDetay> repository;
        public RandevuDetayManager()
        {
		     db=new KuaforRandevuDBEntities2();
			repository = new Repository<RandevuDetay>(db);
        }

        public string Guncelle(int randevularid, string islemdetay, bool randevuaktifmi, DateTime randevusaatleri, bool randevuiptal, string aciklama)
		{
			try
			{
				var guncellenecekveri = repository.BulQuery(d => d.RandevularID == randevularid).FirstOrDefault();
				if(guncellenecekveri==null)
				{
					return "Güncellenecek detay bulunamadı";
				}
				else
				{
					guncellenecekveri.İslemDetay = islemdetay;
					guncellenecekveri.RandevuAktifMi = randevuaktifmi;
					guncellenecekveri.RandevuSaatleri = randevusaatleri;
					guncellenecekveri.Randevuİptal = randevuiptal;
					guncellenecekveri.Aciklama = aciklama;

					int sonuc = repository.Guncelle(guncellenecekveri);
					if(sonuc>0)
					{
						return "Detay güncellendi";
					}
					else
					{
						return "Detay güncellenemedi";
					}
				}

			}
			catch (Exception ex)
			{

				return "Sistemsel bir hata oluştu" + ex.Message;
			}
		}

		public string Kaydet(string islemdetay, bool randevuaktifmi, DateTime randevusaatleri, bool randevuiptal, string aciklama)
		{
			try
			{
				var kaydedilecekveri = repository.BulQuery(d =>d.RandevuSaatleri==randevusaatleri).FirstOrDefault();
				if(kaydedilecekveri!=null)
				{
					return "Bu detayın kaydı önceden yapılmış";
				}
				else
				{
					RandevuDetay detay=new RandevuDetay();
					detay.İslemDetay = islemdetay;
					detay.RandevuAktifMi = randevuaktifmi;
					detay.RandevuSaatleri = randevusaatleri;
					detay.Randevuİptal = randevuiptal;
					detay.Aciklama = aciklama;

					int sonuc = repository.Kaydet(detay);
					if(sonuc>0)
					{
						return "detay kaydedildi";
					}
					else
					{
						return "Detay kaydedilirken bir sorun oluştu";
					}
				}
			}
			catch (Exception ex)
			{

				return "Sistemsel bir hata oluştu" + ex.Message;
			}
		}

		public IEnumerable<RandevuDetay> RandevuDetayListeleri()
		{
			return repository.Listele();
		}

		public string Sil(int randevularid)
		{
			try
			{
				var silinecekveri = repository.BulQuery(d => d.RandevularID == randevularid).FirstOrDefault();
				if (silinecekveri == null)
				{
					return "Silinecek detay bulunamadı";
				}
				else
				{
					int sonuc = repository.Sil(silinecekveri);
					if (sonuc > 0)
					{
						return " Randevu Detayı silindi";
					}
					else
					{
						return "Randevu Detay silinirken bir hata oluştu";
					}
				}
			}
			catch (Exception ex)
			{

				return "Sistemsel bir hata oluştu" + ex.Message;
			}
		}

		

		public IEnumerable<SP_Randevudetaylari2_Result> SP_RandevudetaylarListe()
		{
			return db.SP_Randevudetaylari2().ToList();
		}
	}
}
