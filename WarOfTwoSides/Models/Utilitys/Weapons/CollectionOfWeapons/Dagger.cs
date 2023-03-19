using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.DefaultValues;

namespace WarOfTwoSides.Models.Utilitys.Weapons.CollectionOfWeapons
{
	public class Dagger : Weapon
	{
		public Dagger
	()
	: base
	(
		Default_Value.DAGGER_BASE_DEMAGE,
		Default_Value.DAGGER_ATTACK_DEMAGE,
		Default_Value.DAGGER_MAGIC_DEMAGE,
		Default_Value.DAGGER_DURABILITY
	)
		{

		}
	}
}
