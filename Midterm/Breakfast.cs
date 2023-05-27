using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class Breakfast : Food
    {
        bool _hasDairy;

        public Breakfast(bool hasDairy, bool isHeated, string name, decimal price, int points) : base(isHeated, name, price, points)
        {
            HasDairy = hasDairy;
        }

        public bool HasDairy { get => _hasDairy; set => _hasDairy = value; }

        public override string ToString()
        {
            return base.ToString() + $" - Has Dairy: {HasDairy}";
        }
    }
}
