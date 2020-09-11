using System;

namespace Bridge
{
    public class Motoren : Car
    {
        public Motoren(IProduct product, string v) : base(product, v)
        {
        }

        public override void Assemble()
        {
            Console.WriteLine($"Assembling {base.Product.ProductName} for {base.CarType}");
        }

        public override void ProduceProduct()
        {
            base.Product.Produce();
            Console.WriteLine($"Modifying product {base.Product.ProductName} according to {base.CarType}");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}