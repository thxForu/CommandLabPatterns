using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator;
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                creator = new ConcreteCreator1();
            }
            else if (n == 2)
            {
                creator = new ConcreteCreator2();
            }
            else
            {
                creator = new ConcreteCreator3();
            }

            IProduct product = creator.Action();
            Console.WriteLine(product.Action());
        }
    }
}
