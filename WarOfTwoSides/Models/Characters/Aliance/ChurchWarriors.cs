using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.Characters.ICharacters;

namespace WarOfTwoSides.Models.Characters.Aliance
{
	public abstract class ChurchWarriors : Warrior
	{

		private int _holy { get; set; }

		public int Holy
		{
			get
			{
				return _holy;
			}
			set
			{
				_holy = value;
			}
		}
		public ChurchWarriors(string name, int baseHealth, int baseStrenght, int baseAttackDemage, int baseMagicDemage, Faction faction, Stances stance)
		: base(name, baseHealth, baseStrenght, baseAttackDemage, baseMagicDemage, faction, stance)
		{

		}

	}
}
