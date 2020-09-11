using System;

namespace Decorator
{
    public class SimplyNonVegPizza : IPizza
    {
        public string Description { get; set; }
        public decimal Price { get; set; }

        public SimplyNonVegPizza()
        {
            Description = "SimplyNonVegPizza (350)";
            Price = 350;
        }

        public override string ToString()
        {
            return $"Desc: {Description}{Environment.NewLine}Price: {Price.ToString()}";
        }
    }
}