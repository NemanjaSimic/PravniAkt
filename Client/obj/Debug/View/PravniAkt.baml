   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Client.ViewClient.View  5   	       Client.View.PravniAkt   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Client.View     5   	     � Title$  
Pravni Akt��5   	   $��763.4��6   $��623.6��6+   .��5	      � .+�5
      �� $	��DEO��6-   $
��Left=�6;   $��42��6V   $��
49,491,0,0q�6b   $	��Top=�6v   $	��174��6�   ��6   �� *NewDeoCommand+6�   �� 5      $��GLAVA��6/   $
��Left=�6?   $��42��6Z   $��229,491,0,0q�6f   $	��Top=�6{   $	��157��6�   ��6   �� *NewGlavaCommand+6�   �� 5      $��ODELJAK��61   $
��Left=�6C   $��42��6^   $��391,491,0,0q�6j   $	��Top=�6   $	��170��6�   ��6   �� *NewOdeljakCommand+6�   �� 5      $
��CLAN��6.   $
��Left=�6=   $��37��6X   $��
49,541,0,0q�6d   $	��Top=�6x   $	��512��6�   ��6   �� *NewClanCommand+6�   �� 5      $��TACKA��6/   $
��Left=�6?   $��30��6Z   $��
49,588,0,0q�6f   $	��Top=�6z   $	��250��6�   ��6   �� *NewTackaCommand+6�   �� 5      $
��STAV��6.   $
��Left=�6=   $��30��6X   $��305,588,0,0q�6d   $	��Top=�6y   $	��256��6�   ��6   �� *NewStavCommand+6�   �� 5      -   5        $��NaslovTextBox��5      $
��Left=�6"   $��41��6=   $��
49,358,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $
��Bold"�6�    �� TextAlignment$ Center=�6�   $��24(�6�   $	��Top=�6�   $	��512��6  ��6q   �� *NaslovPravnogAkta+ �� UpdateSourceTrigger$ PropertyChanged=�6  �� 5      -   5        $��UvodTextBox��5      $
��Left=�6   $	��117��6:   $��
49,193,0,0q�6G   $
 Wrap=�6[   $��18(�6�   $ Justify=�6�   $	��Top=�6�   $	��512��6�   ��6o   �� *UvodPravnogAkta+$ PropertyChanged=�6�   �� 5      -   5        $��TipoviAktaComboBox��5      $
��Left=�6t   $��37��6�   $��
305,22,0,0q�6�   $	��Top=�6�   $	��256��6�    �� SelectedItem 6'   �� *TipPravnogAkta+$ PropertyChanged=�6�   �� 5      $ ��Odaberite tip Pravnog Akta��6
   $��18(�6/   $
��Left=�6=   $��37��6X   $��	49,22,0,0q�6d   $	��Top=�6w   $	��250��6�   �� 5      $
��UVOD��6
   $��20(�6   $
��Left=�6'   $��37��6B   $��283,152,0,0q�6N   $	��Top=�6c   $��74��6{   �� 5      $��NASLOV��6
   $��20(�6   $
��Left=�6)   $��37��6D   $��273,316,0,0q�6P   $	��Top=�6e   $��84��6}   �� 5      $=��7Klikom na dugme ubacite elemnt pravnog akta koji zelite��6
   $��20(�6M   $
��Left=�6[   $��42��6v   $��
49,412,0,0q�6�   $	��Top=�6�   $	��512��6�   �� 5      $W��Q*NAPOMENA: Redosled elemenata mora biti po pravilniku za formiranje Pravnih Akti!��6
   $��13(�6g   $
��Left=�6u   $��27��6�   $��
49,459,0,0q�6�   $	��Top=�6�   $	��512��6�   �� 5      $��Sacuvaj��66   $
��Left=�6H   $��54��6c   $��
49,667,0,0q�6o   $	��Top=�6�   $	��512��6�   ��6   �� *CreatePravniAktCommand+6�   (  "System.Windows.Controls.DatePicker  5      -   5        $��
Datepicker��5         DisplayDateStart$ 
01/01/2018X�6!   $
��Left=�6�   $��
423,90,0,0q�6�   $	��Top=�6�   $��44��6�   $	��138��6�      SelectedDate 6?   �� *DatumStupanjaNaSnagu+$ PropertyChanged=�6�   �� 5      $'��!ODABERITE DATUM STUPANJA NA SNAGU��6
   $��18(�66   $
��Left=�6D   $��44��6_   $��	49,90,0,0q�6k   $	��Top=�6~   $	��369��6�   5      5      