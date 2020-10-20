using System;

namespace FactoryMethod
{
    abstract class Action
    {
        private string actionDate;
        private string actionLink;

        public Action(string date, string actionLink)
        {
            actionDate = date;
            this.actionLink = actionLink;
        }

        public IProduct Print()
        {
            Console.WriteLine("\nDate: {0}\nLink: {1}",actionDate,actionLink);
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
        public ConcreteCreator1(string date, string actionLink) : base(date, actionLink)
        {
        }
    }
    class ConcreteCreator2 : Action
    {
        public override IProduct GetDescription()
        {
            return new EnglishDescriptions();
        }

        public ConcreteCreator2(string date, string actionLink) : base(date, actionLink)
        {
        }
    }
}