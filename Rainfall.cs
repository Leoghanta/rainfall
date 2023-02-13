using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rainfall
{
	internal class Rainfall
	{
		private string[] months = {"January","February", "March", "April", "May", "June",
								   "July", "August", "September", "October", "November", "December"};
		private int[] rainfall = new int[12];


		/// <summary>
		/// Set the rainfall amount for a given month
		/// </summary>
		/// <param name="month">numeric value of month</param>
		/// <param name="rainAmount">amount of rainfall</param>
		public void SetRain(int month, int rainAmount)
		{
			rainfall[month] = rainAmount;
		}

		/// <summary>
		/// Display the monthly rainfall
		/// </summary>
		public void Display()
		{
			for (int i = 0; i < rainfall.Length; i++)
			{
				Console.WriteLine($"{months[i]} : {rainfall[i]}");
			}
		}

		
		public int Min()
		{
			Console.WriteLine("This data is not available");
			return 0;
		}

		/// <summary>
		/// Uncoded
		/// </summary>
		public int Max()
		{
			Console.WriteLine("This data is not available");
			return 0;
		}

		public double Average()
		{
			Console.WriteLine("This data is not available");
			return 0.0;
		}

		public int Total()
		{
			Console.WriteLine("This data is not available");
			return 0;
		}

		public int HigherThanAverage()
		{
			Console.WriteLine("This data is not available");
			return 0; 
		}

		public int LowerThanAverage()
		{
			Console.WriteLine("This data is not available");
			return 0;
		}

		public int FindMonthByRainfall(int rainAmount)
		{
			Console.WriteLine("This data is not available");
			return 0;
		}

		public void Sort()
		{
			Console.WriteLine("This data is not available");
		}

	}
}
