   M S B A M L   `   `   `  ����O  KDrugStoreApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DrugStoreApplicationDrugStoreApplication  5   	   &     DrugStoreApplication.LoginWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:DrugStoreApplication     5   	     � Title$  LoginWindow��5   	   $	��600��6   $	��800��6*    � 
ResizeMode$ NoResize=�66    � WindowStartupLocation$ CenterScreen=�6L   .��5	      �  � RowDefinitions 5
   
   �� 5      $��0.25* �6   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      $��0.25* �6    � ColumnDefinitions 5   
   �� 5      $��0.25* �6   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      $��0.25* �6   .+�5   
   �� $��1��6   $��2��6   $��3��6-   $��2��6A   $��Uniform=�6R   $��Source/logo.png��6d   �� 5!   
   $��2��6   $��4��6$   $
��20px(�61   $��
Логин��6A   $��Center=�6N   $��Center=�6k   �� 5#   
   $��2��6   $��5��6$   $
��20px(�61   $��Пароль��6A   $��Center=�6O   $��Center=�6l   �� 5%   
   -   5         ��Name$ TB_Login��5%   C   $��3��6   $��4��6"   $��2��6/   $
��18px(�6U   $��Admin��6e   $��Center=�6r   $
��20pxq�6�   $	��5pxq�6�   �� 5'   
   -   5        $ TB_Password��5'   C   $��3��6   $��5��6"   $��2��6/   $
��18px(�6X   $��12345��6h   $��Center=�6u   $
��20pxq�6�   $	��5pxq�6�   �� 5)   
   -   5         ��Name$ 	BTN_Login��5)   B   $��2��6   $��6��6!   $��3��6.   $
��20px(�6U   $"��Войти в систему��6e   $
��20pxq�6   6�   5*      5+      