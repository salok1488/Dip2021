   M S B A M L   `   `   `  ����A  =uargaz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:uargazuargaz  5          uargaz.MainPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962af bMaterialDesignThemes.MahApps, Version=0.1.6.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5      "localclr-namespace:uargaz   5        N� Title$  MainPage��5      .��5      � .+�5   
   �� $M��GУчёт аварийно-восстановительных работ��6   $��30(�6B   $
��Bold"�6P   $��
38,100,0,0q�6b   $
��Left=�6v   $
��1302��6�   �� 5   
   -   5         ��Name$ Search��5   	   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Поиск��5   	   /  )MaterialDesignThemes.Wpf.TransitionAssist   DisableTransitions . $
��Left=�5   D   $��35��6_   $��
242,32,0,0q�6k    �� TextWrapping$
 Wrap=�6   $	��Top=�6�   $	��250��6�   $��18(�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��TablesTB��5         ColumnHeaderHeight$ 80Q�6#      AutoGenerateColumns .     
IsReadOnly . $	��784��6k   $��10,156,10,0q�6x   $	��Top=�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Повреждение��6&   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 130 6[   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Повреждение+6i     5      $-	 'Характер повреждения��6%   $	
 180 6l    6C   �� *)'Характер_повреждения+6z     5      $	 Объект��6%   $	
 100 6P    65   �� *Объект+6^     5      $	 Участок��6%   $	
 100 6_    66   �� *)'Участок.Наименование+6m     5      $	 
Связь��6%   $	
 100 6[    64   �� *%#Связь.Наименование+6i     5      $ 	 Ответственный��6%   $	
 150 6b    6<   �� *#!Сотрудник.Фамилия+6p     5      $	 Время начала��6%   $	
 150 6\    6;   �� *Время_начала+6j     5      $	 Время конца��6%   $	
 150 6Z    6:   �� *Время_конца+6h   4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $	 Статус��6)   $	
 100 6T    69   �� *Статус+6b     5      $	 Примечание��6%   $
 1* 6X    69   �� *Примечание+6e   5!      5$      5%      