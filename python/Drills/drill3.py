from datetime import *
import os.path
import shutil as sH

path_to_dir = 'C:\\Users\\My Elite\Desktop\\oldFiles\\'

path_to_copy = 'C:\\Users\\My Elite\\Desktop\\transfer\\'

current = datetime.now()


def copyNew(file_list):
    for each in file_list:
        mtime = os.path.getmtime(path_to_dir + each)
        date = datetime.fromtimestamp(mtime)
        print ('Month: {}, Day: {}, Year: {}'.format(date.month,date.day,date.year))
        if date > (current-timedelta(1)):
            sH.copy(path_to_dir + each,
                    path_to_copy)
            
            



            
files = os.listdir(path_to_dir)

copyNew(files)
