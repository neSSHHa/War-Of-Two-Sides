using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.Characters.ICharacters;
using WarOfTwoSides.Models.DefaultValues;

namespace WarOfTwoSides.Models.Characters.Aliance
{
	public class Prist : Warrior
	{
		public int Holy { get; set; }

		public Prist(string name)
		: base
		(
			name,
			Default_Value.ALIANCE_DEFAULT_HEALTH + Default_Value.PRIEST_HEALTH,
			Default_Value.ALIANCE_DEFAULT_STRENGHT + Default_Value.PRIEST_STRENGHT,
			Default_Value.ALIANCE_DEFAULT_ATTACK_DEMAGE + Default_Value.PRIEST_DEFAULT_ATTACK_DEMAGE,
			Default_Value.ALIANCE_DEFAULT_MAGIC_DEMAGE + Default_Value.PRIEST_DEFAULT_MAGIC_DEMAGE,
			Default_Value.ALIANCE_DEFAULT_FACTION,
			Stances.attack
		)
		{

			this.Holy = Default_Value.PRIEST_DEFAULT_HOLY;

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
