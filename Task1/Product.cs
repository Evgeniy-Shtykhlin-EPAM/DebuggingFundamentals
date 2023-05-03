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

        public string Name { get; set; }

        public double Price { get; set; }

        public override bool Equals(object obj)
        {
            var item = obj as Product;

            if (item == null)
            {
                return false;
            }

            if (Name.Equals(item.Name) && Price.Equals(item.Price))
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price);
        }
    }
}
