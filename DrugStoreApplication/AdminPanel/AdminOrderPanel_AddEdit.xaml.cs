using System.Windows;
using System.Windows.Controls;
using DrugStoreApplication.Database.ssms.models;

namespace DrugStoreApplication.AdminPanel;

public partial class AdminOrderPanel_AddEdit : Window
{
     private Service service;
        private List<CartItem> _cartItems = new List<CartItem>();
        private Order _order;
        
        public AdminOrderPanel_AddEdit()
        {
            InitializeComponent();
            service = new Service();
            Load();
        }
        
        public AdminOrderPanel_AddEdit(Order order)
        {
            InitializeComponent();
            _order = order;
            if (order != null)
            {
                BTN_AddOrder.Visibility = Visibility.Collapsed;
                BTN_EditOrder.Visibility = Visibility.Visible;
            }
            service = new Service();
            LoadForEditing();
        }
        
        private void Load()
        {
            SupplierComboBox.ItemsSource = service.GetSuppliers();
        }

        private void LoadForEditing()
        {
            Load();
            if (_order == null) return;
            
            var orderProducts = service.GetProductsFromOrder(_order.Id);
            _cartItems = orderProducts.Select(op => new CartItem
            {
                Product = op.Product,
                Quantity = op.Quantity
            }).ToList();
            
            SupplierComboBox.SelectedValue = _order.SupplierId - 1;
        
            UpdateCart();
        }
        
        private void BTN_Add_OnClick(object sender, RoutedEventArgs e)
        {
            if (ProductsGrid.SelectedItem is Product selectedProduct)
            {
                var existingItem = _cartItems.FirstOrDefault(item => item.Product.Id == selectedProduct.Id);
                
                if (existingItem != null)
                {
                    existingItem.Quantity++;
                }
                else
                {
                    _cartItems.Add(new CartItem
                    {
                        Product = selectedProduct,
                        Quantity = 1
                    });
                }
                
                UpdateCart();
            }
        }
        
        private void BTN_Remove_OnClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button { Tag: int productId })
            {
                var itemToRemove = _cartItems.FirstOrDefault(item => item.Product.Id == productId);
                
                if (itemToRemove != null)
                {
                    _cartItems.Remove(itemToRemove);
                    UpdateCart();
                }
            }
        }
        
        private void UpdateCart()
        {
            CartGrid.ItemsSource = null;
            CartGrid.ItemsSource = _cartItems;
            
            decimal total = _cartItems.Sum(item => item.TotalPrice);
            TotalAmountText.Text = total.ToString("C");
        }
        
        private void BTN_EditOrder_Click(object sender, RoutedEventArgs e)
    {
        var supplier = SupplierComboBox.SelectedItem as Supplier;
        
        if (SupplierComboBox.SelectedItem == null)
        {
            MessageBox.Show("Ошибка выбора поставщика", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }
        
        if (!_cartItems.Any())
        {
            MessageBox.Show("Пожалуйста, заполните корзину", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }
        
        try
        {
            int orderUpdated = service.EditOrder(_order.Id, 
                (int)_cartItems.Sum(item => item.TotalPrice), UserSession.user.Id,
                supplier.Id);
            
            if (orderUpdated == -1)
            {
                MessageBox.Show("Ошибка обновления заказа", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            
            service.DeleteProductsFromOrder(_order);
            
            foreach (var cartItem in _cartItems)
            {
                int productInOrderResult = service.AddProductToOrder(_order.Id, 
                    cartItem.Product.Id, cartItem.Quantity);
                if (productInOrderResult == -1)
                {
                    MessageBox.Show($"Ошибка обновления товара {cartItem.Product.Name} в заказе",
                        "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            
            MessageBox.Show("Заказ успешно обновлен", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            Close();
        }
        catch
        {
            MessageBox.Show("Ошибка при обновлении заказа", 
                "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
        
        private void BTN_AddOrder_Click(object sender, RoutedEventArgs e)
        {
            var supplier = SupplierComboBox.SelectedItem as Supplier;
            
            if (SupplierComboBox.SelectedItem == null)
            {
                MessageBox.Show("Ошибка выбора поставщика", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            
            if (!_cartItems.Any())
            {
                MessageBox.Show("Пожалуйста, заполните корзину", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            
            try
            {
                int orderResult = service.AddOrder(DateTime.Now, (int)_cartItems.Sum(item => item.TotalPrice),
                    UserSession.user.Id, supplier.Id);
                if (orderResult == -1)
                {
                   MessageBox.Show("Ошибка создания заказа", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                   return; 
                }
                    
                
                foreach (var cartItem in _cartItems)
                {
                    int productInOrderResult = service.AddProductToOrder(orderResult, cartItem.Product.Id, cartItem.Quantity);
                    if (productInOrderResult == -1)
                    {
                        MessageBox.Show($"Ошибка добавления товара {cartItem.Product.Name} в заказ ","Ошибка",MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                
                MessageBox.Show("Заказ успешно создан!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                _cartItems.Clear();
                UpdateCart();
                Close();
            }
            catch
            {
                MessageBox.Show($"Ошибка при создании заказа", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        
        private class CartItem
        {
            public Product Product { get; set; }
            public int Quantity { get; set; }
            public decimal TotalPrice => Product.Price * Quantity;
        }
       
        private void BTN_Search_OnClick(object sender, RoutedEventArgs e)
        {
            var searchText = SearchTextBox.Text.ToLower();
            
            if (string.IsNullOrWhiteSpace(searchText))
            {
                Load();
                return;
            }
            
            ProductsGrid.ItemsSource = service.GetProducts()
                .Where(p => p.Name.ToLower().Contains(searchText) ||
                           p.Supplier.Name.ToLower().Contains(searchText) ||
                           p.Type.Name.ToLower().Contains(searchText))
                .ToList();
        }

        private void SupplierComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ProductsGrid.ItemsSource =
                service.GetProducts().Where(e => e.SupplierId == SupplierComboBox.SelectedIndex + 1);
        }
}