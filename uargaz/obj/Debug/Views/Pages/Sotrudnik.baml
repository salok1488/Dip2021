   M S B A M L   `   `   `  ����A  =uargaz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:uargazuargaz  5          uargaz.Sotrudnik   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:uargaz     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962af bMaterialDesignThemes.MahApps, Version=0.1.6.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5        N� Title$  	Sotrudnik��5      .��5      � .+�5   
   �� $��Сотрудники��6   $��30(�6'   $
��Bold"�65   $��
38,100,0,0q�6G   $
��Left=�6[   $	��364��6v   &   System.Windows.Controls.DataGrid  5   
   -   5        $��SotrudnikTB��5         AutoGenerateColumns .     
IsReadOnly . $
��Left=�6T   $	��793��6o   $��
10,156,0,0q�6|   $	��Top=�6�   $
��1313��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *Фамилия+6^     5      $ Имя��6%   $ * 6J    62   �� *Имя+6V     5      $ Отчество��6%   $ * 6T    67   �� *Отчество+6`     5      $ Эл. почта��6%   $ * 6^    68   �� *#!Электронная_почта+6j     5      $ Телефон��6%   $ * 6R    66   �� *Телефон+6^     5      $ Должность��6%   $	 120 6V    68   �� *Должность+6d     5      $! Учётная запись��6%   $	 130 6f    6=   �� *#!Учётная_запись.login+6t    � ContextMenu 5      �� 5      .@�5      m� -   5        $��ContextMenuAdd��5   1   $��Добавить��6   6G   �� 5       m� 5!      -   5        $��ContextMenuChange��5!   6   $ ��Редактировать��6   66   �� 5"      m� 5#      -   5        $��ContextMenuRemove��5#   0   $��Удалить��6   6I   5$      5&      �� 5'   
   -   5         ��Name$ SearchSotrudnik��5(   	   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 
Поиск��5)   	   /  )MaterialDesignThemes.Wpf.TransitionAssist
   DisableTransitions
 . $
��Left=�5*   D   $��28��6_   $��
242,32,0,0q�6k    �� TextWrapping$
 Wrap=�6   $	��Top=�6�   $	��120��6�   $��16(�6�   6�   5+      5,      