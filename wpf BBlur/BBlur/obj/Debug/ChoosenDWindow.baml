   M S B A M L   `   `   `  ����@  <BBlur, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BBlurBBlur  5   	       BBlur.ChoosenDWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:BBlur     5   	     � Title$  ChoosenDWindow��5   	   $	��300��6    $	��300��6-   .��5	      � ���#04B4AE � RowDefinitions 5
   
   �� 5      $	��76* �6   �� 5      $	��52* �6   �� 5      $	��55* �6   �� 5      $	��53* �6   �� 5      $	��34* �6   .+�5   
   �� -   5         ��Name$ 
labelTitle��5      $;��5the file/person you chose to add to the data base is:��6$   $
��Left=�6d   $	��Top=�6�   $��0��6�   $��26��6�   $	��285��6�   �� 5   
   -   5         ��Name$ TextFileName��5      $
��Left=�6*   $��1��6F   $
��Wrap=�6S   $�� ��6g   $	��Top=�6o   $��52��6�   $	��290��6�   �� 5   
   -   5        $ label��5      $��enter name of person:��6   $
��Left=�6?   $��41��6Z   $��	13,14,0,0q�6f   $��2��6y   $	��Top=�6�   $	��271��6�   �� 5   
   -   5         ��Name$ textBox��5      $
��Left=�6#   $��30��6>   $��10,10.8,0,0q�6J   $��3��6_    �� TextWrapping$
 Wrap=�6l   $�� ��6�   $	��Top=�6�   $	��274��6�   �� 5   
   -   5         ��Name$ blurButtonFile��5      $ ��To add person to data base��6)   $
��Left=�6N   $��24��6i   $��13,0,0,0q�6u   $��4��6�   $	��Top=�6�   $	��271��6�   ��5      �� 5       �� Triggers 5      �� 5       �� Binding 6&   �� 	 �� ElementName$	 textBox��
 �� Path$

 Text� �� Value  6Y   .a�5      ��  �� Property � {� �� Value .  6A   5      5      5      5       5!      