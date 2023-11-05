using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KuaforRandevu.DLL;

namespace KuaforRandevu.BLL.Interface
{
	public interface IHizmetler
	{
		string Kaydet(string hizmetadi,int randevuid,decimal hizmetfiyati,int musteriid,int calisanid,int kuaforid,string musteriyorumu);

		string Guncelle(int Hizmetlerid, string hizmetadi, int randevuid, decimal hizmetfiyati, int musteriid, int calisanid, int kuaforid, string musteriyorumu);

		string Sil(int Hizmetlerid);

		IEnumerable<Hizmetler> HizmetlerListesi();
		IEnumerable<SP_HizmetLER3_Result> SP_HizmetLER();
		Hizmetler Bul(int Hizmetlerid);
	}
}
