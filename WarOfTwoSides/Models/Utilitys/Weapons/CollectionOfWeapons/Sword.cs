using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.DefaultValues;

namespace WarOfTwoSides.Models.Utilitys.Weapons.CollectionOfWeapons
{
	public class Sword : Weapon
	{
		public Sword
			()
			: base
			(
				Default_Value.SWORD_BASE_DEMAGE,
				Default_Value.SWORD_ATTACK_DEMAGE,
				Default_Value.SWORD_MAGIC_DEMAGE,
				Default_Value.SWORD_DURABILITY
			)
		{

		}
	}
}
