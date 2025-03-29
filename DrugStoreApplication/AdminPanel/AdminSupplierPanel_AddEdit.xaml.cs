using System.Windows;
using System.Windows.Input;
using DrugStoreApplication.Database.ssms.models;

namespace DrugStoreApplication;

public partial class AdminSupplierPanel_AddEdit : Window
{
    private readonly Service service;
    private bool IsEditing;
    private Supplier? _supplier;
    public AdminSupplierPanel_AddEdit()
    {
        InitializeComponent();
        service = new Service();
        IsEditing = false;
        TB_Main.Text = "Создание поставщика";
    }
    
    public AdminSupplierPanel_AddEdit(Supplier supplier)
    {
        InitializeComponent();
        service = new Service();
        IsEditing = true;
        TB_Main.Text = "Редактирование поставщика";
        TB_Name.Text = supplier.Name;
        TB_Phone.Text = supplier.Phone;
        _supplier = supplier;
    }


    private void BTN_EndManipulation_OnClick(object sender, RoutedEventArgs e)
    {
        if (TB_Name.Text == String.Empty || TB_Phone.Text == String.Empty)
        {
            MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        if (!IsEditing)
        {
            if (service.GetSuppliers().Find(e => e.Phone == TB_Phone.Text || e.Name == TB_Name.Text) != null)
            {
                MessageBox.Show("Поставщик с этими данными уже существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            
            if (service.AddSupplier(TB_Name.Text, TB_Phone.Text) == -1)
                MessageBox.Show("Ошибка добавления поставщика \n Обратитесь к администратору","Ошибка",MessageBoxButton.OK, MessageBoxImage.Error);
            else
                MessageBox.Show("Поставщик добавлен успешно!","Успех",MessageBoxButton.OK, MessageBoxImage.Information);
        }
        else
        {
            if (service.GetSuppliers().Any(e => e.Phone == TB_Phone.Text && TB_Phone.Text != _supplier.Phone) || (service.GetSuppliers().Any(e => e.Name == TB_Name.Text) && TB_Name.Text != _supplier.Name))
            {
                MessageBox.Show("Пользователь с этими данными уже существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            
            if (service.EditSupplier(_supplier.Id, TB_Name.Text, TB_Phone.Text) == -1)
                MessageBox.Show("Ошибка изменения поставщика", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                MessageBox.Show("Поставщик изменён успешно!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            Close();
        }
    }

    private void TB_Phone_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
    {
        e.Handled = !e.Text.All(char.IsDigit);
    }
    
    private void TB_Phone_Pasting(object sender, DataObjectPastingEventArgs e)
    {
        if (e.DataObject.GetDataPresent(typeof(string)))
        {
            string text = (string)e.DataObject.GetData(typeof(string));
            if (!text.All(char.IsDigit))
            {
                e.CancelCommand();
                MessageBox.Show("Ошибка вставки \n Вставьте номер в формате 8**********", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        else
        {
            e.CancelCommand();
            MessageBox.Show("Ошибка вставки", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}