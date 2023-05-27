using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class GoldMember : Member
    {
        public override void DeductPoints(Product product)
        {
            PointAmount += (product.Points / 2) - 50;
        }
        public override void AddPoints(Product product)
        {
            PointAmount += product.Points + 50;
        }


        public GoldMember(string firstName, string lastName) : base(firstName, lastName)
        {
        }
    }
}
