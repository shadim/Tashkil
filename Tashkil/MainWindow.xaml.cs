using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;

namespace Tashkil
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Login login = new Login();
            login.Return += new ReturnEventHandler<bool>(login_Return);
            NavigationService.Navigate(login);
            //myFrame.Navigate(login);
            // Create(1);
        }

        private void login_Return(object sender, ReturnEventArgs<bool> e)
        {
            MessageBox.Show("aasdlfkjasldfjasdf");
        }

        //public void Create(int rows)
        //{
        //    TashkilDataContext db = new TashkilDataContext();
        //    var markaz = db.Markazs.ToArray();

        //    Grid newGrid = new Grid();

        //    for (int i = 0; i < rows; i++)
        //        newGrid.RowDefinitions.Add(new RowDefinition());

        //    for (int i = 0; i < markaz.Count(); i++)
        //        newGrid.ColumnDefinitions.Add(new ColumnDefinition());

        //    for (int x = 0; x < rows; x++)
        //        for (int y = 0; y < markaz.Count(); y++)
        //        {
        //            Button btn = new Button
        //            {
        //                Height = display.Height/rows,
        //                Width = display.Width/markaz.Count(),
        //                Content = markaz[y].Name                      
        //            };
        //            Grid.SetColumn(btn, y);
        //            Grid.SetRow(btn, x);
        //            newGrid.Children.Add(btn);
        //        }

        //    display.Children.Add(newGrid);
        //}

        void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
