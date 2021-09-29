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
	public sealed class Socks : Clothing
	{
		// Variables
		private string size = "n/a";
		private string style = "n/a";

		// Properties
		public string Size { get { return this.size; } set { this.size = value; } }
		public string Style { get { return this.style; } set { this.style = value; } }

		// Constructors
		public Socks() : this("n/a", "n/a", -1, "n/a", "n/a", "n/a", "n/a", Double.MaxValue) { }

		public Socks(string aSize, string aStyle, int anId, string aCategory, string aBrand, string aColor, string aMaterial, double aPrice) :
			base(anId, aCategory, aBrand, aColor, aMaterial, aPrice)
		{
			this.Size = aSize;
			this.Style = aStyle;
		}

		// Methods
		public override void Fold()
		{
			Console.WriteLine("Folding a pair of socks.\n");
		}

		public override string ToString()
		{
			string msg = "";
			msg += base.ToString();
			msg += "\n";
			msg += "Size: " + this.Size + "\n";
			msg += "Design: " + this.Style + "\n";
			return msg;
		}
	}
}
