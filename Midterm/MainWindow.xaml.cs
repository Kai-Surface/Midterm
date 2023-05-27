//Kai Surface
// 5/26/23
// CSI!@$ Midterm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Midterm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            RegularMember member = new RegularMember("", "");

            cbMembers.ItemsSource = Data.Member;
            lbDisplayProducts.ItemsSource = Data.Product;

            // ItemsSource

            //Data.AddProductToCollection(tea);

            //Data.UpdateCurrentProduct(Data.Product[0]);

            //rg.AddPoints

            //rtbDispla.Text = member.Tostring();
            //Data.Products[0].toString
            //Data.CurrentProduct.ToString()
            //rg.ToString()
  
        }

        private void btnMemberInfo_Click(object sender, RoutedEventArgs e)
        {
           MemberInformation memberInformation = new MemberInformation();
            memberInformation.Show();
        }

        private void btnAddNewProduct_Click(object sender, RoutedEventArgs e)
        {
            AddNewProductWindow productPage = new AddNewProductWindow();
            productPage.Show();
        }

        private void cbMembers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //lbPreviousTransactions.Items.Display();
            //cbMembers.SelectedItem
            Member selectedMember = (Member)cbMembers.SelectedItem;
            Data.UpdateCurrentMember(selectedMember);

            lbPreviousTransactions.ItemsSource = Data.CurrentMember.PreviousTransactions;
        }

        private void btnBuyProduct_Click(object sender, RoutedEventArgs e)
        {
            if (Data.CurrentMember != null & Data.CurrentMember != null)
            {
                Data.CurrentMember.AddProduct(Data.CurrentProduct);
                Data.CurrentMember.AddPoints(Data.CurrentProduct);
                cbMembers.Items.Refresh();
            }
        }

        private void btnUsePoints_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lbDisplayProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Product currentlySelected = (Product)lbDisplayProducts.SelectedItem;
            Data.UpdateCurrentProduct(currentlySelected);
        }
    }
}
