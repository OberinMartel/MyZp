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
using MyZp.Windows;

namespace MyZp
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

        private void BtnRegisration_Click(object sender, RoutedEventArgs e)
        {
            WindowRegistration windowRegistration = new WindowRegistration(this);
            windowRegistration.Show();
            this.Hide();
        }

        private void BtnAuthorization_Click(object sender, RoutedEventArgs e)
        {
            WindowAuthorization windowAuthorization = new WindowAuthorization(this);
            windowAuthorization.Show();
            this.Hide();
        }

        private void BtnGuest_Click(object sender, RoutedEventArgs e)
        {
            WindowGuest windowGuest = new WindowGuest(this);
            windowGuest.Show();
            this.Hide();
        }
    }
}
