using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KuaforRandevu.DLL;

namespace KuaforRandevu.BLL.Interface
{
	public interface IRandevular
	{
		string Kaydet(DateTime randevusaati, DateTime randevutarihi, int musteriid, int adresid, int calisanid, int kuaforid, string randevuislemi, decimal odenentutar);

		string Guncelle(int randevularid, DateTime randevusaati, DateTime randevutarihi, int musteriid, int adresid, int calisanid, int kuaforid, string randevuislemi, decimal odenentutar);

		string Sil(int randevularid);
		IEnumerable<SP_RANDEVULAR1_Result> SP_RANDEVULARLİSTE();
	}
}
