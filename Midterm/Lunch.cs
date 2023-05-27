using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class Lunch : Food
    {
        bool _isCombo;

        public Lunch(bool isCombo, bool isHeated, string name, decimal price, int points) : base(isHeated, name, price, points)
        {
            IsCombo = isCombo;
        }

        public bool IsCombo { get => _isCombo; set => _isCombo = value; }

        public override string ToString()
        {
            return base.ToString() + $" - Is Combo: {IsCombo}";
        }
    }
}
