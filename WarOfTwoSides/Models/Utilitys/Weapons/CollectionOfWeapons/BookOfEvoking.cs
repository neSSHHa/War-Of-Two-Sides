using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.DefaultValues;

namespace WarOfTwoSides.Models.Utilitys.Weapons.CollectionOfWeapons
{
	public class BookOfEvoking : Weapon
	{
		public BookOfEvoking
	()
	: base
	(
		Default_Value.BOOKOFEVOKING_BASE_DEMAGE,
		Default_Value.BOOKOFEVOKING_ATTACK_DEMAGE,
		Default_Value.BOOKOFEVOKING_MAGIC_DEMAGE,
		Default_Value.BOOKOFEVOKING_DURABILITY
	)
		{

		}
	}
}
