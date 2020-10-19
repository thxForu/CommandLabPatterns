namespace FactoryMethod
{
    abstract class Action
    {
        private string LinkAction;
        private string dateAction;
        private string descriptionAction;
        
        public Action (string link, string date, string description)
        {
            dateAction = date;
            descriptionAction = description;
            LinkAction = link;

        }
        
        public abstract IProduct PrintAction();
    }

    class ConcreteCreator1 : Action
    {

        public ConcreteCreator1(string link, string date, string description) : base(link, date, description)
        {
        }
        public override IProduct PrintAction()
        {
            return new Date();
        }
    }
    class ConcreteCreator2 : Action
    {
        public ConcreteCreator2(string link, string date, string description) : base(link, date, description)
        {
        }
        public override IProduct PrintAction()
        {
            return new Description();
        }
    }
}