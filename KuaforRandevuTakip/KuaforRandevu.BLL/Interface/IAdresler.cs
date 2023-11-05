using System;
using System.Collections.Generic;
using KuaforRandevu.DLL;

namespace KuaforRandevu.BLL.Interface
{
	public interface IAdresler
	{
		string Kaydet(string adresbasligi, int musteriid, int ilceid, string adres);
		string Guncelle(int adreslerid,string adresbasligi,int musteriid,int ilceid,string adres);

		string Sil(int adreslerid);

		IEnumerable<Adresler> AdresListele();
		IEnumerable<SP_Adresler2_Result> SP_ADRESLERR();
		Adresler Bul(int adresid);
		

		
	}
}
