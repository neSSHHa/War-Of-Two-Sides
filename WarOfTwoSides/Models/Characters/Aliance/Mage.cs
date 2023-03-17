using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.Characters.ICharacters;
using WarOfTwoSides.Models.DefaultValues;

namespace WarOfTwoSides.Models.Characters.Aliance
{


	public class Mage : Warrior
	{
		private int mana { get; set; }

		public int Mana 
		{
			get
			{
				return mana;
			}
			set
			{
				mana = value;
			}
		}

		public Mage(string name)
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
			this.mana = Default_Value.MAGE_DEFAULT_MANA;
		}

		public override void Attack(IWarrior warrior)
		{
			throw new NotImplementedException();
		}

		public override void SpecialAttack(IWarrior warrior)
		{
			throw new NotImplementedException();
		}

	}
}
