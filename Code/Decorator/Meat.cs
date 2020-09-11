namespace Decorator
{
    public class Meat : PizzaDecorator
    {
        public Meat(IPizza pizza) : base(pizza)
        {
            base.Description += ", Meat (14.25)";
            base.Price += 14.25M;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}