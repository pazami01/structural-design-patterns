namespace Decorator
{
    public class Cheese : PizzaDecorator
    {
        public Cheese(IPizza pizza) : base(pizza)
        {
            base.Description += ", Cheese (20.72)";
            base.Price += 20.72M;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}