using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Simple_Currency_App
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

        private void hitungButton_Click(object sender, RoutedEventArgs e)
        {
            var nominalString = inputTextBox.Text;

            Regex regex = new Regex("[^0-9.-]+");

            if (!regex.IsMatch(nominalString))
            {
                var nominalDouble = Convert.ToDouble(nominalString);
                resultLabel.Content = "Rp. " + Convert.ToString(nominalDouble * 4);
            }
            else
            {
                resultLabel.Content = "Inputan tidak valid";
            }
            
        }
    }
}
