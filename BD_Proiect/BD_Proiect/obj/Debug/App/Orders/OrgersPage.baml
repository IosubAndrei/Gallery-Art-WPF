   M S B A M L   `   `   `  ����E  ABD_Proiect, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:BD_Proiect.OrdersBD_Proiect.Orders  5      "    BD_Proiect.Orders.OrgersPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:BD_Proiect.Orders     5      .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5           Name$  OrdersDataGrid��5
         CanUserAddRows .  $��18,10,18,104q�6B      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        columnNamePainting��,  &System.Windows.Controls.DataGridColumn   Header$ 
Nume Opera��5   _   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *	NameOpera+6_     5      -   5        columnNamePlacement��$ Data Plasare��5   d    6B   �� *PlacementDate+6d     5      -   5        columnNameDelivered��$ Data Livrare��5   c    6B   �� *DeliveryDate+6c      RowDetailsTemplate 5      �� 5      .R�5      ]� 
�������.+�5      � $
��0,10q�6    � ColumnDefinitions 5      �� 5   "   $
��Auto �63   �� 5   "   $��* �63    � RowDefinitions 5      �� 5   "   $
��Auto �60   �� 5   "   $
��Auto �60   �� 5   "   $
��Auto �60   �� 5   "   $
��Auto �60   �� 5   "   $
��Auto �60   �� 5   "   $
��Auto �60   .+�5!      �� $��
An Opera: ��6(   $
��Bold"�6:   �� 5"      $��1��6>   ��6(   �� *Year+6>   �� 5#      $��Pret: ��6(   $
��Bold"�66   $��1��6H   �� 5$      $��1��6?   $��1��6O   ��6(   �� *Price+6O   �� 5%      $��Detalii Opera: ��6(   $
��Bold"�6?   $��2��6Q   �� 5&      $��1��6A   $��2��6Q   ��6(   �� *	Details+6Q   �� 5'      $��Nume Client: ��6(   $
��Bold"�6=   $��3��6O   �� 5(      $��1��6B   $��3��6R   ��6(   �� *
FullName+6R   �� 5)      $��Numar Telefon: ��6(   $
��Bold"�6?   $��4��6Q   �� 5*      $��1��6F   $��4��6V   ��6(   �� *Phone_Number+6V   �� 5+      $��Adresa: ��6(   $
��Bold"�68   $��5��6J   �� 5,      $��1��6A   $��5��6Q   ��6(   �� *	Address+6Q   5-      5.      5/      51      52      53      