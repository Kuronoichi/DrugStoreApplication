using System.Windows;
using System.Windows.Controls;
using DrugStoreApplication.Database.ssms.models;

namespace DrugStoreApplication.PharmacyPanel;

public partial class PharmacistSalePanel_Add : Window
{
    private readonly Service service;
    private readonly List<SaleItem> saleItems;
    private List<Product> availableProducts;

    public PharmacistSalePanel_Add()
    {
        InitializeComponent();
        service = new Service();
        saleItems = new List<SaleItem>(); // Инициализация коллекции
        
        try
        {
            var products = service.GetProducts();
            availableProducts = products?
                .Where(p => p != null && p.Quantity > 0)
                .ToList() ?? new List<Product>();
        }
        catch (Exception ex)
        {
            availableProducts = new List<Product>();
            MessageBox.Show($"Ошибка загрузки продуктов: {ex.Message}", "Ошибка", 
                MessageBoxButton.OK, MessageBoxImage.Error);
        }
        
        Load();
    }

    private void Load()
    {
        ProductsGrid.ItemsSource = availableProducts;
    }
    
    private void BTN_Search_OnClick(object sender, RoutedEventArgs e)
    {
        try
        {
            var searchText = SearchTextBox.Text?.ToLower() ?? string.Empty;
            
            if (string.IsNullOrWhiteSpace(searchText))
            {
                ProductsGrid.ItemsSource = availableProducts;
                return;
            }

            var filtered = availableProducts
                .Where(m => m != null)
                .Where(m => (m.Name?.ToLower()?.Contains(searchText) ?? false) ||
                           (m.Supplier?.Name?.ToLower()?.Contains(searchText) ?? false))
                .ToList();

            ProductsGrid.ItemsSource = filtered;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка поиска: {ex.Message}", "Ошибка", 
                MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void BTN_Add_OnClick(object sender, RoutedEventArgs e)
    {
        try
        {
            var button = sender as Button;
            if (button?.Tag == null) return;

            if (!int.TryParse(button.Tag.ToString(), out int medicineId))
            {
                MessageBox.Show("Неверный идентификатор товара", "Ошибка", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var product = availableProducts.FirstOrDefault(m => m?.Id == medicineId);
            if (product == null)
            {
                MessageBox.Show("Товар не найден", "Ошибка", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!int.TryParse(QuantityTextBox?.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Введите корректное количество", "Ошибка", 
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (quantity > product.Quantity)
            {
                MessageBox.Show("Недостаточное количество товара на складе", "Ошибка", 
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            saleItems.Add(new SaleItem
            {
                Id = product.Id,
                Quantity = quantity,
                TotalPrice = quantity * product.Price
            });

            MessageBox.Show("Товар добавлен к продаже", "Успешно", 
                MessageBoxButton.OK, MessageBoxImage.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка добавления товара: {ex.Message}", "Ошибка", 
                MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void BTN_Cancel_Click(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void BTN_Save_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            if (saleItems == null || !saleItems.Any())
            {
                MessageBox.Show("Нет товаров для продажи", "Ошибка", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            foreach (var item in saleItems)
            {
                if (item == null) continue;
                
                var result = service.AddSale(DateTime.Now, item.Quantity, item.TotalPrice, 
                    item.Id, UserSession.user?.Id ?? -1);
                
                if (result == -1)
                {
                    MessageBox.Show($"Ошибка при сохранении продажи для товара ID: {item.Id}", "Ошибка",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }

            MessageBox.Show("Продажи успешно сохранены", "Успешно", 
                MessageBoxButton.OK, MessageBoxImage.Information);
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка добавления продажи: {ex.Message}", "Ошибка",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    public class SaleItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
    }
}