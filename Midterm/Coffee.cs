using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class Coffee : Drink
    {
        public string _roastType;

        public Coffee(string roastType, _size drinkSize, string name, decimal price, int points) : base(drinkSize, name, price, points)
        {
            RoastType = roastType;
        }

        public string RoastType { get => _roastType; set => _roastType = value; }

        public override string ToString()
        {
            return base.ToString() + $" - Roast Type {_roastType}";
        }

    }
}
