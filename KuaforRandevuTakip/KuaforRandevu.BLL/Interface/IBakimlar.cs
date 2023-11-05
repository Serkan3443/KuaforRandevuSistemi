using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KuaforRandevu.DLL;

namespace KuaforRandevu.BLL.Interface
{
	public interface IBakimlar
	{
		string Kaydet(string Bakimadi, int alinanhizmetid, int bakimfiyati, string aciklama);

		string Guncelle(int Bakimlarid, string Bakimadi, int alinanhizmetid, int bakimfiyati, string aciklama);

		string Sil(int Bakimlarid);

		IEnumerable<Bakimlar> BakimlariListele();
		IEnumerable<SP_Bakimlar_Result> SP_BAKİMLAR();

		Bakimlar Bul(int Bakimlarid);
	}
}
