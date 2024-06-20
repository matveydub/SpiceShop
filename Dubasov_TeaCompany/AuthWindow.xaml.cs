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
using Dubasov_TeaCompany.Windows;
using Dubasov_TeaCompany.Windows.Admin;
using Dubasov_TeaCompany.Windows.Manager;
using Dubasov_TeaCompany.Windows.Salesman;

namespace Dubasov_TeaCompany
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public DB.Client userAuth;
        public AuthWindow()
        {
            InitializeComponent();
        }
        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            userAuth = ClassHelper.EF.Context.Client.ToList().
                Where(i => i.Login == TbLogin.Text && i.Password == PbPassword.Password).
                FirstOrDefault();

            if (userAuth != null)
            {
                if (userAuth.Login == 1)
                {
                    CreateOrderWindow createOrderWindow = new CreateOrderWindow();
                    this.Close();
                    createOrderWindow.ShowDialog();
                }
                else if (userAuth.Login == 2)
                {
                    ManagerMenu managerMenu = new ManagerMenu();
                    this.Close();
                    managerMenu.ShowDialog();
                }
                else if (userAuth.Login == 3)
                {
                    AdminMenu adminMenu = new AdminMenu();
                    this.Close();
                    adminMenu.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Неправильно введен логин или пароль", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void BtnReg_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            this.Hide();
            registrationWindow.ShowDialog();
            this.Show();
        }
    }
}
