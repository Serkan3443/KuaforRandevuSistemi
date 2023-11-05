using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KuaforRandevu.DLL;

namespace KuaforRandevu.BLL.Interface
{
	public interface ICalisanlar
	{
		string Kaydet(string calisanadi, string calisansoyadi, string calisantelefon, string calisanemail, string calisanadres, DateTime calisandogumtarihi, string calisancinsiyeti, string calisanpozisyonu, DateTime calisanbaslamatarihi, DateTime calisancikistarihi, int kuaforid);

		string Guncelle(int calisanlarid, string calisanadi, string calisansoyadi, string calisantelefon, string calisanemail, string calisanadres, DateTime calisandogumtarihi, string calisancinsiyeti, string calisanpozisyonu, DateTime calisanbaslamatarihi, DateTime calisancikistarihi,  int kuaforid);

		string Sil(int Calisanlarid);
		IEnumerable<Calisanlar> CalisanListesi();
		IEnumerable<SP_CALİSANLAR1_Result> SP_CALİSANLAR();

		Calisanlar Bul(int Calisanlarid);
	}
}
