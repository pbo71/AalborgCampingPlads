using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAalborgCamping
{
	public class CampGround
	{
		public Pitch pitch { get; set; }
		public SmallBungalow smallBungalow { get; set; }
		public LargeBungalow bigBungalow { get; set; }
		public LuxuryBungalow luxuryBungalow { get; set; }
		
		public List<CampGroundReservationsInfo> ReservationList { get; set; }

		public CampGround(int nof_sites, int nof_small_bungalow, int nof_big_bungalow, int nof_luxury_bungalow)
		{
			pitch = new Pitch(nof_sites);
			smallBungalow = new SmallBungalow(nof_small_bungalow);
			bigBungalow = new LargeBungalow(nof_big_bungalow);
			luxuryBungalow = new LuxuryBungalow(nof_luxury_bungalow);
			ReservationList = new List<CampGroundReservationsInfo> { };
		}
	}
}
