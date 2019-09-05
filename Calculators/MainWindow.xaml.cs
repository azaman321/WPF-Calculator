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

namespace Calculators
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


            int txt1 = int.Parse(textbox1.Text);
            int txt2 = int.Parse(textbox2.Text);
               int   answer = 0;

            if (ComboBox1.Text == "+")
                answer = (txt1 + txt2);
            else if (ComboBox1.Text == "-")
                answer = (txt1 - txt2);
            else if (ComboBox1.Text == "*")
                answer = (txt1 * txt2);
            else if (ComboBox1.Text == "/")
                answer = (txt1 / txt2);

            MessageBox.Show(answer.ToString());
        }
    }
}
