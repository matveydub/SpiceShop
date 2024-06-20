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
    /// Логика взаимодействия для RedactProductWindow.xaml
    /// </summary>
    public partial class RedactProductWindow : Window
    {
        DB.Product editProduct = null;
        public RedactProductWindow()
        {
            InitializeComponent();
        }
        public RedactProductWindow(DB.Product product)
        {
            InitializeComponent();

            ImgImageProduct.Source = new BitmapImage(new Uri(product.Image));

            TbProductName.Text = product.ProductName;
            TbProductDesc.Text = product.Description;
            TbPrice.Text = Convert.ToString(product.Price);

            CmbProductType.ItemsSource = ClassHelper.EF.Context.Category.ToList();
            CmbProductType.DisplayMemberPath = "TagName";

            CmbProductType.SelectedItem = ClassHelper.EF.Context.Category.Where(i => i.ID == product.ProductTypeID);

            editProduct = product;
        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            editProduct.ProductName = TbProductName.Text;
            editProduct.Description = TbProductDesc.Text;

            editProduct.Price = Convert.ToDecimal(TbPrice.Text);
            editProduct.ProductTypeID = (CmbProductType.SelectedItem as DB.Category).ID;

            ClassHelper.EF.Context.SaveChanges();

            MessageBox.Show("Данные успешно сохранены!");

            this.Close();
        }

    }
}
