using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Tashkil
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //myFrame.Navigate(new Login());
           // Create(1);
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
