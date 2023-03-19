using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.DefaultValues;

namespace WarOfTwoSides.Models.Utilitys.Weapons.CollectionOfWeapons
{
	public class Warglaives : Weapon
	{
		public Warglaives
			() 
			: base
			(
				Default_Value.WARGLAIVES_BASE_DEMAGE,
				Default_Value.WARGLAIVES_ATTACK_DEMAGE,
				Default_Value.WARGLAIVES_MAGIC_DEMAGE,
				Default_Value.WARGLAIVES_DURABILITY
			)
		{

		}
	}
}
