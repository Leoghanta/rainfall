using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rainfall
{
	internal class YearlyData
	{
		Rainfall year2022 = new Rainfall();

		/// <summary>
		/// Constructor to add the yearly data to the array and display statistics for the year
		/// </summary>
		public YearlyData()
		{
			InputRainData();

			year2022.Display();

			//Print minimum rain fall
			Console.WriteLine($"Lowest rainfall this year was {year2022.Min()}");

			//Print maximum rain fall
			Console.WriteLine($"Highest rainfall this year was {year2022.Max()}");

			//Print Average rain fall
			Console.WriteLine($"Average rainfall this year was {year2022.Average()}");

			//How many had higher than average rainfall?
			Console.WriteLine($"{year2022.HigherThanAverage()} months had higher than average rainfall.");

			//How many had lower than average rainfall?
			Console.WriteLine($"{year2022.LowerThanAverage()} months had lower than average rainfall.");

			//Total rain fall
			Console.WriteLine($"This year had a total rainfall of {year2022.Total()}");

			//sort the rainfall
			Console.WriteLine("The sorted rainfall table is as follows:");
			year2022.Sort();

		}

		/// <summary>
		/// Input rain data into the array.
		/// TODO: add error checking using Valid Input algorithm.
		/// </summary>
		public void InputRainData()
		{
			int rainAmount = 0;
			string[] months = {"January","February", "March", "April", "May", "June",
					 		   "July", "August", "September", "October", "November", "December"};

			for (int i=0; i<12; i++) 
			{
				Console.Write($"Enter rainfall figure for {months[i]} >> ");
				string? input = Console.ReadLine();
				rainAmount = Convert.ToInt32( input );
				year2022.SetRain(i, rainAmount);
			}
		}
	}
}
