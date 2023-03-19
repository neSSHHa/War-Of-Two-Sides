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
	public class Evoker : Warrior
	{
		private int beastSpawned;

		public int BeastSpawned { get => beastSpawned; set => beastSpawned = value; }

		public Evoker(string name = "Evoker")
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
			base.Arrmor = new LeatherArmor();
			base.Weapon = new BookOfEvoking();
			BeastSpawned = 0;
		}

		public override void Attack(IWarrior warrior)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(base.Name + " has attacked " + warrior.Name);
			warrior.Stance = Stances.attack;

			double totalAttackDemage = 0;
			double totalMagicDemage = base.BaseMagicDemage;
			double totalDemage = 0;
			double totalHealhDealt = 0;
			double totalArmorPenetratedAttackDemage = 0;
			double totalArmorPenetratedMagicDemage = 0;
			double totalArmorPenetratedDemage = 0;

			if (!(Weapon.Durability < 1))
			{
				Console.ForegroundColor = ConsoleColor.Red;
				totalMagicDemage *= Weapon.MagicDemage + this.BeastSpawned * 10;

				totalDemage += totalAttackDemage + totalMagicDemage;

				Console.WriteLine("Total magic demage: " + totalMagicDemage);
				Console.WriteLine("Total beast spawned " + this.BeastSpawned);

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
				Console.WriteLine(warrior.Arrmor + " armor is broken...");
			}

			totalMagicDemage /= totalArmorPenetratedMagicDemage;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(warrior.Arrmor + " Total armor penetrated attack demage: " + (totalAttackDemage - (totalAttackDemage / totalArmorPenetratedAttackDemage)));
			Console.WriteLine(warrior.Arrmor + " Total armor penetrated magic demage: " + (totalMagicDemage - (totalMagicDemage / totalArmorPenetratedMagicDemage)));
			totalArmorPenetratedDemage = (totalMagicDemage - (totalMagicDemage / totalArmorPenetratedMagicDemage)) + (totalAttackDemage - (totalAttackDemage / totalArmorPenetratedAttackDemage));
			Console.WriteLine(warrior.Arrmor + " Total armor penetrated demage: " + totalArmorPenetratedDemage);

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
		public void SpawnBeast()
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(base.Name + " has spawned beast and now has: " + this.BeastSpawned + " beast");
			BeastSpawned++;
		}
	}
}
