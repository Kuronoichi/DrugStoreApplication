using System.Windows;
using DrugStoreApplication.Database.ssms.models;
using DrugStoreApplication.PharmacyPanel;

namespace DrugStoreApplication;

public partial class PharmacistWindow : Window
{
    public PharmacistWindow()
    {
        InitializeComponent();
        TB_Login.Text = UserSession.user.Login;
        TB_Password.Text = UserSession.user.Password;
    }


    private void BTN_Exit_OnClick(object sender, RoutedEventArgs e)
    {
        new LoginWindow().Show();
        UserSession.user = null;
        Close();
    }

    private void BTN_Profile_OnClick(object sender, RoutedEventArgs e)
    {
        new PharmacistWindow().Show();
        Close();
    }

    private void BTN_Sales_OnClick(object sender, RoutedEventArgs e)
    {
        new PharmacistSalePanel().Show();
        Close();
    }

    private void BTN_Products_OnClick(object sender, RoutedEventArgs e)
    {
        new PharmacistProductPanel().Show();
        Close();
    }
}