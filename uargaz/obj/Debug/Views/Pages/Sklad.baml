   M S B A M L   `   `   `  ����A  =uargaz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:uargazuargaz  5          uargaz.Sklad   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:uargaz     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962af bMaterialDesignThemes.MahApps, Version=0.1.6.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5        N� Title$  Sklad��5      .��5      � .+�5   
   �� $��Материалы��6   $��30(�6&   $
��Bold"�64   $��
38,100,0,0q�6F   $
��Left=�6Z   $	��364��6u   �� 5   
   -   5         ��Name$ SearchSotrudnik��5   	   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Поиск��5   	   /  )MaterialDesignThemes.Wpf.TransitionAssist   DisableTransitions . $
��Left=�5   D   $��28��6_   $��
242,32,0,0q�6k    �� TextWrapping$
 Wrap=�6   $	��Top=�6�   $	��120��6�   $��16(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��SkladTB��5      $
��Left=�6"      AutoGenerateColumns .     
IsReadOnly . $	��548��6k   $��
10,156,0,0q�6x   $	��Top=�6�   $	��940��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Материал��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6T   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 67   �� *Название+6`     5      $ Цена��6%   $		 700 6L   
 63   �� *
Цена+6Z   5      5      5      