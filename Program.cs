using Incapsulation.Abstract;
using Incapsulation.Protected;
using Incapsulation.Sealed;
using Incapsulation.Static;

namespace Incapsulation;


class Incapsulation
{
    public static void Main(String[] args)
    {
        var animal = new Mammal();
        //animal.B = 1;
        //Console.WriteLine(AnimalCat.cat);
        var dog = new Dog();
        Console.WriteLine(dog);
        var shark = new Shark();
        Console.WriteLine(shark);
    }
}