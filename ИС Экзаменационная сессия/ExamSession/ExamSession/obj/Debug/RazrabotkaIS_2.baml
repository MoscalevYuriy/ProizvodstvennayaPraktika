   M S B A M L   `   `   `  ����F  BExamSession, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ExamSessionExamSession  5           ExamSession.RazrabotkaIS_2   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:ExamSession     5        N� Title$  RazrabotkaIS_2��5	      .��5      � .+�5   
   �� ���	#FFE0E0E0.+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 	dataGrid1��5      $	��356��6*   $��
20,20,20,0q�67   
�������   
IsReadOnly .    AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6N   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *ФИО+6N     5      $ № билета��6)   $
 auto 6\    6;   �� *Номер_билета+6\     5      $ Оценка��6)   $
 auto 6T    69   �� *Оценка+6T   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 auto 6-   5      5      5      �� 5   
   -   5         ��Name$ 
buttonBack��5      $��Вернуться��6%   $��Normal"�69       MaterialDesignOutlinedButton#��[  6M   $
��Auto��6�   $��22(�6�   $��20,389,762,43q�6�   6�    � 5   
   -   5        	  �Name$	 MyFrame��5      
  � NavigationUIVisibility$
 Hidden=�6!   5      5      