using System;
/*Generics
 * Date : 06 NOV 2020
 * a class Box<> that can store anything.  */
namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BOX");
            //using int
            Box<int> box1 = new Box<int>();
            box1.Add(1);
            box1.Add(2);
            box1.Add(3);
            Console.WriteLine(box1.Remove());
            box1.Add(4);
            box1.Add(5);
            Console.WriteLine(box1.Remove());
            //using sting
            Box<String> box2 = new Box<String>();
            box2.Add("Dog");
            box2.Add("Cat");
            box2.Add("Lion");
            Console.WriteLine(box2.Remove());
            box2.Add("Tiger");
            box2.Add("Wolf");
            Console.WriteLine(box2.Remove());
        }

    }
}

