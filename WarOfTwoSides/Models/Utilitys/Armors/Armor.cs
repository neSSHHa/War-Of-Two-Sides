using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.Utilitys.Armors.IArmor;
using WarOfTwoSides.Models.Utilitys.Weapons.IWeapon;

namespace WarOfTwoSides.Models.Utilitys.Armors
{
	public abstract class Armor : IArmors
	{

		private int _magicEndurance;
		private int _attackEndurance;
		private int _durability;
		private bool _broken;

		protected Armor(int magicEndurance, int attackEndurance, int durability)
		{
			MagicEndurance = magicEndurance;
			AttackEndurance = attackEndurance;
			Durability = durability;
			Broken = false;
		}

		public int MagicEndurance { get => _magicEndurance; set => _magicEndurance = value; }
		public int AttackEndurance { get => _attackEndurance; set => _attackEndurance = value; }
		public int Durability { get => _durability; set => _durability = value; }
		public bool Broken { get => _broken; set => _broken = value; }
	}
}
