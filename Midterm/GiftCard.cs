using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class GiftCard : Product
    {
        string _amount;

        public GiftCard(string amount, string name, decimal price, int points) : base(name, price, points)
        {
            Amount = amount;
        }

        public string Amount { get => _amount; set => _amount = value; }

        public override string ToString()
        {
            return base.ToString() + $" - Gift Card Amount: {Amount}";
        }
    }
}
