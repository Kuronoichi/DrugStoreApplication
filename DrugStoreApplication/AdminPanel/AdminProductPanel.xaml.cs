using System.Windows;
using System.Windows.Controls;
using DrugStoreApplication.Database.ssms.models;

namespace DrugStoreApplication.AdminPanel;

public partial class AdminProductPanel : Window
{
    private Service service;
    private Product selectedProduct;
    
    public AdminProductPanel()
    {
        InitializeComponent();
        service = new Service();
        Load();
    }

    private void Load()
    {
        service = new Service();
        ProductsGrid.ItemsSource = service.GetProducts();
    }

    private void BTN_Add_OnClick(object sender, RoutedEventArgs e)
    {
        var addWindow = new AdminProductPanel_AddEdit();
        addWindow.Closed += (s, args) => Load();
        addWindow.ShowDialog();
    }

    private void BTN_Edit_OnClick(object sender, RoutedEventArgs e)
    {
        if (selectedProduct == null)
        {
            MessageBox.Show("Пожалуйста, выберите товар", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }
        
        var addWindow = new AdminProductPanel_AddEdit(selectedProduct);
        addWindow.Closed += (s, args) => Load();
        addWindow.ShowDialog();
    }

    private void BTN_Delete_OnClick(object sender, RoutedEventArgs e)
    {
        if (selectedProduct == null)
        {
            MessageBox.Show("Пожалуйста, выберите товар", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        var result = MessageBox.Show($"Удалить товар {selectedProduct.Name}?", 
            "Подтверждение", MessageBoxButton.YesNo);
            
        if (result == MessageBoxResult.Yes)
        {
            if (service.DeleteProduct(selectedProduct.Id) == -1)
            {
                MessageBox.Show("Не удалось удалить товар", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Товар успешно удален", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                Load();
            }
        }
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

    private void ProductsGrid_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        selectedProduct = ProductsGrid.SelectedItem as Product;
    }

    private void BTN_Search_OnClick(object sender, RoutedEventArgs e)
    {
        string searchText = SearchTextBox.Text.Trim();
        if (!string.IsNullOrEmpty(searchText))
        {
            var filteredProducts = service.GetProducts()
                .Where(p => p.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                .ToList();
            ProductsGrid.ItemsSource = filteredProducts;
        }
    }

    private void BTN_Update_OnClick(object sender, RoutedEventArgs e)
    {
        Load();
    }
}