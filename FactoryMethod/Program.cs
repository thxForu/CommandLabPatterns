using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string deskUkr = "Слава Україні";
            string deskEng = "Make America grate again";
            string date = "20.10.2020";
            string link = "www.google.com";

            Action action;
            string f = "asd";
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                action = new ConcreteCreator1(link,date,deskEng);
            }
            else
            {
                action = new ConcreteCreator2(link,date,deskUkr);
            }


            IProduct product = action.PrintAction();
            Console.WriteLine(product.Action());
        }
    }
}
