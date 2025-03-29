using System.Windows;
using System.Windows.Controls;
using DrugStoreApplication.AdminPanel;
using DrugStoreApplication.Database.ssms.models;

namespace DrugStoreApplication;

public partial class AdminWindow : Window
{
    private readonly Service service;
    public AdminWindow()
    {
        InitializeComponent();
        service = new Service();
        TB_Login.Text = UserSession.user.Login;
        TB_Password.Text = UserSession.user.Password;
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

    private void BTN_Exit_OnClick(object sender, RoutedEventArgs e)
    {
        new LoginWindow().Show();
        UserSession.user = null;
        Close();
    }

    private void BTN_ChangeLogin_OnClick(object sender, RoutedEventArgs e)
    {
        var user = UserSession.user;
        if (service.EditUser(user.Id, TB_Login.Text, user.Password, user.Phone) != -1)
            MessageBox.Show("Успешное измеенение логина", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
        else
            MessageBox.Show("Ошибка при изменении логина", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
    }

    private void BTN_ChangePassword_OnClick(object sender, RoutedEventArgs e)
    {
        var user = UserSession.user;
        if (service.EditUser(user.Id, user.Login, TB_Password.Text, user.Phone) != -1)
            MessageBox.Show("Успешное измеенение пароля", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
        else
            MessageBox.Show("Ошибка при изменении пароля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
    }
}