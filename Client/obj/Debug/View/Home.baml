   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Client.ViewClient.View  5   	       Client.View.Home   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Client.View     5   	     � Title$
  Home��5   	   $	��450��6   $	��800��6#   .��5	      � .+�5
      �� $��28(�6%   $
��Left=�63   $��59��6N   $��545,0,-0.4,0q�6Z   $	��Top=�6p   $	��249��6�   ��6
   �� *Naslov+6�   �� 5      -   5        $��DodajKorisnikaButton��5      $��Dodaj korisnika��6'   $
��Left=�6j   $��25��6�   $��
203,10,0,0q�6�   $	��Top=�6�   $	��180��6�   ��6A   �� *CreateNewUserCommand+6�   �� 5      -   5        $��IzmeniPodatkeButton��5      $��Izmeni podatke��6&   $
��Left=�6q   $��25��6�   $��	10,10,0,0q�6�   $	��Top=�6�   $	��175��6�   ��6?   �� *ChangeUserInformationsCommand+6�   �� 5      $��Novi Pravni Akt��63   $
��Left=�6M   $��29��6h   $��
10,347,0,0q�6t   $	��Top=�6�   $	��175��6�   ��6   �� *NewPravniAktCommand+6�   &   System.Windows.Controls.DataGrid  5         
IsReadOnly .    AutoGenerateColumns .  $
��Left=�6�   $	��231��6�   $��
10,111,0,0q�6�   $	��Top=�6  $	��738��6'  ��6;   �� *
PravneAkte+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 6�   �� *PravniAktToDelete+$ PropertyChanged=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Naslov��6      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6D   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *Naslov+6D     5      $
 Uvod��6   $ * 6A    6(   �� *Uvod+6A     5      $ Datum Stupanja Na Snagu��6   $ * 6d    6;   �� *DatumStupanjaNaSnagu+6d     5      $ Tip Pravnog Akta��6   $ * 6W    64   �� *TipPravnogAkta+6W   5      �� 5      $��Izbrisi Pravni Akt��6   $
��Left=�6M   $��29��6h   $��
10,381,0,0q�6t   $	��Top=�6�   $	��175��6�   ��6(   �� *DeleteAktCommand+6�   5      5      