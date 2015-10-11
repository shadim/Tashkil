using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Tashkil
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }


        private void Moskulink_OnClick(object sender, RoutedEventArgs e)
        {
            AddMosku addMosku = new AddMosku();
            addMosku.Return += AddMosku_Return;
            NavigationService.Navigate(addMosku);
        }

        void AddMosku_Return(object sender, ReturnEventArgs<string> e)
        {
            MessageBox.Show(e.Result);
        }
    }
}
