   M S B A M L   `   `   `  ����O  KDrugStoreApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DrugStoreApplicationDrugStoreApplication  5   	   5    /DrugStoreApplication.AdminSupplierPanel_AddEdit   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   4local"clr-namespace:DrugStoreApplication     5   	     � Title$6  0Манипуляция с поставщиком��5   	   $	��450��6+   $	��800��68    � 
ResizeMode$ NoResize=�6D    � WindowStartupLocation$ CenterScreen=�6Z   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      $��3* �6   �� 5      .+�5   
   �� -   5         ��Name$ TB_Main��5      $��0��6%   $��1��62   $��20(�5      $
��Bold"�6"    �� TextAlignment$ Center=�64   �� 5    
   $��1��6   $��1��6!   $��Наименование��61   $��20(�6E   $ Center=�6S   �� 5!   
   -   5         ��Name$ TB_Name��5!   /   $��2��6   $��1��6   $��5q�6@   �� 5#   
   $��3��6   $��1��6!   $��Телефон��61   $��20(�6@   $ Center=�6N   �� 5$   
   -   5        $ TB_Phone��5$   /   $��4��6   $��1��6    �� 	MaxLength$ 11��6A   $��5q�6�   �� 5&   
   -   5        	 ��Name$	 BTN_EndManipulation��5&   .   $��9��6   $��1��6   $��Завершить��6K   $��5q�6_   6j   5'      5(      