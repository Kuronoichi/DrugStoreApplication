using System;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using DrugStoreApplication.Database.ssms.models;

namespace DrugStoreApplication
{
    public partial class AdminProductPanel_AddEdit : Window
    {
        private readonly Service service;
        private bool IsEditing;
        private Product? product;
        private string imagesFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Source", "products");
        
        public AdminProductPanel_AddEdit()
        {
            InitializeComponent();
            service = new Service();
            IsEditing = false;
            InitializeControls();
            TB_Main.Text = "Создание товара";
            
            Directory.CreateDirectory(imagesFolder);
        }
        
        public AdminProductPanel_AddEdit(Product _product)
        {
            InitializeComponent();
            service = new Service();
            IsEditing = true;
            product = _product;
            InitializeControls();
            TB_Main.Text = "Редактирование товара";
            
            TB_Name.Text = product.Name;
            TB_Price.Text = product.Price.ToString();
            TB_Quantity.Text = product.Quantity.ToString();
            CB_Supplier.SelectedValue = product.SupplierId;
            CB_Type.SelectedValue = product.TypeId;
            
            if (!string.IsNullOrEmpty(product.ImagePath))
            {
                TB_ImagePath.Text = product.ImagePath;
                LoadImagePreview(product.ImagePath);
            }
        }

        private void InitializeControls()
        {
            CB_Supplier.ItemsSource = service.GetSuppliers();
            CB_Type.ItemsSource = service.GetTypes();
        }

        private void BTN_EndManipulation_OnClick(object sender, RoutedEventArgs e)
        {
            if (!ValidateInput()) return;

            int price = int.Parse(TB_Price.Text);
            int quantity = int.Parse(TB_Quantity.Text);
            int supplierId = (int)CB_Supplier.SelectedValue;
            int typeId = (int)CB_Type.SelectedValue;
            string imagePath = TB_ImagePath.Text;

            if (!IsEditing)
            {
                if (service.GetProducts().Exists(p => p.Name == TB_Name.Text))
                {
                    MessageBox.Show("Товар с таким названием уже существует", "Ошибка", 
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (service.AddProduct(TB_Name.Text, price, quantity, imagePath, typeId, supplierId ) == -1)
                    ShowError("Ошибка добавления товара");
                else
                    ShowSuccess("Товар добавлен успешно!");
            }
            else
            {
                if (service.GetProducts().Exists(p => p.Name == TB_Name.Text && p.Id != product.Id))
                {
                    MessageBox.Show("Товар с таким названием уже существует", "Ошибка", 
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (service.EditProduct(product.Id, TB_Name.Text, price, quantity, imagePath, typeId, supplierId) == -1)
                    ShowError("Ошибка изменения товара");
                else
                    ShowSuccess("Товар изменён успешно!");
            }
            
            this.Close();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(TB_Name.Text) || 
                string.IsNullOrEmpty(TB_Price.Text) || 
                string.IsNullOrEmpty(TB_Quantity.Text) ||
                CB_Supplier.SelectedItem == null ||
                CB_Type.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля", "Ошибка", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if (!int.TryParse(TB_Price.Text, out int price) || price <= 0 ||
                !int.TryParse(TB_Quantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Некорректные числовые значения", "Ошибка", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            return true;
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message + "\nОбратитесь к администратору", "Ошибка", 
                MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BTN_SelectImage_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|All files (*.*)|*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
            };

            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    string destinationPath = CopyImageToAppFolder(openFileDialog.FileName);
                    TB_ImagePath.Text = destinationPath;
                    LoadImagePreview(destinationPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}", "Ошибка", 
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private string CopyImageToAppFolder(string sourcePath)
        {
            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(sourcePath);
            string destinationPath = Path.Combine(imagesFolder, fileName);
            File.Copy(sourcePath, destinationPath, true);
            return $"Source/products/{fileName}";
        }

        private void LoadImagePreview(string imagePath)
        {
            try
            {
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath);
                if (File.Exists(fullPath))
                {
                    var bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri(fullPath);
                    bitmap.CacheOption = BitmapCacheOption.OnLoad;
                    bitmap.EndInit();
                    IMG_Preview.Source = bitmap;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}", "Ошибка", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void NumericTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !e.Text.All(char.IsDigit);
        }
        
        private void NumericTextBox_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                string text = (string)e.DataObject.GetData(typeof(string));
                if (!text.All(char.IsDigit))
                {
                    e.CancelCommand();
                    MessageBox.Show("Ошибка вставки\nМожно вставлять только цифры", "Ошибка", 
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                e.CancelCommand();
                MessageBox.Show("Ошибка вставки", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}