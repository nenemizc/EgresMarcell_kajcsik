using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kajcsik
{
	internal abstract class Etel
	{
		double caloriesPerDkg;
		double wheight;
		string name;

		protected Etel(double caloriesPerDkg, double wheight, string name)
		{
			this.caloriesPerDkg = caloriesPerDkg;
			this.wheight = wheight;
			this.name = name;
			ItsDairyfree = false;
		}

		public abstract double CountCalories();

		bool itsDairyfree;

		public bool ItsDairyfree { get => itsDairyfree; set => itsDairyfree = value; }
	}
}
