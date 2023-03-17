using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.Characters.ICharacters;
using WarOfTwoSides.Models.DefaultValues;

namespace WarOfTwoSides.Models.Characters.Demons
{
	public class Warlock : Warrior
	{
		private int _knowledge;

		public int Knowledge 
		{
			get
			{
				return _knowledge;
			}
			set
			{
				_knowledge = value;
			}
		}


		public Warlock(string name)
		: base
		(
			name,
			Default_Value.DEMONS_DEFAULT_HEALTH + Default_Value.WARLOCK_HEALTH,
			Default_Value.DEMONS_DEFAULT_STRENGHT + Default_Value.WARLOCK_STRENGHT,
			Default_Value.DEMONS_DEFAULT_ATTACK_DEMAGE + Default_Value.WARLOCK_DEFAULT_ATTACK_DEMAGE,
			Default_Value.DEMONS_DEFAULT_MAGIC_DEMAGE + Default_Value.WARLOCK_DEFAULT_MAGIC_DEMAGE,
			Default_Value.DEMONS_DEFAULT_FACTION,
			Stances.attack
		)
		{
			Knowledge = Default_Value.WARLOCK_DEFAULT_KNOWLEDGE;
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
