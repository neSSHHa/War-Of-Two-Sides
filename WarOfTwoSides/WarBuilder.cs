using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfTwoSides.Models.Characters;
using WarOfTwoSides.Models.Characters.Aliance;
using WarOfTwoSides.Models.Characters.Demons;
using WarOfTwoSides.Models.Characters.ICharacters;

namespace WarOfTwoSides
{
	public class WarBuilder
	{
		public (IList<Warrior> Aliance, IList<Warrior> Demons) GetRandomCharacters(int numberOfCharacters)
		{
			var random = new Random();
			var alianceList = new List<Warrior>();
			var demonList = new List<Warrior>();

			for (int i = 0; i < numberOfCharacters; i++)
			{
				int r = random.Next(1,6);
				switch (r)
				{
					case 1:
						Soldier soldier = new Soldier();
						alianceList.Add(soldier);
						break;
					case 2:
						Prist prist = new Prist();
						alianceList.Add(prist);
						break;
					case 3:
						Paladin paladin = new Paladin();
						alianceList.Add(paladin);
						break;
					case 4:
						Monk monk = new Monk();
						alianceList.Add(monk);
						break;
					case 5:
						Mage mage = new Mage();
						alianceList.Add(mage);
						break;
					case 6:
						DemonHunter demonHunter = new DemonHunter();
						alianceList.Add(demonHunter);
						break;
				}
			}

			for (int i = 0; i < numberOfCharacters; i++)
			{
				int r = random.Next(1, 6);
				switch (r)
				{
					case 1:
						DeathKing deathKing = new DeathKing();
						demonList.Add(deathKing);
						break;
					case 2:
						Demon demon = new Demon();
						demonList.Add(demon);
						break;
					case 3:
						Evoker evoker = new Evoker();
						demonList.Add(evoker);
						break;
					case 4:
						Hunter hunter = new Hunter();
						demonList.Add(hunter);
						break;
					case 5:
						Rogue rogue = new Rogue();
						demonList.Add(rogue);
						break;
					case 6:
						Warlock warlock = new Warlock();
						demonList.Add(warlock);
						break;
				}
			}

			foreach(var item in alianceList)
			{
				Console.WriteLine(item.ToString());
			}
			foreach (var item in demonList)
			{
				Console.WriteLine(item.ToString());
			}

			return (alianceList, demonList);


		}

		public void fight(IList<Warrior> aliance, IList<Warrior> demons)
		{

			int aliancecount = aliance.Count;
			int demonscount = demons.Count;

			Random r = new Random();
			while(aliancecount > 0 && demonscount > 0)
			{
				var aliwarrior = aliance.ElementAt(r.Next(aliancecount));
				var demowarrior = demons.ElementAt(r.Next(demonscount));

				if(aliwarrior is Prist)
				{
					aliwarrior.Attack(demowarrior);
				}
				else
				{
					switch (r.Next(1, 2))
					{
						case 1: aliwarrior.Attack(demowarrior);break;
						case 2: aliwarrior.BlockAttack();break;
					}
				}
				if(demowarrior.BaseHealth < 1)
				{
					demons.Remove(demowarrior);
					demonscount--;
					if (demonscount == 0)
						break;
				}

				var aliwarrior2 = aliance.ElementAt(r.Next(aliancecount));
				var demowarrior2 = demons.ElementAt(r.Next(demonscount));

				if (demowarrior2 is Evoker)
				{
					switch (r.Next(1, 2))
					{
						case 1: demowarrior2.Attack(aliwarrior2); break;
						case 2: (demowarrior2 as Evoker).SpawnBeast(); break;
					}
				}
				else if(demowarrior2 is Warlock)
				{
					demowarrior2.Attack(aliwarrior2);
				}
				else
				{
					switch (r.Next(1, 2))
					{
						case 1: demowarrior2.Attack(aliwarrior2); break;
						case 2: demowarrior2.BlockAttack(); break;
					}
				}
				if (aliwarrior2.BaseHealth < 1)
				{
					aliance.Remove(aliwarrior2);
					aliancecount--;
					if (aliancecount == 0)
						break;
				}

			}
			
			if(aliance.Count > 0)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("aliance has winned");
				Console.WriteLine("The end result are here: ");
				foreach (var item in aliance)
				{
					Console.WriteLine(item);
				}
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Magenta;
				Console.WriteLine("demons has winned");
				Console.WriteLine("The end result are here: ");
				foreach(var item in demons)
				{
					Console.WriteLine(item);
				}
			}

			
			

		}


	}
}
