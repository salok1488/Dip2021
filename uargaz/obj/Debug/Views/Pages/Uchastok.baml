   M S B A M L   `   `   `  ����A  =uargaz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:uargazuargaz  5          uargaz.Uchastok   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:uargaz     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962af bMaterialDesignThemes.MahApps, Version=0.1.6.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5        N� Title$  Uchastok��5      .��5      � .+�5   
   �� $��Участок��6   $��30(�6$   $
��Bold"�62   $��
38,100,0,0q�6D   $
��Left=�6X   $	��364��6s   �� 5   
   -   5         ��Name$ Search��5   	   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Поиск��5   	   /  )MaterialDesignThemes.Wpf.TransitionAssist   DisableTransitions . $
��Left=�5   D   $��28��6_   $��
242,32,0,0q�6k    �� TextWrapping$
 Wrap=�6   $	��Top=�6�   $	��120��6�   $��16(�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��
UchastokTB��5         AutoGenerateColumns .     
IsReadOnly . $
��Left=�6S   $	��793��6n   $��
10,156,0,0q�6{   $	��Top=�6�   $
��1313��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Наименование��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 5* 6\   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6;   �� *Наименование+6i   5      5      5      