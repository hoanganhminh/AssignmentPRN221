   M S B A M L   `   `   `  ����F  BSalesWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SalesWPFAppSalesWPFApp  5   	   '    !SalesWPFApp.WindowOrderManagement   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SalesWPFApp     5   	   $��0q�5   	     � WindowStyle$
  None=�6   
���   � � 
ResizeMode$ NoResize=�6D    � Title$ Order Management��5	   	   $	��689��6"   $	��917��6/    � WindowState$ Normal=�6;    � WindowStartupLocation$ CenterScreen=�6P   
���   �.��5
      ��  �� Orientation$ Vertical=�6   ���#a6d9ef$��2,0,0,0q�6=   .+�5   
   ��  �� CornerRadius$ 25��6   $��20,10,20,10q�6#   
���  ��
�������$	��863��6]   $	��661��6i   ._�5      �� $ Vertical=�6   .+�5      �� $��Order Management��6   $��25(�63   $��Center=�6A   $
��Bold"�6^   $��2,5,2,0q�6p   $��Bottom=�6�   � 5      $��2q�6    � RowDefinitions 5      �� 5      $
��auto �6(   68   �� 5      $��* �6(   65   �� 5      $��4* �6(   66   �� 5      $��* �6(   65   .+�5      �� $ Vertical=�6!   $��Center=�68   $	��838��6U   
����ح�$��0,0,0,88q�6x   $��2��6�   .+�5      �� $��Order Id��6    �� 5      -   5        $��
txtOrderId��5   "   $��Stretch=�64   $��25��6R   ��5      ��  �� Path$ OrderId�	 �� Mode$	 OneWay=�
 � DataContext
 5      ��  �� ElementName$ lvOrder��$ SelectedItem��� 5      $��	Member Id��6    �� 5      -   5        $��txtMemberId��5   "   $��Stretch=�65   $��25��6S   ��5      �� $ MerberId�$	 OneWay=�
 5      �� $ lvOrder��$ SelectedItem��� 5       $��Orderd Date��6    �� 5!      -   5        $��txtOrderdDate��5!   "   $��Stretch=�67   $��25��6U   ��5"      �� $ 
OrderdDate�$	 OneWay=�
 5#      �� $ lvOrder��$ SelectedItem��� 5$      $��Required Date��6    �� 5%      -   5        $��txtRequiredDate��5%   "   $��Stretch=�69   $��25��6W   ��5&      �� $ RequiredDate�$	 OneWay=�
 5'      �� $ lvOrder��$ SelectedItem��� 5(      $��Shipped Date��6    �� 5)      -   5        $��txtShippedDate��5)   "   $��Stretch=�68   $��25��6V   ��5*      �� $ ShippedDate�$	 OneWay=�
 5+      �� $ lvOrder��$ SelectedItem��� 5,      $��Freight��6    �� 5-      -   5        $��
txtFreight��5-   "   $��Stretch=�64   $��25��6R   ��5.      �� $ Freight�$	 OneWay=�
 5/      �� $ lvOrder��$ SelectedItem�50      �� 52      $��1��6!   $ 
Horizontal=�6.   $
��Left=�6G   $��
0,339,0,43q�6b   .+�53      �� -   5        $��	btnInsert��53   !   $��Insert��62   $��10q�6C   $��80��6O   54      �� 55      -   5        $��	btnUpdate��55   !   $��Update��62   $��10q�6C   $��80��6O   56      �� 57      -	   5        $��	btnDelete��57   !   $��Delete��62   $��10q�6C   $��80��6O   58      59      �� 5;      -
   5        $��lvOrder��5;   ,   $��1��6   $
��auto��6;   $
��auto��6H   $��
0,380,0,19q�6V    �� View 5<      �� 5=      .P�5>   "   �� $��Order Id��61    �� Width$ 90��6C    �� DisplayMemberBinding 5?   %   �� $ OrderId��� 5@   "   $��	Member Id��61   $	 150��6D    5A   %   �� $ MerberId��� 5B   "   $��Orderd Date��61   $	 150��6F    5C   %   �� $ 
OrderdDate��� 5D   "   $��Required Date��61   $	 100��6H    5E   %   �� $ RequiredDate��� 5F   "   $��Shipped Date��61   $	 140��6G    5G   %   �� $ ShippedDate��� 5H   "   $��Freight��61   $	 100��6B    5I   %   �� $ Freight�5J      5L      �� 5N      -   5        $��btnClose��5N      $��3��6-   $��0,0,11,-150q�6:   $��Right=�6O   $��Bottom=�6k   $��80��6�   $��Close��6�   6�   5O      5P      5Q      5R      5S      