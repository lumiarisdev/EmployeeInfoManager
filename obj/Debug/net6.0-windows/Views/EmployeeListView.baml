   M S B A M L   `   `   `  ����N  JEmployeeInfoManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:EmployeeInfoManager.ViewsEmployeeInfoManager.Views  5      E'clr-namespace:EmployeeInfoManager.ModelEmployeeInfoManager.Model  5      0    *EmployeeInfoManager.Views.EmployeeListView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:EmployeeInfoManager.Views     5      9model'clr-namespace:EmployeeInfoManager.Model     5        � 	Resources  5       �� DataType(   "EmployeeInfoManager.Model.Employee �� Orientation d� 	IsChecked��%�  (��       5      *, +)�� 6
   "  6   .R�5      �� $ 
Horizontal=�6   .+�5      �� $	��150��6   $��10q�6,   $ Vertical=�68   .+�5      �� $ 
Horizontal=�6!   .+�5      �� $��Name: ��6$   �� 5      ��6$   �� *Name+5      �� 5      $ 
Horizontal=�6!   .+�5      �� $��
Username: ��6$   �� 5      ��6$   �� *
Username+5      �� 5      $ 
Horizontal=�6!   .+�5      �� $��Email: ��6$   �� 5      ��6$   �� *Email+5      5      �� 5      $	��150��6   $��10q�6,   $ Vertical=�68   .+�5      �� $ 
Horizontal=�6!   .+�5      �� $��Phone Number: ��6$   �� 5      ��6$   �� *PhoneNumber+5       �� 5!      $ 
Horizontal=�6!   .+�5"      �� $��Alternate Phone: ��6$   �� 5#      ��6$   �� *PhoneNumber2+5$      �� 5%      $ 
Horizontal=�6!   .+�5&      �� $��Alternate Email: ��6$   �� 5'      ��6$   �� *Email2+5(      5)      �� 5*      $ 
Horizontal=�6   .+�5+      �� $��Active?��6    $��Center=�6/   $��Center=�6J   �� 5,      $��Center=�6   $��Center=�6:   $��10q�6W   ${�False��6�    6c   �� *Active+6�   5-      5.      5/      50      .��52      �  � RowDefinitions 53   
   �� 54      $
��Auto �6   �� 55      $��* �6   �� 56      $
��Auto �6   .+�59   
   �� $��Employee List��6   $��30��6)   $��24(�68   $��Center=�6F   $��Center=�6c   $��0 0 0 15q�6~   �� 5;   
   $��1��6^   $��0q�6k   ��6   �� *	Employees+ �� SelectedItem 64   �� *SelectedEmployee+6k   5=      5?      