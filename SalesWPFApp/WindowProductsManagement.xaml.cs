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
using DataAccess;
using DataAccess.Repository;

namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for WindowProducts.xaml
    /// </summary>
    public partial class WindowProducts : Window
    {
        public WindowProducts()
        {
            InitializeComponent();
            LoadProduct();
        }

        public void LoadProduct()
        {
            lvProduct.ItemsSource = DataAccess.ProductDAO.GetProducts();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure delete this item?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    Product product = DataAccess.ProductDAO.GetProductById(int.Parse(txtProductId.Text));
                    DataAccess.ProductDAO.RemoveProduct(product);
                    LoadProduct();
                    MessageBox.Show($"{product.ProductName} inserted successfully", "Insert product");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete product");
                }
            }
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product product = new Product
                {
                    ProductId = int.Parse(txtProductId.Text),
                    CategoryId = int.Parse(txtCategoryId.Text),
                    ProductName = txtPoductName.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Weight = txtWeight.Text,
                    UnitsInStock = int.Parse(txtUnitInStock.Text)
                };
                DataAccess.ProductDAO.InsertProduct(product);
                LoadProduct();
                MessageBox.Show($"{product.ProductName} inserted successfully", "Insert product");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert product");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product product = new Product
                {
                    ProductId = int.Parse(txtProductId.Text),
                    CategoryId = int.Parse(txtCategoryId.Text),
                    ProductName = txtPoductName.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Weight = txtWeight.Text,
                    UnitsInStock = int.Parse(txtUnitInStock.Text)
                };
                DataAccess.ProductDAO.UpdateProduct(product);
                LoadProduct();
                MessageBox.Show($"{product.ProductName} updated successfully", "Update product");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update product");
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            LoadProduct();
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            lvProduct.ItemsSource = DataAccess.ProductDAO.SearchProductByName(txtSearch.Text);
        }
    }
}
