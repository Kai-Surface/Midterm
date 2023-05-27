using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal abstract class Member
    {
        string _firstName;
        string _lastName;
        int _memberNumber;
        int _pointAmount;
        DateTime _memberSince;
        static ObservableCollection<Product> _previousTransactions;

        string generateMemberNumber;

        public ObservableCollection<Product> PreviousTransactions { get => _previousTransactions; }
        protected int PointAmount { get => _pointAmount; set => _pointAmount = value; }

        public Member(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            PointAmount = 0;
            _memberSince = DateTime.Now;
            _previousTransactions = new ObservableCollection<Product>();
        }

        public Member(int memberNumber)
        {
            Random random = new Random();
            int unique = random.Next((int)1000000, (int)10000000);
            generateMemberNumber = unique.ToString();
        }

        public abstract void DeductPoints(Product product);


        public abstract void AddPoints(Product product);


        public void AddProduct(Product product)
        {
            _previousTransactions.Add(product);
        }

        public override string ToString()
        {
            return $"{GetType().Name} - {_firstName}, {_lastName}, {PointAmount}, {_memberNumber}";
        }
    }
}
