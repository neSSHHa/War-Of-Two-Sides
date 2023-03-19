using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarOfTwoSides.Models.Utilitys.Armors.IArmor
{
    public interface IArmors
    {
		public int MagicEndurance { get; set; }
		public int AttackEndurance { get; set; }
		
		public int Durability { get; set; }

		public bool Broken { get; set; }
	}
}
