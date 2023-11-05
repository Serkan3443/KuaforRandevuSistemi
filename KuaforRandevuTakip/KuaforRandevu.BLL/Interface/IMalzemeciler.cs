using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KuaforRandevu.DLL;

namespace KuaforRandevu.BLL.Interface
{
	public interface IMalzemeciler
	{
		string Kaydet(int UrunID, string malzemeciadi, string isletmeturu, string malzemeciadres, string malzemecitelefon, string malzemeciemail, bool malzemeciaktifmi);

		string Guncelle(int malzemecilerid, int UrunID, string malzemeciadi, string isletmeturu, string malzemeciadres, string malzemecitelefon, string malzemeciemail, bool malzemeciaktifmi);

		string Sil(int malzemecilerid);
		IEnumerable<sp_Malzemeciler_Result> sp_MalzemecilerListesi();
		
	}
}
