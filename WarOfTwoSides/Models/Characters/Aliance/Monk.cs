using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.Characters.ICharacters;
using WarOfTwoSides.Models.DefaultValues;

namespace WarOfTwoSides.Models.Characters.Aliance
{
	public class Monk : Warrior
	{

		public Monk(string name)
		: base
		(
			name,
			Default_Value.ALIANCE_DEFAULT_HEALTH + Default_Value.MONK_HEALTH,
			Default_Value.ALIANCE_DEFAULT_STRENGHT + Default_Value.MONK_STRENGHT,
			Default_Value.ALIANCE_DEFAULT_ATTACK_DEMAGE + Default_Value.MONK_DEFAULT_ATTACK_DEMAGE,
			Default_Value.ALIANCE_DEFAULT_MAGIC_DEMAGE + Default_Value.MONK_DEFAULT_MAGIC_DEMAGE,
			Default_Value.ALIANCE_DEFAULT_FACTION,
			Stances.attack
		)
		{

		}

		public override void Attack(IWarrior warrior)
		{
			throw new NotImplementedException();
		}

		public override void SpecialAttack(IWarrior warrior)
		{
			throw new NotImplementedException();
		}
	}
}
