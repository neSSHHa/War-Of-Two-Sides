using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.DefaultValues;

namespace WarOfTwoSides.Models.Utilitys.Armors.CollectionOfArmors
{
	public class LigtArmor : Armor
	{
		public LigtArmor()
		: base
		(
			 Default_Value.LIGHTARMOR_MAGIC_ENDURANCE,
			 Default_Value.LIGHTARMOR_MAGIC_ENDURANCE,
			 Default_Value.LIGHTARMOR_DURABILITY
		)
		{

		}
	}
}
