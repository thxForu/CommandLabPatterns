using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Action action;
            string actionType = "Death";
            string date = "22.11.1963";
            Console.WriteLine("Enter what leng u want");
            Console.WriteLine("1. Ukraine description\n2. English description");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                action = new ConcreteCreator1(date,actionType);
            }
            else
            {
                action = new ConcreteCreator2(date,actionType);
            }
            
            IProduct productPrint = action.Print();
            IProduct product = action.GetDescription();
            Console.WriteLine(product.GetDescriptions());
            Console.WriteLine(productPrint);
        }
    }
}
