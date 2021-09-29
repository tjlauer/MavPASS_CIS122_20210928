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
	public sealed class Shirt : Clothing
	{
		// Variables
		private string size = "n/a";
		private string design = "n/a";
		private string type = "n/a";

		// Properties
		public string Size { get { return this.size; } set { this.size = value; } }
		public string Design { get { return this.design; } set { this.design = value; } }
		public string Type { get { return this.type; } set { this.type = value; } }

		// Constructors
		public Shirt() : this("n/a", "n/a", "n/a", -1, "n/a", "n/a", "n/a", "n/a", Double.MaxValue) { }

		public Shirt(string aSize, string aDesign, string aType, int anId, string aCategory, string aBrand, string aColor, string aMaterial, double aPrice) : 
			base(anId, aCategory, aBrand, aColor, aMaterial, aPrice)
		{
			this.Size = aSize;
			this.Design = aDesign;
			this.Type = aType;
		}

		// Methods
		public override void Fold()
		{
			Console.WriteLine("Folding a shirt.\n");
		}

		public override string ToString()
		{
			string msg = "";
			msg += base.ToString();
			msg += "Size: " + this.Size + "\n";
			msg += "Design: " + this.Design + "\n";
			msg += "Type: " + this.Type + "\n";
			return msg;
		}
	}
}
