using System;
using System.Windows;
using System.Windows.Navigation;

namespace Tashkil
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : PageFunction<bool>
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {             
            Page1 page1 = new Page1();

            NavigationService.Navigate(page1);
        }
    }
}
