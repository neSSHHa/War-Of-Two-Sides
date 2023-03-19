using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.DefaultValues;

namespace WarOfTwoSides.Models.Utilitys.Weapons.CollectionOfWeapons
{
	public class Bow : Weapon
	{
		public Bow
	()
	: base
	(
		Default_Value.BOW_BASE_DEMAGE,
		Default_Value.BOW_ATTACK_DEMAGE,
		Default_Value.BOW_MAGIC_DEMAGE,
		Default_Value.BOW_DURABILITY
	)
		{

		}
	}
}
