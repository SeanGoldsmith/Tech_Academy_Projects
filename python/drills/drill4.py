from datetime import *
import os.path
import shutil as sH
from tkinter import *
from tkinter import ttk
from tkinter import filedialog as tkF

current = datetime.now()


def copyNew(file_list):
    print (file_list)
    for each in file_list:
        mtime = os.path.getmtime(path_to_dir + '/' + each)
        date = datetime.fromtimestamp(mtime)
        print ('Month: {}, Day: {}, Year: {}'.format(date.month,date.day,date.year))
        if date > (current-timedelta(1)):
            sH.copy(path_to_dir + '/' + each,
                    path_to_copy)
            
            
def generateGUI():
    frame = ttk.Frame(root,width=640,height=480)
    frame.pack()

    transButton = ttk.Button(frame,text="Initiate File Transfer",command = lambda: copyNew(files))
    transButton.grid(row=0,column=0,columnspan=2)

    firstDirButton = ttk.Button(frame,text = "Choose Origin Directory",
                                command = lambda: fetchDir())
    firstDirButton.grid(row=1,column=0,padx=20,pady=20)

    secondDirButton = ttk.Button(frame,text = "Choose Destination Directory",
                                 command = lambda: fetchCopyDir())
    secondDirButton.grid(row=2,column = 0,padx=20,pady=20)

    global firstPathEntry
    firstPathEntry = ttk.Entry(frame,width=50)
    firstPathEntry.grid(row=1,column=1)
    global secondPathEntry
    secondPathEntry = ttk.Entry(frame,width=50)
    secondPathEntry.grid(row=2,column=1)

    
def fetchDir():
    direct = tkF.askdirectory()
    global path_to_dir
    path_to_dir = direct
    firstPathEntry.insert(0,direct)
    global files
    files = os.listdir(path_to_dir)

def fetchCopyDir():
    direct = tkF.askdirectory()
    global path_to_copy
    path_to_copy = direct
    secondPathEntry.insert(0,direct)


root = Tk()
generateGUI()
mainloop()

            



