using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.Characters.ICharacters;
using WarOfTwoSides.Models.DefaultValues;
using WarOfTwoSides.Models.Utilitys.Armors.CollectionOfArmors;
using WarOfTwoSides.Models.Utilitys.Weapons.CollectionOfWeapons;

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


		public Warlock(string name = "Warlock")
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
			base.Arrmor = new LigtArmor();
			base.Weapon = new Wand();
		}

		public override void Attack(IWarrior warrior)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(base.Name + " has attacked " + warrior.Name);
			warrior.Stance = Stances.attack;

			double totalAttackDemage = 1;
			double totalMagicDemage = base.BaseMagicDemage;
			double totalDemage = 0;
			double totalHealhDealt = 0;
			double totalArmorPenetratedAttackDemage = 1;
			double totalArmorPenetratedMagicDemage = 1;
			double totalArmorPenetratedDemage = 1;

			if (!(Weapon.Durability < 1))
			{
				Console.ForegroundColor = ConsoleColor.Red;
				totalMagicDemage *= Weapon.MagicDemage + this.Knowledge;

				totalDemage += totalAttackDemage + totalMagicDemage;

				Console.WriteLine("Total magic demage: " + totalMagicDemage);
				Console.WriteLine("Total Knowledge used " + Knowledge);

				Console.WriteLine("Total demage: " + totalDemage);
			}
			else
			{
				Console.WriteLine(base.Name + " weapon is broken...");

			}
			if (!(warrior.Arrmor.Durability < 1))
			{
				totalArmorPenetratedMagicDemage = warrior.Arrmor.MagicEndurance;

			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine(" armor is broken...");
			}

			totalMagicDemage /= totalArmorPenetratedMagicDemage;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(" Total armor penetrated attack demage: " + (totalAttackDemage - (totalAttackDemage / totalArmorPenetratedAttackDemage)));
			Console.WriteLine(" Total armor penetrated magic demage: " + (totalMagicDemage - (totalMagicDemage / totalArmorPenetratedMagicDemage)));
			totalArmorPenetratedDemage = (totalMagicDemage - (totalMagicDemage / totalArmorPenetratedMagicDemage)) + (totalAttackDemage - (totalAttackDemage / totalArmorPenetratedAttackDemage));
			Console.WriteLine(" Total armor penetrated demage: " + totalArmorPenetratedDemage);

			totalHealhDealt = totalAttackDemage + totalMagicDemage;

			Console.WriteLine(base.Name + " dealt: " + totalHealhDealt + " to " + warrior.Name);
			warrior.Arrmor.Durability -= (int)totalArmorPenetratedDemage;
			warrior.BaseHealth -= (int)totalHealhDealt;
			base.Weapon.Durability -= base.BaseAttackDemage * base.BaseStrenght / 2;

			if (warrior.BaseHealth < 1)
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("The warrior " + warrior.Name + " has died");
			}
		}

		public override void SpecialAttack(IWarrior warrior)
		{
			throw new NotImplementedException();
		}
	}
}
