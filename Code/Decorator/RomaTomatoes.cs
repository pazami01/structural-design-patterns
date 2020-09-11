namespace Decorator
{
    public class RomaTomatoes : PizzaDecorator
    {
        public RomaTomatoes(IPizza pizza) : base(pizza)
        {
            base.Description += ", Roma Tomatoes (5.20)";
            base.Price += 5.20M;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}