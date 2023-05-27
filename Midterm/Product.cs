using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal abstract class Product
    {
        Random rand = new Random();
        string _name;
        string _Sku;
        decimal _Price;
        int _points;
        static int _numberOfProduct;

        string _generateSku;

        public Product(string name, decimal price, int points)
        {
            Name = name;
            Price = price;
            Points = points;

            //Sku = rand.Next.(100000, 10000000);
        }

        public Product(int Sku)
        {
            Random random = new Random();
            int unique = random.Next((int)1000000, (int)10000000);
            _generateSku = unique.ToString();
        }

        public string Name { get => _name; set => _name = value; }
        public string Sku { get => _Sku; set => _Sku = value; }
        public decimal Price { get => _Price; set => _Price = value; }
        public int Points { get => _points; set => _points = value; }

        public override string ToString()
        {
            return $"{GetType().Name} - {Sku}, - {Name}, - {Price.ToString("c")}, - {Points}";
        }
    }
}
