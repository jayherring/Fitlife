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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnReview_Click(object sender, RoutedEventArgs e)
        {
            AddReview addreview = new AddReview();
            addreview.Show();

        }

        private void Btnpromo_Click(object sender, RoutedEventArgs e)
        {
            AddPromo addpromo = new AddPromo();
            addpromo.Show();
        }
    }
}
