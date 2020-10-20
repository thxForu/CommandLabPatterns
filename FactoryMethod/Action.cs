using System;

namespace FactoryMethod
{
    abstract class Action
    {
        private string actionDate;
        private string actionType;

        public Action(string date, string action)
        {
            actionDate = date;
            actionType = action;
        }

        public IProduct Print()
        {
            Console.WriteLine("\nDate: {0}\nAction: {1}",actionDate,actionType);
            return null;
        }
        public abstract IProduct GetDescription();
    }

    class ConcreteCreator1 : Action
    {
        public override IProduct GetDescription()
        {
            return new UkraineDescriptions();
        }
        public ConcreteCreator1(string date, string action) : base(date, action)
        {
        }
    }
    class ConcreteCreator2 : Action
    {
        public override IProduct GetDescription()
        {
            return new EnglishDescriptions();
        }

        public ConcreteCreator2(string date, string action) : base(date, action)
        {
        }
    }
}