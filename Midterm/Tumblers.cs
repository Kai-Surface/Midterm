using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class Tumblers : Merchandise
    {
        string _color;

        public Tumblers(string color, string name, decimal price, int points) : base(name, price, points)
        {
            Color = color;
        }

        public string Color { get => _color; set => _color = value; }

        public override string ToString()
        {
            return base.ToString() + $" - Color: {Color}";
        }
    }
}
