   M S B A M L   `   `   `  ����D  @Zadatak_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Zadatak_1	Zadatak_1  5   	       Zadatak_1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Zadatak_1     5   	   $��18(�5        � Title$  HTML Content Downloader��5   	   $	��300��6)   $	��350��66   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��20 �6   .+�5   
   �� $��1��6   $��1��6$   $
��URL:��61   $��Center=�6=   �� 5   
   $��1��6   $��2��6"   $	��300��5      $��40��6   ��5   /   �� *Content.URL+ �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5!   
   -   5        $��btnDownload��5!   .   $��1��6   $��3��6!   $��Download HTML��6A   $��50��6Y   $	��300��6e   $��Center=�6q   $��0,10,0,0q�5"   S   ��6   �� *
Download+$ PropertyChanged=�6S   �� 5$   
   -   5        $��btnZip��5$   .   $��1��6   $��4��6!   $��Zip HTML��6<   $��50��6O   $	��300��6[   $��Center=�6g   $��0,10,0,0q�5%   N   ��6   �� *Zip+$ PropertyChanged=�6N   5'      5(      