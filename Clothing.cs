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
	public abstract class Clothing
	{
		private int id = -1;
		private string category = "n/a";
		private string brand = "n/a";
		private string color = "n/a";
		private string material = "n/a";
		private double price = Double.MaxValue;

		// Gets and sets
		public int Id { get { return this.id; } set { this.id = value; } }
		public string Category { get { return this.category; } set { this.category = value; } }
		public string Brand { get { return this.brand; } set { this.brand = value; } }
		public string Color { get { return this.color; } set { this.color = value; } }
		public string Material { get { return this.material; } set { this.material = value; } }
		public double Price { get { return this.price; } set { this.price = value; } }

		public Clothing() : this(-1, "n/a", "n/a", "n/a", "n/a", Double.MaxValue) { }

		public Clothing(int anId, string aCategory, string aBrand, string aColor, string aMaterial, double aPrice)
		{
			this.Id = anId;
			this.Category = aCategory;
			this.Brand = aBrand;
			this.Color = aColor;
			this.Material = aMaterial;
			this.Price = aPrice;
		}

		public virtual void Fold()
		{
			Console.WriteLine("Base folding action.\n");
		}

		public override string ToString()
		{
			string msg = "";
			msg += "Id: " + this.Id + "\n";
			msg += "Category: " + this.Category + "\n";
			msg += "Brand: " + this.Brand + "\n";
			msg += "Color: " + this.Color + "\n";
			msg += "Material: " + this.Material + "\n";
			msg += "Price: " + this.Price + "\n";
			return msg;
		}

	}
}
