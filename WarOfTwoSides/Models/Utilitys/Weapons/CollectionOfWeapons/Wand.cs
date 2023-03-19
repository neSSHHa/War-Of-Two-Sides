using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.Characters;
using WarOfTwoSides.Models.DefaultValues;

namespace WarOfTwoSides.Models.Utilitys.Weapons.CollectionOfWeapons
{
	public class Wand : Weapon
	{
		public Wand
			()
			: base
			(
				Default_Value.WAND_BASE_DEMAGE,
				Default_Value.WAND_ATTACK_DEMAGE,
				Default_Value.WAND_MAGIC_DEMAGE,
				Default_Value.WAND_DURABILITY
			)
		{

		}
	}
}
