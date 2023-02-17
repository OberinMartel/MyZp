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
    /// Логика взаимодействия для WindowRegistration.xaml
    /// </summary>
    public partial class WindowRegistration : Window
    {
        MainWindow mainWindow;
        public WindowRegistration()
        {
            InitializeComponent();
        }
        public WindowRegistration(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(TBoxEMail.Text))
                errors.AppendLine("Укажите электронную почту.");
            if (string.IsNullOrEmpty(TBoxPassword.Text))
                errors.AppendLine("Укажите пароль.");
            if (string.IsNullOrEmpty(TBoxName.Text))
                errors.AppendLine("Укажите имя пользователя.");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            Users _currentUser = new Users();
            _currentUser.UserName = TBoxName.Text;
            _currentUser.EMail = TBoxEMail.Text;
            _currentUser.Password = TBoxPassword.Text;
            KR_VPKSEntities.GetContext().Users.Add(_currentUser);

            try
            {
                bool flag = true;
                foreach (Users u in KR_VPKSEntities.GetContext().Users.ToList())
                {
                    if (u.EMail == TBoxEMail.Text) flag = false;
                }
                if (flag)
                {
                    KR_VPKSEntities.GetContext().SaveChanges();
                    MessageBox.Show("Информация сохранена!");
                    mainWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Пользователь с таким логином уже существует.");
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
