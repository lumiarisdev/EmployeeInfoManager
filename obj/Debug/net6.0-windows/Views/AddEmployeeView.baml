   M S B A M L   `   `   `  ����N  JEmployeeInfoManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:EmployeeInfoManager.ViewsEmployeeInfoManager.Views  5      M+clr-namespace:EmployeeInfoManager.ViewModelEmployeeInfoManager.ViewModel  5      /    )EmployeeInfoManager.Views.AddEmployeeView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:EmployeeInfoManager.Views     5      A	viewModel+clr-namespace:EmployeeInfoManager.ViewModel     5        � 	Resources  5       �� 
TargetType �� Property �� Value��%�   '��       '�� r     �� 5   
   " ��6   .�5      ��  � ��$	 150��6)   �� 5       � ��$ 5 0 5 0q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 10 0 5 0q�6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��Center=�6!   $��Center=�6<   $��36(�6Y   $��New Employee��6g   �� 5    
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��	0 10 0 10q�6;   .+�5!      �� $��Center=�6   $
��Left=�63   $��Name: ��6N   �� 5"      $��Center=�6   $
��Left=�61   $	��500��6{   $
��Auto��6�   ��6L   �� *NewEmployee.Name+ �� Mode$ TwoWay=�6�   5#      � 5%   
   $��2��6    5&      �� 5'      $
��Auto �6    $��30��6.   �� 5(      $
��Auto �6    $��30��6.   �� 5)      $
��Auto �6    $��30��6.   �� 5*      $
��Auto �6    $��30��6.   �� 5+      $
��Auto �6    $��30��6.   �� 5,      $
��Auto �6    $��30��6.   �� 5-      $
��Auto �6    $��30��6.   �� 5.      $
��Auto �6    $��30��6.   �� 5/      $
��Auto �6    $��30��6.   �� 50      $
��Auto �6    $��30��6.   �� 51      $
��Auto �6    $��30��6.   �� 52      $
��Auto �6    $��30��6.   �� 53      $
��Auto �6    $��30��6.   �� 54      $
��Auto �6    $��30��6.   �� 55      $
��Auto �6    $��30��6.    � ColumnDefinitions 57      �� 58      $��* �6#   �� 59      $��* �6#   .+�5<      �� $��0��6   $��0��6&   $ 
Horizontal=�66   .+�5=      �� $��Center=�6   $
��Left=�67   $��DOB: ��6R   �� 5>      $��Center=�6   $
��Left=�65   ��6P   �� *NewEmployee.DateOfBirth+$ TwoWay=�5?      �� 5A      $��1��6   $��0��6&   $ 
Horizontal=�66   .+�5B      �� $��Center=�6   $
��Left=�67   $��Preferred Name: ��6R   �� 5C      $��Center=�6   $
��Left=�65   ��6P   �� *NewEmployee.PreferredName+$ TwoWay=�5D      �� 5F      $��2��6   $��0��6&   $ 
Horizontal=�66   .+�5G      �� $��Center=�6   $
��Left=�67   $��	Phone #: ��6R   �� 5H      $��Center=�6   $
��Left=�65   ��6P   �� *NewEmployee.PhoneNumber+$ TwoWay=�5I      �� 5K      $��3��6   $��0��6&   $ 
Horizontal=�66   .+�5L      �� $��Center=�6   $
��Left=�67   $��Alternate Phone # ��6R   �� 5M      $��Center=�6   $
��Left=�65   ��6P   �� *NewEmployee.PhoneNumber2+$ TwoWay=�5N      �� 5P      $��4��6   $��0��6&   $ 
Horizontal=�66   .+�5Q      �� $��Center=�6   $
��Left=�67   $��Email Address: ��6R   �� 5R      $��Center=�6   $
��Left=�65   ��6P   �� *NewEmployee.Email+$ TwoWay=�5S      �� 5U      $��5��6   $��0��6&   $ 
Horizontal=�66   .+�5V      �� $��Center=�6   $
��Left=�67   $��Alternate Email: ��6R   �� 5W      $��Center=�6   $
��Left=�65   ��6P   �� *NewEmployee.Email2+$ TwoWay=�5X      �� 5Z      $��6��6   $��0��6&   $ 
Horizontal=�66   .+�5[      �� $��Center=�6   $
��Left=�67   $��
Username: ��6R   �� 5\      $��Center=�6   $
��Left=�65   ��6P   �� *NewEmployee.Username+$ TwoWay=�5]      �� 5_      $��7��6   $��0��6&   $ 
Horizontal=�66   .+�5`      �� $��Center=�6   $
��Left=�67   $��Alias: ��6R   �� 5a      $��Center=�6   $
��Left=�65   ��6P   �� *NewEmployee.Alias+$ TwoWay=�5b      �� 5d      $��8��6   $��0��6&   $ 
Horizontal=�66   .+�5e      �� $��Center=�6   $
��Left=�67   $��Street Address: ��6R   �� 5f      $��Center=�6   $
��Left=�65   ��6P   �� *NewEmployee.Address+$ TwoWay=�5g      �� 5i      $��9��6   $��0��6&   $ 
Horizontal=�66   .+�5j      �� $��Center=�6   $
��Left=�67   $��Address 2: ��6R   �� 5k      $��Center=�6   $
��Left=�65   ��6P   �� *NewEmployee.Address2+$ TwoWay=�5l      �� 5n      $��10��6   $��0��6'   $ 
Horizontal=�67   .+�5o      �� $��Center=�6   $
��Left=�67   $��City: ��6R   �� 5p      $��Center=�6   $
��Left=�65   ��6P   �� *NewEmployee.City+$ TwoWay=�5q      �� 5s      $��11��6   $��0��6'   $ 
Horizontal=�67   .+�5t      �� $��Center=�6   $
��Left=�67   $��
Zip Code: ��6R   �� 5u      $��Center=�6   $
��Left=�65   ��6P   �� *NewEmployee.ZipCode+$ TwoWay=�5v      �� 5x      $��0��6   $��1��6&   $ 
Horizontal=�66   .+�5y      �� $��Center=�6   $
��Left=�67   $��Date of Hire: ��6R   �� 5z      $��Center=�6   $
��Left=�65   ��6P   �� *NewEmployee.DateOfHire+$ TwoWay=�5{      �� 5}      $��1��6   $��1��6&   $ 
Horizontal=�66   .+�5~      �� $��Center=�6   $
��Left=�67   $��Date of Separation: ��6R   �� 5      $��Center=�6   $
��Left=�65   ��6P   �� *NewEmployee.DateOfSeparation+$ TwoWay=�5�      �� 5�      $��2��6   $��1��6&   $ 
Horizontal=�66   .+�5�      �� $��Center=�6   $
��Left=�67   $��Active: ��6R   �� 5�      $��Center=�6   $
��Left=�66    d� 	IsChecked 6Q   �� *NewEmployee.Active+$ TwoWay=�5�      �� 5�      $��3��6   $��1��6&   $ 
Horizontal=�66   .+�5�      �� $��Center=�6   $
��Left=�67   $��Temporary: ��6R   �� 5�      $��Center=�6   $
��Left=�66    6Q   �� *NewEmployee.Temporary+$ TwoWay=�5�      �� 5�      $��4��6   $��1��6&   $ 
Horizontal=�66   .+�5�      �� $��Center=�6   $
��Left=�67   $��Expiration: ��6R   �� 5�      $��Center=�6   $
��Left=�65   ��6P   �� *NewEmployee.Expiration+$ TwoWay=�5�      �� 5�      $��6��6   $��1��6&   $ 
Horizontal=�66   .+�5�      �� $��Center=�6   $
��Left=�67   $��Job Title: ��6R   �� 5�      $��Center=�6   $
��Left=�65   ��6P   �� *NewEmployee.JobTitle+$ TwoWay=�5�      �� 5�      $��7��6   $��1��6&   $ 
Horizontal=�66   .+�5�      �� $��Center=�6   $
��Left=�67   $��Department: ��6R   �� 5�      $��Center=�6   $
��Left=�65   ��6P   �� *NewEmployee.Department+$ TwoWay=�5�      �� 5�      $��8��6   $��1��6&   $ 
Horizontal=�66   .+�5�      �� $��Center=�6   $
��Left=�67   $��	Manager: ��6R   �� 5�      $��Center=�6   $
��Left=�65   ��6P   �� *NewEmployee.Manager+$ TwoWay=�5�      �� 5�      $��9��6   $��1��6&   $ 
Horizontal=�66   .+�5�      �� $��Center=�6   $
��Left=�67   $��Salary: ��6R   �� 5�      $��Center=�6   $
��Left=�65   ��6P   �� *NewEmployee.Salary+$ TwoWay=�5�      �� 5�      $��10��6   $��1��6'   $ 
Horizontal=�67   .+�5�      �� $��Center=�6   $
��Left=�67   $��SSN or Tax ID: ��6R   �� 5�      $��Center=�6   $
��Left=�65   ��6P   �� *NewEmployee.SSN+$ TwoWay=�5�      �� 5�      $��12��6   $��1��6#   $��Submit Record��63   ��6K   �� *AddEmployee+��6k   �� *NewEmployee+�� 5�      $��13��6   $��1��6"   $��Center=�6_   ��62   �� *WarningText+$ OneWay=�6_   5�      5�      5�      