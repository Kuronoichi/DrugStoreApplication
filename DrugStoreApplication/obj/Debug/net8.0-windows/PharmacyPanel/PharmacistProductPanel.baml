   M S B A M L   `   `   `  ����O  KDrugStoreApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:DrugStoreApplication.PharmacyPanel"DrugStoreApplication.PharmacyPanel  5   	   ?    9DrugStoreApplication.PharmacyPanel.PharmacistProductPanel   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Blocal0clr-namespace:DrugStoreApplication.PharmacyPanel     5   	     � Title$  PharmacistProductPanel��5   	   $	��600��6(   $	��800��65    � 
ResizeMode$ NoResize=�6A    � WindowStartupLocation$ CenterScreen=�6W   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      $��4* �6   .+�5   
   � $��0��6   
������� � RowDefinitions 5      �� 5      $��2* �6    �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      $��5* �6    .+�5      �� $��/Source/logo.png��6   �� 5      -   5         ��Name$ BTN_Profile��5   "   $��1��6      Menu_Button#��[  67   $��Профиль��6\   6n   �� 5      -   5        $ 
BTN_Orders��5   "   $��2��6   #��[  66   $!��Панель продажи��6[   6t   �� 5      -   5        $ BTN_Products��5   "   $��3��6   #��[  68   $��Панель товары��6]   6u   5       � 5"      $��1��6   $��10q�6    5#      �� 5$      $
��Auto �6    �� 5%      $
��Auto �6    �� 5&      $
��Auto �6    �� 5'      $
��Auto �6    �� 5(      $��* �6    .+�5+      �� $��0��6   $+��%Управление товарами��6%   $��28(�5,      $
��Bold"�6&   $��Center=�5-      $
��0 10q�65   �� 5/      $��1��6    �� Orientation$ 
Horizontal=�6&   $��Center=�6?   $
��0 10q�6\   .+�50      �� -   5        $ BTN_Add��50      $��Добавить��6*   $	��120��6=   $��5q�6I   6T   �� 51      -   5        $ BTN_Edit��51      $��Изменить��6+   $	��120��6>   $��5q�6J   6U   �� 52      -   5        $ 
BTN_Delete��52      $��Удалить��6-   $	��120��6?   $��5q�6K   6V   �� 53      -   5        $ 
BTN_Update��53      $��Обновить��6-   $	��120��6@   $��5q�6L   6W   54      �� 56      $��2��6   $ 
Horizontal=�6&   $��0 0 0 10q�6?   .+�57      �� -   5         ��Name$ SearchTextBox��57      $	��200��61   $��5q�6=   $��5q�6H   $��Center=�58      �� 59      -	   5        $ 
BTN_Search��59      $��
Найти��6-   $��80��6=   $��5q�6H   6S   5:      &   System.Windows.Controls.DataGrid  5<      -
   5          Name$ ProductsGrid��5<   $   $��3��6   	   AutoGenerateColumns$	 False��6:   
   CanUserAddRows$
 False��5=         
IsReadOnly$
 True��6.      Columns 5>      0  *System.Windows.Controls.DataGridTextColumn  5?      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Id+6L     5@      $ Наименование��6)   $ * 6X    6?   �� *Name+6X     5A      $ Цена��6)   $ * 6Q    67   �� *Price+6Q     5B      $ Количество��6)   $ * 6Z    6=   �� *
Quantity+6Z     5C      $ Поставщик��6)   $ * 6^    6<   �� *Supplier.Name+6^     5D      $ Тип��6)   $ * 6T    66   �� *	Type.Name+6T   5F      5G      5H      5I      