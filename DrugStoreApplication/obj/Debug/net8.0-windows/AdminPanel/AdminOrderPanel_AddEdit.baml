   M S B A M L   `   `   `  ����O  KDrugStoreApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:DrugStoreApplication.AdminPanelDrugStoreApplication.AdminPanel  5   	   =    7DrugStoreApplication.AdminPanel.AdminOrderPanel_AddEdit   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   ?local-clr-namespace:DrugStoreApplication.AdminPanel     5   	     � Title$.  (Манипуляция с заказом��5   	   $	��450��6'   $	��800��64    � WindowStartupLocation$ CenterScreen=�6@   .��5	      � $��1��6   $��10q�6    � RowDefinitions 5
      �� 5      $
��Auto �6    �� 5      $��* �6    �� 5      $
��Auto �6    �� 5      $��* �6    �� 5      $
��Auto �6    .+�5      �� $��0��6   $+��%Управление заказами��6%   $��28(�5      $
��Bold"�6&   $��Center=�5      $
��0 10q�65   �� 5      $��1��6   $%��Доступные товары��6$   $��0 0 0 10q�6>   .��5      �  5      �� 5      $
��Auto �6(   �� 5      $��* �6(   .+�5      �� $��0��6!    �� Orientation$ 
Horizontal=�6.   $��0 0 0 5q�6G   .+�5      �� -   5         ��Name$ SearchTextBox��5   "   $	��200��69   $��5q�6E   $��5q�6P   $��Center=�5   "   �� 5       -   5         ��Name$ 
BTN_Search��5    !   $��
Найти��65   $��80��6E   $��5q�6P   6[   5!      &   System.Windows.Controls.DataGrid  5#      -   5          Name$ ProductsGrid��5#   ,   $��1��6      AutoGenerateColumns$ False��6B      CanUserAddRows$ False��5$      	   
IsReadOnly$
	 True��66   
   Columns
 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��61      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Id+6T     5'      $ Наименование��61   $ * 6`    6G   �� *Name+6`     5(      $ Цена��61   $ * 6Y    6?   �� *Price+6Y     5)      $ Количество��61   $ * 6b    6E   �� *
Quantity+6b     5*      $ Поставщик��61   $ * 6f    6D   �� *Supplier.Name+6f   4  .System.Windows.Controls.DataGridTemplateColumn  5+      $
 Auto 65      CellTemplate 5,   "   �� 5-   &   .R�5.   *   �� $ BTN_Add��61   -   5        $��Добавить��5.   B   
 � Tag 6m   �� *Id+5/   '   51      53      54      55      �� 57      $��3��6   $"��Товары в заказе��6$   $��0 0 0 10q�6=   .��58      �  59      �� 5:      $��* �6(   �� 5;      $
��Auto �6(   .+�5>        -   5        $ CartGrid��5>   ,   $��0��6   $ False��6>   $ False��5?      $
	 True��66   
 5@        5A      $ ID��61   $
 Auto 6\    6=   �� *
Product.Id+6\     5B      $ Наименование��61   $ * 6h    6G   �� *Product.Name+6h     5C      $ Цена��61   $ * 6a    6?   �� *Product.Price+6a     5D      $ Количество��61   $ * 6b    6E   �� *
Quantity+6b     5E   "    5F   &   �� 5G   *   .R�5H   .   �� $��50��5I   6    �� TextAlignment$ Center=�6A   ��5H   6   �� *
Quantity+ �� UpdateSourceTrigger$ PropertyChanged=�5I   A   5J   +   5L   #     5M      $ 
Сумма��61   $ * 6_    6@   �� *
TotalPrice+6_     5N      $
 Auto 65    5O   "   �� 5P   &   .R�5Q   *   �� $ 
BTN_Remove��61   -   5        $��Удалить��5Q   E    6r   �� *
Product.Id+5R   '   5T      5V      �� 5X      $��1��6!   $ 
Horizontal=�6.   $��Right=�6G   $��0 5 0 0q�6c   .+�5Y      �� $��Итого:��6$   $
��Bold"�62   $��0,0,10,0q�6D   $��Center=�6V   �� 5Z      -   5         ��Name$ TotalAmountText��5Z   $   $��0��6=   $
��Bold"�6F   $	��100��6X   $��Center=�5[   $    �� TextAlignment$ Right=�6?   5\      5]      5^      �� 5`      $��4��6   $ 
Horizontal=�6&   $��Right=�6?   .+�5a      �� $��Поставщик��6   $��Center=�6-   �� 5b      -   5         ��Name$ SupplierComboBox��5b       �� DisplayMemberPath$
 Name��65    �� SelectedValuePath$ Id��6N   $	��200��5c      $��5q�6'    �� SelectedValue 62   �� *SelectedSupplierId+6_   �� 5d      -	   5        $ BTN_EditOrder��5d      $!��Изменить заказ��60   $	��120��6J   $��5q�6V   $y�	Collapsed=�5e   5   �� 5f      -
   5        $ BTN_AddOrder��5f      $��Создать заказ��6/   $	��120��6G   $��5q�6S   5g      5h      5i      5j      