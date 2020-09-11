namespace Decorator
{
    public class Spinach : PizzaDecorator
    {
        public Spinach(IPizza pizza) : base(pizza)
        {
            base.Description += ", Spinach (7.92)";
            base.Price += 7.92M;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}