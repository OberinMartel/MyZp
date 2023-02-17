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
    /// Логика взаимодействия для WindowAuthorization.xaml
    /// </summary>
    public partial class WindowAuthorization : Window
    {
        MainWindow mainWindow;
        public WindowAuthorization()
        {
            InitializeComponent();
        }
        public WindowAuthorization(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }
        private void BtnAutorization_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(TBoxEMail.Text))
                errors.AppendLine("Укажите электронную почту.");
            if (string.IsNullOrEmpty(TBoxPassword.Text))
                errors.AppendLine("Укажите пароль.");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }



            try
            {
                foreach (Users user in KR_VPKSEntities.GetContext().Users)
                {
                    if (user.EMail == TBoxEMail.Text && user.Password == TBoxPassword.Text)
                    {
                        WindowUser userWindow = new WindowUser(mainWindow, user);
                        userWindow.Show();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Show();
            this.Close();
        }
    }
}
