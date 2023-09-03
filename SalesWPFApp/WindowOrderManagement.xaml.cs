using DataAccess.Repository;
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

namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for WindowOrderManagement.xaml
    /// </summary>
    public partial class WindowOrderManagement : Window
    {
        public WindowOrderManagement()
        {
            InitializeComponent();
            LoadOrder();
        }

        public void LoadOrder()
        {
            lvOrder.ItemsSource = DataAccess.OrderDAO.GetOrders();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Order order = new Order
                {
                    OrderId = int.Parse(txtOrderId.Text),
                    MerberId = int.Parse(txtMemberId.Text),
                    OrderdDate = DateTime.Parse(txtOrderdDate.Text),
                    RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                    ShippedDate = DateTime.Parse(txtShippedDate.Text),
                    Freight = decimal.Parse(txtFreight.Text)
                };
                DataAccess.OrderDAO.InsertOrder(order);
                LoadOrder();
                MessageBox.Show($" OrderId {order.OrderId} updated successfully", "Update Order");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Order");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Order order = new Order
                {
                    OrderId = int.Parse(txtOrderId.Text),
                    MerberId = int.Parse(txtMemberId.Text),
                    OrderdDate = DateTime.Parse(txtOrderdDate.Text),
                    RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                    ShippedDate = DateTime.Parse(txtShippedDate.Text),
                    Freight = decimal.Parse(txtFreight.Text)
                };
                DataAccess.OrderDAO.UpdateOrder(order);
                LoadOrder(); ;
                MessageBox.Show($"OrderId {order.OrderId} updated successfully", "Update Order");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Order");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure delete this order?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    Order order = new Order
                    {
                        OrderId = int.Parse(txtOrderId.Text),
                        MerberId = int.Parse(txtMemberId.Text),
                        OrderdDate = DateTime.Parse(txtOrderdDate.Text),
                        RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                        ShippedDate = DateTime.Parse(txtShippedDate.Text),
                        Freight = decimal.Parse(txtFreight.Text)
                    };
                    DataAccess.OrderDAO.RemoveOrder(order);
                    LoadOrder();
                    MessageBox.Show($"OrderId {order.OrderId} deleted successfully", "Delete Order");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Remove Order");
                }
            }
        }
    }
}
