   M S B A M L   `   `   `  ����H  DTRANQUIL_CARE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Hos_01Hos_01  5   	       Hos_01.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Hos_01     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ 
MainWindow��5
   	   $	��600��6   $	��500��6)    � DataContext 5         Hos_01.MainWindowVM  5   
   .��5      � ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ 
WhiteSmoke��6    � Offset$ 0Q�62   � 5       $ 	AliceBlue��6   $ 1Q�61   5!      .+�5+   
   � .+�5,      �� $��\Images\01.png��6   $��UniformToFill=�6,   $��135,10,135,418q�6D   $��90��6\   $	��102��6g   z�5-      �� 5.       �� CenterX$ 45Q�6&    �� CenterY$ 51Q�63   	 � Triggers	 50      :� 51      
 :� RoutedEvent$
 Loaded��6#   .[�52      �� .��53      �� .��54   "   W�  �� TargetProperty$5 /(Image.RenderTransform).(RotateTransform.Angle)�62    W� From 055   *   	 W� To 36063    g� Duration$ 0:1:30D�6<    g� RepeatBehavior$ Forever��6N   56      57      58      5:      �� 5;      $��Center=�6   $��Center=�6<   5<      �� 5A   
   $��TRANQUIL CARE HOSPITAL��6   $	��300��62   $��BR Firma)�6>    �� TextAlignment$ Center=�6T   $��20(�5B      
���   �$��SemiBold"�6.   $��10 ,180 ,10 ,360q�6D   �� 5K   
   $��Center=�6    �� Orientation$ Vertical=�62   $	��340��5L      $��
0,250,0,20q�6!   .+�5O      �� $��Username��6   $	��150��6(   $��BR Firma)�64   $ Center=�6J   $��16(�5P      
����� �$��SemiBold"�61   $
��0 10q�6G   �� 5Q      $�� 0 0 0 1q�60   
������ $	��250��5R      $��Josefin Sans)�6"   $��20(�6<   $��Italic$�6J   ��5Q      �� *
UserName+5R   J   �� 5S      $��Password��6   $	��150��6(   $��BR Firma)�64   $ Center=�6J   $��16(�5T      
����� �$��SemiBold"�61   $
��0 10q�6G   �� 5U      $�� 0 0 0 1q�61   
������ $	��250��5V      $��Josefin Sans)�6#   $��20(�6=   $��Italic$�6K   ��5U      �� *
Password+5V   K   �� 5\      $��Login��6   $��0 30 0 0q�6'      
mainbutton#��[  6Z   ��69   �� *LoginCommand+6Z   5`      5b      5c      