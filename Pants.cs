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
	public sealed class Pants : Clothing
	{
		// Variables
		private int waist = -1;
		private int length = -1;
		private string style = "n/a";

		// Properties
		public int Waist { get { return this.waist; } set { this.waist = value; } }
		public int Length { get { return this.length; } set { this.length = value; } }
		public string Style { get { return this.style; } set { this.style = value; } }

		// Constructors
		public Pants() : this(-1, -1, "n/a", -1, "n/a", "n/a", "n/a", "n/a", Double.MaxValue) { }

		public Pants(int aWaist, int aLength, string aStyle, int anId, string aCategory, string aBrand, string aColor, string aMaterial, double aPrice) :
			base(anId, aCategory, aBrand, aColor, aMaterial, aPrice)
		{
			this.Waist = aWaist;
			this.Length = aLength;
			this.Style = aStyle;
		}

		// Methods
		public override void Fold()
		{
			Console.WriteLine("Folding a pair of pants.\n");
		}

		public override string ToString()
		{
			string msg = "";
			msg += base.ToString();
			msg += "\n";
			msg += "Waist: " + this.Waist + "\n";
			msg += "Length: " + this.Length + "\n";
			msg += "Style: " + this.Style + "\n";
			return msg;
		}
	}
}
