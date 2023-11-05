using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KuaforRandevu.DLL;
namespace KuaforRandevu.BLL.Interface
{
	public interface IFiyatlar
	{
		string Kaydet(decimal fiyat, DateTime fiyatbaslangictarihi, DateTime fiyatbitistarihi, int kuaforid, int bakimlarid, int alinanhizmetid);

		string Guncelle(int fiyatlarid, decimal fiyat, DateTime fiyatbaslangictarihi, DateTime fiyatbitistarihi, int kuaforid, int bakimlarid, int alinanhizmetid);

		string Sil(int fiyatlarid);

		IEnumerable<Fiyatlar> FiyatlarListesi();
		IEnumerable<Sp_Fiyatlar1_Result> sp_FiyatlarListesi();
		Fiyatlar Bul(int fiyatlarid);
	}
}
