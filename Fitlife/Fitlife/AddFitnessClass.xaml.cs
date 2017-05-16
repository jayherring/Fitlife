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
    /// Interaction logic for AddFitnessClass.xaml
    /// </summary>
    public partial class AddFitnessClass : Window
    {
        public AddFitnessClass()
        {
            InitializeComponent();
        }

        private void BtnSubmitFC_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            AppCompute appcomp = new AppCompute();

            string[] strinput = new string[7];
            int nbrinput = 0;

            strinput[0] = txtfcidfc.Text;
            strinput[1] = txtempfc.Text;
            strinput[2] = txtorderfc.Text;
            strinput[3] = txtclassfc.Text;
            strinput[4] = txtdatesfc.Text;
            strinput[5] = txtpricefc.Text;
            strinput[6] = txtstatusfc.Text;

            nbrinput = 7;

            retval = appcomp.showData(strinput, nbrinput);
        }
    }
}
