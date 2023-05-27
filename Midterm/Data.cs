using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    static class Data
    {
        static ObservableCollection<Member> _member;
        static ObservableCollection<Product> _product;
        static Product currentProduct = null;
        static Member currentMember = null;

        internal static ObservableCollection<Member> Member { get => Member; }
        internal static ObservableCollection<Product> Product { get => Product; }

        internal static Product CurrentProduct { get => currentProduct;  }
        internal static Member CurrentMember { get => currentMember;  }

        static Data()
        {
            _member = new ObservableCollection<Member>();
            _product = new ObservableCollection<Product>();

            Preload();
        }

        public static void Preload()
        {
            _member.Add(new GoldMember("Will", "Cram"));

            //_product.Add(new Coffee());

            // Loading Products into members
            _member[0].AddProduct( _product[0]);
            _member[1].AddProduct( _product[1]);
        }

        public static void AddProductToCollection(Product product)
        {
            _product.Add(product);
        }

        public static void AddMemberToCollection(Member member)
        {
            _member.Add(member);
        }

        public static void UpdateCurrentProduct(Product product)
        {
            currentProduct = product;
        }

        public static void UpdateCurrentMember(Member member)
        {
            currentMember = member;
        }

        //cbMembers.ItemsSource = Member;
    }
}
