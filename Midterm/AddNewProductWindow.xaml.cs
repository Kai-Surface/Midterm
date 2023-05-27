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
using System.Windows.Shapes;

namespace Midterm
{
    /// <summary>
    /// Interaction logic for AddNewProductWindow.xaml
    /// </summary>
    public partial class AddNewProductWindow : Window
    {
        public AddNewProductWindow()
        {
            InitializeComponent();
            lbProducts.ItemsSource = Data.Product;


            bool isChecked = ckIsHeated.IsChecked.Value;
            bool isChecked1 = ckHasDairy.IsChecked.Value;
        }

        private void btnAddCoffee_Click(object sender, RoutedEventArgs e)
        {
            Coffee._size size = (Coffee._size)cbSize.SelectedIndex;

            void PopulateSizeComboBox()
            {
                cbSize.Items.Add("Short");
                cbSize.Items.Add("Tall");
                cbSize.Items.Add("Grande");
                cbSize.Items.Add("Venti");
                cbSize.Items.Add("Trenta");
                cbSize.SelectedIndex = 0;
            }
        }

        private void btnAddTea_Click(object sender, RoutedEventArgs e)
        {
            Tea._size size = (Tea._size)cbSize.SelectedIndex;

            void PopulateSizeComboBox()
            {
                cbSize.Items.Add("Short");
                cbSize.Items.Add("Tall");
                cbSize.Items.Add("Grande");
                cbSize.Items.Add("Venti");
                cbSize.Items.Add("Trenta");
                cbSize.SelectedIndex = 0;
            }
        }
    }
}
