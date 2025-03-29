using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DrugStoreApplication;

/// <summary>
/// Interaction logic for LoginWindow.xaml
/// </summary>
public partial class LoginWindow : Window
{
    private readonly Service service;
    public LoginWindow()
    {
        InitializeComponent();
        service = new Service();
    }

    private void BTN_Login_OnClick(object sender, RoutedEventArgs e)
    {
        int result = service.Login(TB_Login.Text, TB_Password.Text);
        if (result == -1)
            MessageBox.Show("Ошибка входа", "Неверный логин", MessageBoxButton.OK, MessageBoxImage.Error);
        else if (result == -2)
            MessageBox.Show("Ошибка входа", "Неверный пароль", MessageBoxButton.OK, MessageBoxImage.Error);
        else
        {
            MessageBox.Show("Успешный вход", "Успешный вход", MessageBoxButton.OK, MessageBoxImage.Information);
            UserSession.user = service.GetUserById(result);
            if (service.GetUserById(result).RoleId == 1)
            {
                new AdminWindow().Show();
                Close();
            }
            if (service.GetUserById(result).RoleId == 2)
                new PharmacistWindow().Show();
            Close();
        }
    }
}