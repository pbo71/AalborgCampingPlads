using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAalborgCamping
{
	public class CampGroundReservationsInfo
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public int Adults { get; set; }
		public int Kids { get; set; }
		public bool Animal { get; set; }

		public enum BungaLowTypes { Ingen, Lille, Stor, Luksus };
		public BungaLowTypes BungalowType { get; set; }
		public int BungalowNumber { get; set; }

		public int SiteNumber { get; set; }

	}
}
