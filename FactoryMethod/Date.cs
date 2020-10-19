using System;

namespace FactoryMethod
{
    public class Date : IProduct
    {
        public string Action(string type)
        {
            return "Hi, i'm Date";
        }
    }
    public class Description : IProduct
    {
        public string Action(string desk)
        {
            return "Hi, i'm Description";
        }
    }
    public class Link : IProduct
    {
        public string Action(string link)
        {
            return "Hi, i'm Link (https://www.google.com/search?q=funny+cats)";
        }
    }
}