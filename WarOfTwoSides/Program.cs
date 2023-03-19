
using WarOfTwoSides.Models.Characters;
using WarOfTwoSides.Models.Characters.ICharacters;

namespace WarOfTwoSides
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			WarBuilder wr = new WarBuilder();
			(IList<Warrior> aliance, IList<Warrior> demons) = wr.GetRandomCharacters(10);
			wr.fight(aliance,demons);

		}
	}
}