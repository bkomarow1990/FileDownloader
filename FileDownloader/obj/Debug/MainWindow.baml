   M S B A M L   `   `   `  ����I  EFileDownloader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:FileDownloaderFileDownloader  5   	       FileDownloader.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:FileDownloader     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �� .+�5
   
   �� $��From:��6    �� Left$ 18��6    
 �� Top$ 20��61   �� 5   
   -   5        $��
fileNameTB��5      $��23��6$   $ 81��60    �� TextWrapping$
 Wrap=�6A   $ ��http:/johnson.com/test.jpg��6U   $ 24��6w   $	��323��6�   �� 5   
   $	��To:��6   $ 33��6   $ 84��6/   �� 5   
   -   5        $��folderNameTB��5      $��23��6&   $ 81��62   $
 Wrap=�6C   $��User/Desktop��6W   $ 85��6k   $	��323��6{   �� 5   
   -   5        $��Open Folder��5      $	 428��6'   $ 87��69   $��75��6I   6T   �� 5   
   -   5        $��Start��5      $	 428��6!   $	 132��63   $��75��6D   $��33��6O   ���	#FF4BAA696r   �� 5   
   -   5        $��threadsListBox��5      $��Stretch=�6(   $	��284��6M   $ 33��6Z   $	 132��6k   $	��371��6|   ��5      �� 5      .R�5      ]� $��5q�6    .+�5      �� $
��Left=�6$   $��Center=�6:   �� 5      $
�Id: ��6"    �� 5      �6"   �� *Id+ �� 5      $� ��6"   5      �� 5      $
��Bold"�6    ��62   �� *
FileName+6Q   �� 5      .��6    	copy to6)   �� 5      $
��Bold"�6    ��62   �� *
FolderName+6S   �� 5      $��Right=�6$   $��Center=�6;   �� 5       �6"   �� *
Progress+ �� 5!      .�6"   %6%   5"      � 5#      $	��100��6&   $��5q�65    � Value 6@   �� *
Progress+6]   5$      5%      5'      �� 5(   
   -   5        $��stopBtn��5(   q   $
��Stop��6   $	 428��6    $	 200��62   $��75��6C   $��33��6N   ���	#FFC46E536�   �� 5)   
   -   5        $��pauseBtn��5)   r   $��Pause��6   $	 428��6!   $	 268��63   $��75��6D   $��32��6O   ���	#FFC8B75D6�   5*      5+      