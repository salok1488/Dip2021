   M S B A M L   `   `   `  ����A  =uargaz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:uargazuargaz  5   	       uargaz.Authorization   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:uargaz     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962af bMaterialDesignThemes.MahApps, Version=0.1.6.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	     � Title$  Authorization��5
   	   $	��550��6   $	��400��6,    � WindowStyle$
 None=�68    � 
ResizeMode$ NoResize=�6K   ���	#FF0079C2 � WindowStartupLocation$ CenterScreen=�6x    � Icon$= 7C:\Users\calok\OneDrive\Desktop\значки\газ.png��6�   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ White��6    � Offset$	 0.4Q�6-   � 5      $ 	#FF0079C2��6   $	 0.8Q�61   5      	 � RowDefinitions	 5   
   �� 5      $��25 �6   �� 5      $	��100 �6   �� 5      $	��275 �6   .+�5   
   � -   5        
 �Name$
 ToolBar��5      ���	#FF0079C2$��0��67   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5      �� -   5         ��Name$ 	MinButton��5      $
��19.5��6+   $
��19.5��69   $��2q�6F   ��5      �� 5       �� 
TargetType" ��6    .�5      ��  �� Property � �� �� Value$ /Source/min.png��67    �� Triggers 5      �� 5    "    �� Binding 6.   �� *IsMouseOver+ �� ElementName$ 	MinButton�� �� Value True5!   .   .a�5"   &   ��  � ��$ /Source/min1.png��6?   5#   #   5%      5(      �� 5)      -   5        $ CloseButton��5)      $
��19.5��6-   $
��19.5��6;   $��2q�6H   ��5*      �� 5+      " ��6    .�5,      ��  � ��$ /Source/close1.png��67    5-      �� 5.   "    6.   �� *IsMouseOver+$ CloseButton�� True5/   .   .a�50   &   ��  � ��$ /Source/close.png��6?   51   #   53       J� Effect 55      -  'System.Windows.Media.Effects.BlurEffect  56         Radius$ 1Q�6%   58      59      5:      � 5;   
   -   5        $

 Logo��5;   (   
������ $��1��66   6C   �� 5<   
   $��
0,0,249,19q�6   $��/Source/Image2.png��6$   $
��Fill=�6@   $��1��6O   �� 5=   
   -   5         ��Name$ login��5=      $��15(�6!   $
��Left=�6/   $��42��6J   $��	44,90,0,0q�6V   $��2��6i    �� TextWrapping$
 Wrap=�6v   $	��Top=�6�   $	��315��6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$% Имя пользователя��5>       %  !MaterialDesignFloatingHintTextBox#��[  5?      G� 5N   
   -   5         G�Name$ on��5N      $��15(�6G   $
��Left=�6U   $��
44,146,0,0q�6p   $��2��6�   $	��Top=�6�   $	��315��6�   $ Пароль��5O      .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton .  ) %MaterialDesignFloatingHintPasswordBox#��[ 5Q      $��45��6U   '  !MaterialDesignThemes.Wpf.PackIcon  5S   
      Kind$ AccountOutline=�6"   $��2��68   $��
19,112,0,0q�6F   $��20��6Z   $��20��6f     5T   
   $ 
KeyOutline=�6#   $��2��66   $��
19,171,0,0q�6D   $��20��6X   $��20��6d   �� 5X   
   -   5        $"��Авторизоваться��5X      $
��Left=�6*   $��30,295,0,-61q�6E   $��2��6[   $	��Top=�6h   $	��340��6�    �� 	IsDefault . 6�   5Z      5\      