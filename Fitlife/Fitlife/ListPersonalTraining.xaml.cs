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
    /// Interaction logic for ListPersonalTraining.xaml
    /// </summary>
    public partial class ListPersonalTraining : Window
    {
        public ListPersonalTraining()
        {
            InitializeComponent();
        }

        private void BtnListPT_Click(object sender, RoutedEventArgs e)
        {
            fitlifeDataSet dataset = new fitlifeDataSet();

            // use a table adapter to populate the review table
           
            fitlifeDataSetTableAdapters.PersonalTrainingTableAdapter adapter = new fitlifeDataSetTableAdapters.PersonalTrainingTableAdapter();
            adapter.Fill(dataset.PersonalTraining);
            // use the Customer table as the DataContext for this Window
            PersonalTrainingDataGrid.ItemsSource = dataset.PersonalTraining.DefaultView;
        }
    }
}
