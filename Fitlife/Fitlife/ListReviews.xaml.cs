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

namespace Fitlife
{
    /// <summary>
    /// Interaction logic for ListReviews.xaml
    /// </summary>
    public partial class ListReviews : Window
    {
        public ListReviews()
        {
            InitializeComponent();
        }

        private void BtnViewReviews_Click(object sender, RoutedEventArgs e)
        {
            fitlifeDataSet dataset = new fitlifeDataSet();

            // use a table adapter to populate the review table
            fitlifeDataSetTableAdapters.ReviewsTableAdapter adapter = new fitlifeDataSetTableAdapters.ReviewsTableAdapter();

            adapter.Fill(dataset.Reviews);
            // use the Customer table as the DataContext for this Window
            reviewdataGrid.ItemsSource = dataset.Reviews.DefaultView;
        }
    }
}
