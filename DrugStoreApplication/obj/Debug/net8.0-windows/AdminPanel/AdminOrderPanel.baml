   M S B A M L   `   `   `  ����O  KDrugStoreApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:DrugStoreApplication.AdminPanelDrugStoreApplication.AdminPanel  5   	   5    /DrugStoreApplication.AdminPanel.AdminOrderPanel   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   ?local-clr-namespace:DrugStoreApplication.AdminPanel     5   	     � Title$  Заказы��5   	   $	��600��6   $
��1000��6%    � 
ResizeMode$ NoResize=�62    � WindowStartupLocation$ CenterScreen=�6H   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      $��4* �6   .+�5   
   � $��0��6   
������� � RowDefinitions 5      �� 5      $��2* �6    �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      $��5* �6    .+�5      �� $��/Source/logo.png��6   �� 5      -   5         ��Name$ BTN_Profile��5   "   $��1��6      Menu_Button#��[  67   $��Профиль��6\   6n   �� 5      -   5        $ 
BTN_Orders��5   "   $��2��6   #��[  66   $��Панель заказы��6[   6s   �� 5      -   5        $ BTN_Products��5   "   $��3��6   #��[  68   $��Панель Товары��6]   6u   �� 5!      -   5        $ BTN_Suppliers��5!   "   $��4��6   #��[  69   $'��!Панель поставщики��6^   6z   �� 5#      -   5        $ 	BTN_Users��5#   "   $��5��6   #��[  65   $+��%Панель пользователи��6Z   6x   5$      � 5&   
   $��1��6    5'      �� 5(      $
��Auto �6    �� 5)      $
��Auto �6    �� 5*      $
��Auto �6    �� 5+      $��* �6    .+�5.      �� $��0��6   $+��%Управление заказами��6%   $��28(�5/      $
��Bold"�6&   $��Center=�50      $
��0 10q�65   �� 52      $��1��6    �� Orientation$ 
Horizontal=�6&   $��Center=�6?   $
��0 10q�6\   .+�53      �� -   5        $ BTN_Add��53      $��Добавить��6*   $	��120��6=   $��5q�6I   6T   �� 54      -   5        $ BTN_Edit��54      $��Изменить��6+   $	��120��6>   $��5q�6J   6U   �� 55      -   5        $ 
BTN_Delete��55      $��Удалить��6-   $	��120��6?   $��5q�6K   6V   �� 56      -	   5        $ 
BTN_Update��56      $��Обновить��6-   $	��120��6@   $��5q�6L   6W   57      &   System.Windows.Controls.DataGrid  59      -
   5          Name$ 
OrdersGrid��59   $   $��2��6      AutoGenerateColumns$ False��68   $��5q�6T   	   CanUserAddRows$	 False��5:      
   
IsReadOnly$

 True��6.      Columns 5;      0  *System.Windows.Controls.DataGridTextColumn  5<      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Id+6L     5=      $ Дата��6)   $ * 6o    67   �� *Date+ �� StringFormat$ {0:dd.MM.yyyy}��6o     5>      $ 
Сумма��6)   $ * 6Q    68   �� *Cost+6Q     5?      $ Статус��6)   $ * 6Y    69   �� *Status.Name+6Y     5@      $ Поставщик��6)   $ * 6^    6<   �� *Supplier.Name+6^   5B      5D      5E      5F      