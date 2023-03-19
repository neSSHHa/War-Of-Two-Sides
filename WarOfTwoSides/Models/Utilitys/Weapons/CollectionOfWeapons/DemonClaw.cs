using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.DefaultValues;

namespace WarOfTwoSides.Models.Utilitys.Weapons.CollectionOfWeapons
{
	public class DemonClaw : Weapon
	{
		public DemonClaw
	()
	: base
	(
		Default_Value.DEMONCLAW_BASE_DEMAGE,
		Default_Value.DEMONCLAW_ATTACK_DEMAGE,
		Default_Value.DEMONCLAW_MAGIC_DEMAGE,
		Default_Value.DEMONCLAW_DURABILITY
	)
		{

		}
	}
}
