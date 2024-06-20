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

namespace Dubasov_TeaCompany
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }
        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbLogin.Text))
            {
                MessageBox.Show("Ошибка! Пустое поле!");
                return;
            }
            if (string.IsNullOrEmpty(PbPassword.Password))
            {
                MessageBox.Show("Ошибка! Пустое поле!");
                return;
            }
            if (string.IsNullOrEmpty(TbFirstName.Text))
            {
                MessageBox.Show("Ошибка! Пустое поле!");
                return;
            }
            if (string.IsNullOrEmpty(TbLastName.Text))
            {
                MessageBox.Show("Ошибка! Пустое поле!");
                return;
            }
            if (string.IsNullOrEmpty(TbPhone.Text))
            {
                MessageBox.Show("Ошибка! Пустое поле!");
                return;
            }
            DB.Employee addEmployee = new DB.Employee();
            addEmployee.Login = TbLogin.Text;
            addEmployee.Password = PbPassword.Password;
            addEmployee.FirstName = TbFirstName.Text;
            addEmployee.LastName = TbLastName.Text;
            if (TbPatronymic.Text != string.Empty)
            {
                addEmployee.Patronymic = TbPatronymic.Text;
            }
            addEmployee.Phone = TbPhone.Text;
            addEmployee.GenderCode = (CmbGender.SelectedItem as DB.Gender).Name;
            addEmployee.PositionID = 1;
            ClassHelper.EF.Context.Employee.Add(addEmployee);

            
            ClassHelper.EF.Context.SaveChanges();
            MessageBox.Show("Регистрация успешна!");
            this.Close();
        }
    }
}
