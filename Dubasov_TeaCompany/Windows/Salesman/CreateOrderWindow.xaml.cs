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

namespace Dubasov_TeaCompany.Windows.Salesman
{
    /// <summary>
    /// Логика взаимодействия для CreateOrderWindow.xaml
    /// </summary>
    public partial class CreateOrderWindow : Window
    {
        public CreateOrderWindow()
        {
            GetListProduct();
            InitializeComponent();
        }
        public void GetListProduct()
        {
            LvProduct.ItemsSource = ClassHelper.EF.Context.Product.ToList();
        }
        private void BtnAddToCart_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            if (button == null)
            {
                return;
            }
            var Product = button.DataContext as DB.Product;


            Product.Count++;
            ProductCartClass.ProductCart.Add(Product);

        }

        private void BtnProductCart_Click(object sender, RoutedEventArgs e)
        {
            ShoppingCartWindow shoppingCartWindow = new ShoppingCartWindow();
            this.Hide();
            shoppingCartWindow.ShowDialog();
            this.Show();
        }
    }
}
