using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal abstract class Drink : Product
    {
        public enum _size { Short, Tall, Grande, Venti, Trenta};
        _size _drinkSize;

        public _size DrinkSize { get; }

        internal Drink(_size drinkSize, string name, decimal price, int points) : base(name, price, points)
        {
            _drinkSize = drinkSize;
        }

        public Drink(string name, decimal price, int points) : base(name, price, points)
        {

        }

        public override string ToString()
        {
            return base.ToString() + $" - Drink Size {_drinkSize}";
        }

    }
}
