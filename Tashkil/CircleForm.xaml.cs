using System;
using System.Windows;
using System.Windows.Navigation;

namespace Tashkil
{
    /// <summary>
    /// Interaction logic for CircleForm.xaml
    /// </summary>
    public partial class CircleForm : PageFunction<String>
    {
        public CircleForm()
        {
            InitializeComponent();
            
        }

        private void Save_OnClick(object sender, RoutedEventArgs e)
        {
            OnReturn(new ReturnEventArgs<string>());
        }
    }
}
