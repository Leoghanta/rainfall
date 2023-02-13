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

		/// <summary>
		/// Calculate and return the minimum rainfall
		/// TODO: Use the find minimum algorithm to calculate
		/// </summary>
		/// <returns>Minimum value as Integer</returns>
		public int Min()
		{
			Console.WriteLine("This data is not available");
			return 0;
		}


		/// <summary>
		/// Calculate and return the maximum rainfall
		/// TODO: Use the find maximum algorithm to calculate
		/// </summary>
		/// <returns>Maximum value as integer</returns>
		public int Max()
		{
			Console.WriteLine("This data is not available");
			return 0;
		}


		/// <summary>
		/// Calculate the average for the year
		/// TODO: use sum and average algorithms to complete
		/// </summary>
		/// <returns>Average value as double</returns>
		public double Average()
		{
			Console.WriteLine("This data is not available");
			return 0.0;
		}


		/// <summary>
		/// Calculate the total rainfall for the year
		/// TODO: sum up all the rainfall in the array
		/// </summary>
		/// <returns>Total value as integer</returns>
		public int Total()
		{
			Console.WriteLine("This data is not available");
			return 0;
		}

		
		/// <summary>
		/// Count all the months with higher than average rainfall
		/// TODO: find average and count algorithm to complete
		/// </summary>
		/// <returns>Number of months as integer</returns>
		public int HigherThanAverage()
		{
			Console.WriteLine("This data is not available");
			return 0; 
		}

		/// <summary>
		/// Count all the months with lower than average rainfall
		/// TODO: find average and count algorithm to complete
		/// </summary>
		/// <returns>Number of months as integer</returns>
		public int LowerThanAverage()
		{
			Console.WriteLine("This data is not available");
			return 0;
		}


		/// <summary>
		/// Find the month by an amount of rainfall...
		/// TODO: Use Linear Search algorithm to locate Rain Amount
		/// </summary>
		/// <param name="rainAmount"></param>
		/// <returns>Returns month as integer when found, or -1 if not found</returns>
		public int FindMonthByRainfall(int rainAmount)
		{
			Console.WriteLine("This data is not available");
			return 0;
		}


		/// <summary>
		/// Sort the rainfall into ascending order and print to screen
		/// TODO: use Bubble Sort algorithm to sort the array 
		///       take a copy of the array to sort so values are not distorted
		/// </summary>
		public void Sort()
		{
			Console.WriteLine("This data is not available");
		}

	}
}
