using Microsoft.Win32;
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

namespace Dubasov_TeaCompany.Windows.Admin
{
    /// <summary>
    /// Логика взаимодействия для AddProductWindow.xaml
    /// </summary>
    public partial class AddProductWindow : Window
    {
        private string ImgProduct = null;
        public AddProductWindow()
        {
            InitializeComponent();
            CmbProductType.ItemsSource = ClassHelper.EF.Context.Category.ToList();
            CmbProductType.DisplayMemberPath = "TypeName";
            CmbProductType.SelectedIndex = 0;
        }
        private void BtnAddProductImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                ImgImageProduct.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                ImgProduct = openFileDialog.FileName;
            }
        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product.ProductName = TbProductName.Text;
            product.Description = TbProductDesc.Text;
            product.Price = Convert.ToDecimal(TbPrice.Text);
            product.Image = ImgProduct;
            product.ProductTypeID = (CmbProductType.SelectedItem as Category).ID;

            ClassHelper.EF.Context.Product.Add(product);
            ClassHelper.EF.Context.SaveChanges();

            MessageBox.Show("Товар успешно добавлен!");
        }
    }
}
