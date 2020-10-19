using System;

namespace FactoryMethod
{
    public class Date : IProduct
    {
        public string Action()
        {
            return "Hi, i'm Date";
        }
    }
    public class Description : IProduct
    {
        public string Action()
        {
            return "Hi, i'm Description";
        }
    }
    public class Link : IProduct
    {
        public string Action()
        {
            return "Hi, i'm Link (https://www.google.com/search?q=funny+cats)";
        }
    }
}