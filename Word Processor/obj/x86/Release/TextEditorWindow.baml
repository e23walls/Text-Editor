   M S B A M L   `   `   `  ����   Simple Text Editor,    &Word_Processor__1._0_.TextEditorWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  Simple Text Editor��$	��563��$	��544��$��Normal"�$��Center=�$��Center=� � 
ResizeMode$ NoResize=� � Icon$J Dfile:///H://ICS/File%20IO/Word%20Processor/text%20editor%20icon1.png�����	#FFD1D1D1 � WindowStartupLocation$ CenterScreen=� J� OpacityMask Z� .��� $	��523��$	��521��.+��� -   $��
titleLabel��$��Untitled��$��45��$��Center=�$��
12,12,12,0q�$	��Top=�$��Lucida Bright)�$��33(�$	��497��$��Center=��� -   $��fileContents_txt��$	��338��$
��Left=�$��	12,0,0,12q�$��Bottom=�$	��497�� �� 
AcceptsTab .  �� AcceptsReturn . $�� ��" �� VerticalScrollBarVisibility$
 Auto=� �� TextWrapping$
 Wrap=�$��Lucida Console)��� -   $��
saveButton��$
��Save��$��49��$��70,60,407,0q�$	��Top=�$
��Bold"�$��10(�	 J� Opacity$	 1Q����� 
 �� ImageSource$(
 "file:///H://save%20file%20icon.png���� -   $��	newButton��$	��New��$��49��$
��Left=�$��	12,60,0,0q�$	��Top=�$��44��$
��Bold"�$��10(�$	 1Q����� $*
 $file:///H://create%20new%20file1.png���� -   $��filePath_txt��$��23��$
��Left=�$��104,142,0,0q�$	��Top=�$	��158��
�������
���   �$	��0.2q�$
��H://���� -   $��savePathLabel��$��Save Location:��$��28��$
��Left=�$��
12,139,0,0q�$	��Top=�$
��Bold"��� -   $��fileName_txt��$��23��$��104,113,259,0q�$	��Top=� �� TextAlignment$ Right=�$��Untitled.txt���� -	   $��label1��$��
File Name:��$��28��$
��Left=�$��
33,111,0,0q�$	��Top=�$
��Bold"��� -
   $��quit_Button��$
��Quit��$��49��$
��Left=�$��456,0,0,414q�$��Bottom=�$��53��$
��Quit)�$
��Bold"�$	 1Q����� $+
 %file:///H://quit%20program%20icon.png���� -   $��openFile_txt��$��23��$��Right=�$��
0,113,12,0q�$	��Top=�$	��142��$
��H://���� -   $��openfileLabel��$��Open Location:��$��28��$
��Left=�$��271,111,0,0q�$	��Top=�$��12(�$
��Bold"��� -   $��
openButton��$
��Open��$��10(�$
��Bold"�$��49��$��128,60,349,0q�$	��Top=�$	 1Q����� $(
 "file:///H://open%20file%20icon.png��o� -   $��menu1��$��23��$
��Left=�$	��Top=�$	��521������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FFBEBEBE�� � Offset$ 0.244Q�� $ White��$ 0.831Q�.@�m� $
��File��.@�m� -   $��New File�� m� InputGestureText$ Ctrl + N�� m� Icon �� $A��;file:///H://ICS/File%20IO/Word%20Processor/plus%20sign1.png��m� -   $
��Save��$ Ctrl + S�� �� $H��Bfile:///H://ICS/File%20IO/Word%20Processor/save%20file%20icon1.png��m� -   $��Open…��$ Ctrl + O�� �� $H��Bfile:///H://ICS/File%20IO/Word%20Processor/open%20file%20icon1.png��m� -   $��Close��$ Ctrl + W�� �� $&�� file:///H://close%20program1.png��m� -   $
��Exit��$ Ctrl + Q�� �� $K��Efile:///H://ICS/File%20IO/Word%20Processor/quit%20program%20icon1.png��m� $
��Edit��.@�m�  m� Command$ ApplicationCommands.Copy��$
��Copy�� �� $@��:file:///H://ICS/File%20IO/Word%20Processor/copy%20icon.png��m� $ ApplicationCommands.Cut��$	��Cut�� �� $?��9file:///H://ICS/File%20IO/Word%20Processor/cut%20icon.png��m� $ ApplicationCommands.Paste��$��Paste�� �� $A��;file:///H://ICS/File%20IO/Word%20Processor/paste%20icon.png��m� $ ApplicationCommands.Undo��$
��Undo�� �� $@��:file:///H://ICS/File%20IO/Word%20Processor/undo%20icon.png��m� $ ApplicationCommands.Redo��$
��Redo��$ Shift + Ctrl + Z�� �� $@��:file:///H://ICS/File%20IO/Word%20Processor/redo%20icon.png���� -   $��closeWinButton��$��Close��$
��Quit)�$
��Bold"�$��49��$
��Left=�$��188,0,0,413q�$	 1Q�$��Bottom=�$��43������ $%
 file:///H://close%20program.png������ $ 1,0.5&�$ 0,0.5&�.��� $ White��$ 0Q�� $ 	#FFFFCEF4��$ 1Q�