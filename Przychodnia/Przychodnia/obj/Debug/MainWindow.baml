   M S B A M L   `   `   `  ����F  BPrzychodnia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ProjektPrzychodniaProjektPrzychodnia  5   	   #    ProjektPrzychodnia.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:ProjektPrzychodnia     5   	     � Title$  
MainWindow��5   	   $��540.054��6   $��573.925��6-   .��5	      � .+�5   
   � -   5         �Name$ PanelLekarz��5      $	��243��6%   $	��Top=�62   $��10,10,312.2,0q�6J   .+�5      �� -   5         ��Name$ UstawL��5      $��Ustaw Lekarza��6%   $
��Left=�6R   $	��Top=�6m   $��97��6�   $��
45,170,0,0q�6�   $��30��6�   �� 5      $��Imie i nazwisko lekarza��6   $
��Left=�66   $	��Top=�6Q   $��	45,15,0,0q�6i   �� 5      -   5         ��Name$ danelekarza��5      $
��Left=�6+   $��23��6F    �� TextWrapping$
 Wrap=�6R   $	��Top=�6f   $	��120��6~   $��	45,41,0,0q�6�   �� 5      $��Specjalność��6   $
��Left=�6*   $	��Top=�6E   $��	45,79,0,0q�6]   �� 5      -   5        $ specjalnosc��5      $
��Left=�6+   $��23��6F   $
 Wrap=�6R   $	��Top=�6f   $	��120��6~   $��
45,110,0,0q�6�   5      � 5   
   -   5        $ PanelPacjent��5      $	��500��6%   $	��Top=�62   $��10,0,10.2,0q�6J   .+�5      �� -   5        $ dopiszdokolejki��5      $��Dopisz do kolejki��6L   $
��Left=�6h   $	��Top=�6�   $	��101��6�   $��266,205,0,0q�6�   $��26��6�   �� 5      $��Imie i nazwisko pacjenta��6   $
��Left=�67   $	��Top=�6R   $��
266,21,0,0q�6j   �� 5      -   5        $ danepacjenta��5      $
��Left=�6,   $��23��6G   $
 Wrap=�6S   $��TextBox��6g   $	��Top=�6v   $	��120��6�   $��
266,52,0,0q�6�   �� 5      $
��Wiek��6   $
��Left=�6$   $	��Top=�6?   $��
266,80,0,0q�6W   �� 5      -   5        $
 wiek��5      $
��Left=�6$   $��23��6?   $
 Wrap=�6K   $	��Top=�6_   $	��120��6w   $��266,106,0,0q�6�   �� 5      $��Choroba��6   $
��Left=�6&   $	��Top=�6A    J� RenderTransformOrigin$ 1.569,2.607&�6Y   $��266,129,0,0q�6}   �� 5      -	   5        $ choroba��5      $
��Left=�6'   $��23��6B   $
 Wrap=�6N   $	��Top=�6b   $	��120��6z   $��266,160,0,0q�6�   �� 5      -
   5        $ porada��5      $��Wykonaj poradę��6:   $
��Left=�6S   $	��Top=�6n   $	��120��6�   $��
46,278,0,0q�6�   $��28��6�   �� 5      -   5        $ badanie��5      $��Wykonaj badanie��6<   $
��Left=�6V   $	��Top=�6q   $	��120��6�   $��
46,324,0,0q�6�   $��26��6�   �� 5      -   5        $ raport��5      $��Generuj raport��6%   $
��Left=�6S   $	��Top=�6n   $	��120��6�   $��
46,371,0,0q�6�   $��25��6�   �� 5      -   5         ��Name$ kolejka��5      $	��316��6)   $	��232��65   $
��Left=�6B   $
��Wrap=�6]   $	��Top=�6q   $��221,268,0,0q�6�   5       5#      5$      