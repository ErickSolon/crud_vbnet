   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��444��6)   .��5	      � .+�5
   
   �  J� RenderTransformOrigin$ 0.519,0.501&�6    � ColumnDefinitions 5      �� 5      $	��82* �6#   �� 5      $
��233* �6#   �� 5      $
��129* �6#   .+�5      �� -   5         ��Name$ 	nomeInput��5      $
��Left=�6)   $��	36,34,0,0q�6D    �� TextWrapping$
 Wrap=�6W   $	��Top=�6k   $	��120��6�   $��2��6�   �� 5      -   5        $ sobrenomeInput��5      $
��Left=�6.   $��	99,34,0,0q�6I   $
 Wrap=�6\   $	��Top=�6p   $	��120��6�   $��1��6�   �� 5      -   5         ��Name$ 	updatebtn��5      $��Update��6(   $
��Left=�69   $��	19,32,0,0q�6T   $	��Top=�6g   $ 1.321,0.559&�6   $��2��6�   �� 5      -   5        $ insertButton��5      $	��Add��6+   $
��Left=�69   $��	79,32,0,0q�6T   $	��Top=�6g   $��2��6   �� 5      $
��Nome��6   $
��Left=�6#   $��36,3,0,0q�6>   $	��Top=�6P   �� 5      $��	Sobrenome��6   $
��Left=�6(   $��99,3,0,0q�6C   $	��Top=�6U   $��1��6m   �� 5      -   5        $ procurarBtn��5      $��Procurar��6*   $
��Left=�6=   $��
95,386,0,0q�6X   $	��Top=�6l   $��1��6�   �� 5      -   5        $ procurarpessoaInput��5      $
��Left=�63   $��
36,387,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   $ 0.216,0.619&�6�   $��2��6�   �� 5      -   5        $ 
btnDeletar��5      $��Deletar��6)   $
��Left=�6;   $��159,386,0,0q�6V   $	��Top=�6k   $��1��6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ dados��5      $��36,65,24,78q�6Q   $��3��6f   5      5      5      