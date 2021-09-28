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

namespace Checkbox
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

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("True");
        }

        private void Checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("False");
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)checkBox1.IsChecked)
            {
                MessageBox.Show("True");
            }
            else
            {
                MessageBox.Show("False");
            }
        }

        private void CheckBox3_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox3.IsChecked == null)
            {
                MessageBox.Show("Check box 3 clicked.");
            }
        }
    }
}
