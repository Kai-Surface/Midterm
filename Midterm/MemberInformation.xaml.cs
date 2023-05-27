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
    /// Interaction logic for MemberInformation.xaml
    /// </summary>
    public partial class MemberInformation : Window
    {
        public MemberInformation()
        {
            InitializeComponent();

            lbMembers.ItemsSource = Data.Member;
        }

        private void lbMembers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Member selectedMember = (Member)lbMembers.SelectedItem;
            Data.UpdateCurrentMember(selectedMember);

            lbTransactionHistory.ItemsSource = Data.CurrentMember.PreviousTransactions;
        }

        private void btnAddMember_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();

            if(rand.Next(0,2) == 0)
            {
                Data.AddMemberToCollection(new GoldMember("", ""));
            }
            else
            {
                Data.AddMemberToCollection(new RegularMember("", ""));
            }
        }
    }
}
