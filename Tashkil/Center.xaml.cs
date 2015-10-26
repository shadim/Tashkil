using System;
using System.Linq;
using System.Net.Sockets;
using System.Windows;
using System.Windows.Navigation;

namespace Tashkil
{
    /// <summary>
    /// Interaction logic for Center.xaml
    /// </summary>
    public partial class Center : PageFunction<String>
    {
        private readonly TashkilDataContext _db = new TashkilDataContext();

        public Center(Center center)
        {
            InitializeComponent();
            DataContext = center;

            var moskus = _db.Moskus.Where(m => m.MarkazID == center.ID);
            var circles = _db.Circles.Where(c => c.MarkazID == center.ID)
                //                .GroupBy(x => x.ID)
                .Select(c => new
                {
                    c.ID,
                    c.Name,
                    MoskusCount = moskus.Count(m => m.HalakaID == c.ID),
                    MuslimCount = moskus.Where(m => m.HalakaID == c.ID).Sum(m => m.MuslimCount),
                    PrayerCount = moskus.Where(m => m.HalakaID == c.ID).Sum(m => m.PrayerCount),
                    MemberCount = moskus.Where(m => m.HalakaID == c.ID).Sum(m => m.MemberCount),
                    Url = "CircleForm.xaml?ID=" + c.ID,
                    Moskus = moskus.Where(m => m.HalakaID == c.ID)
                });

            GrdCircles.ItemsSource = circles;


        }

        private void CicleHyperlink_OnClick(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void MoskuHyperlink_OnClick(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
        }
    }
}
