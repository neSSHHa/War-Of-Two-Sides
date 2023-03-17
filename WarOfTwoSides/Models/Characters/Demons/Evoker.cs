using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.Characters.ICharacters;
using WarOfTwoSides.Models.DefaultValues;

namespace WarOfTwoSides.Models.Characters.Demons
{
	public class Evoker : Warrior
	{
		//List<> SpawnedBeast = new List<> ();

		public Evoker(string name)
		: base
		(
			name,
			Default_Value.DEMONS_DEFAULT_HEALTH + Default_Value.EVOKER_HEALTH,
			Default_Value.DEMONS_DEFAULT_STRENGHT + Default_Value.EVOKER_STRENGHT,
			Default_Value.DEMONS_DEFAULT_ATTACK_DEMAGE + Default_Value.EVOKER_DEFAULT_ATTACK_DEMAGE,
			Default_Value.DEMONS_DEFAULT_MAGIC_DEMAGE + Default_Value.EVOKER_DEFAULT_MAGIC_DEMAGE,
			Default_Value.DEMONS_DEFAULT_FACTION,
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
		public void SpawnBeast()
		{
			throw new NotImplementedException();
		}
	}
}
