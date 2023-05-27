using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal abstract class Merchandise : Product
    {
        public Merchandise(string name, decimal price, int points) : base(name, price, points)
        {
        }
    }
}
