   M S B A M L   `   `   `  ����A  =BTv2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BTv2._0BTv2._0  5   	       BTv2._0.OptionWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:BTv2._0     5   	     � Title$  Options��5   	   $	��450��6   $	��800��6&    � WindowStartupLocation$ CenterScreen=�62    � 
ResizeMode$ CanMinimize=�6W   .��5	      � ��5
   
   �� 5       �� ImageSource$ MAINFRAME.jpg��6    j� Stretch$ UniformToFill=�65   .+�5   
   �� -   5         ��Name$ 
emplistBTN��5      $
��Left=�6%   $��	55,75,0,0q�6@   $	��Top=�6S   $	��120��6k   $��77��6w    � Cursor$
 Hand��6�   ��6�   Z� ��6�   Z� ��6�   Z� .��5      �� $��employee_list_option.png��6   $
��Fill=�66   $��55��6E   $��75��6Q   5      �� 5   
   -   5         ��Name$ wlcmLBL��5      $��Welcome��6!   $
��Left=�63   $��
305,11,0,0q�6N   $	��Top=�6b   $��36(�6z   $��Comic Sans MS)�6�   �� 5   
   -   5        $ 
emplistLBL��5      $��Employee List��6$   $
��Left=�6<   $��
175,95,0,0q�6W   $	��Top=�6k   $��14(�6�   $��Consolas)�6�   $
��Bold"�6�   $	��110��6�   $��25��6�   �� 5   
   -   5        $ productlistBTN��5      $
��Left=�6)   $��
55,155,0,0q�6D   $	��Top=�6X   $	��120��6p   $��85��6|   $
 Hand��6�   ��6�   Z� ��6�   Z� .��5      �� $��55��6   $��product_list_option.png��6    $
��Fill=�6A   $��75��6P   5      �� 5   
   -   5        $ productlistLBL��5      $��Product List��6(   $
��Left=�6?   $��175,187,0,0q�6Z   $	��Top=�6o   $	��110��6�   $��25��6�   $��14(�6�   $��Consolas)�6�   $
��Bold"�6�   �� 5   
   -   5        $ sellproductBTN��5      $
��Left=�6)   $��
55,251,0,0q�6D   $	��Top=�6X   $	��120��6p   $��85��6|   $
 Hand��6�   ��6�   Z� ��6�   Z� .��5      �� $��65��6   $��sell_product_opt.png��6    $
��Fill=�6>   $��90��6M   5      �� 5   
   -   5        $ sellproductLBL��5      $��Sell Product��6(   $
��Left=�6?   $��175,276,0,0q�6Z   $	��Top=�6o   $	��110��6�   $��25��6�   $��Consolas)�6�   $��14(�6�   $
��Bold"�6�   �� 5   
   -   5        $ takenotesBTN��5      $
��Left=�6'   $��
462,75,0,0q�6B   $	��Top=�6V   $	��120��6n   $��77��6z   $
 Hand��6�   ��6�   Z� ��6�   Z� .��5      �� $��55��6   $��note_option.png��6    $
��Fill=�69   $��75��6H   5      �� 5   
   -	   5        $ takenoteLBL��5      $��
Take Notes��6%   $
��Left=�6:   $��
582,95,0,0q�6U   $	��Top=�6i   $	��110��6�   $��25��6�   $��14(�6�   $��Consolas)�6�   $
��Bold"�6�   �� 5   
   -
   5        $ 
aboutmeBTN��5      $
��Left=�6%   $��462,155,0,0q�6@   $	��Top=�6U   $	��120��6m   $��85��6y   $
 Hand��6�   ��6�   Z� ��6�   Z� .��5      �� $��55��6   $��user_option.png��6    $
��Fill=�69   $��85��6H   5       �� 5!   
   -   5        $ 
aboutmeLBL��5!      $�� ��6$   $
��Left=�6/   $��582,187,0,0q�6J   $	��Top=�6_   $	��110��6w   $��25��6�   $��14(�6�   $��Consolas)�6�   $
��Bold"�6�   �� 5"   
   -   5        $ faqBTN��5"      $
��Left=�6!   $��462,251,0,0q�6<   $	��Top=�6Q   $	��120��6i   $��85��6u   $
 Hand��6�   ��6�   Z� ��6�   Z� .��5#      �� $��55��6   $��faq_option.png��6    $
��Fill=�68   $��85��6G   5$      �� 5%   
   -   5        $ faqLBL��5%      $��FAQ's��6    $
��Left=�60   $��582,276,0,0q�6K   $	��Top=�6`   $	��110��6x   $��25��6�   $��14(�6�   $��Consolas)�6�   $
��Bold"�6�   �� 5&   
   -   5        $ 	logoutBTN��5&      $
��Left=�6$   $��708,341,0,0q�6?   $	��Top=�6T   $��60��6l   $��55��6w   $
 Hand��6�   ��6�   Z� ��6�   Z� .��5'      �� $��50��6   $��logout_button.png��6    $
��Fill=�6;   $��50��6J   5(      �� 5)   
   -   5        $ virLBL��5)      $��Version 2.0��6    $
��Left=�66   $��359,383,0,0q�6Q   $	��Top=�6f   $��Consolas)�6~   $
��Bold"�6�   ���	#FFA8A8A8��6�   Z� 6�   �� 5*   
   -   5        $ clockLBL��5*      $�� ��6"   $
��Left=�6-   $��	650,5,0,0q�6H   $	��Top=�6[   $	��126��6s   $��60��6   $��Microsoft YaHei UI Light)�6�   $��14(�6�   $
 Wait��6�   $
��Bold"�6�   5,      5-      