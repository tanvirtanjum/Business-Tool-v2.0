   M S B A M L   `   `   `  ����A  =BTv2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BTv2._0BTv2._0  5   	       BTv2._0.EmpListWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:BTv2._0     5   	     � Title$  Employee List��5   	   $	��580��6   $
��1020��6,    � WindowStartupLocation$ CenterScreen=�69    � 
ResizeMode$ CanMinimize=�6^   .��5	      � $��-1,0,-7.4,-5.6q�6   $	��560��6#   ��5
   
   �� 5       �� ImageSource$ EMPLOYEELISTFRAME.jpg��6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ empDG��5         
IsReadOnly . $
��Left=�64   $	��325��6O   $��
360,85,0,0q�6\   $	��Top=�6p   $	��635��6�   $��14(�6�      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6�   
���   �
������� � Cursor$ No��6�    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader	 �� 
TargetType
 �� Property �� Value��%�   '        �� 5      "	  6   .�5      �� 
 � ��
 ���@�63   �� 5      
 � ��$ SemiBold"�63   �� 5      
 � ��$ 0,0,1,2q�68   �� 5      
 � ��
 �   �64   �� 5      
 � ��$ Center=�6C   5      5      5      �� 5   
   -   5         ��Name$ empidLBL��5      $��Employee ID:��6"   $
��Left=�69   $��	20,85,0,0q�6T   $	��Top=�6g   $��30��6   $	��100��6�   $��14(�6�   $
��Bold"�6�   �� 5   
   -   5        $ nameLBL��5      $��Name:��6!   $
��Left=�61   $��
20,135,0,0q�6L   $	��Top=�6`   $	��100��6x   $��30��6�   $��14(�6�   $
��Bold"�6�   �� 5   
   -   5        $ desigLBL��5      $��Designation:��6"   $
��Left=�69   $��
20,185,0,0q�6T   $	��Top=�6h   $	��100��6�   $��30��6�   $��14(�6�   $
��Bold"�6�   �� 5   
   $��Salary:��6   $
��Left=�6"   $��
20,235,0,0q�6=   $	��Top=�6Q   $��14(�6i   $
��Bold"�6w   $	��100��6�   $��30��6�   �� 5   
   -   5        $ mblLBL��5      $��
Mobile No:��6    $
��Left=�65   $��
20,285,0,0q�6P   $	��Top=�6d   $��14(�6|   $
��Bold"�6�   $	��100��6�   $��30��6�   �� 5   
   -   5        $ joindateLBL��5      $��
Join Date:��6%   $
��Left=�6:   $��
20,335,0,0q�6U   $	��Top=�6i   $	��100��6�   $��30��6�   $��14(�6�   $
��Bold"�6�   �� 5    
   -   5        $ addbyLBL��5       $��	Added By:��6"   $
��Left=�66   $��
20,385,0,0q�6Q   $	��Top=�6e   $	��100��6}   $��30��6�   $��14(�6�   $
��Bold"�6�   �� 5!   
   -   5         ��Name$ empidTB��5!      $
��Left=�6#   $��30��6>   $��
125,85,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��200��6�   $��14(�6�   $ IBeam��6�   ��6�   Z� �� 5"   
   -	   5        $ 	empnameTB��5"      $
��Left=�6%   $��30��6@   $��125,135,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��200��6�   $��14(�6�   $ IBeam��6�   ��6�   Z� �� 5#   
   -
   5        $ mobTB��5#      $
��Left=�6!   $��30��6<   $��125,285,0,0q�6H   $
 Wrap=�6]   $	��Top=�6q   $	��200��6�   $��14(�6�   $ IBeam��6�   ��6�   Z� �� 5$   
   -   5        $ salaryTB��5$      $
��Left=�6$   $��30��6?   $��125,235,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��200��6�   $��14(�6�   $ IBeam��6�   ��6�   Z� �� 5%   
   -   5        $ 
joindateTB��5%       �� 
IsReadOnly . $
��Left=�68   $��30��6S   $��125,335,0,0q�6_   $
 Wrap=�6t   $	��Top=�6�   $	��200��6�   $��14(�6�   $!��           Auto Generation ��6�   $ No��6�   ��6�   Z� �� 5&   
   -   5        $ addbyTB��5&       . $
��Left=�65   $��30��6P   $��125,385,0,0q�6\   $
 Wrap=�6q   $	��Top=�6�   $	��200��6�   $��14(�6�   $ IBeam��6�   ��6�   Z� 6�   �� 5'   
   -   5         ��Name$ desigCB��5'       �� SelectedIndex$ 0��6$   $
��Left=�66   $��125,185,0,0q�6Q   $	��Top=�6f   $	��200��6~   $��30��6�   $��14(�6�    �� 
IsReadOnly . $
 Hand��6�   ��6�   Z� .@�5(      �� $��             ---Select---��6   �� 5)      $��1. ADMIN��6   �� 5*      $��
2. MANAGER��6   �� 5+      $��3. SALESMAN��6   5-      �� 5.   
   -   5         ��Name$ backBTN��5.      $
��Left=�6"   $��
940,10,0,0q�6=   $	��Top=�6Q   $��50��6i   $��44��6t   $
 Hand��6�   ��6�   Z� ��6�   Z� .��5/      �� $��40��6   $��back_button__.png��6    $
��Fill=�6;   $��45��6J   50      �� 51   
   -   5        $ backLBL��51      $
��Back��6!   $
��Left=�60   $��
951,48,0,0q�6K   $	��Top=�6_   $��10(�6w   $��Consolas)�6�   $
��Bold"�6�   �� 52   
   -   5        $ idLBL��52      $	��ID:��6   $
��Left=�6-   $��
360,31,0,0q�6H   $	��Top=�6\   $��40��6t   $��30��6   $��14(�6�   $
��Bold"�6�   �� 53   
   -   5        $ 
searchidTB��53      $
��Left=�6&   $��30��6A   $��
400,31,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��200��6�   $��14(�6�   $ IBeam��6�   ��6�   Z� 6�   �� 54   
   -   5        $ 	searchBTN��54      $
��Left=�6$   $��
610,31,0,0q�6?   $	��Top=�6S   $��45��6k   $��30��6v   $
 Hand��6�   ��6�   Z� ��6�   Z� .��55      �� $��25��6   $��search_button.png��6    $
��Fill=�6;   $��40��6J   56      �� 57   
   -   5        $ 	logoutBTN��57      $
��Left=�6$   $��944,494,0,0q�6?   $	��Top=�6T   $��40��6l   $��40��6w   $
 Hand��6�   ��6�   Z� ��6�   Z� .��58      �� $��35��6   $��logout_button.png��6    $
��Fill=�6;   $��35��6J   59      �� 5:   
   -   5        $ showtableBTN��5:      $
��Left=�6'   $��940,414,0,0q�6B   $	��Top=�6W   $��50��6o   $��50��6�   $
 Hand��6�   ��6z   Z� ��6�   Z� .��5;      �� $��40��6   $��show_table_button.png��6    $
��Fill=�6?   $��45��6N   5<      �� 5=   
   -   5        $ showtableLBL��5=      $��
Show Table��6&   $
��Left=�6;   $��933,458,0,0q�6V   $	��Top=�6k   $��10(�6�   $
��Bold"�6�   $��Consolas)�6�   �� 5>   
   -   5        $ 
refreshBTN��5>      $
��Left=�6%   $��360,440,0,0q�6@   $	��Top=�6U   $��80��6m   $��60��6x   $
 Hand��6�   ��6�   Z� ��6�   Z� .��5?      �� $��40��6   $��refresh_button.png��6    $
��Fill=�6<   $��65��6K   5@      �� 5A   
   -   5        $ 	insertBTN��5A      $
��Left=�6$   $��500,440,0,0q�6?   $	��Top=�6T   $��80��6l   $��60��6�   $
 Hand��6�   ��6w   Z� ��6�   Z� .��5B      �� $��40��6   $��insert_button.png��6    $
��Fill=�6;   $��65��6J   5C      �� 5D   
   -   5        $ 	updateBTN��5D      $
��Left=�6$   $��640,440,0,0q�6?   $	��Top=�6T   $��80��6l   $��60��6w   $
 Hand��6�   ��6�   Z� ��6�   Z� .��5E      �� $��40��6   $��update_button.png��6    $
��Fill=�6;   $��65��6J   5F      �� 5G   
   -   5        $ 	deleteBTN��5G      $
��Left=�6$   $��780,440,0,0q�6?   $	��Top=�6T   $��80��6l   $��60��6�   $
 Hand��6�   ��6w   Z� ��6�   Z� .��5H      �� $��40��6   $��delete_button.png��6    $
��Fill=�6;   $��65��6J   5I      �� 5J   
   -   5        $ 
refreshLBL��5J      $��Refresh��6$   $
��Left=�66   $��375,500,0,0q�6Q   $	��Top=�6f   $��50��6~   $��25��6�   $��Consolas)�6�   $��10(�6�   $
��Bold"�6�   �� 5K   
   -   5        $ 	insertLBL��5K      $��Insert��6#   $
��Left=�64   $��517,500,0,0q�6O   $	��Top=�6d   $��50��6|   $��25��6�   $��10(�6�   $��Consolas)�6�   $
��Bold"�6�   �� 5L   
   -   5        $ 	updateLBL��5L      $��Update��6#   $
��Left=�64   $��658,500,0,0q�6O   $	��Top=�6d   $��50��6|   $��25��6�   $��10(�6�   $��Consolas)�6�   $
��Bold"�6�   �� 5M   
   -   5        $ 	deleteLBL��5M      $��Delete��6#   $
��Left=�64   $��797,500,0,0q�6O   $	��Top=�6d   $��50��6|   $��25��6�   $��10(�6�   $��Consolas)�6�   $
��Bold"�6�   5N      5O      