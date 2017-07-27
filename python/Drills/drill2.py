
import shutil as sH
import os


def copy():
    path = 'C:\\Users\\seang\\Desktop\\folderA\\'
    newdir = 'C:\\Users\\seang\\Desktop\\folderB\\'
    files = os.listdir(path)

    for each in files:
        print(path + each + ' moved to: ' + newdir + each)
        sH.move(path+each,newdir)

copy()
##  This seemed ugly to me. So I imported OS so I could loop through all files.  
##
###############################################################################
##  sH.move('C:\\Users\\seang\\Desktop\\folderA\\file1.txt',
##        'C:\\Users\\seang\\Desktop\\folderB')
##  sH.move('C:\\Users\\seang\\Desktop\\folderA\\file2.txt',
##        'C:\\Users\\seang\\Desktop\\folderB')
##  sH.move('C:\\Users\\seang\\Desktop\\folderA\\file3.txt',
##        'C:\\Users\\seang\\Desktop\\folderB')
##  sH.move('C:\\Users\\seang\\Desktop\\folderA\\file4.txt',
##        'C:\\Users\\seang\\Desktop\\folderB')
###############################################################################
##
        




