   M S B A M L   `   `   `  ���� 
  Physea    
Physea.GUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -   ���#303030  � 	Resources     ButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius ��Name �� Triggers P� Property	 P� Value  TextBoxStyle  TextBlockStyle  RadioButtonStyle  CheckBoxStyle��%�  &	        &	 �    &	 �    &	 O    &	     �� " ��.���  � �� �#878787��  � ��
 �������  � ��$ 14(���  �@J�SnapsToDevicePixels . ��  � ��$ Normal$���  � ��$ Segoe UI)���  � �� �� " ��.R��� $ 0��#��z��._�� .+��� $ MyContentPresenter��#��z��$��Center=�$��Center=�$��0,0,0,0q� P�  �@J�IsMouseOver	 . . ���  � �� �#041c52��  � ��
 �����P�  � ��	 . . ���  � �� �#020832��  � ��
 ������� " ��.���  � �� �#505050��  � ��
 �������  � ��$ 14(���  �@J�SnapsToDevicePixels . ��  � ��$ Normal$���  � ��$ Segoe UI)��� " ��.���  � �� �#505050��  � ��
 �������  � ��$ 14(���  �@J�SnapsToDevicePixels . ��  � ��$ Normal$���  � ��$ Segoe UI)��� " 	�.���  � �� �#505050��  � ��
 �������  � ��$ 14(���  �@J�SnapsToDevicePixels . ��  � ��$ Normal$���  � ��$ Segoe UI)��� " ��.���  � �� �#505050��  � ��
 �������  � ��$ 14(���  �@J�SnapsToDevicePixels . ��  � ��$ Normal$���  � ��$ Segoe UI)�.��� 
 � RowDefinitions
 �� $��1* ��� $��8* ��� $��1* ��� $��1* �.+��� -    ��Name$ 
MainCanvas��$��1��$	��600��$
��1000����  �� Orientation$ 
Horizontal=�$��2�����#505050.+��� $ Vertical=�$��5q�.+��� $��	Mass (kg)��#��[ �� -    ��Name$ MassTBo��#��[ $��50������ *Mass+�� $ Vertical=�$��5q�.+��� $
��Size��#��[ �� -   $ SizeTBo��#��[ $��50���� $ Vertical=�$��5q�.+��� $��
Weight (N)��#��[ �� -    ��Name$ 	WeightTBl��#��[ ���� *Weight+�� $ Vertical=�$��5q�.+��� $��Drag (N)��#��[ �� -   $ DragTBl��#��[ ���� *Drag+�� $ Vertical=�$��5q�.+��� $��Velocity (m/s)��#��[ �� -   $ VelocityTBl��#��[ ���� *
Velocity+�� $ Vertical=�$��5q�.+��� $��XPosition (m)��#��[ �� -   $ XPosTBl��#��[ ���� *	XPosition+�� $ Vertical=�$��5q�.+��� $��YPosition (m)��#��[ �� -	   $ YPosTBl��#��[ ���� *	YPosition+�� $ Vertical=�$��5q�.+�	� -
    	�Name$ CubeRB��$
��Cube��#��[ 	� -   $ SphereRB��$��Sphere��#��[ �� $ Vertical=�$��5q�.+��� -    ��Name$ UseGravityCB��$��Use Gravity��#��[ �� -   $ UseAirResistanceCB��$��Use Air resistance��#��[ � $��3�� � ColumnDefinitions �� $��5* ��� $��1* �.+��� -   $��0��$��Start��#��[  $��4q��� -   $��1��$
��Stop��#��[  $��4q�