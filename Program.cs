using Incapsulation.Protected;
using Incapsulation.Static;

namespace Incapsulation;


class Incapsulation
{
    public static void Main(String[] args)
    {
        var animal = new Mammal();
        animal.B = 1;
        Console.WriteLine(AnimalCat.cat);
    }
}