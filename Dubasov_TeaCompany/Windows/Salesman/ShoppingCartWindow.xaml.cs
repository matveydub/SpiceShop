using Dubasov_TeaCompany.ClassHelper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Dubasov_TeaCompany.Windows.Salesman
{
    /// <summary>
    /// Логика взаимодействия для ShoppingCartWindow.xaml
    /// </summary>
    public partial class ShoppingCartWindow : Window
    {
        public ShoppingCartWindow()
        {
            InitializeComponent();
            SetListViewItems();
        }
        public void SetListViewItems()
        {
            ObservableCollection<DB.Product> listCart = new ObservableCollection<DB.Product>(ClassHelper.ProductCart.productCart);
            LvProductCart.ItemsSource = listCart.Distinct();
            TotalSum.totalSum = 0;
            foreach (var item in ClassHelper.ProductCart.productCart)
            {
                TotalSum.totalSum += Convert.ToInt32(item.Price) * item.Count;
            }
            TbTotalSum.Text = Convert.ToString(TotalSum.totalSum) + " ₽";
        }

        private void BtnDeleteCart_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            if (button == null)
            {
                return;
            }
            var product = button.DataContext as DB.Product;

            ClassHelper.ProductCart.productCart.Remove(product);

            product.Count = 0;

            SetListViewItems();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnCreateOrder_Click(object sender, RoutedEventArgs e)
        {

            DB.Order order = new DB.Order();
            order.OrderDate = DateTime.Now;
            order.EmployeeID = 1;
            order.ClientID = 1;
            ClassHelper.EF.Context.Order.Add(order);
            ClassHelper.EF.Context.SaveChanges();

            foreach (var item in ClassHelper.ProductCart.productCart.Distinct())
            {
                OrderProduct orderProduct = new OrderProduct();
                orderProduct.OrderID = order.ID;
                orderProduct.ProductID = item.ID;
                orderProduct.Quantity = item.Count;

                ClassHelper.EF.Context.OrderProduct.Add(orderProduct);
                ClassHelper.EF.Context.SaveChanges();
            }

            MessageBox.Show("Заказ успешно оформлен");
        }

        private void BtnLowerCart_Click(object sender, RoutedEventArgs e)
        {

            var button = sender as Button;

            if (button == null)
            {
                return;
            }
            var product = button.DataContext as DB.Product;

            if (product.Count > 1)
            {
                product.Count--;

                SetListViewItems();
            }

        }

        private void BtnHigherCart_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            if (button == null)
            {
                return;
            }
            var product = button.DataContext as DB.Product;

            if (product.Count < 20)
            {
                product.Count++;

                SetListViewItems();
            }
        }
    }
}
