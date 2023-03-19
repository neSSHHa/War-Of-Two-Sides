﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.Characters.ICharacters;
using WarOfTwoSides.Models.DefaultValues;
using WarOfTwoSides.Models.Utilitys.Armors.CollectionOfArmors;
using WarOfTwoSides.Models.Utilitys.Weapons.CollectionOfWeapons;

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

		public Soldier(string name = "Soldier")
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
			base.Arrmor = new ChainArmor();
			base.Weapon = new Sword();
			base.Name += " " + this.Rank;
			assingRank();
		}

		public override void Attack(IWarrior warrior)
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine(base.Name + " has attacked " + warrior.Name);
			if((warrior.Stance == Stances.block) || (warrior.Arrmor.Durability > 1))
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(warrior.Name + " is in block position, the armor will be penetrated as well ");
				warrior.Arrmor.Durability -= (base.BaseAttackDemage * base.BaseStrenght * Weapon.AttackDemage) + (Weapon.MagicDemage * base.BaseMagicDemage)/2;
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
				double totalArmorPenetratedAttackDemage = 0;
				double totalArmorPenetratedMagicDemage = 0;
				double totalArmorPenetratedDemage = 0;

				if (!(Weapon.Durability < 1))
				{
					totalAttackDemage *= Weapon.AttackDemage;
					totalMagicDemage *= Weapon.MagicDemage;

					totalDemage += totalAttackDemage + totalMagicDemage;

					Console.WriteLine("Total attack demage: " + totalAttackDemage);
					Console.WriteLine("Total magic demage: " + totalMagicDemage);

					Console.WriteLine("Total demage: " + totalDemage);
				}
				else
				{
					Console.WriteLine(base.Name + " weapon is broken...");

				}
				if(!(warrior.Arrmor.Durability < 1))
				{
					totalArmorPenetratedAttackDemage = warrior.Arrmor.AttackEndurance;
					totalArmorPenetratedMagicDemage = warrior.Arrmor.MagicEndurance;

				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(warrior.Arrmor + " armor is broken...");
				}

				totalAttackDemage /= totalArmorPenetratedAttackDemage;
				totalMagicDemage /= totalArmorPenetratedMagicDemage;
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine(warrior.Arrmor + " Total armor penetrated attack demage: " + (totalAttackDemage - (totalAttackDemage / totalArmorPenetratedAttackDemage)));
				Console.WriteLine(warrior.Arrmor + " Total armor penetrated magic demage: " + (totalMagicDemage - (totalMagicDemage / totalArmorPenetratedMagicDemage)));
				totalArmorPenetratedDemage = (totalMagicDemage - (totalMagicDemage / totalArmorPenetratedMagicDemage)) + (totalAttackDemage - (totalAttackDemage / totalArmorPenetratedAttackDemage));
				Console.WriteLine(warrior.Arrmor + " Total armor penetrated demage: " + totalArmorPenetratedDemage);
				
				totalHealhDealt = totalAttackDemage + totalMagicDemage;

				Console.WriteLine(base.Name + " dealt: " + totalHealhDealt + " to " + warrior.Name);
				warrior.Arrmor.Durability -= (int)totalArmorPenetratedDemage;
				warrior.BaseHealth -= (int)totalHealhDealt;
				base.Weapon.Durability -= base.BaseAttackDemage * base.BaseStrenght/2;

				if(warrior.BaseHealth < 1)
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
