using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Navigation;

namespace Tashkil
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private TashkilDataContext db = new TashkilDataContext();

        public Page1()
        {
            InitializeComponent();
         
            Centers.ItemsSource = db.Centers.Select(m => new
            {
                m.ID,
                m.Name,
                Url = "Center.xaml?ID=" + m.ID
            });
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

        private void Circle_OnClick(object sender, RoutedEventArgs e)
        {
            CircleForm circle = new CircleForm();
            circle.Return += circle_Return;
            NavigationService.Navigate(circle);
        }

        void circle_Return(object sender, ReturnEventArgs<string> e)
        {

        }

        private void CenterRow_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void EventSetter_OnHandler(object sender, RoutedEventArgs e)
        {
            var destination = ((Hyperlink)e.OriginalSource).NavigateUri;

            var index=destination.ToString().LastIndexOf('=');

            if (index > -1)
            {
                int id=int.Parse(destination.ToString().Substring(index + 1));
                var data = db.Centers.FirstOrDefault(c => c.ID == id);
                Center center = new Center(data);
                NavigationService.Navigate(center);
                //MessageBox.Show("click link "+destination);
            }
        }
    }
}
