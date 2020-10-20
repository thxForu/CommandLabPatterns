using System;

namespace FactoryMethod
{
    class UkraineDescriptions: IProduct
    {
        public string GetDescriptions()
        {
            return "Вбивство Кенедi";
        }
    }

    class EnglishDescriptions : IProduct
    {
        public string GetDescriptions()
        {
            return "Kennedy assassination";
        }
    }
}