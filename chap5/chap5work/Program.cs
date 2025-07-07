using static System.Console;
using System.Linq;
using System.IO.Compression;
using static System.DateTime;


public class Animal
    {
        public virtual
         void speak()
        {
            System.Console.WriteLine("Grunt");
        }
    }

    public class Dog : Animal
    {
        public override void speak()
        {
            System.Console.WriteLine("Woof");
        }
    }
public class ChapWork
{
    public static void Main()
    {
        Animal d = new Dog();
        d.speak();

        Dog d1 = new Dog();
        d1.speak();

        Animal a = new Animal();
        a.speak();
    }
}