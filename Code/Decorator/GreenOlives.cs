namespace Decorator
{
    public class GreenOlives : PizzaDecorator
    {
        public GreenOlives(IPizza pizza) : base(pizza)
        {
            base.Description += ", Green Olives (5.47)";
            base.Price += 5.47M;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}