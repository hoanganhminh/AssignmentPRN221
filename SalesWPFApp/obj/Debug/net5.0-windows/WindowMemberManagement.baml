   M S B A M L   `   `   `  ����F  BSalesWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SalesWPFAppSalesWPFApp  5   	   (    "SalesWPFApp.WindowMemberManagement   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SalesWPFApp     5   	   $��0q�5   	     � WindowStyle$
  None=�6   
���   � � 
ResizeMode$ NoResize=�6D    � Title$ Member Management��5	   	   $	��689��6#   $	��917��60    � WindowState$ Normal=�6<    � WindowStartupLocation$ CenterScreen=�6Q   
���   �.��5
      ��  �� Orientation$ Vertical=�6   ���#a6d9ef$��2,0,0,0q�6=   .+�5   
   ��  �� CornerRadius$ 25��6   $��20,10,20,10q�6#   
���  ��
�������$	��863��6]   $	��661��6i   ._�5      �� $ Vertical=�6   .+�5      �� $��Member Management��6   $��25(�64   $��Center=�6B   $
��Bold"�6_   $��2,5,2,0q�6q   $��Bottom=�6�   � 5      $��2q�6    � RowDefinitions 5      �� 5      $
��auto �6(   68   �� 5      $��* �6(   65   �� 5      $��4* �6(   66   �� 5      $��* �6(   65   .+�5      �� $ Vertical=�6!   $��Center=�68   $	��838��6U   
����ح�$��0,0,0,40q�6x   $��2��6�   .+�5      �� $��	Member Id��6    �� 5      -   5        $��txtMemberId��5   "   $��Stretch=�65   $��25��6S   ��5      ��  �� Path$ MemberId�	 �� Mode$	 OneWay=�
 � DataContext
 5      ��  �� ElementName$ lvMember��$ SelectedItem��� 5      $��Email��6    �� 5      -   5        $��txtEmail��5   "   $��Stretch=�62   $��25��6P   ��5      �� $ Email�$	 OneWay=�
 5      �� $ lvMember��$ SelectedItem��� 5       $��Company Name��6    �� 5!      -   5        $��txtCompanyName��5!   "   $��Stretch=�68   $��25��6V   ��5"      �� $ CompanyName�$	 OneWay=�
 5#      �� $ lvMember��$ SelectedItem��� 5$      $
��City��6    �� 5%      -   5        $��txtCity��5%   "   $��Stretch=�61   $��25��6O   ��5&      �� $
 City�$	 OneWay=�
 5'      �� $ lvMember��$ SelectedItem��� 5(      $��Country��6    �� 5)      -   5        $��
txtCountry��5)   "   $��Stretch=�64   $��25��6R   ��5*      �� $ Country�$	 OneWay=�
 5+      �� $ lvMember��$ SelectedItem��� 5,      $��Password��6    �� 5-      -   5        $��txtPassword��5-   "   $��Stretch=�65   $��25��6S   ��5.      �� $ Password�$	 OneWay=�
 5/      �� $ lvMember��$ SelectedItem��� 50      $
��Role��6    �� 51      -   5        $��txtRole��51   "   $��Stretch=�61   $��25��6O   ��52      �� $
 Role�$	 OneWay=�
 53      �� $ lvMember��$ SelectedItem�54      �� 56      $��1��6!   $ 
Horizontal=�6.   $
��Left=�6G   $��	0,355,0,5q�6b   .+�57      �� -   5        $��	btnInsert��57   !   $��Insert��62   $��10q�6C   $��80��6O   58      �� 59      -	   5        $��	btnUpdate��59   !   $��Update��62   $��10q�6C   $��80��6O   5:      �� 5;      -
   5        $��	btnDelete��5;   !   $��Delete��62   $��10q�6C   $��80��6O   5<      5=      �� 5?      -   5        $��lvMember��5?   ,   $��2��6   $
��auto��6<   $
��auto��6I    �� View 5@      �� 5A      .P�5B   "   �� $��	Member Id��61    �� Width$ 90��6D    �� DisplayMemberBinding 5C   %   �� $ MemberId��� 5D   "   $��Email��61   $	 150��6@    5E   %   �� $ Email��� 5F   "   $��Company Name��61   $	 150��6G    5G   %   �� $ CompanyName��� 5H   "   $
��City��61   $	 100��6?    5I   %   �� $
 City��� 5J   "   $��Country��61   $	 140��6B    5K   %   �� $ Country��� 5L   "   $��Password��61   $	 100��6C    5M   %   �� $ Password��� 5N   "   $
��Role��61   $	 100��6?    5O   %   �� $
 Role�5P      5R      �� 5T      -   5        $��btnClose��5T      $��3��6-   $��10q�6:   $��Right=�6F   $��Bottom=�6b   $��80��6}   $��Close��6�   6�   5U      5V      5W      5X      5Y      