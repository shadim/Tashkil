using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Tashkil
{
    /// <summary>
    /// Interaction logic for HistoryLog.xaml
    /// </summary>
    public partial class HistoryLog : Page
    {
        class HistoryViewModel
        {
            private readonly TashkilDataContext _db = new TashkilDataContext();

            public ObservableCollection<History> Histories { get; private set; }
            public Table<Mosku> Moskus { get; private set; }

            public HistoryViewModel()
            {
                Histories = new ObservableCollection<History>(_db.Histories);
                Moskus = _db.Moskus;
            }

            public void Insert(int source, int destination, DateTime dateTime)
            {
                var newEntry = new History
                {
                    Source = source,
                    Destination = destination,
                    Date = dateTime
                };
                _db.Histories.InsertOnSubmit(newEntry);
                _db.SubmitChanges();
                Histories.Add(newEntry);
            }
        }


        private readonly HistoryViewModel _model = new HistoryViewModel();

        public HistoryLog()
        {
            InitializeComponent();
            DataContext = _model;
            GrdHistory.ItemsSource = _model.Histories;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _model.Insert(
                int.Parse(fromMosku.SelectedValue.ToString()),
                int.Parse(toMosku.SelectedValue.ToString()),
                DateTime.Now);

        }
    }
}
