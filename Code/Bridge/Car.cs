using System.Net.Http.Headers;

namespace Bridge
{
    public abstract class Car
    {
        public IProduct Product { get; private set; }
        public string CarType { get; private set; }

        public Car(IProduct product, string carType)
        {
            Product = product;
            CarType = carType;
        }
        
        public abstract void Assemble();
        public abstract void ProduceProduct();

        public override string ToString()
        {
            return $"Car: {CarType}, {Product.ToString()}";
        }
    }
}