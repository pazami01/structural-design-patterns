using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class PizzaDecorator : IPizza
    {
        public string Description
        {
            get { return _pizza.Description; }
            set { _pizza.Description = value; }
        }
        public decimal Price
        {
            get { return _pizza.Price; }
            set { _pizza.Price = value; }
        }

        protected IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public override string ToString()
        {
            return _pizza.ToString();
        }
    }
}
