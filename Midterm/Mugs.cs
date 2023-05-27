using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class Mugs : Merchandise
    {
        string _design;

        public Mugs(string design, string name, decimal price, int points) : base(name, price, points)
        {
            Design = design;
        }

        public string Design { get => _design; set => _design = value; }

        public override string ToString()
        {
            return base.ToString() + $" - Design: {Design}";
        }
    }
}