using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.DefaultValues;

namespace WarOfTwoSides.Models.Utilitys.Weapons.CollectionOfWeapons
{
	public class Spear : Weapon
	{
		public Spear
			()
			: base
			(
				Default_Value.SPEAR_BASE_DEMAGE,
				Default_Value.SPEAR_ATTACK_DEMAGE,
				Default_Value.SPEAR_MAGIC_DEMAGE,
				Default_Value.SPEAR_DURABILITY
			)
		{

		}
	}
}
