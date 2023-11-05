using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KuaforRandevu.DLL;

namespace KuaforRandevu.BLL.Interface
{
	public interface IKuaforler
	{
		string Kaydet(string Kuaforadi, string kuafortelefon, string kuaforadres, int kuaforilceid);

		string Guncelle(int kuaforlerid,string kuaforadi, string kuafortelefon,string kuaforadres,int kuaforilceid);

		string Sil(int kuaforlerid);

		IEnumerable<Kuaforler> KuaforListesi();
		IEnumerable<sp_kuaforler_Result> sp_KuaforListesi();
		
	}
}
