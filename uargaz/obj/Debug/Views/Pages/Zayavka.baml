   M S B A M L   `   `   `  ����A  =uargaz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:uargazuargaz  5          uargaz.Zayavka   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962af bMaterialDesignThemes.MahApps, Version=0.1.6.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5      "localclr-namespace:uargaz   5        N� Title$  Zayavka��5	   1   .��5      � .+�5   
   �� $��Заявка��6   $��30(�6#   $
��Bold"�61   $��
38,100,0,0q�6C   $
��Left=�6W   $	��364��6r   �� 5   
   -   5         ��Name$ SearchSotrudnik��5   	   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Поиск��5   	   /  )MaterialDesignThemes.Wpf.TransitionAssist   DisableTransitions . $
��Left=�5   D   $��28��6_   $��
242,32,0,0q�6k    �� TextWrapping$
 Wrap=�6   $	��Top=�6�   $	��120��6�   $��16(�6�   '  !MaterialDesignThemes.Wpf.PackIcon  5   
      Kind$ 	ArrowLeft=�6"   $��25��63   $��43��6?   $��	55,35,0,0q�6J    � ToolTip$ 
Назад��6]   &   System.Windows.Controls.DataGrid  5   
   -   5        $��	ZayavkaTB��5      $
��Left=�6$   $	��793��6?   $��
10,156,0,0q�6L   $	��Top=�6`   $
��1313��6x      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Дата��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6L   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 63   �� *
Дата+6X     5      $ Нахождение��6%   $		 400 6X   
 69   �� *Нахождение+6f     5      $ Сотрудник��6%   $		 400 6^   
 68   �� *#!Сотрудник.Фамилия+6l    � ContextMenu 5      �� 5      .@�5      m� -   5        $��ContextMenuAdd��5   1   $��Добавить��6   6G   �� 5      m� 5      -   5        $��ContextMenuChange��5   6   $ ��Редактировать��6   66   �� 5      m� 5       -   5        $��ContextMenuRemove��5    0   $��Удалить��6   6I   5!      5#      5%      5&      