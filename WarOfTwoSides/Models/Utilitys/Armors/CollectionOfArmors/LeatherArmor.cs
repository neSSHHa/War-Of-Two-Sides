using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.DefaultValues;

namespace WarOfTwoSides.Models.Utilitys.Armors.CollectionOfArmors
{
	public class LeatherArmor : Armor
	{
		public LeatherArmor()
		:base
		(
			 Default_Value.LEATHERARMOR_MAGIC_ENDURANCE,
			 Default_Value.LEATHERARMOR_MAGIC_ENDURANCE,
			 Default_Value.LEATHERARMOR_DURABILITY
		)
		{

		}
	}
}
