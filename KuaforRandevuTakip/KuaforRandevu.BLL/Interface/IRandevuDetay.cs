using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KuaforRandevu.DLL;
namespace KuaforRandevu.BLL.Interface
{
	public interface IRandevuDetay
	{
		string Kaydet(string islemdetay, bool randevuaktifmi, DateTime randevusaatleri, bool randevuiptal, string aciklama);

		string Guncelle(int randevularid, string islemdetay, bool randevuaktifmi, DateTime randevusaatleri, bool randevuiptal, string aciklama);

		string Sil(int randevularid);

		IEnumerable<SP_Randevudetaylari2_Result> SP_RandevudetaylarListe();
		IEnumerable<RandevuDetay> RandevuDetayListeleri();
		


	}
}
