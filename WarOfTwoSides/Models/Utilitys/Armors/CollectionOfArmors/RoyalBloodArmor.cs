using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.DefaultValues;

namespace WarOfTwoSides.Models.Utilitys.Armors.CollectionOfArmors
{
	public class RoyalBloodArmor : Armor
	{
		public RoyalBloodArmor() 
			:base
			(
				 Default_Value.ROYALBLOODARMOR_MAGIC_ENDURANCE,
				 Default_Value.ROYALBLOODARMOR_MAGIC_ENDURANCE,
				 Default_Value.ROYALBLOODARMOR_DURABILITY
			)
		{

		}
	}
}
