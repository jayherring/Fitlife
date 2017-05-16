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
    /// Interaction logic for AddFitnessGear.xaml
    /// </summary>
    public partial class AddFitnessGear : Window
    {
        public AddFitnessGear()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            AppCompute appcomp = new AppCompute();

            string[] strinput = new string[7];
            int nbrinput = 0;

            strinput[0] = txtfgid.Text;
            strinput[1] = txtorder.Text;
            strinput[2] = txtitem.Text;
            strinput[3] = txtcolor.Text;
            strinput[4] = txtprice.Text;
            strinput[5] = txtpprice.Text;
            strinput[6] = txtstatus.Text;
            nbrinput = 7;

            retval = appcomp.showData(strinput, nbrinput);
        }
    }
}
