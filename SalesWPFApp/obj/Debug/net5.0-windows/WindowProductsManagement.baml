   M S B A M L   `   `   `  ����F  BSalesWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SalesWPFAppSalesWPFApp  5   	        SalesWPFApp.WindowProducts   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SalesWPFApp     5   	   $��0q�5   	     � WindowStyle$
  None=�6   
���   � � 
ResizeMode$ NoResize=�6D    � Title$ Product Management��5	   	   $	��689��6$   $	��920��61    � WindowState$ Normal=�6=    � WindowStartupLocation$ CenterScreen=�6R   
���   �.��5
      ��  �� Orientation$ Vertical=�6   ���#a6d9ef$��2,0,0,0q�6=   $
��Left=�6N   $	��918��6i   .+�5   
   ��  �� CornerRadius$ 25��6   $��20,10,20,10q�6#   
���  ��
�������$	��881��6]   $	��661��6i   ._�5      �� $ Vertical=�6   .+�5      �� $��Product Management��6   $��25(�65   $��Center=�6C   $
��Bold"�6`   $��2,5,2,0q�6r   $��Bottom=�6�   � 5      $��2q�6    � RowDefinitions 5      �� 5      $
��auto �6(   68   �� 5      $��* �6(   65   �� 5      $��4* �6(   66   �� 5      $��* �6(   65   .+�5      �� $��0��6!   $ Vertical=�6.   $��Center=�6E   $*��$857                                 ��6b   $��305.76��5   #   
����ح�.+�5      �� $��
Product Id��6    �� 5      -   5        $��txtProductId��5   "   $��Stretch=�66   $��25��6T   ��5      ��  �� Path$ 	ProductId�	 �� Mode$	 OneWay=�
 � DataContext
 5      ��  �� ElementName$ 	lvProduct��$ SelectedItem��� 5      $��Category Id��6    �� 5      -   5        $��txtCategoryId��5   "   $��Stretch=�67   $��25��6U   ��5      �� $ 
CategoryId�$	 OneWay=�
 5       �� $ 	lvProduct��$ SelectedItem��� 5!      $��Product Name��6    �� 5"      -   5        $��txtPoductName��5"   "   $��Stretch=�67   $��25��6U   ��5#      �� $ ProductName�$	 OneWay=�
 5$      �� $ 	lvProduct��$ SelectedItem��� 5%      $��Weitht��6    �� 5&      -   5        $��	txtWeight��5&   "   $��Stretch=�63   $��25��6Q   ��5'      �� $ Weight�$	 OneWay=�
 5(      �� $ 	lvProduct��$ SelectedItem��� 5)      $��
Unit Price��6    �� 5*      -   5        $��txtUnitPrice��5*   "   $��Stretch=�66   $��25��6T   ��5+      �� $ 	UnitPrice�$	 OneWay=�
 5,      �� $ 	lvProduct��$ SelectedItem��� 5-      $��Unit In Stock��6    �� 5.      -   5        $��txtUnitInStock��5.   "   $��Stretch=�68   $��25��6V   ��5/      �� $ UnitsInStock�$	 OneWay=�
 50      �� $ 	lvProduct��$ SelectedItem�51      �� 53      $��1��6!   $ 
Horizontal=�6.   $
��Left=�6G   $��39.96��6b   .+�54      �� -   5        $��btnLoad��54   !   $��ReLoad��60   $��10q�6A   $��80��6M   6X   �� 56      -   5        $��	btnInsert��56   !   $��Insert��62   $��10q�6C   $��80��6O   57      �� 58      -	   5        $��	btnUpdate��58   !   $��Update��62   $��10q�6C   $��80��6O   59      �� 5:      -
   5        $��	btnDelete��5:   !   $��Delete��62   $��10q�6C   $��80��6O   5;      �� 5<      $��	Search : ��6    $��30��64   $��80,0,0,0q�6@   �� 5=      -   5        $��	txtSearch��5=   "   $	��243��63   $��22��6?   6K   5>      �� 5@      -   5        $��	lvProduct��5@   ,   $��2��6   $
��auto��6=   $
��auto��6J    �� View 5A      �� 5B      .P�5C   "   �� $��
Product Id��61    �� Width$	 100��6E    �� DisplayMemberBinding 5D   %   �� $ 	ProductId��� 5E   "   $��Category Id��61   $	 100��6F    5F   %   �� $ 
CategoryId��� 5G   "   $��Product Name��61   $	 160��6G    5H   %   �� $ ProductName��� 5I   "   $��Weight��61   $	 100��6A    5J   %   �� $ Weight��� 5K   "   $��
Unit Price��61   $	 130��6E    5L   %   �� $ 	UnitPrice��� 5M   "   $��Unit In Stock��61   $	 110��6H    5N   %   �� $ UnitsInStock��� 5O   "   $��Edit / Delete��61    �� CellTemplate 5P   &   �� 5Q   *   .R�5R   .   �� $ 
Horizontal=�69   .+�5S   2   �� $��70��69   $��5q�6D   $
��Edit��6O   $��Center=�6^   �� 5T   2   $��70��69   $��5q�6D   $��Delete��6O   $��Center=�6`   5U   /   5V   +   5X   #   5Y      5[      �� 5]      -   5        $��btnClose��5]      $��3��6-   $��10q�6:   $��Right=�6F   $��Bottom=�6b   $��80��6}   $��Close��6�   6�   5^      5_      5`      5a      5b      