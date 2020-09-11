namespace Decorator
{
    public class Ham : PizzaDecorator
    {
        public Ham(IPizza pizza) : base(pizza)
        {
            base.Description += ", Ham (18.12)";
            base.Price += 18.12M;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}