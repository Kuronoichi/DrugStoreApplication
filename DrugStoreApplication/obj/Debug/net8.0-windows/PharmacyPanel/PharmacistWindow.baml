   M S B A M L   `   `   `  ����O  KDrugStoreApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DrugStoreApplicationDrugStoreApplication  5   	   +    %DrugStoreApplication.PharmacistWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   4local"clr-namespace:DrugStoreApplication     5   	     � Title$  PharmacistWindow��5   	   $	��650��6"   $	��800��6/    � 
ResizeMode$ NoResize=�6;    � WindowStartupLocation$ CenterScreen=�6Q   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      $��4* �6   .+�5   
   � $��0��6   
������� � RowDefinitions 5      �� 5      $��2* �6    �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      $��5* �6    .+�5      �� $��/Source/logo.png��6   �� 5      -   5         ��Name$ BTN_Profile��5   "   $��1��6      Menu_Button#��[  67   $��Профиль��6\   6n   �� 5      -   5        $ 
BTN_Orders��5   "   $��2��6   #��[  66   $!��Панель продажи��6[   6t   �� 5      -   5        $ BTN_Products��5   "   $��3��6   #��[  68   $��Панель товары��6]   6u   5       � 5"   
   $��1��6   .+�5#      �  5%      �� 5&      �� 5'      �� 5(      �� 5)      �� 5*      �� 5+      �� 5,       5/      �� 50      �� 51      �� 52      �� 53      �� 54      .+�57      �� $��1��6   $��2��6%   $��Source/Profile.png��65   $��Uniform=�6Q   �� 59      $��1��6   $��2��6,   $��3��69   $
��20pxq�6M   $
��30px(�6[   $��Профиль��6k    �� TextAlignment$ Center=�6z   �� 5;      -   5         ��Name$ TB_Login��5;   K   $��1��6   $��3��6*   $��3��67   $
��20pxq�6]   $
��20px(�6k   $��Login��6{   $��Center=�6�   $	��5pxq�6�   ${�False��6�   �� 5=      -   5        $ TB_Password��5=   K   $��1��6   $��4��6*   $��3��67   $
��20pxq�6`   $
��20px(�6n   $��Password��6~   $��Center=�6�   $	��5pxq�6�   ${�False��6�   �� 5?      -   5        $ BTN_Exit��5?   J   $��1��6   $��5��6)   $��3��66   $
��20pxq�6\   $
��15px(�6j   $$��Выйти из системы��6z   6�   5A      5B      5C      5D      