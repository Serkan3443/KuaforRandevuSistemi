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
	public class ModellerManager : IModeller
	{
		KuaforRandevuDBEntities2 db=new KuaforRandevuDBEntities2();
		Repository<Modeller> repository;
        public ModellerManager()
        {
			db = new KuaforRandevuDBEntities2();
			repository = new Repository<Modeller>(db);
        }

        public string Guncelle(int modellerid, string modelAdi, string Modeltipi, int calisanid, decimal modelyapilissuresi, bool musteribegendimi, decimal modelfiyati, string aciklama)
		{
			try
			{
				var guncellenecekveri = repository.BulQuery(md => md.ModellerID == modellerid).FirstOrDefault();
				if(guncellenecekveri==null)
				{
					return "Güncellenecek veri bulunamadı";
				}
				else
				{
					guncellenecekveri.ModelAdi = modelAdi;
					guncellenecekveri.ModelTipi = Modeltipi;
					guncellenecekveri.CalisanID = calisanid;
					guncellenecekveri.ModelYapilisSuresi = modelyapilissuresi;
					guncellenecekveri.MusteriBegendiMi = musteribegendimi;
					guncellenecekveri.ModelFiyati = modelfiyati;
					guncellenecekveri.Aciklama=aciklama;

					int sonuc = repository.Guncelle(guncellenecekveri);
					if(sonuc>0)
					{
						return "Model güncellendi";
					}
					else
					{
						return "Model güncellenemedi";
					}
				}
			}
			catch (Exception ex)
			{

				return "Sistemsel bir hata oluştu" + ex.Message;
			}
		}

		public string Kaydet(string modelAdi, string Modeltipi, int calisanid, decimal modelyapilissuresi, bool musteribegendimi, decimal modelfiyati, string aciklama)
		{
			try
			{
				var kaydedilecekveri = repository.BulQuery(md => md.ModelAdi == modelAdi).FirstOrDefault();
				if(kaydedilecekveri!=null)
				{
					return "Bu model zaten kayıtlı";
				}
				else
				{
					Modeller modeller = new Modeller();
					modeller.ModelAdi=modelAdi;
					modeller.ModelTipi = Modeltipi;
					modeller.CalisanID=calisanid;
					modeller.ModelYapilisSuresi = modelyapilissuresi;
					modeller.MusteriBegendiMi = musteribegendimi;
					modeller.ModelFiyati = modelfiyati;
					modeller.Aciklama = aciklama;

					int sonuc = repository.Kaydet(modeller);
                    if (sonuc>0)
                    {
						return "Model kaydedildi";
                    }
					else
					{
						return "Model kaydedilemedi";
					}
                }
			}
			catch (Exception ex)
			{

				return "Sistemsel bir hata oluştu " + ex.Message;
			}
		}

		public string Sil(int modellerid)
		{
			var silinecekveri = repository.BulQuery(md => md.ModellerID == modellerid).FirstOrDefault();
			if(silinecekveri==null)
			{
				return "Silinecek model bulunamadı";
			}
			else
			{
				int sonuc = repository.Sil(silinecekveri);
				if(sonuc>0)
				{
					return "Model Silindi";
				}
				else
				{
					return "Model silinemedi";
				}
			}
		}

		public IEnumerable<sp_Modeller_Result> sp_Modellerlistesi()
		{
			return db.sp_Modeller().ToList();
		}
	}
}
