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

namespace MyZp.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowUser.xaml
    /// </summary>
    public partial class WindowUser : Window
    {
        Users user = new Users();
        Window MainWindow = new MainWindow();
        public WindowUser()
        {
            InitializeComponent();
        }
        public WindowUser(Window window, Users user)
        {
            InitializeComponent();
            this.MainWindow = window;
            this.user = user;
        }
        private void ImgHome_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new HomePage());
            ImgSwitch(1);
        }

        private void ImgProfile_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new ProfilePage());
            ImgSwitch(2);
        }

        private void ImgWork_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new WorkPage());
            ImgSwitch(3);
        }

        private void ImgFriends_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new FriendsPage());
            ImgSwitch(4);
        }

        private void ImgExit_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
            mainWindow.Show();
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {

        }
        private void ImgSwitch(int num)
        {
            ImgHome.Visibility = Visibility.Visible;
            ImgProfile.Visibility = Visibility.Visible;
            ImgWork.Visibility = Visibility.Visible;
            ImgFriends.Visibility = Visibility.Visible;
            if (num == 1)
            {
                ImgHome.Visibility = Visibility.Hidden;
            }
            if (num == 2)
            {
                ImgProfile.Visibility = Visibility.Hidden;
            }
            if (num == 3)
            {
                ImgWork.Visibility = Visibility.Hidden;
            }
            if (num == 4)
            {
                ImgFriends.Visibility = Visibility.Hidden;
            }
        }
    }
}
