   M S B A M L   `   `   `  ����O  KBankManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:BankManagementSystem.PagesBankManagementSystem.Pages  5   	   0    *BankManagementSystem.Pages.DashBoardWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:BankManagementSystem.Pages     5   	   -   5          � Title$  DashBoardWindow��5   	   $	��450��6!   $	��800��6.   .��5      � $
��1200��6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��	DashBoard��6   $��32(�6%   $
��bold"�63   $��0��6E   $��10 20 10 10q�6R   � 5   
   $��1��6   $��10 20 10 10q�6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� -   5         ��Name$
 brd1��5      $��0��6#    �� CornerRadius$ 2��63   $��1q�6D   
�������._�5      �� $��10 10 10 10q�6   .+�5      �� $
��bold"�6    $��10(�62   $��
10 10 10 2q�6@   Your Balance6b   �� 5      $��42(�6!   $��	30 2 10 2q�6/   
��� � �$20006\   5      5       �� 5"      -   5         ��Name$ 
btnDeposit��5"      $��1��6)   $��20 0 0 0q�69   $��Deposit��6K   $��12(�6]   
�������$
��Bold"�5#   &   
���   �5%      �� 5(      -   5        $ btnWithdraw��5(      $��2��6*   $��20 0 0 0q�6:   $��Withdraw��6L   $��12(�6_   
�������$
��Bold"�5)   +   
���   �5+      �� 5-      -   5        $ 
btnManager��5-      $��3��6)   $��20 0 0 0q�69   $��Account Manager��6K   $��12(�6e   
�������$
��Bold"�5.      
���   �50      51      � 52   
   $��2��6   $��10 20 10 10q�6    53      �� 54      $��* �6#   �� 55      $	��250 �6#   .+�57      �� $��0��6   
����� �$ 3��58      5:      �� 5<      $��1��6   ���#9e0344$��10 0 0 0q�6:   $ 3��6L   5>      5?      5@      5A      