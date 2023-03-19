using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.DefaultValues;

namespace WarOfTwoSides.Models.Utilitys.Armors.CollectionOfArmors
{
	public class DemonSkin : Armor
	{
		public DemonSkin()
		: base
		(
			 Default_Value.DEMONSKIN_MAGIC_ENDURANCE,
			 Default_Value.DEMONSKIN_MAGIC_ENDURANCE,
			 Default_Value.DEMONSKIN_DURABILITY
		)
		{

		}
	}
}
