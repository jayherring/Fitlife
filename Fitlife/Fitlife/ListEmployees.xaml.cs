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
    /// Interaction logic for ListEmployees.xaml
    /// </summary>
    public partial class ListEmployees : Window
    {
        public ListEmployees()
        {
            InitializeComponent();
        }

        private void BtnListEmp_Click(object sender, RoutedEventArgs e)
        {
            fitlifeDataSet dataset = new fitlifeDataSet();

            // use a table adapter to populate the review table
          
            fitlifeDataSetTableAdapters.EmployeesTableAdapter adapter = new fitlifeDataSetTableAdapters.EmployeesTableAdapter();
            adapter.Fill(dataset.Employees);
            // use the Customer table as the DataContext for this Window
            ListEmpDataGrid.ItemsSource = dataset.Employees.DefaultView;
        }
    }
}
