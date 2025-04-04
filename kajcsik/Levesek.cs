using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kajcsik
{
	internal class Levesek : Etel
	{
		public Levesek(double caloriesPerDkg, double wheight, string name) : base(caloriesPerDkg, wheight, name)
		{
		}

		public override double CountCalories()
		{
			return caloriesPerDkg * wheight;//ha a súly deka
		}

		public override string ToString()
		{
			return $"{name} - {caloriesPerDkg} cal/dkg - {wheight} dkg - Its Dairy Free: {ItsDairyfree}";
		}
	}
}
