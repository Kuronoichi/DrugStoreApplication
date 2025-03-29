using System.Windows;
using System.Windows.Controls;
using DrugStoreApplication.AdminPanel;
using DrugStoreApplication.Database.ssms.models;

namespace DrugStoreApplication;

public partial class AdminSupplierPanel : Window
{
    private Service service;
    private Supplier selectedSupplier;
    public AdminSupplierPanel()
    {
        InitializeComponent();
        service = new Service();
        Load();
    }

    private void Load()
    {
        service = new Service();
        SuppliersGrid.ItemsSource = service.GetSuppliers();
    }

    private void BTN_Add_OnClick(object sender, RoutedEventArgs e)
    {
        new AdminSupplierPanel_AddEdit().Show();
        Load();
    }

    private void BTN_Edit_OnClick(object sender, RoutedEventArgs e)
    {
        new AdminSupplierPanel_AddEdit(selectedSupplier).Show();
        Load();
    }

    private void BTN_Delete_OnClick(object sender, RoutedEventArgs e)
    {
        if (selectedSupplier == null)
        {
            MessageBox.Show("Пожалуйста, выберите поставщика","Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        var result = MessageBox.Show($"Удалить поставщика {selectedSupplier.Name}?", 
            "Подтверждение", MessageBoxButton.YesNo);
            
        if (result == MessageBoxResult.Yes)
        {
            if (service.DeleteUser(selectedSupplier.Id) == -1)
            {
                MessageBox.Show("Не удалось удалить поставщика", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
                MessageBox.Show("Успешное удаление", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            Load();
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

    private void SuppliersGrid_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        selectedSupplier = SuppliersGrid.SelectedItem as Supplier;
    }

    private void BTN_Update_OnClick(object sender, RoutedEventArgs e)
    {
        Load();
    }
}