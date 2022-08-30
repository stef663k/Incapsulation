using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation.Sealed;

public class Shark // : Fish //Shark kan ikke nedarve fra fish da den er sealed
{
	public Shark()
	{
		Console.WriteLine("RAWRCHUMP");
	}
}
