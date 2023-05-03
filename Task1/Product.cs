using System;

namespace Task1
{
    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; }

        public double Price { get; }

        public override bool Equals(object obj)
        {
            if (!(obj is Product item))
            {
                return false;
            }

            return Name.Equals(item.Name) && Price.Equals(item.Price);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price);
        }
    }
}
