   M S B A M L   `   `   `  ����E  APhotobooth, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Photobooth
Photobooth  5   	       Photobooth.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Photobooth     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   $	��450��65   $	��800��6E   .��5	      �  � RowDefinitions 5
   
   �� 5      $��45 �6   �� 5      $��* �6   �� 5      $��25 �6   .+�5   
   � -   5        $��Button_Container��5      $��0��6   
���   �.+�5      �� -   5         ��Name$ lb_Title��5      $��
Photobooth��6&   $��45��6<   $��Center=�6H   $��Right=�6c   $	��Top=�6   $��30(�6�   $��Viner Hand ITC)�6�   
���� �����#00EEFF$��0,0,0,2q�6�   $��	0,0,622,0q�6  $	��170��6  �� 5      -   5        $��	btn_Login��5      
�������$��0q�69   $��	630,0,0,0q�6t   $y�Hidden=�6�   ��6E   Z� ��5      �� 5       �� ImageSource$ view/img/Login.png��6!    j� Stretch$ Uniform=�6B    j� 
AlignmentX$ Right=�6T   .��5   %   Login5      5      �� 5   
   -   5        $��	btn_Start��5      
�������$��0q�65   $��	630,0,0,0q�6p   $y�Hidden=�6�   ��6A   Z� ��5      �� 5      $ view/img/start.png��6   $ Uniform=�6>   $ Right=�6P   .��5   !   
Démarer5       � 5#   
   -   5        $��Window_Container��5#      $��1��6   5%      � 5(   
   $��2��6   
���   �.+�5)      �� $��-----��6   $��40��6$   $��Center=�60   $
��Left=�6K   $	��Top=�6f   $��20(�6{   $��Vladimir Script)�6�   
���   ����#00EEFF$��158,-8,0,-7q�6�    J� RenderTransformOrigin$ 
0.562,0.79&�6�   �� 5*      $8��2| ©2020 | Téo | SaintMichelAnnecy | PhotoBooth |��6   $��40��6O   $��Center=�6[   $��Center=�6v   $	��Top=�6�   $��20(�6�   $��Vladimir Script)�6�   
���   �
���� ��6�   �� 5+      $��-----��6   $��40��6$   $��Center=�60   $��Right=�6K   $	��Top=�6g   $��20(�6|   $��Vladimir Script)�6�   
���   ����#00EEFF$��0,-8,158,-7q�6�   5,      5-      5.      