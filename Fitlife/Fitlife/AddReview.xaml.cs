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
    /// Interaction logic for AddReview.xaml
    /// </summary>
    public partial class AddReview : Window
    {
        public AddReview()
        {
            InitializeComponent();
        }

        private void BtnSubmitR_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            AppCompute appcomp = new AppCompute();

            string[] strinput = new string[4];
            int nbrinput = 0;

            strinput[0] = txtcustidr.Text;
            strinput[1] = txtraiting.Text;
            strinput[2] = txtdatar.Text;
            strinput[3] = txtnotesr.Text;
            nbrinput = 4;

            retval = appcomp.showData(strinput, nbrinput);
        }
    }
}
