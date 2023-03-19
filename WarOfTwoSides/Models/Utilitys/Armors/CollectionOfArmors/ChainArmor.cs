using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.DefaultValues;

namespace WarOfTwoSides.Models.Utilitys.Armors.CollectionOfArmors
{
	public class ChainArmor : Armor
	{
		public ChainArmor()
		: base
		(
			 Default_Value.CHAINARMOR_MAGIC_ENDURANCE,
			 Default_Value.CHAINARMOR_MAGIC_ENDURANCE,
			 Default_Value.CHAINARMOR_DURABILITY
		)
		{

		}
	}
}
