   M S B A M L   `   `   `  ����O  KDrugStoreApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:DrugStoreApplication.PharmacyPanel"DrugStoreApplication.PharmacyPanel  5   	   G    ADrugStoreApplication.PharmacyPanel.PharmacistProductPanel_AddEdit   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Blocal0clr-namespace:DrugStoreApplication.PharmacyPanel     5   	     � Title$$  PharmacistProductPanel_AddEdit��5   	   $	��600��60   $	��800��6=    � WindowStartupLocation$ CenterScreen=�6I   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ TB_Main��5      $��0��6%   $��3��62   $��20(�5      $
��Bold"�6"    �� TextAlignment$ Center=�64   $
��0,10q�6K   �� 5!   
   $��1��6   $��0��6!   $��Наименование��61   $��5q�6E   $��Center=�6P   �� 5"   
   -   5         ��Name$ TB_Name��5"   /   $��1��6   $��1��6   $��5q�6@   �� 5$   
   $��2��6   $��0��6!   $��Цена��61   $��5q�6=   $��Center=�6H   �� 5%   
   -   5        $ TB_Price��5%   /   $��2��6   $��1��6   $��5q�6v   �� 5'   
   $��3��6   $��0��6!   $��Количество��61   $��5q�6C   $��Center=�6N   �� 5(   
   -   5        $ TB_Quantity��5(   /   $��3��6   $��1��6   $��5q�6y   �� 5*   
   $��4��6   $��0��6!   $��Поставщик��61   $��5q�6B   $��Center=�6M   �� 5+   
   -   5         ��Name$ CB_Supplier��5+   0   $��4��6   $��1��6     �� DisplayMemberPath$
 Name��6E   	 �� SelectedValuePath$	 Id��5,      $��5q�6)   �� 5.   
   $��5��6   $��0��6!   $��Тип��61   $��5q�6<   $��Center=�6G   �� 5/   
   -   5        $ CB_Type��5/   0   $��5��6   $��1��6    $
 Name��6A   $	 Id��50      $��5q�6)   �� 52   
   $��6��6   $��0��6!   $��Изображение��61   $��5q�6D   $��Center=�6O   �� 53   
   $��6��6   $��1��6"   
 �� Orientation$
 
Horizontal=�62   $��5q�6K   .+�54      �� -   5        $ TB_ImagePath��54       �� 
IsReadOnly$
 True��6,   $	��200��6>   $��0,0,5,0q�6J   �� 55      -   5        $��Выбрать...��55      $��80��6H   56      �� 58   
   $��7��6   $��0��6!   $��Превью��61   $��5q�6?   $	��Top=�6J   �� 59   
   $��7��6   $��1��6   
�������$��1q�6A   $��5q�6U   $
��Left=�5:      $	��Top=�6,   ._�5;      �� -	   5         ��Name$ IMG_Preview��5;      $	��150��6)   $	��150��65   $��Uniform=�6B   5<      �� 5>   
   -
   5         ��Name$ BTN_EndManipulation��5>   /   $��10��6   $��1��6   $��Сохранить��6L   $��Center=�5?      $��5q�6.   $	��120��69   6E   5@      5A      