   M S B A M L   `   `   `  ����E  ABD_Proiect, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:BD_Proiect.GalleryBD_Proiect.Gallery  5      $    BD_Proiect.Gallery.GalleryPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:BD_Proiect.Gallery     5      .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5           Name$  GalleryDataGrid��5
         CanUserAddRows .  $��18,10,18,104q�6C      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        
columnName��,  &System.Windows.Controls.DataGridColumn   Header$ Nume Galerie��5   9   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6O   �� *Name+  5      -   5        columnAddress��$ Adresa��5   =    6M   �� *Adress+   RowDetailsTemplate 5      �� 5      .R�5      ]� 
�������.+�5      �� $
��Left=�6    $	��100��66   $��10q�6C   ��6O   �� *
ImageUrl+� 5      $
��0,10q�6    � ColumnDefinitions 5      �� 5   "   $
��Auto �63   �� 5   "   $��* �63    � RowDefinitions 5      �� 5   "   $
��Auto �60   �� 5   "   $
��Auto �60   �� 5   "   $
��Auto �60   �� 5   "   $
��Auto �60   .+�5      �� $��Nume Galerie: ��6(   $
��Bold"�6>   �� 5       	 ��Name$	 txtBlockName��6(   $��1��6T   ��6>   �� *Name+6T   �� 5!      $��Adresa: ��6(   $
��Bold"�68   $��1��6J   �� 5"      $	 txtBlockAddress��6(   $��1��6Y   $��1��6i   ��6A   �� *Adress+6i   �� 5#      $��Localitate: ��6(   $
��Bold"�6<   $��2��6N   �� 5$      $	 txtBlockLoc��6(   $��1��6Y   $��2��6i   ��6=   �� *
Localitate+6i   �� 5%      $��Cod Postal: ��6(   $
��Bold"�6<   $��3��6N   �� 5&      $	 txtBlockCod��6(   $��1��6Y   $��3��6i   ��6=   �� *
Cod_Postal+6i   5'      5(      5)      5+      �� 5,      -   5        
 ��Name$
 
BackButton��5,      $
��BACK��5-      $��Center=�5.      $��	0,374,0,0q�5/      $	��Top=�50      $	��305��51      $��50��52      
������� � Cursor$
 Hand��54      ���	#FF7456AE$��0,0,0,0q�56      $��
Nirmala UI)�57   ;   $
��Bold"�6S   58      59      