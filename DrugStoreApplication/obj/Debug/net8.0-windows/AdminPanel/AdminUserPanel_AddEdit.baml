   M S B A M L   `   `   `  ����O  KDrugStoreApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DrugStoreApplicationDrugStoreApplication  5   	   1    +DrugStoreApplication.AdminUserPanel_AddEdit   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   4local"clr-namespace:DrugStoreApplication     5   	     � Title$:  4Манипуляция с пользователем��5   	   $	��450��6-   $	��800��6:    � 
ResizeMode$ NoResize=�6F    � WindowStartupLocation$ CenterScreen=�6\   .��5	      �  � RowDefinitions 5
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
   $��1��6   $��1��6!   $��
Логин��61   $��20(�6>   $ Center=�6L   �� 5!   
   -   5         ��Name$ TB_Login��5!   >   $��2��6   $��1��6    �� 	MaxLength$ 50��6/   $��5q�6P   �� 5#   
   $��3��6   $��1��6!   $��Пароль��61   $��20(�6?   $ Center=�6M   �� 5$   
   -   5        $ TB_Password��5$   >   $��4��6   $��1��6   $ 50��6/   $��5q�6S   �� 5&   
   $��5��6   $��1��6!   $��Телефон��61   $��20(�6@   $ Center=�6N   �� 5'   
   -   5        $ TB_Phone��5'   m   $��6��6   $��1��6   $ 11��6^   $��5q�6   �� 5)   
   -   5        $ TB_Role��5)      $��7��6%   $��1��62   $��Роль��6B   $��20(�6O   $ Center=�6]   �� 5*   
   -   5        	 ��Name$	 CB_Role��5*   0   $��8��6   $��1��6    
 �� DisplayMemberPath$

 Name��6A    �� SelectedValuePath$ ID��5+      $��5q�6*    �� SelectedIndex$ 0��65   �� 5-   
   -   5         ��Name$ BTN_EndManipulation��5-   .   $��9��6   $��1��6   $��Завершить��6K   $��5q�6_   6j   5.      5/      