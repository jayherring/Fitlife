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
    /// Interaction logic for AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void BtnSubmitEMP_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            AppCompute appcomp = new AppCompute();

            string[] strinput = new string[4];
            int nbrinput = 0;

            strinput[0] = txtempid.Text;
            strinput[1] = txtempfn.Text;
            strinput[2] = txtempln.Text;
            strinput[3] = txtemail.Text;

            nbrinput = 4;

            retval = appcomp.showData(strinput, nbrinput);
        }

        private void txtemail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
