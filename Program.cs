// Thomas J. Lauer
// MNSU MavPASS - CIS 122
// September 28, 2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_CIS122_20210928
{
	public class Program
	{
		public static void Main(string[] args)
		{
			List<Clothing> Inventory = new List<Clothing>();
			Inventory.Add(new Shirt());
			Inventory.Add(new Shirt());
			Inventory.Add(new Shirt());
			Inventory.Add(new Shirt());
			Inventory.Add(new Shirt());

			foreach(Clothing c in Inventory)
			{
				Console.WriteLine(c.ToString());
				c.Fold();
			}

			Console.ReadLine();
		}
	}
}
