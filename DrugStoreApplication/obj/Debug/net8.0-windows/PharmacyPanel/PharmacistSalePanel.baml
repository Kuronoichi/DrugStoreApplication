   M S B A M L   `   `   `  ����O  KDrugStoreApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:DrugStoreApplication.PharmacyPanel"DrugStoreApplication.PharmacyPanel  5   	   <    6DrugStoreApplication.PharmacyPanel.PharmacistSalePanel   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Blocal0clr-namespace:DrugStoreApplication.PharmacyPanel     5   	     � Title$  PharmacistSalePanel��5   	   $	��600��6%   $	��800��62    � 
ResizeMode$ NoResize=�6>    � WindowStartupLocation$ CenterScreen=�6T   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      $��4* �6   .+�5   
   � $��0��6   
������� � RowDefinitions 5      �� 5      $��2* �6    �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      $��5* �6    .+�5      �� $��/Source/logo.png��6   �� 5      -   5         ��Name$ BTN_Profile��5   "   $��1��6      Menu_Button#��[  67   $��Профиль��6\   6n   �� 5      -   5        $ 
BTN_Orders��5   "   $��2��6   #��[  66   $!��Панель продажи��6[   6t   �� 5      -   5        $ BTN_Products��5   "   $��3��6   #��[  68   $��Панель товары��6]   6u   5       � 5"   
   $��1��6    5#      �� 5$      $
��Auto �6    �� 5%      $
��Auto �6    �� 5&      $��* �6    .+�5)      �� $��0��6    �� Orientation$ 
Horizontal=�6&   $��Center=�6?   $
��0 10q�6\   .+�5*      �� -   5        $ BTN_Add��5*      $��Добавить��6*   $	��120��6=   $��5q�6I   6T   �� 5+      -   5        $ 
BTN_Delete��5+      $��Удалить��6-   $	��120��6?   $��5q�6K   6V   �� 5,      -   5        $ 
BTN_Update��5,      $��Обновить��6-   $	��120��6@   $��5q�6L   6W   5-      &   System.Windows.Controls.DataGrid  5/      -   5          Name$ 	SalesGrid��5/   $   $��1��6      AutoGenerateColumns$ False��67   $��5q�6S   	   CanUserAddRows$	 False��50      
   
IsReadOnly$

 True��6.      Columns 51      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Id+6L     53      $ Дата��6)   $ * 6o    67   �� *Date+ �� StringFormat$ {0:dd.MM.yyyy}��6o     54      $ Количество��6)   $ * 6Z    6=   �� *
Quantity+6Z     55      $ Цена��6)   $ * 6Q    67   �� *Price+6Q     56      $ 
Товар��6)   $ * 6Z    68   �� *Medicine.Name+6Z     57      $ Продавец��6)   $ * 6Z    6;   �� *
User.Login+6Z   59      5;      5<      5=      