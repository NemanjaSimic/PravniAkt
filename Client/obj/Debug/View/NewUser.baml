   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Client.ViewClient.View  5   	       Client.View.NewUser   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Client.View     5   	     � Title$  NewUser��5   	   $	��318��6   $��311.6��6&   .��5	      � $��
0,0,3.6,-1q�6   .+�5
      �� $
��IME:��6
   $
��Left=�6   $��30��64   $��	35,34,0,0q�6@   $	��Top=�6S   $��73��6k   �� 5      $��PREZIME:��6
   $
��Left=�6   $��31��68   $��	35,69,0,0q�6D   $	��Top=�6W   $��73��6o   �� 5      $��	USERNAME:��6
   $
��Left=�6   $��27��69   $��
35,105,0,0q�6E   $	��Top=�6Y   $��90��6q   �� 5      $��SIFRA:��6
   $
��Left=�6   $��36��66   $��
35,140,0,0q�6B   $	��Top=�6V   $��73��6n   �� 5      $��TIP KORISNIKA:��6
   $
��Left=�6#   $��30��6>   $��
35,181,0,0q�6J   $	��Top=�6^   $��90��6v   �� 5      $
��Left=�6   $��30��6'   $��
130,34,0,0q�63    �� TextWrapping$
 Wrap=�6G   $	��Top=�6�   $	��158��6�   ��6[   �� *NewUser.Ime+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      $
��Left=�6   $��30��6'   $��
130,70,0,0q�63   $
 Wrap=�6G   $	��Top=�6�   $	��158��6�   ��6[   �� *NewUser.Prezime+$ PropertyChanged=�6�   �� 5      $
��Left=�6   $��30��6'   $��130,105,0,0q�63   $
 Wrap=�6H   $	��Top=�6�   $	��158��6�   ��6\   �� *NewUser.Username+$ PropertyChanged=�6�   �� 5      $
��Left=�6   $��30��6'   $��130,140,0,0q�63   $
 Wrap=�6H   $	��Top=�6�   $	��158��6�   ��6\   �� *NewUser.Sifra+$ PropertyChanged=�6�   �� 5      $��Napravi korisinika��6   $
��Left=�6N   $��31��6i   $��
72,249,0,0q�6u   $	��Top=�6�   $	��132��6�   ��6(   �� *CreateUserCommand+6�   �� 5      -   5        $��ComboBoxTipKorisinika��5      $
��Left=�6O   $��30��6j   $��130,178,0,0q�6v   $	��Top=�6�   $	��158��6�    �� SelectedItem 6*   �� *NewUser.Tip+6�   5      5      