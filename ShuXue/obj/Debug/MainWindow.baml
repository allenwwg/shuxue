   M S B A M L   `   `   `  ����A  =ShuXue, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ShuXueShuXue  5   	       ShuXue.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:ShuXue     5   	     � Title$  	加减法��5   	   $	��350��6   $	��850��6"   $��38(�6.   $��Center=�6<   $��Center=�6Y    +� FocusedElement 5	   	   ��  �� ElementName$ 	tbItemRst��.��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   �� $��0��6   $��0��6   ��6/   �� *	Item1.A+6J   �� 5   
   $��0��6   $��1��6   $��Center=�6/   ��6L   �� *Item1.Operator+6n   �� 5   
   $��0��6   $��2��6   ��6/   �� *	Item1.B+6J   �� 5   
   $��0��6   $��3��6   $��Center=�6-   $��Center=�6J   .��6e   =6h   �� 5   
   -   5        $��	tbItemRst��5      $��0��6#   $��4��60   ��6@   �� *	Item1.C+6\   �� 5    
   $��0��6   $��5��6   ��6-   �� *Item1.CheckRstString+6X   �� 5"   
   $��1��6   $��0��6   ��6/   �� *	Item2.A+6J   �� 5#   
   $��1��6   $��1��6   $��Center=�6/   ��6L   �� *Item2.Operator+6n   �� 5$   
   $��1��6   $��2��6   ��6/   �� *	Item2.B+6J   �� 5%   
   $��1��6   $��3��6   $��Center=�6-   $��Center=�6J   .��6e   =6h   �� 5&   
   $��1��6   $��4��6   ��6/   �� *	Item2.C+6J   �� 5'   
   $��1��6   $��5��6   ��6-   �� *Item2.CheckRstString+6Y   �� 5)   
   $��2��6   $��4��6   $��3��6.   ��6B   �� *NextGroupCommand+.��6g   下一关(Next Group)6x   �� 5*   
   $��2��6   $��3��6   $��Center=�6I   ��6-   �� *	StepCnt+6h   �� 5+   
   $��2��6   $��0��6   $��3��6.   ��6B   �� *CheckCommand+.��6c   检查(Check)6n   r� 5-   
   $y�	Collapsed=�6   $��0��6.   $��2��6;   $��5��6L   $��2��6\    r� Source$P Jhttp://hubblesource.stsci.edu/sources/video/clips/details/images/hst_1.mpg?�6p   6�   5.      5/      