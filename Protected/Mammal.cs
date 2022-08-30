using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation.Protected;

 class Mammal : Animal
{
    public Mammal()
    {
        var animal = new Mammal();
        animal.A = null;
        animal.B = null;
    }
}
