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
    /// Interaction logic for ListFitnessGear.xaml
    /// </summary>
    public partial class ListFitnessGear : Window
    {
        public ListFitnessGear()
        {
            InitializeComponent();
        }

        private void BtnListFG_Click(object sender, RoutedEventArgs e)
        {
            fitlifeDataSet dataset = new fitlifeDataSet();

            // use a table adapter to populate the review table
     
            fitlifeDataSetTableAdapters.FitnessGearTableAdapter adapter = new fitlifeDataSetTableAdapters.FitnessGearTableAdapter();
            adapter.Fill(dataset.FitnessGear);
            // use the Customer table as the DataContext for this Window
            FitnessGearDataGrid.ItemsSource = dataset.FitnessGear.DefaultView;
        }
    }
}
