using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using DrugStoreApplication.Database.ssms.models;

namespace DrugStoreApplication;

public partial class AdminUserPanel_AddEdit : Window
{
    private readonly Service service;
    private bool IsEditing;
    private User? user;
    public AdminUserPanel_AddEdit()
    {
        InitializeComponent();
        service = new Service();
        IsEditing = false;
        CB_Role.ItemsSource = service.GetRoles();
        TB_Main.Text = "Создание пользователя";
    }
    
    public AdminUserPanel_AddEdit(User _user)
    {
        InitializeComponent();
        service = new Service();
        IsEditing = true;
        CB_Role.ItemsSource = service.GetRoles();
        user = _user;
        TB_Main.Text = "Редактирование пользователя";
        TB_Login.Text = user.Login;
        TB_Password.Text = user.Password;
        TB_Phone.Text = user.Phone;
        TB_Role.Visibility = Visibility.Collapsed;
        CB_Role.Visibility = Visibility.Collapsed;
    }

    private void BTN_EndManipulation_OnClick(object sender, RoutedEventArgs e)
    {
        if (TB_Phone.Text.Length != 11)
        {
            MessageBox.Show("Ошибка ввода номера телефона", "Ошибка" , MessageBoxButton.OK , MessageBoxImage.Error);
            return;
        }
        
        if (TB_Login.Text == String.Empty || TB_Phone.Text == String.Empty || TB_Password.Text == String.Empty ||
            CB_Role.Text == String.Empty)
        {
            MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }
        if (!IsEditing)
        {
            if (service.GetUsers().Find(e => e.Phone == TB_Phone.Text || e.Login == TB_Login.Text) != null)
            {
                MessageBox.Show("Пользователь с этими данными уже существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var role = CB_Role.SelectedItem as Role;
            
            if (service.AddUser(TB_Login.Text, TB_Password.Text, TB_Phone.Text, role.Id) == -1)
                MessageBox.Show("Ошибка добавления пользователя\n Обратитесь к администратору","Ошибка",MessageBoxButton.OK, MessageBoxImage.Error);
            else
                MessageBox.Show("Пользователь добавлен успешно!","Успех",MessageBoxButton.OK, MessageBoxImage.Information);
        }
        else
        {
            if (service.GetUsers().Any(e => e.Phone == TB_Phone.Text && TB_Phone.Text != user.Phone) || 
                (service.GetUsers().Any(e => e.Login == TB_Login.Text) && TB_Login.Text != user.Login))
            {
                MessageBox.Show("Пользователь с этими данными уже существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            
            if (service.EditUser(user.Id, TB_Login.Text, TB_Password.Text, TB_Phone.Text) == -1)
                MessageBox.Show("Ошибка изменения пользователя", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                MessageBox.Show("Пользователь изменён успешно!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            return;
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
                MessageBox.Show("Ошибка вставки", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        else
        {
            e.CancelCommand();
            MessageBox.Show("Ошибка вставки", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}