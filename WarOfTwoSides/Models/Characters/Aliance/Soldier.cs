using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.Characters.ICharacters;
using WarOfTwoSides.Models.DefaultValues;

namespace WarOfTwoSides.Models.Characters.Aliance
{
	public class Soldier : Warrior
	{
		private Ranks _rank;
		private readonly Random _random = new Random();

		public Ranks Rank 
		{
			get
			{
				return _rank;
			}
			set
			{
				_rank = value;
			} 
		}

		public Soldier(string name)
			:base
			(
				name,
				Default_Value.ALIANCE_DEFAULT_HEALTH + Default_Value.SOLDIER_HEALTH,
				Default_Value.ALIANCE_DEFAULT_STRENGHT + Default_Value.SOLDIER_STRENGHT,
				Default_Value.ALIANCE_DEFAULT_ATTACK_DEMAGE + Default_Value.SOLDIER_DEFAULT_ATTACK_DEMAGE,
				Default_Value.ALIANCE_DEFAULT_MAGIC_DEMAGE + Default_Value.SOLDIER_DEFAULT_MAGIC_DEMAGE,
				Default_Value.ALIANCE_DEFAULT_FACTION,
				Stances.attack
			)
		{

			assingRank();

		}

		public override void Attack(IWarrior warrior)
		{
			throw new NotImplementedException();
		}
	
		public override void SpecialAttack(IWarrior warrior)
		{
			throw new NotImplementedException();
		}

		public void assingRank()
		{
			var enums = Enum.GetValues(typeof(Ranks));
			this.Rank = (Ranks)enums.GetValue(_random.Next(7));

			switch (this.Rank)
			{
				case Ranks.Sergeant:
					base.BaseHealth += 30;
					base.BaseStrenght += 3;
					base.BaseAttackDemage+= 2;		
					break;

				case Ranks.Commander:
					base.BaseHealth += 25;
					base.BaseStrenght += 2;
					base.BaseAttackDemage += 2;
					break;

				case Ranks.Senior:
					base.BaseHealth += 20;
					base.BaseStrenght += 1;
					base.BaseAttackDemage += 2;
					break;

				case Ranks.Corporal:
					base.BaseHealth += 15;
					base.BaseStrenght += 1;
					base.BaseAttackDemage += 1;
					break;

				case Ranks.Army_Specialist:
					base.BaseHealth += 10;
					base.BaseAttackDemage += 2;
					break;

				case Ranks.Private_Class:
					base.BaseHealth += 8;
					break;

				case Ranks.Moderate:
					base.BaseHealth += 5;		
					break;
			}
		}

	}
}
