   M S B A M L   `   `   `  ����A  =BTv2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BTv2._0BTv2._0  5   	       BTv2._0.LogInWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:BTv2._0     5   	     � Title$  Log-In��5   	    � WindowStartupLocation$ CenterScreen=�6    � 
ResizeMode$ CanMinimize=�6=   $��476.4��6V   $	��378��6e   .��5	      � $��0,0,-0.8,-3.8q�6   ��5
   
   �� 5       �� ImageSource$ LOGINFRAME.jpg��6    j� Stretch$ UniformToFill=�66   .+�5   
   �� $��20,13,67,268q�6   $��bt_logo_option.png��6&   $
��Fill=�6B   �� 5   
   -   5         ��Name$ lidTB��5      $
��Left=�6!   $��30��6<   $��
91,259,0,0q�6H    �� TextWrapping$
 Wrap=�6\   $	��Top=�6p   $	��217��6�   $��15(�6�   ���	#00000000 � Cursor$ IBeam��6�   G� 5   
   -   5         G�Name$ passPB��5      $y�Visible=�6&   $
��Left=�6;   $��
91,316,0,0q�6V   $	��Top=�6j   $��30��6�   $	��217��6�   $��15(�6�   ���	#00000000$ IBeam��6�   �� 5   
   -   5        $ passTB��5      $y�Hidden=�6"   	 �� 
IsReadOnly	 . $
��Left=�6H   $��
91,316,0,0q�6c   $	��Top=�6w   $��30��6�   $	��217��6�   $��15(�6�   ���	#00000000$ IBeam��6�   �� 5   
   -   5        
 ��Name$
 loginBTN��5      $��LOGIN��6#   $
��Left=�63   $��122,371,0,0q�6N   $	��Top=�6c   $	��133��6{   $��30��6�   $��Consolas)�6�   $��14(�6�   
�������$
��Bold"�6�   ���	#00000000��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF1B3457��6#    � Offset$ 0Q�65   � 5      $ 	#FF296ED3��6#   $ 1Q�65   5      5      �� 5   
   $��36,259,275,155q�6   $��user_field.png��6(   $
��Fill=�6@   �� 5   
   $��45,309,287,92q�6   $��password_field.png��6'   $
��Fill=�6C   �� 5   
   $2��,Login with your organization ID. & password.��6   $��
10,197,2,0q�6K   $	��Top=�6_   $��36��6w   $��15(�6�   $
��Bold"�6�   $��Comic Sans MS)�6�   �� 5   
   -   5         ��Name$ 
showpassCB��5      $�� ��6'   $
��Left=�62   $��310,325,0,0q�6M   $	��Top=�6b   $��15��6z   $��15��6�   $��8(�6�   $
 Hand��6�   6�   �� 5   
   -   5         ��Name$ showpassLBL��5      $
��SHOW��6%   $
��Left=�64   $��322,322,0,0q�6O   $	��Top=�6d   $��8(�6|   $
��Bold"�6�   �� 5   
   -   5        $ virLBL��5      $��Version 2.0��6    $
��Left=�66   $��294,420,0,0q�6Q   $	��Top=�6f   ���	#FF636060$��Consolas)�6�   $
��Bold"�6�   $��10(�6�   5"      5#      