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
	public class KuaforlerManager : IKuaforler
	{
		KuaforRandevuDBEntities2 db = new KuaforRandevuDBEntities2();
		Repository<Kuaforler> repository;
        public KuaforlerManager()
        {
				db=new KuaforRandevuDBEntities2();
			repository = new Repository<Kuaforler>(db); 
        }

        public string Guncelle(int kuaforlerid, string kuaforadi, string kuafortelefon, string kuaforadres, int kuaforilceid)
		{
			try
			{
				var guncellencekveri = repository.BulQuery(k => k.KuaforlerID == kuaforlerid).FirstOrDefault();
				if(guncellencekveri==null)
				{
					return "Güncellencek veri bulunamadı";
				}
				else
				{
					guncellencekveri.KuaforAdi = kuaforadi;
					guncellencekveri.KuaforTelefon= kuafortelefon;
					guncellencekveri.KuaforAdres = kuaforadres;
					guncellencekveri.KuaforIlceID=kuaforilceid;

					int sonuc = repository.Guncelle(guncellencekveri);
					if(sonuc>0)
					{
						return "Veriler Güncellendi";
					}
					else
					{
						return "Veriler güncellenemedi";
					}
				}
			}
			catch (Exception ex)
			{

				return "SİSTEMSEL BİR HATA OLUŞTU" + ex.Message;
			}
		}

		public string Kaydet(string Kuaforadi, string kuafortelefon, string kuaforadres, int kuaforilceid)
		{
			try
			{
				var kaydedilecekveri = repository.BulQuery(k => k.KuaforAdi == Kuaforadi).FirstOrDefault();
				if(kaydedilecekveri!=null)
				{
					return "Bu veri daha önce kaydedilmiş";
				}
				else
				{
					Kuaforler kuafor = new Kuaforler();
					kuafor.KuaforAdi = Kuaforadi;
					kuafor.KuaforTelefon = kuafortelefon;
					kuafor.KuaforAdres= kuaforadres;
					kuafor.KuaforIlceID= kuaforilceid;

					int sonuc = repository.Kaydet(kuafor);
					if(sonuc>0)
					{
						return "veri kaydedildi";
					}
					else
					{
						return "Veri kaydedilemedi";
					}
				}
			}
			catch (Exception ex)
			{

				return "SİSTEMSEL BİR HATA OLUŞTU" + ex.Message;
			}
		}

		public IEnumerable<Kuaforler> KuaforListesi()
		{
			return repository.Listele();
		}

		public string Sil(int kuaforlerid)
		{
			try
			{
				var silinecekveri = repository.BulQuery(k => k.KuaforlerID == kuaforlerid).FirstOrDefault();
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

				return "SİSTEMSEL BİR HATA OLUŞTU" + ex.Message;
			}

		}

		public IEnumerable<sp_kuaforler_Result> sp_KuaforListesi()
		{
			return db.sp_kuaforler().ToList();
		}
	}
}
