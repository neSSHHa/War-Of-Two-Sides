using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.Utilitys.Armors.IArmors;
using WarOfTwoSides.Models.Utilitys.Weapons.IWeapon;

namespace WarOfTwoSides.Models.Characters.ICharacters
{
	public interface IWarrior
	{
		public string Name { get; set; }

		public int BaseHealth { get; set; }
		public int BaseStrenght { get; set; }
		public int BaseAttackDemage { get; set; }
		public int BaseMagicDemage { get; set; }

		public Stances Stance { get; set; }

		public IWeapons Weapon { get; set; }
		public IArmors Arrmor { get; set; }

		public Faction Faction { get; set; }

		void Attack(IWarrior warrior);
		void SpecialAttack(IWarrior warrior);
		void BlockAttack();
	}
}
