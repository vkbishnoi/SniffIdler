   M S B A M L   `   `   `  ����  
SniffIdler    SniffIdler.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   X TXceed.Wpf.Toolkit, Version=1.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f41l)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  
Break Time��5   	   $	��122��6   $	��300��6)   $��14(�65   .��5      %  Xceed.Wpf.Toolkit.BusyIndicator  -   5          Name$ bi��5      .��5   
   �  � RowDefinitions 5   
   �� 5	      $��* �6   �� 5
      $��* �6   .+�5      �� -   5         ��Name$ btnPakdo��5      $��Find Idle Time��6'   $��16(�6@   ��6N   �� *FindKCCommand+� 5   
   $��1��6   $��40��6    � ColumnDefinitions 5      �� 5      $��4* �6#   �� 5      $��2* �6#   �� 5      $��3* �6#   .+�5      �� $��0��6   $��1q�6%   $��3q�69   
���   �._�5      �� $
��Left=�5      $��Center=�67    � ToolTip$ Observation date��6R   ��5      �� *KCDate+ �� StringFormat$ 	Date: {0}��5   R   5      �� 5      $��1��6   $��1q�6%   $��3q�69   
���   �._�5      �� $
��Left=�5       $��Center=�6;   $7 1Number of times person was away from workstation.��6V   ��5       �� *NumberOfTimes+$ 
Times: {0}��5   V   5      �� 5      $��2��6   $��1q�6%   $��3q�69   
���   �._�5      �� $
��Left=�5        $��Center=�6;   $5 /Total minutes person was away from workstation.��6V   ��5       �� *KCTime+$ Minutes: {0}��5    V   5!      5"      5$      5%      5&      