using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KuaforRandevu.DLL;

namespace KuaforRandevu.BLL.Interface
{
	public interface IAlinanUrunler
	{
		string Kaydet(string Alinanurunadi, string Alinanurunmarkasi, string Alinanurunturu, string Alinanuruntipi, decimal Alinanurunmiktari, string aciklama);

		string Guncelle(int AlinanUrunlerid, string ALinanurunadi, string Alinanurunmarkasi, string Alinanurunturu, string Alinanuruntipi, decimal Alinanurunmiktari, string aciklama);

		string Sil(int AlinanUrunlerid);

		IEnumerable<AlinanUrunler> AlinanUrunleriListele();
		AlinanUrunler Bul(int AlinanUrunlerid);
	}
}
