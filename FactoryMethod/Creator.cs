namespace FactoryMethod
{
    abstract class Creator
    {
        public abstract IProduct Action();
    }

    class ConcreteCreator1 : Creator
    {
        public override IProduct Action()
        {
            return new Date();
        }
    }
    class ConcreteCreator2 : Creator
    {
        public override IProduct Action()
        {
            return new Description();
        }
    }
    class ConcreteCreator3 : Creator
    {
        public override IProduct Action()
        {
            return new Link();
        }
    }
}