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

namespace pervaya
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_NewPage(object sender, RoutedEventArgs e)
        {
            int a11 = int.Parse(a1.Text);
            int a22 = int.Parse(a2.Text);
            int a33 = int.Parse(a3.Text);
            int b11 = int.Parse(b1.Text);
            int b22 = int.Parse(b2.Text);
            int b33 = int.Parse(b3.Text);
            int c11 = int.Parse(c1.Text);
            int c22 = int.Parse(c2.Text);
            int c33 = int.Parse(c3.Text);
           int qwe = a11 * b22 * c33 + a22 * b33 * c11 + a33 * b11 * c22 - a33 * b22 * c11 - a11 * b33 * c22 - a22 * b11 * c33;
            string qwestring = Convert.ToString(qwe);
            ye.Text = qwestring;
        }
    }
}
