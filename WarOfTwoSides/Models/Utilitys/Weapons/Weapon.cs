using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.Utilitys.Weapons.IWeapon;

namespace WarOfTwoSides.Models.Utilitys.Weapons
{
	public abstract class Weapon : IWeapons
	{
		private int _demage;
		private int _attackDemage;
		private int _magicDemage;
		private int _durability;
		private bool _broken;

		protected Weapon(int demage, int attackDemage, int magicDemage, int durability)
		{
			Demage = demage;
			AttackDemage = attackDemage;
			MagicDemage = magicDemage;
			Durability = durability;
			Broken = false;
		}


		public int Demage 
		{
			get => _demage; 
			set => _demage = value;
		}

		public int AttackDemage
		{
			get => _attackDemage;
			set => _attackDemage = value; 
		}

		public int MagicDemage
		{
			get => _magicDemage; 
			set => _magicDemage = value; 
		}

		public int Durability 
		{
			get => _durability;
			set {
				if(value < 1)
				{
					Broken = true;
				}
				_durability = value;
			}
		}

		public bool Broken 
		{
			get => _broken; 
			set => _broken = value; 
		}

	}
}
