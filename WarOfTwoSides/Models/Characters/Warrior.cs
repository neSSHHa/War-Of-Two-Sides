using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.Characters.Aliance;
using WarOfTwoSides.Models.Characters.ICharacters;
using WarOfTwoSides.Models.Utilitys.Armors.IArmor;
using WarOfTwoSides.Models.Utilitys.Weapons.IWeapon;

namespace WarOfTwoSides.Models.Characters
{
	public abstract class Warrior : IWarrior
	{
		private string _name;
		private int _baseHealt;
		private int _baseStrenght;
		private int _baseAttackDemage;
		private int _BaseMagicDemage;
		private IWeapons _weapon;
		private IArmors _armor;
		private Faction _faction;
		private Stances _stance;

		public Warrior(string name, int baseHealth, int baseStrenght, int baseAttackDemage, int baseMagicDemage, Faction faction, Stances stance)
		{
			Name = name;
			Stance = stance;
			BaseHealth = baseHealth;
			BaseStrenght = baseStrenght;
			BaseAttackDemage = baseAttackDemage;
			BaseMagicDemage = baseMagicDemage;
			Faction = faction;
		}

		public string Name 
		{
			get
			{
				return this._name;
			} 
			set 
			{
				this._name = value;
			}
		}

		public Stances Stance
		{
			get
			{
				return this._stance;
			}
			set
			{
				this._stance = value;
			}
		}

		public int BaseHealth 
		{
			get
			{
				return this._baseHealt;
			}
			set
			{
				this._baseHealt = value;
			}
			
		}

		public int BaseStrenght
		{
			get
			{
				return this._baseStrenght;
			}
			set
			{
				this._baseHealt = value;
			}
		}

		public int BaseAttackDemage 
		{
			get
			{
				return this._baseAttackDemage;
			}
			set
			{
				this._baseAttackDemage = value;
			}
		}

		public int BaseMagicDemage
		{
			get
			{
				return this._BaseMagicDemage;
			}
			set
			{
				this._BaseMagicDemage = value;
			}
		}

		public IWeapons Weapon 
		{
			get
			{
				return this._weapon;
			}
			set
			{
				this._weapon = value;
			}
		}

		public IArmors Arrmor 
		{
			get
			{
				return this._armor;
			}
			set
			{
				this._armor = value;
			}
		}

		public Faction Faction
		{
			get
			{
				return this._faction;
			}
			set
			{
				this._faction = value;
			}
		}



		public abstract void Attack(IWarrior warrior);
		public virtual void BlockAttack()
		{
			this.Stance = Stances.block;
		}
		public abstract void SpecialAttack(IWarrior warrior);

		public override string ToString()
		{
			return "Name: " + Name + "\n" +
				"Health: " + this.BaseHealth + "\n" +
				"Strenght: " + this.BaseStrenght + "\n" +
				"Attack Demage: " + this.BaseAttackDemage + "\n" +
				"Magic Demage: " + this.BaseMagicDemage + "\n" +
				"Faction: " + Faction.ToString() + "\n";
		}

	}
}
