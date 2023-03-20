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
	public class DeathKing : Warrior
	{
		public DeathKing(string name = "Death King")
		: base
		(
			name,
			Default_Value.DEMONS_DEFAULT_HEALTH + Default_Value.DEATHKING_HEALTH,
			Default_Value.DEMONS_DEFAULT_STRENGHT + Default_Value.DEATHKING_STRENGHT,
			Default_Value.DEMONS_DEFAULT_ATTACK_DEMAGE + Default_Value.DEATHKING_DEFAULT_ATTACK_DEMAGE,
			Default_Value.DEMONS_DEFAULT_MAGIC_DEMAGE + Default_Value.DEATHKING_DEFAULT_MAGIC_DEMAGE,
			Default_Value.DEMONS_DEFAULT_FACTION,
			Stances.attack
		)
		{
			base.Arrmor = new RoyalBloodArmor();
			base.Weapon = new Sword();
		}

		public override void Attack(IWarrior warrior)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(base.Name + " has attacked " + warrior.Name);
			if ((warrior.Stance == Stances.block))
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine(warrior.Name + " is in block position, the armor will be penetrated as well ");
				warrior.Arrmor.Durability -= (base.BaseAttackDemage * base.BaseStrenght * Weapon.AttackDemage) + (Weapon.MagicDemage * base.BaseMagicDemage) / 2;
				Console.WriteLine(warrior.Name + " armor now has durability: " + warrior.Arrmor.Durability);
				warrior.Stance = Stances.attack;
			}
			else
			{
				warrior.Stance = Stances.attack;
				double totalAttackDemage = base.BaseAttackDemage * base.BaseStrenght;
				double totalMagicDemage = base.BaseMagicDemage;
				double totalDemage = 0;
				double totalHealhDealt = 0;
				double totalArmorPenetratedAttackDemage = 1;
				double totalArmorPenetratedMagicDemage = 1;
				double totalArmorPenetratedDemage = 1;

				if (!(Weapon.Durability < 1))
				{
					totalAttackDemage *= Weapon.AttackDemage;
					totalMagicDemage *= Weapon.MagicDemage;

					totalDemage = totalAttackDemage + totalMagicDemage;

					Console.WriteLine("Total attack demage: " + totalAttackDemage);
					Console.WriteLine("Total magic demage: " + totalMagicDemage);

					Console.WriteLine("Total demage: " + totalDemage);
				}
				else
				{
					Console.WriteLine(base.Name + " weapon is broken...");

				}
				if (!(warrior.Arrmor.Durability < 1))
				{
					totalArmorPenetratedAttackDemage = warrior.Arrmor.AttackEndurance;
					totalArmorPenetratedMagicDemage = warrior.Arrmor.MagicEndurance;

				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Cyan;
					Console.WriteLine(" armor is broken...");
				}

				totalAttackDemage /= totalArmorPenetratedAttackDemage;
				totalMagicDemage /= totalArmorPenetratedMagicDemage;
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(" Total armor penetrated attack demage: " + (totalAttackDemage - (totalAttackDemage / totalArmorPenetratedAttackDemage)));
				Console.WriteLine( " Total armor penetrated magic demage: " + (totalMagicDemage - (totalMagicDemage / totalArmorPenetratedMagicDemage)));
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
		}

		public override void SpecialAttack(IWarrior warrior)
		{
			throw new NotImplementedException();
		}
	}
}
