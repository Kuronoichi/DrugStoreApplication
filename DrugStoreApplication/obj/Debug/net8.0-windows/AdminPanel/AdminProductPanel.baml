   M S B A M L   `   `   `  ����O  KDrugStoreApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:DrugStoreApplication.AdminPanelDrugStoreApplication.AdminPanel  5   	   7    1DrugStoreApplication.AdminPanel.AdminProductPanel   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   ?local-clr-namespace:DrugStoreApplication.AdminPanel     5   	     � Title$  Продукты��5   	   $	��700��6   $	��800��6'    � 
ResizeMode$ NoResize=�63    � WindowStartupLocation$ CenterScreen=�6I   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      $��4* �6   .+�5   
   � $��0��6   
������� � RowDefinitions 5      �� 5      $��2* �6    �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      $��5* �6    .+�5      �� $��/Source/logo.png��6   �� 5      -   5         ��Name$ BTN_Profile��5   "   $��1��6      Menu_Button#��[  67   $��Профиль��6\   6n   �� 5      -   5        $ 
BTN_Orders��5   "   $��2��6   #��[  66   $��Панель заказы��6[   6s   �� 5       -   5        $ BTN_Products��5    "   $��3��6   #��[  68   $��Панель Товары��6]   6u   �� 5"      -   5        $ BTN_Suppliers��5"   "   $��4��6   #��[  69   $'��!Панель поставщики��6^   6z   �� 5$      -   5        $ 	BTN_Users��5$   "   $��5��6   #��[  65   $+��%Панель пользователи��6Z   6x   5%      � 5'   
   $��1��6   $��10q�6    5(      �� 5)      $
��Auto �6    �� 5*      $
��Auto �6    �� 5+      $
��Auto �6    �� 5,      $
��Auto �6    �� 5-      $��* �6    .+�50      �� $��0��6   $+��%Управление товарами��6%   $��28(�51      $
��Bold"�6&   $��Center=�52      $
��0 10q�65   �� 54      $��1��6    �� Orientation$ 
Horizontal=�6&   $��Center=�6?   $
��0 10q�6\   .+�55      �� -   5        $ BTN_Add��55      $��Добавить��6*   $	��120��6=   $��5q�6I   6T   �� 56      -   5        $ BTN_Edit��56      $��Изменить��6+   $	��120��6>   $��5q�6J   6U   �� 57      -   5        $ 
BTN_Delete��57      $��Удалить��6-   $	��120��6?   $��5q�6K   6V   �� 58      -	   5        $ 
BTN_Update��58      $��Обновить��6-   $	��120��6@   $��5q�6L   6W   59      �� 5;      $��2��6   $ 
Horizontal=�6&   $��0 0 0 10q�6?   .+�5<      �� -
   5         ��Name$ SearchTextBox��5<      $	��200��61   $��5q�6=   $��5q�6H   $��Center=�5=      �� 5>      -   5        $ 
BTN_Search��5>      $��
Найти��6-   $��80��6=   $��5q�6H   6S   5?      &   System.Windows.Controls.DataGrid  5A      -   5          Name$ ProductsGrid��5A   $   $��3��6   	   AutoGenerateColumns$	 False��6:   
   CanUserAddRows$
 False��5B         
IsReadOnly$
 True��6.      Columns 5C      0  *System.Windows.Controls.DataGridTextColumn  5D      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Id+6L     5E      $ Наименование��6)   $ * 6X    6?   �� *Name+6X     5F      $ Цена��6)   $ * 6Q    67   �� *Price+6Q     5G      $ Количество��6)   $ * 6Z    6=   �� *
Quantity+6Z     5H      $ Поставщик��6)   $ * 6^    6<   �� *Supplier.Name+6^     5I      $ Тип��6)   $ * 6T    66   �� *	Type.Name+6T   5K      5L      5M      5N      