using Incapsulation.Protected;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation.Sealed;

sealed class Fish : Animal //Fish kan godt nedarve fra animal, men this is the end of the line
{
	public Fish()
	{
		Console.WriteLine("BLUBLUB");
	}
}
