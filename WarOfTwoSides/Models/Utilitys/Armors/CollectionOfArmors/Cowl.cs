using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.DefaultValues;

namespace WarOfTwoSides.Models.Utilitys.Armors.CollectionOfArmors
{
	public class Cowl : Armor
	{
		public Cowl()
		: base
		(
			 Default_Value.COWL_MAGIC_ENDURANCE,
			 Default_Value.COWL_MAGIC_ENDURANCE,
			 Default_Value.COWL_DURABILITY
		)
		{

		}
	}
}
