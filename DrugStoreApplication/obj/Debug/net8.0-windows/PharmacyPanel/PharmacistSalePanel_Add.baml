   M S B A M L   `   `   `  ����O  KDrugStoreApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:DrugStoreApplication.PharmacyPanel"DrugStoreApplication.PharmacyPanel  5   	   @    :DrugStoreApplication.PharmacyPanel.PharmacistSalePanel_Add   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Blocal0clr-namespace:DrugStoreApplication.PharmacyPanel     5   	     � Title$  PharmacistSalePanel_Add��5   	   $	��450��6)   $	��800��66    � 
ResizeMode$ NoResize=�6B    � WindowStartupLocation$ CenterScreen=�6X   .��5	      � $��1��6   $��10q�6    � RowDefinitions 5
      �� 5      $
��Auto �6    �� 5      $��* �6    �� 5      $
��Auto �6    .+�5      �� $��0��6   $-��'Управление продажами��6%   $��28(�5      $
��Bold"�6&   $��Center=�5      $
��0 10q�65   �� 5      $��1��6   $%��Доступные товары��6$   $��0 0 0 10q�6>   .��5      �  5      �� 5      $
��Auto �6(   �� 5      $��* �6(   �� 5      $
��Auto �6(   .+�5      �� $��0��6!    �� Orientation$ 
Horizontal=�6.   $��0 0 0 5q�6G   .+�5      �� -   5         ��Name$ SearchTextBox��5   "   $	��200��69   $��5q�6E   $��5q�6P   $��Center=�5   "   �� 5      -   5         ��Name$ 
BTN_Search��5   !   $��
Найти��65   $��80��6E   $��5q�6P   6[   5       &   System.Windows.Controls.DataGrid  5"      -   5          Name$ ProductsGrid��5"   ,   $��1��6      AutoGenerateColumns$ False��6B   	   CanUserAddRows$	 False��5#      
   
IsReadOnly$

 True��66      Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��61      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Id+6T     5&      $ Наименование��61   $ * 6`    6G   �� *Name+6`     5'      $ Цена��61   $ * 6Y    6?   �� *Price+6Y     5(      $ Количество��61   $ * 6b    6E   �� *
Quantity+6b     5)      $ Поставщик��61   $ * 6f    6D   �� *Supplier.Name+6f   4  .System.Windows.Controls.DataGridTemplateColumn  5*      $
 Auto 65      CellTemplate 5+   "   �� 5,   &   .R�5-   *   �� $ BTN_Add��61   -   5        $��Продать��5-   B   
 � Tag 6l   �� *Id+5.   '   50      52      �� 54      $��2��6!   $ 
Horizontal=�6.   $��0 10 0 0q�6G   .+�55      �� $��Количество:��6$   $��Center=�67   $��5q�6R   �� 56      -   5        $ QuantityTextBox��56   "   $��50��6;   $��5q�6F   $��1��6Q   57      58      59      �� 5;      $��2��6   $ 
Horizontal=�6&   $��Right=�6?   .+�5<      �� -   5        $ 
BTN_Cancel��5<      $��Отмена��6-   $	��120��6>   $��5q�6J   6U   �� 5=      -   5        $ BTN_Save��5=      $��Сохранить��6+   $	��120��6?   $��5q�6K   6V   5>      5?      5@      