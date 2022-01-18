# NoManSky-Savegame-Backup
 Automatic Backups for No Man Sky Savegames
 
# License
See LICENSE file

# Why?
No Man Sky Savegame Backup, was born because i was annoyed with the bug about the expeditions ending prematurly,
making me waste hours replaying, so I decided to make a small utility to make backups of the savegames as
changes are detected.

I suppose it could also be used if you want to keep an historic record of your savegames.

# How to build:
This project does not use any 3rd party tools.
Load the project in Visual Studio 2017 and compile no need to download any 3rd party libraries.

# How to use:
1) Select your No Man Sky savegame folder (the one starting with ST_ located in your user data directory) 
   by clicking the topmost "..." button.
2) Select the destination folder, where your savegames will be copied to. The second "..." button.
3) Click Enable Monitoring button.
4) Play No Man Sky.
5) When you are done playing click the "Disable Monitoring" button or close the program.

If for some reason you keep getting errors about the savegame file being used by NMS you can try increasing the value
in the "Delay after change (Seconds)".

If you dont want to keep selecting the savegame location and destination each time you start the program you can
check the "Remember Paths" option, this will create a file named "paths.txt" in the program directory with
only two intries, each one for each directory. If you uncheck this option the file will be deleted.

Any relevant error or information message will be displayed in the Log section, this data is NOT saved so it will
be lost when exitting the program.