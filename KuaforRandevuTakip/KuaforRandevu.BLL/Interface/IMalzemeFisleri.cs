using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KuaforRandevu.DLL;

namespace KuaforRandevu.BLL.Interface
{
	public interface IMalzemeFisleri
	{
		string Kaydet(int kuaforid, int urunid, int malzemeciid, decimal fistutari, DateTime fiskesimtarihi, string fiskesimadresi);

		string Guncelle(int fislerid, int kuaforid, int urunid, int malzemeciid, decimal fistutari, DateTime fiskesimtarihi, string fiskesimadresi);

		string Sil(int fislerid);
		IEnumerable<sp_Malzemefisleri_Result> sp_MalzemeFisleriListesi();
	}
}
