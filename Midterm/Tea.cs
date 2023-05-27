using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class Tea : Drink
    {
        string _teaType;

        public Tea(string teaType, string name, decimal price, int points) : base( name, price, points)
        {
            TeaType = teaType;
        }

        public string TeaType { get => _teaType; set => _teaType = value; }

        public override string ToString()
        {
            return $"{GetType().Name} - {TeaType}";
        }
    }
}
