   M S B A M L   `   `   `  ����   
SniffIdler    SniffIdler.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     X TXceed.Wpf.Toolkit, Version=1.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f41l)http://schemas.xceed.com/wpf/xaml/toolkit    � Title$  
Break Time��$	��122��$	��300��$��14(�.��%  Xceed.Wpf.Toolkit.BusyIndicator  -     Name$ bi��.���  � RowDefinitions �� $��* ��� $��* �.+��� -    ��Name$ btnPakdo��$��Find Idle Time��$��16(����� *FindKCCommand+� $��1��$��40�� � ColumnDefinitions �� $��4* ��� $��2* ��� $��3* �.+��� $��0��$��1q�$��3q�
���   �._��� $
��Left=�$��Center=� � ToolTip$ Observation date������ *KCDate+ �� StringFormat$ 	Date: {0}���� $��1��$��1q�$��3q�
���   �._��� $
��Left=�$��Center=�$7 1Number of times person was away from workstation.������ *NumberOfTimes+$ 
Times: {0}���� $��2��$��1q�$��3q�
���   �._��� $
��Left=�$��Center=�$5 /Total minutes person was away from workstation.������ *KCTime+$ Minutes: {0}��