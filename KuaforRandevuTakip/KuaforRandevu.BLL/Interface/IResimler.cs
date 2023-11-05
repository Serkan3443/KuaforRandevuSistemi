using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KuaforRandevu.DLL;

namespace KuaforRandevu.BLL.Interface
{
	public interface IResimler
	{
		string ResimKaydet(string resimadi, string resimyolu, DateTime eklenmetarihi, int modelid, bool aktifmi,string aciklama);

		string ResimGuncelle(int resimlerid, string resimadi, string resimyolu, DateTime eklenmetarihi, int modelid, bool aktifmi,string aciklama);

		string ResimSil(int resimlerid, bool aktifmi);
	}
}
