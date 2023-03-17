using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarOfTwoSides.Models.Utilitys.Weapons.IWeapons
{
	public class IWeapons
	{
		public string Name { get; set; }

		public int Demage { get; set; }
		public int AttackDemage { get; set; }
		public int MagicDemage { get; set; }

		public int Durability { get; set; }
	}
}
