   M S B A M L   `   `   `  ����N  JEmployeeInfoManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:EmployeeInfoManager.ViewsEmployeeInfoManager.Views  5      M+clr-namespace:EmployeeInfoManager.ViewModelEmployeeInfoManager.ViewModel  5      E'clr-namespace:EmployeeInfoManager.ModelEmployeeInfoManager.Model  5      ,    &EmployeeInfoManager.Views.EmployeeView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:EmployeeInfoManager.Views     5      A	viewModel+clr-namespace:EmployeeInfoManager.ViewModel     5      9model'clr-namespace:EmployeeInfoManager.Model     5        � 	Resources  5       �� 
TargetType �� Property �� Value �� DataType(   "EmployeeInfoManager.Model.Employee��%  '��       '�� r     (�� �     5      *, +)�� 5   
   " ��6   .�5      ��  � ��$	 150��6)   �� 5       � ��$ 5 0 5 0q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 10 0 5 0q�6'   5      �� 5   
   "  6   5      5      .��5       �  � RowDefinitions 5!   
   �� 5"      $
��Auto �6   �� 5#      $
��Auto �6   �� 5$      $��* �6   .+�5'   
   �� $��0��6   $��Center=�6!   $��Center=�6<   $��36(�6Y   $��Employee Record��6g   �� 5)   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��	0 10 0 10q�6;   .+�5*      �� $��Center=�6   $
��Left=�63   $��Name: ��6N   �� 5+      $��Center=�6   $
��Left=�61   $	��500��6x   $
��Auto��6�   ��6L   �� *Employee.Name+ �� Mode$ TwoWay=�6�   5,      � 5.   
   $��2��6    5/      �� 50      $
��Auto �6    $��30��6.   �� 51      $
��Auto �6    $��30��6.   �� 52      $
��Auto �6    $��30��6.   �� 53      $
��Auto �6    $��30��6.   �� 54      $
��Auto �6    $��30��6.   �� 55      $
��Auto �6    $��30��6.   �� 56      $
��Auto �6    $��30��6.   �� 57      $
��Auto �6    $��30��6.   �� 58      $
��Auto �6    $��30��6.   �� 59      $
��Auto �6    $��30��6.   �� 5:      $
��Auto �6    $��30��6.   �� 5;      $
��Auto �6    $��30��6.   �� 5<      $
��Auto �6    $��30��6.   �� 5=      $
��Auto �6    $��30��6.   �� 5>      $
��Auto �6    $��30��6.    � ColumnDefinitions 5@      �� 5A      $��* �6#   �� 5B      $��* �6#   .+�5E      �� $��0��6   $��0��6&   $ 
Horizontal=�66   .+�5F      �� $��Center=�6   $
��Left=�67   $��DOB: ��6R   �� 5G      $��Center=�6   $
��Left=�65   ��6P   �� *Employee.DateOfBirth+$ TwoWay=�5H      �� 5J      $��1��6   $��0��6&   $ 
Horizontal=�66   .+�5K      �� $��Center=�6   $
��Left=�67   $��Preferred Name: ��6R   �� 5L      $��Center=�6   $
��Left=�65   ��6P   �� *Employee.PreferredName+$ TwoWay=�5M      �� 5O      $��2��6   $��0��6&   $ 
Horizontal=�66   .+�5P      �� $��Center=�6   $
��Left=�67   $��	Phone #: ��6R   �� 5Q      $��Center=�6   $
��Left=�65   ��6P   �� *Employee.PhoneNumber+$ TwoWay=�5R      �� 5T      $��3��6   $��0��6&   $ 
Horizontal=�66   .+�5U      �� $��Center=�6   $
��Left=�67   $��Alternate Phone # ��6R   �� 5V      $��Center=�6   $
��Left=�65   ��6P   �� *Employee.PhoneNumber2+$ TwoWay=�5W      �� 5Y      $��4��6   $��0��6&   $ 
Horizontal=�66   .+�5Z      �� $��Center=�6   $
��Left=�67   $��Email Address: ��6R   �� 5[      $��Center=�6   $
��Left=�65   ��6P   �� *Employee.Email+$ TwoWay=�5\      �� 5^      $��5��6   $��0��6&   $ 
Horizontal=�66   .+�5_      �� $��Center=�6   $
��Left=�67   $��Alternate Email: ��6R   �� 5`      $��Center=�6   $
��Left=�65   ��6P   �� *Employee.Email2+$ TwoWay=�5a      �� 5c      $��6��6   $��0��6&   $ 
Horizontal=�66   .+�5d      �� $��Center=�6   $
��Left=�67   $��
Username: ��6R   �� 5e      $��Center=�6   $
��Left=�65   ��6P   �� *Employee.Username+$ TwoWay=�5f      �� 5h      $��7��6   $��0��6&   $ 
Horizontal=�66   .+�5i      �� $��Center=�6   $
��Left=�67   $��Alias: ��6R   �� 5j      $��Center=�6   $
��Left=�65   ��6P   �� *Employee.Alias+$ TwoWay=�5k      �� 5m      $��8��6   $��0��6&   $ 
Horizontal=�66   .+�5n      �� $��Center=�6   $
��Left=�67   $��Street Address: ��6R   �� 5o      $��Center=�6   $
��Left=�65   ��6P   �� *Employee.Address+$ TwoWay=�5p      �� 5r      $��9��6   $��0��6&   $ 
Horizontal=�66   .+�5s      �� $��Center=�6   $
��Left=�67   $��Address 2: ��6R   �� 5t      $��Center=�6   $
��Left=�65   ��6P   �� *Employee.Address2+$ TwoWay=�5u      �� 5w      $��10��6   $��0��6'   $ 
Horizontal=�67   .+�5x      �� $��Center=�6   $
��Left=�67   $��City: ��6R   �� 5y      $��Center=�6   $
��Left=�65   ��6P   �� *Employee.City+$ TwoWay=�5z      �� 5|      $��11��6   $��0��6'   $ 
Horizontal=�67   .+�5}      �� $��Center=�6   $
��Left=�67   $��
Zip Code: ��6R   �� 5~      $��Center=�6   $
��Left=�65   ��6P   �� *Employee.ZipCode+$ TwoWay=�5      �� 5�      $��0��6   $��1��6&   $ 
Horizontal=�66   .+�5�      �� $��Center=�6   $
��Left=�67   $��Date of Hire: ��6R   �� 5�      $��Center=�6   $
��Left=�65   ��6P   �� *Employee.DateOfHire+$ TwoWay=�5�      �� 5�      $��1��6   $��1��6&   $ 
Horizontal=�66   .+�5�      �� $��Center=�6   $
��Left=�67   $��Date of Separation: ��6R   �� 5�      $��Center=�6   $
��Left=�65   ��6P   �� *Employee.DateOfSeparation+$ TwoWay=�5�      �� 5�      $��2��6   $��1��6&   $ 
Horizontal=�66   .+�5�      �� $��Center=�6   $
��Left=�67   $��Active: ��6R   �� 5�      $��Center=�6   $
��Left=�66   	 d� 	IsChecked	 6Q   �� *Employee.Active+$ TwoWay=�5�      �� 5�      $��3��6   $��1��6&   $ 
Horizontal=�66   .+�5�      �� $��Center=�6   $
��Left=�67   $��Temporary: ��6R   �� 5�      $��Center=�6   $
��Left=�66   	 6Q   �� *Employee.Temporary+$ TwoWay=�5�      �� 5�      $��4��6   $��1��6&   $ 
Horizontal=�66   .+�5�      �� $��Center=�6   $
��Left=�67   $��Expiration: ��6R   �� 5�      $��Center=�6   $
��Left=�65   ��6P   �� *Employee.Expiration+$ TwoWay=�5�      �� 5�      $��6��6   $��1��6&   $ 
Horizontal=�66   .+�5�      �� $��Center=�6   $
��Left=�67   $��Job Title: ��6R   �� 5�      $��Center=�6   $
��Left=�65   ��6P   �� *Employee.JobTitle+$ TwoWay=�5�      �� 5�      $��7��6   $��1��6&   $ 
Horizontal=�66   .+�5�      �� $��Center=�6   $
��Left=�67   $��Department: ��6R   �� 5�      $��Center=�6   $
��Left=�65   ��6P   �� *Employee.Department+$ TwoWay=�5�      �� 5�      $��8��6   $��1��6&   $ 
Horizontal=�66   .+�5�      �� $��Center=�6   $
��Left=�67   $��	Manager: ��6R   �� 5�      $��Center=�6   $
��Left=�65   ��6P   �� *Employee.Manager+$ TwoWay=�5�      �� 5�      $��9��6   $��1��6&   $ 
Horizontal=�66   .+�5�      �� $��Center=�6   $
��Left=�67   $��Salary: ��6R   �� 5�      $��Center=�6   $
��Left=�65   ��6P   �� *Employee.Salary+$ TwoWay=�5�      �� 5�      $��10��6   $��1��6'   $ 
Horizontal=�67   .+�5�      �� $��Center=�6   $
��Left=�67   $��SSN or Tax ID: ��6R   �� 5�      $��Center=�6   $
��Left=�65   ��6P   �� *Employee.SSN+$ TwoWay=�5�      �� 5�      $��13��6   $��1��6#   $
��Save��63   $	��150��6a   
���2�2�$��0 0 0 5q�6�   ��6B   �� *
SaveRecord+6�   �� 5�      $��14��6   $��1��6#   $��Delete��63   $	��150��6e   
���  ��$��0 5 0 0q�6�   ��6D   �� *DeleteRecord+6�   5�      5�      5�      