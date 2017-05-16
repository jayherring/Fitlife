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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fitlife
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnPromo_Click(object sender, RoutedEventArgs e)
        {
            AddReview addreview = new AddReview();
            addreview.Show();
                
        }

        private void BtnEmp_Click(object sender, RoutedEventArgs e)
        {
            AddEmployee addemployee = new AddEmployee();
            addemployee.Show();
        }

        private void BtnFg_Click(object sender, RoutedEventArgs e)
        {
            AddFitnessGear addfitnessgear = new AddFitnessGear();
            addfitnessgear.Show();
        }

        private void BtnFC_Click(object sender, RoutedEventArgs e)
        {
            AddFitnessClass addfitnessclass = new AddFitnessClass();
            addfitnessclass.Show();

        }

        private void BtnPT_Click(object sender, RoutedEventArgs e)
        {
            AddPersonalTraining addpersonaltraining = new AddPersonalTraining();
            addpersonaltraining.Show();
        }

        private void BtnListReview_Click(object sender, RoutedEventArgs e)
        {
            ListReviews listreviews = new ListReviews();
            listreviews.Show();
        }

        private void BtnListEmp_Click(object sender, RoutedEventArgs e)
        {
            ListEmployees listemployees = new ListEmployees();
            listemployees.Show();
        }

        private void BtnListFG_Click(object sender, RoutedEventArgs e)
        {
            ListFitnessGear listfitnessgear = new ListFitnessGear();
            listfitnessgear.Show();
        }

        private void BtnListFC_Click(object sender, RoutedEventArgs e)
        {
            ListFitnessClasses listfitnessclasses = new ListFitnessClasses();
            listfitnessclasses.Show();
        }

        private void BtnListPT_Click(object sender, RoutedEventArgs e)
        {
            ListPersonalTraining listpersonaltraining = new ListPersonalTraining();
            listpersonaltraining.Show();
        }
    }
}
