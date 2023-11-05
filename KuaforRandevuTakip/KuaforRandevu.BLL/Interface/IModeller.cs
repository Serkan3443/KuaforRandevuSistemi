using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using KuaforRandevu.DLL;

namespace KuaforRandevu.BLL.Interface
{
	public interface IModeller
	{
		string Kaydet(string modelAdi, string Modeltipi, int calisanid, decimal modelyapilissuresi, bool musteribegendimi, decimal modelfiyati,string aciklama);

		string Guncelle(int modellerid, string modelAdi, string Modeltipi, int calisanid, decimal modelyapilissuresi, bool musteribegendimi, decimal modelfiyati, string aciklama);

		string Sil(int modellerid);
		IEnumerable<sp_Modeller_Result> sp_Modellerlistesi();
	}
}
