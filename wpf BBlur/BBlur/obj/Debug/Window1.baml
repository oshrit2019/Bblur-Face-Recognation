   M S B A M L   `   `   `  ����@  <BBlur, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BBlurBBlur  5   	       BBlur.Window1   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:BBlur     5   	     � Title$  Window1��5   	   $	��400��6   $	��525��6&   .��5	      � ���#04B4AE � RowDefinitions 5
   
   �� 5      $	��80* �6   �� 5      $
��182* �6   �� 5      $	��59* �6   .+�5   
   ]� $��10,10,10.4,0.4q�6   $��2��6,   .+�5      � $��Center=�6   $	��Top=�65   $��0,0,0,10q�6J   .+�5      �� -   5        $��btnOpenFile��5      .��6F   	Open file6Q   5      �� 5      -   5        $��	txtEditor��5      $��0,0.2,0,230q�6'   5      �� 5   
   -   5         ��Name$ image��5      $	��154��6   $��35,10,44.4,0q�6,   $	��Top=�6B   $��1��6Z   �� 5   
   -   5         ��Name$ BlurImagebutton��5      $��to blur the image��6*   $
��Left=�6F   $��48��6a   $��
35,9.6,0,0q�6m   $��2��6�   $	��Top=�6�   $	��439��6�   ��5      �� 5       �� Triggers 5      �� 5       �� Binding 6&   ��  �� ElementName$ 	txtEditor�� �� Path$
 Text� �� Value  6[   .a�5      �� 	 �� Property	 � {�
 �� Value
 .  6A   5      5       5"      5#      5$      