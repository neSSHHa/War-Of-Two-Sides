using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.DefaultValues;

namespace WarOfTwoSides.Models.Utilitys.Weapons.CollectionOfWeapons
{
	public class Hammer : Weapon
	{
		public Hammer
		()
		: base
		(
			Default_Value.HAMMER_BASE_DEMAGE,
			Default_Value.HAMMER_ATTACK_DEMAGE,
			Default_Value.HAMMER_MAGIC_DEMAGE,
			Default_Value.HAMMER_DURABILITY
		)
		{

		}
	}
}
