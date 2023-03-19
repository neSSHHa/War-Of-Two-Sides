using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.DefaultValues;

namespace WarOfTwoSides.Models.Utilitys.Armors.CollectionOfArmors
{
	public class HolyVestments : Armor
	{
		public HolyVestments()
		: base
		(
			 Default_Value.HOLYVESTMENTS_MAGIC_ENDURANCE,
			 Default_Value.HOLYVESTMENTS_MAGIC_ENDURANCE,
			 Default_Value.HOLYVESTMENTS_DURABILITY
		)
		{

		}
	}
}
