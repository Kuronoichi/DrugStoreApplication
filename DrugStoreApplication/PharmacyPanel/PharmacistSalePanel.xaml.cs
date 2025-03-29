using System.Windows;
using System.Windows.Controls;
using DrugStoreApplication.Database.ssms.models;

namespace DrugStoreApplication.PharmacyPanel;

public partial class PharmacistSalePanel : Window
{
    private Service service;
    private Sale sale;
    public PharmacistSalePanel()
    {
        InitializeComponent();
        service = new Service();
        Load();
    }

    private void Load()
    {
        SalesGrid.ItemsSource = service.GetSales();
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

    private void SalesGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        sale = SalesGrid.SelectedItem as Sale;
    }

    private void BTN_Add_OnClick(object sender, RoutedEventArgs e)
    {
        new PharmacistSalePanel_Add().ShowDialog();
        Load();
    }

    private void BTN_Delete_OnClick(object sender, RoutedEventArgs e)
    {
        if (sale == null)
        {
            MessageBox.Show("Пожалуйста, выберите продажу", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        if (service.DeleteSale(sale.Id) == -1)
        {
            MessageBox.Show("Ошибка удаления продажи", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }
        MessageBox.Show("Успешное удаление продажи","Успех",MessageBoxButton.OK, MessageBoxImage.Information);
    }
}