using System.Windows;
using System.Windows.Controls;
using DrugStoreApplication.Database.ssms.models;

namespace DrugStoreApplication.AdminPanel;

public partial class AdminOrderPanel : Window
{
        private Service service;
        private Order order;
        
        public AdminOrderPanel()
        {
            InitializeComponent();
            service = new Service();
            Load();
        }

        private void Load()
        {
            service = new Service();
            OrdersGrid.ItemsSource = service.GetOrders();
        }

        private void BTN_Edit_OnClick(object sender, RoutedEventArgs e)
        {
            var addWindow = new AdminOrderPanel_AddEdit(order);
            addWindow.Show();
        }

        private void BTN_Delete_OnClick(object sender, RoutedEventArgs e)
        {
            if (order == null)
            {
                MessageBox.Show("Пожалуйста, выберите заказ для удаления", "Ошибка", 
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (service.DeleteOrder(order.Id) == -1)
            {
                MessageBox.Show("Ошибка удаления заказа", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            
            MessageBox.Show("Успешное удаление заказа", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            Load();
        }

        private void BTN_Add_OnClick(object sender, RoutedEventArgs e)
        {
            var addWindow = new AdminOrderPanel_AddEdit();
            addWindow.Closed += (s, args) => Load();
            addWindow.ShowDialog();
        }

        private void OrdersGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            order = OrdersGrid.SelectedItem as Order;
        }
        
        private void BTN_Profile_OnClick(object sender, RoutedEventArgs e)
        {
            new AdminWindow().Show();
            Close();
        }

        private void BTN_Orders_OnClick(object sender, RoutedEventArgs e)
        {
            new AdminOrderPanel().Show();
            Close();
        }

        private void BTN_Products_OnClick(object sender, RoutedEventArgs e)
        {
            new AdminProductPanel().Show();
            Close();
        }

        private void BTN_Suppliers_OnClick(object sender, RoutedEventArgs e)
        {
            new AdminSupplierPanel().Show();
            Close();
        }

        private void BTN_Users_OnClick(object sender, RoutedEventArgs e)
        {
            new AdminUserPanel().Show();
            Close();
        }

        private void BTN_Update_OnClick(object sender, RoutedEventArgs e)
        {
            Load();
        }
}