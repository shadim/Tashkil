using System;
using System.Windows;
using System.Windows.Navigation;

namespace Tashkil
{
    /// <summary>
    /// Interaction logic for AddMosku.xaml
    /// </summary>
    public partial class AddMosku : PageFunction<String>
    {
        public AddMosku()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OnReturn(new ReturnEventArgs<String>("Add Successfully"));
        }


    }
}
