using System;

namespace Decorator
{
    public class SimplyVegPizza : IPizza
    {
        public string Description { get; set; }
        public decimal Price { get; set; }

        public SimplyVegPizza()
        {
            Description = "SimplyVegPizza (230)";
            Price = 230M;
        }

        public override string ToString()
        {
            return $"Desc: {Description}{Environment.NewLine}Price: {Price.ToString()}";
        }
    }
}