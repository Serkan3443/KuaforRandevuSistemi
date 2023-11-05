using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KuaforRandevu.DLL;

namespace KuaforRandevu.BLL.Interface
{
	public interface IMusteriler
	{
		string Kaydet(string Musteriadi, string musterisoyadi, string musteritelefon, string musteriadres, string mustericinsiyet, DateTime musteridogumtarihi, int ilceid);

		string Guncelle(int musterilerid, string Musteriadi, string musterisoyadi, string musteritelefon, string musteriadres, string mustericinsiyet, DateTime musteridogumtarihi, int ilceid);

		string Sil(int musterilerid);

		IEnumerable<sp_MUSTERİLER1_Result> SP_MUSTERİLER();

	}
}
