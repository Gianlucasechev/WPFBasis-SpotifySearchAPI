   M S B A M L   `   `   `  ����O  KProyectoFinalSpotify, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ProyectoFinalSpotifyProyectoFinalSpotify  5   	   %    ProyectoFinalSpotify.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:ProyectoFinalSpotify     5   	   -   5        $��window��5        � Title$  Popularidad en Spotify��5	   	   $	��800��5
   	   $	��800��5   	    � AllowsTransparency$
 True��5   	   
������  � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � Topmost$
 True��5   	   .��5      �� $��10q�6    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 10Q�6      	Direction$	 270Q�6/      ShadowDepth$ 3Q�6?   	   Color$	 Black��6O   ._�5   
   �    BackgroundWindow1#��[  6   .+�5      ]� -   5        $��	tittleBar��5      $
��Auto��5      
���   �$��Bottom=�5      .+�5      �� $
��10,0q�6     	Neitherly#��[ 5      $��20(�5      
��������� 5!      $��20(�5"      $��15q�5#      ��5!      �� *Title+
 �� ElementName$
 window��5#      5$      �� 5%      -   5         ��Name$ btnminimize��5%       J� OpacityMask 5(      �� 5)       �� ImageSource$ /Assets/minimize.png��6%   5+      �� 5,      -   5        $ btnclose��5,       5/      �� 50      $ /Assets/exit.png��6%   52      53      � 54       � RowDefinitions 55      �� 56      $��50 �6$   �� 57      �� 58      $
��auto �6$   .+�5:      �� $��10q�6   $��Center=�6)    �� Orientation$ 
Horizontal=�6F   .+�5;      �� -   5         ��Name$ 	txtSearch��5;      $	��180��6D     TextBoxSearch#��[ 5<        textboxSpotify#��[ 5=      6C   5>      �� 5?      -   5         ��Name$ 
ListArtist��5@      $��1��5?      $��10q�5A        BackgroundWindow2#��[ 5B        ListArtistTemplate#��[ 5C      5E      �� 5F      $��2��6   $��5q�6*   $��Right=�65   $ 
Horizontal=�6Q   .+�5G      �� $��Powered by Spotify��6    $��Center=�6:   6W   �� 5H      $��48��6   $Q��Khttps://cdn.icon-icons.com/icons2/2201/PNG/256/spotify_logo_icon_134023.png��6(   6   5I      5K      5L      5M      5P      