   M S B A M L   `   `   `  ����E  ABD_Proiect, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BD_Proiect
BD_Proiect  5   	       BD_Proiect.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:BD_Proiect     5   	   -   5          �Name$  Login1��5   	    � Title$ Login��5   	   $	��540��6   $	��285��6$   $��Center=�60   $��Center=�6T    � 
ResizeMode$ NoResize=�6v   
����������	#FFA4A5A9$��
Nirmala UI)�6�    J� IsHitTestVisible . $
��Bold"�6�   $��10(�6�    J� IsManipulationEnabled . $��Stretch=�6#  $��Stretch=�6A  .��5
      � -   5         �Name$ 	LoginPage��5
      $��Center=�6   $��Center=�6;    � ColumnDefinitions 5   
   �� 5      $
��232* �6   �� 5      $	��23* �6   .+�5   
   �� -   5         ��Name$ 	LoginName��5      $��Login��6#   $��	0,0,119,0q�63   $	��Top=�6F   ���	#FF7456AE$��MS UI Gothic)�6u   $��20(�6�   �� 5   
   -   5        $ labelUsername��5      $��Username��6'   $
��Left=�6:   $��3,44,0,0q�6U   $	��Top=�6g   ��5      �� 5       �� Color# � ��6"   5      �� 5   
   -   5        	 ��Name$	 txtUsername��5      $��Center=�6'   $��0,67,0,0q�6D   
 �� TextWrapping$

 Wrap=�5      $	��Top=�6&   $	��232��6>   $��28��6J   $
��Left=�6V   $��MS UI Gothic)�6x   $��16(�6�   $��Normal"�6�   ���	#FFE6E7E9$��0,0,0,0q�6�   ��5      �� *
Username+ �� ValidatesOnExceptions .  �� UpdateSourceTrigger$ PropertyChanged=�5   �   �� 5   
   -   5        $ labelPassword��5      $��Password��6'   $
��Left=�6:   $��	0,100,0,0q�6U   $	��Top=�6h   ��5      �� 5      # � ��6"   5      G� 5   
   -   5         G�Name$ passwordBox��5      $��Center=�6+   $��	0,123,0,0q�6H   $	��Top=�6[   $	��232��6s   $��28��6   $
��Left=�6�   $��MS UI Gothic)�6�   $��16(�6�   $��Normal"�6�   ���	#FFE6E7E9$��0,0,0,0q�6   6  �� 5   
   -   5        $	 txtPassword��5      $��Center=�6'   $��	0,123,0,0q�6D   $

 Wrap=�6W   $	��Top=�6k   $	��232��6�   $��28��6�   $
��Left=�6�   $��MS UI Gothic)�6�   $��16(�6�   $��Normal"�6�   ���	#FFE6E7E9$��0,0,0,0q�6  $y�	Collapsed=�6*  �� 5   
   -	   5         ��Name$ checkbxShowPassword��5      $��Show Password��60   $
��Left=�6H   $��	130,0,0,0q�6c   $��Center=�6v   $��4,0,0,0q�6�   $��1,1,1,1q�6�    � Cursor$
 Hand��6�   ��5       �� 5!      # � ��6"   5#      �� 5$   
   -
   5         ��Name$ registerButton��5$      $��REGISTER��6)   $
��Left=�6<   $��	6,286,0,0q�6W   $	��Top=�6j   $	��216��6�   $��35��6�   
�������$
 Hand��6�   ���	#FF7456AE$��0,0,0,0q�6�   6�   �� 5%   
   $��CLEAR��6   $
��Left=�6!   $��	6,326,0,0q�6<   $	��Top=�6O   $	��216��6g   $��35��6s   ���	#FF7456AE$
 Hand��6�   
�������$��1,1,1,1q�6�   �� 5&   
   -   5        $ loginButton��5&      $��LOGIN��6&   $
��Left=�66   $��	6,246,0,0q�6Q   $	��Top=�6d   $	��216��6|   $��35��6�   
�������$
 Hand��6�   ���	#FF7456AE$��0,0,0,0q�6�   6�   5'      5(      