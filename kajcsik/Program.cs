using System.Collections.Generic;

namespace kajcsik
{
	internal class Program
	{
		static double SumCalories(List<Etel> lista)
		{
			double sum = 0;
			foreach (Etel e in lista)
			{
				sum += e.CountCalories();
			}
			return sum;
		}

		static List<Etel> Szuro(List<Etel> lista)
		{
			List<Etel> noDairy= new List<Etel>();
			foreach (Etel e in lista) 
			{
				if (e.ItsDairyfree == true)
				{
					noDairy.Add(e);
				}
			}
			return noDairy;
		}

		static void Main(string[] args)
		{
			List<Etel> etterem = new List<Etel>();
			//3 leves
			etterem.Add(new Levesek(3, 50, "Lebbencsleves"));
			etterem.Add(new Levesek(11, 300, "Kőleves"));
			etterem.Add(new Levesek(7, 60, "Borsóleves"));

			//3 kenyer
			etterem.Add(new Kenyerfelek(50, 20, "Fehér"));
			etterem.Add(new Kenyerfelek(56, 18, "Tejes kenyér"));
			etterem.Add(new Kenyerfelek(78, 15, "Kék kenyér"));

			//3 hús
			etterem.Add(new SultHusok(50, 24, "Csirke"));
			etterem.Add(new SultHusok(19, 289, "Tehénhús(tejjel)"));
			etterem.Add(new SultHusok(70, 27, "Disznó"));

			etterem[0].ItsDairyfree = true;
			etterem[1].ItsDairyfree = true;
			etterem[2].ItsDairyfree = true;
			etterem[3].ItsDairyfree = true;
			etterem[5].ItsDairyfree = true;
			etterem[6].ItsDairyfree = true;
			etterem[8].ItsDairyfree = true;

            Console.WriteLine($"Az összes étel össz kalóriája: {SumCalories(etterem)}");
            Console.WriteLine("Tejtelen termékek:");
            List<Etel> noDairy = Szuro(etterem);
			foreach ( Etel e in noDairy )
			{
				Console.WriteLine(e);
			}



        }
	}
}
