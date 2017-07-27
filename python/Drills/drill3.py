from datetime import *
import os.path
import shutil as sH

path_to_dir = 'C:\\Users\\seang\\Desktop\\oldFiles\\'

path_to_copy = 'C:\\Users\\seang\\Desktop\\transfer'

current = datetime.now()



def copyNew(file_list):
    for each in file_list:
        mtime = os.path.getmtime(path_to_dir + each)
        date = datetime.fromtimestamp(mtime)
        print ('Month: {}, Day: {}, Year: {}').format(date.month,date.day,date.year)
        if date.day == current.day:
            sH.copy(path_to_dir + each,
                    path_to_copy)
            
            



            
files = os.listdir(path_to_dir)

copyNew(files)
