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
    /// Interaction logic for AddPersonalTraining.xaml
    /// </summary>
    public partial class AddPersonalTraining : Window
    {
        public AddPersonalTraining()
        {
            InitializeComponent();
        }

        private void BtnSubmitPT_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            AppCompute appcomp = new AppCompute();

            string[] strinput = new string[6];
            int nbrinput = 0;

            strinput[0] = txtptid.Text;
            strinput[1] = txtempidpt.Text;
            strinput[2] = txtcustidpt.Text;
            strinput[3] = txtorderidpt.Text;
            strinput[4] = txtnum.Text;
            strinput[5] = txtpricept.Text;
            nbrinput = 6;

            retval = appcomp.showData(strinput, nbrinput);
        }
    }
}
