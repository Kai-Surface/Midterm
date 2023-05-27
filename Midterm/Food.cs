using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal abstract class Food : Product
    {
        bool _isHeated;

        public Food(bool isHeated, string name, decimal price, int points) : base(name, price, points)
        {
            IsHeated = isHeated;
        }

        public bool IsHeated { get => _isHeated; set => _isHeated = value; }

        public override string ToString()
        {
            return base.ToString() + $" - Is Heated : {IsHeated}";
        }
    }
}
