   M S B A M L   `   `   `  ���� A  =Kebabi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KebabiKebabi      Kebabi.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     &localclr-namespace:Kebabi       � Title$  Kebabi��$	��480��$	��850�� � 
ResizeMode$ CanMinimize=�
������� � Icon$( "/E17YMPMUYAExTuh-orig-modified.png�� � 	Resources    ScrollViewerStyle1 �� 
TargetType �� Property �� Value �� 
TargetType �Name	 � ColumnDefinitions
 � RowDefinitions ��Name �� RadiusY �� RadiusX ��Name �� CanHorizontallyScroll �� CanVerticallyScroll �� CanContentScroll ��Name4  .System.Windows.Automation.AutomationProperties   AutomationId � Cursor �� ScrollableHeight � Maximum � Minimum �� ViewportHeight �� ViewportSize* �� #ComputedVerticalScrollBarVisibility � Value �� Mode �� RelativeSource �� ScrollableWidth �� Orientation  �� ViewportWidth,! �� %ComputedHorizontalScrollBarVisibility" �� Triggers# P� Property$ P� Value  FocusVisual% �� StrokeDashArray& J� SnapsToDevicePixels  OptionMarkFocusVisual   OptionMark.Static.Background' �� Color  OptionMark.Static.Border  OptionMark.Static.Glyph # OptionMark.MouseOver.Background  OptionMark.MouseOver.Border  OptionMark.MouseOver.Glyph !	 OptionMark.Pressed.Background 
 OptionMark.Pressed.Border  OptionMark.Pressed.Glyph " OptionMark.Disabled.Background  OptionMark.Disabled.Border  OptionMark.Disabled.Glyph  CheckBoxStyle1( ��Name) �� CornerRadius* F�Name+ J� Opacity, �� Stretch- ��Name. �� Triggers/ �� 
TargetName  FocusVisual1  Button.Static.Background  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground  ButtonStyle1��%E  &	        &	     &	 d    &	 �    &	 �    &	 �    &	 �    &	 	    &	     &		 3    &	
 H    &	 ]    &	 r    &	 �    &	 �    &	 �    7  7  7  7  7  7  7  7  7  7  7  7  7  7  7 	 7 
 7  7  &	 �
    &	 !    &	 6    &	 K    &	 `    &	 u    &	 �    &	 �    &	 �    &	 �    &	 �    7  7  7  7  7  7  7  7  7  7  �� " ��.���  � �� �� " ��.R�� $
 Grid��#��z��	 �� $��* ��� $
��Auto �
 �� $��* ��� $
��Auto �.+��� $ Corner��$��1��#��� ��$��1��$ 15��$ 15��$��0���� $! PART_ScrollContentPresenter�� .  #��z�� .  $��0��#��z��# z��#��z��$��0���� $ PART_VerticalScrollBar��$ VerticalScrollBar��$ Arrow��$��1��# z $ 0Q�$��0��# z #y�z $��0,0,0,0q�
����������	#FFF0F0F0 �� *VerticalOffset+$ OneWay=� �� *TemplatedParent+��Z� �� $ PART_HorizontalScrollBar��$ HorizontalScrollBar��$ Arrow��$��0��# z $ 0Q�$ 
Horizontal=�$��1��# z  #y�z!  �� *HorizontalOffset+$ OneWay=� �� *TemplatedParent+" P� # � {�$ .  . ���  � ��# � ���� .���  � �� �� .R��� $��2q�$	% 1 2R�#��� ��& . $��1���� .���  � �� �� .R��� $��14,0,0,0q�$	% 1 2R�#��� ��& . $��1���� $' 	#FFFFFFFF���� $' 	#FF707070���� $' 	#FF212121���� $' White���� $' 	#FF676767���� $' 	#FF212121���� $' 	#FFCECECE���� $' 	#FF717171���� $' 	#FF212121���� $' 	#FFE6E6E6���� $' 	#FFBCBCBC���� $' 	#FF707070���� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# � ����  � ��$ 1q���  � �� �� " ��.R�� $ templateRoot��
������ & . 	 �� $
��Auto ��� $��* �.+��� $( checkBoxBorder��#��z��#��z��#��z��#��z��$��1q�#��z��$) 5,5,5,5��$��20��$��20��._�� $ markGrid��$��Center=�$��Center=�.+�F� $* 
optionMark��Y�����4� �� Ѽ�G dԊ Ѩ�D dԊ �    ^>O ��z r�5 ��@ ��\ 
ܺ��� @�j�  �>��4� �� 8�� $��1q�$+ 0Q�$
, None=��� $ indeterminateMark��8�� $��0,0,0,0q�$+ 0Q��� $- contentPresenter��$��1��|�.  #��z��#��z����. #& z& #��z��. P� # � ��$ . . ��� 8   �@�FocusVisualStyle��  � ��$ 4,-1,0,0q�P� # �@J�IsMouseOver$ . . ��� $/ checkBoxBorder��8   � ���� $/ checkBoxBorder��8   � ���� $/ 
optionMark��8   � ���� $/ indeterminateMark��8 	  � ��P� # � {�$ .  . ��� $/ checkBoxBorder��8 
  � ���� $/ checkBoxBorder��8   � ���� $/ 
optionMark��8   � ���� $/ indeterminateMark��8   � ��P� # � ��$ . . ��� $/ checkBoxBorder��8   � ���� $/ checkBoxBorder��8   � ���� $/ 
optionMark��8   � ���� $/ indeterminateMark��8   � ��P� # �@d�	IsChecked$
$ trueY�. ��� $/ 
optionMark�� �@J�Opacity$ 1Q��� $/ indeterminateMark�� �@J�Opacity$ 0Q�P� $ Z� # �@d�	IsChecked. ��� $/ 
optionMark�� �@J�Opacity$ 0Q��� $/ indeterminateMark�� �@J�Opacity$ 1Q��� .���  � �� �� .R��� $��2q�$	% 1 2R�#��� ��& . $��1���� $' 	#FFDDDDDD���� $' 	#FF707070���� $' 	#FFBDBDBD���� $' 	#FF3C7FB1���� $' 	#FF9A9A9A���� $' 	#FF2C628B���� $' 	#FFF4F4F4���� $' 	#FFADB2B5���� $' 	#FF838383���� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# � ����  � ��$ 1q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��.R��� $( border��#��z��#��z��#��z��& . $) 15,15,15,15��._��� $- contentPresenter��|�.  #��z��#��z����. #& z& #��z��. P� # �@��IsDefaulted$ . . ��� $/ border��# � �� � ��P� # �@J�IsMouseOver$ . . ��� $/ border��8   � ���� $/ border��8   � ��P� # � ��$ . . ��� $/ border��8   � ���� $/ border��8   � ��P� # � {�$ .  . ��� $/ border��8   � ���� $/ border��8   � ���� $/ contentPresenter��8 	  � ��.��� .+��� $��
40,75,40,0q�$	��250��$	��Top=�.��� $	��748��.+��� -   0 ��Name$0 Remove��#���  $��18(�$��	15,20,0,0q�$
��Left=�$	��Top=�1 d� 	IsChecked$1 FalseY�$��Segoe UI)�.��� .+��� $	��319��$��57.9921806337573��
���   �$��2��$ 10��$ 10����   Null#���  $��20(�$
��Bold"�$��Center=�$��Center=��� -   $
0 Zero��#���  $��18(�$��Right=�$	��Top=�$1 FalseY�$��Segoe UI)�$��	0,20,15,0q�.���� $��	Img/0.png��$	��320��2 J� Clip2 �� 3 �� RadiusX$3 15Q�4 �� RadiusY$4 10Q�5 �� Rect$5 0,0,320,56.9921773142112��� -   $0 First��#���  $��18(�$
��Left=�$	��Top=�$1 FalseY�$��Segoe UI)�$��
15,110,0,0q�.���� $��	Img/1.png��$	��320��2 �� $3 15Q�$4 10Q�$5 0,0,320,56.9921773142112��� -   $0 Forth��#���  $��18(�$��Right=�$	��Top=�$1 FalseY�$��Segoe UI)�$��
0,190,15,0q�.���� $��	Img/4.png��$	��320��2 �� $3 15Q�$4 10Q�$5 0,0,320,56.9921773142112��� -   $0 Third��#���  $��18(�$
��Left=�$	��Top=�$1 FalseY�$��Segoe UI)�$��
15,190,0,0q�.���� $��	Img/3.png��$	��320��2 �� $3 15Q�$4 10Q�$5 0,0,320,56.9921773142112��� -   $0 Second��#���  $��18(�$��Right=�$	��Top=�$1 FalseY�$��Segoe UI)�$��
0,110,15,0q�.���� $��	Img/2.png��$	��320��2 �� $3 15Q�$4 10Q�$5 0,0,320,56.9921773142112��� -   $0 Fifth��#���  $��18(�$
��Left=�$	��Top=�$1 FalseY�$��Segoe UI)�$��15,270,0,20q�.���� $��	Img/5.png��$	��320��2 �� $3 15Q�$4 10Q�$5 0,0,320,56.9921773142112��� -   $0 Sixth��#���  $��18(�$��Right=�$	��Top=�$1 FalseY�$��Segoe UI)�$��0,270,15,20q�.���� $��	Img/6.png��$	��320��2 �� $3 15Q�$4 10Q�$5 0,0,320,56.9921773142112��� 
���   �$ 15��$ 15��$��
40,61,40,0q�$	��283��$	��Top=��� -	   6 ��Name$6 Start��#���   	 Start#���  $��45��$	��Top=�7 J� RenderTransformOrigin$7 0.5,0.5&�$��24(�$��	0,360,0,0q�$��Segoe UI)�$
��Bold"�
���   �$��0,0,0,0q�$��Center=�$��	20,0,20,0q��� -
   $0 CreatShortCut��#���  $��18(�$��	0,30,51,0q�$��Right=�$	��Top=�$1 FalseY�$��Segoe UI)�  CreatShortCut#���  �� -   $0 Close_Protect��#���  $��18(�$��	54,30,0,0q�$
��Left=�$	��Top=�$1 FalseY�$��Segoe UI)�  CloseProtect#���  �� $#��Designed by めぐたん#8475��$
��Left=�$��Bottom=�$��Segoe UI)�$��24��