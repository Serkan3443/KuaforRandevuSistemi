using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KuaforRandevu.DLL;

namespace KuaforRandevu.BLL.Interface
{
	public  interface IKullanicilar
	{
		string Kaydet(string Kullaniciadi, string kullanicisifre, int calisanid, int yetkiid);

		string Guncelle(int kullanicilarid, string Kullaniciadi, string kullanicisifre, int calisanid, int yetkiid);

		string Sil(int kullanicilarid);
		IEnumerable<SP_KullanicİLAR4_Result> SP_KullanicİLAR();

		Kullanicilar Giris(string kullaniciadi, string giris);
	}
}
