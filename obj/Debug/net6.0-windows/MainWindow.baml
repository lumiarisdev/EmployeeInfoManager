   M S B A M L   `   `   `  ����N  JEmployeeInfoManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:EmployeeInfoManagerEmployeeInfoManager  5   	   E'clr-namespace:EmployeeInfoManager.ViewsEmployeeInfoManager.Views  5   	   M+clr-namespace:EmployeeInfoManager.ViewModelEmployeeInfoManager.ViewModel  5   	   $    EmployeeInfoManager.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:EmployeeInfoManager     5   	   9views'clr-namespace:EmployeeInfoManager.Views     5   	   B
viewModels+clr-namespace:EmployeeInfoManager.ViewModel     5   	     � Title$  
MainWindow��5
   	   $	��720��6   $
��1280��6)    � DataContext 5      7   1EmployeeInfoManager.ViewModel.MainWindowViewModel  5   
    � 	Resources 5       �� DataType9   3EmployeeInfoManager.ViewModel.EmployeeListViewModel0   *EmployeeInfoManager.Views.EmployeeListView5   /EmployeeInfoManager.ViewModel.EmployeeViewModel,   &EmployeeInfoManager.Views.EmployeeView8   2EmployeeInfoManager.ViewModel.AddEmployeeViewModel/   )EmployeeInfoManager.Views.AddEmployeeView1   +EmployeeInfoManager.ViewModel.HomeViewModel(	   "EmployeeInfoManager.Views.HomeView��%,  (��       5      *, +)(�� 2     5      *, +)(�� d     5      *, +)(�� �     5      *, +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5      	  5      5       .��5"      �  � ColumnDefinitions 5#   
   �� 5$      $��9* �6   �� 5%      $��* �6   $	��100��6)   .+�5(   
   � $��1��6    � RowDefinitions 5)      �� 5*      $��* �6    �� 5+      $��* �6    .+�5.      �� -   5         ��Name$ NavBar��5.   =   $��0��6    �� Orientation$ Vertical=�6&   .+�50      �� $
��Home��6   $
��home��6G   $��	0 10 10 3q�6_   ��6(   �� *
NavCommand+6_   �� 52      $��Employee List��6   $��employeelist��6P   $��	0 10 10 3q�6p   ��61   �� *
NavCommand+6p   �� 54      $��Add Employee��6   $��addEmployee��6O   $��0 3 10 3q�6n   ��60   �� *
NavCommand+6n   �� 56      $��Search Employee��6   $��searchEmployee��6R   $��0 3 10 3q�6t   ��63   �� *
NavCommand+6t   �� 58      $ Vertical=�6   .+�59      �� $��Search Employee By: ��6    $��Center=�6<   $��15��6Y   $��0 40 3 0q�6h   �� 5:      -   5        $��0 3 10 3q�5:   L   .@�5;      �� $��Username��6'    �� 
IsSelected$
 True��6:   �� 5<      $��Email��6'   �� 5=      $��Alias��6'   �� 5>      $
��Name��6'   �� 5?      $��Phone Number��6'   5@      �� 5A      	 �� TextWrapping$
	 Wrap=�6Q   $��Center=�6e   $��Center=�6�   $��75��6�   $
��Auto��6�   $��20��6�   $��40��6�   $��0 3 10 3q�6�   ��6   �� *SearchInput.Username+
 �� Mode$
 TwoWay=�6�   �� 5B      $��Search��6   $��Center=�6.   $��75��6�   $��0 3 10 3q�6�   ��6K   �� *SearchCommand+��6m   �� *SearchInput.Username+6�   5C      �� 5E      $��Open Selected��6   $��employee��6P   $��	0 40 10 3q�6l   ��61   �� *
NavCommand+6l   5G      �� 5I      $��1��6   $��DB Connection��6"   $��	0 3 10 10q�6W   $��Bottom=�6k   ��6:   �� *
DBPrompt+6k   5K      � 5M   
   -   5         �Name$ MainContent��5M      $��0��6$   .+�5N      �� ��6   �� *CurrentViewModel+5O      5Q      5S      