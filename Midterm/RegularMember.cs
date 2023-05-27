using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class RegularMember : Member
    {
        public override void DeductPoints(Product product)
        {
            PointAmount += product.Points;
        }
        public override void AddPoints(Product product)
        {
            PointAmount += product.Points;
        }

        public RegularMember(string firstName, string lastName) : base(firstName, lastName)
        {
        }
    }
}
