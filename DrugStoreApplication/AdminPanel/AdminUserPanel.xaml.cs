using System.Windows;
using System.Windows.Controls;
using DrugStoreApplication.AdminPanel;
using DrugStoreApplication.Database.ssms.models;

namespace DrugStoreApplication;

public partial class AdminUserPanel : Window
{
    private Service service;
    private User selectedUser;
    public AdminUserPanel()
    {
        InitializeComponent();
        service = new Service();
        load();
    }

    private void load()
    {
        service = new Service();
        UsersGrid.ItemsSource = service.GetUsers();
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

    private void BTN_Add_OnClick(object sender, RoutedEventArgs e)
    {
        new AdminUserPanel_AddEdit().ShowDialog();
        load();
        
    }

    private void BTN_Edit_OnClick(object sender, RoutedEventArgs e)
    {
        new AdminUserPanel_AddEdit(selectedUser).ShowDialog();
        load();
    }

    private void BTN_Delete_OnClick(object sender, RoutedEventArgs e)
    {
        if (selectedUser == null)
        {
            MessageBox.Show("Пожалуйста, выберите пользователя","Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        var result = MessageBox.Show($"Удалить пользователя {selectedUser.Login}?", 
            "Подтверждение", MessageBoxButton.YesNo);
            
        if (result == MessageBoxResult.Yes)
        {
            if (service.DeleteUser(selectedUser.Id) == -1)
            {
                MessageBox.Show("Не удалось удалить пользователя", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
                MessageBox.Show("Успешное удаление", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            load();
        }
    }

    private void UsersGrid_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        selectedUser = UsersGrid.SelectedItem as User;
        BTN_Edit.IsEnabled = selectedUser != null && selectedUser.Role.Name != "Админ";
        BTN_Delete.IsEnabled = selectedUser != null && selectedUser.Role.Name != "Админ";
    }

    private void BTN_Update_OnClick(object sender, RoutedEventArgs e)
    {
        load();
    }
}