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


	public class Mage : Warrior
	{
		private int _mana { get; set; }

		public int Mana 
		{
			get
			{
				return _mana;
			}
			set
			{
				_mana = value;
			}
		}

		public Mage(string name = "Mage")
		: base
		(
			name,
			Default_Value.ALIANCE_DEFAULT_HEALTH + Default_Value.MAGE_HEALTH,
			Default_Value.ALIANCE_DEFAULT_STRENGHT + Default_Value.MAGE_STRENGHT,
			Default_Value.ALIANCE_DEFAULT_ATTACK_DEMAGE + Default_Value.MAGE_DEFAULT_ATTACK_DEMAGE,
			Default_Value.ALIANCE_DEFAULT_MAGIC_DEMAGE + Default_Value.MAGE_DEFAULT_MAGIC_DEMAGE,
			Default_Value.ALIANCE_DEFAULT_FACTION,
			Stances.attack
		)
		{
			this.Mana = Default_Value.MAGE_DEFAULT_MANA;
			base.Weapon = new Wand();
			base.Arrmor = new LeatherArmor();
		}

		public override void Attack(IWarrior warrior)
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine(base.Name + " has attacked " + warrior.Name);
			warrior.Stance = Stances.attack;

			double totalAttackDemage = 1;
			double totalMagicDemage = base.BaseMagicDemage;
			double totalDemage = 0;
			double totalHealhDealt = 0;
			double totalArmorPenetratedAttackDemage = 1;
			double totalArmorPenetratedMagicDemage = 1;
			double totalArmorPenetratedDemage = 1;

			if(this.Mana < 10)
			{
				Console.WriteLine(this.Name + " doesnt have enough mana to cast a spell for attack");
				return;
			}

			if (!(Weapon.Durability < 1))
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
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
				totalArmorPenetratedMagicDemage = warrior.Arrmor.MagicEndurance;

			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(" armor is broken...");
			}

			totalMagicDemage /= (totalArmorPenetratedMagicDemage * 0.5);
			Console.ForegroundColor = ConsoleColor.Cyan;
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
