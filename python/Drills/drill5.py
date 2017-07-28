from datetime import *
import os.path
import shutil as sH
from tkinter import *
from tkinter import ttk
from tkinter import filedialog as tkF
import sqlite3

current = datetime.now()

conn = sqlite3.connect('fileTransfer.db')
c = conn.cursor()
c.execute("CREATE TABLE IF NOT EXISTS transfer_info (time INT,origin_dir TEXT,destination_dir TEXT)")

##This is used to check later if there are no records in the database.
##Without this check, the generateLastTransfer() call gives an error
##because the variable passed to it is not a string.
c.execute("SELECT COUNT(time) FROM transfer_info")
test = c.fetchall()
test = test[0][0]
###################################################
###################################################

##  Grabs the latest file transfer from the database
def generateLastTransfer():
    c.execute("SELECT MAX(time) FROM transfer_info")
    last = c.fetchall()
    return last
    
##  Checks to see if there are any files that have been updated
##  since the last transfer. If so, they are transfered.
def copyNew(file_list):
    current = datetime.now()
    for each in file_list:
        mtime = os.path.getmtime(path_to_dir + '/' + each)
        date = datetime.fromtimestamp(mtime)
        print ('Month: {}, Day: {}, Year: {}'.format(date.month,date.day,date.year))

        
        if (test != 0):

            if date > datetime.strptime(generateLastTransfer()[0][0],
                                        '%Y-%m-%d %H:%M:%S.%f'):
                sH.copy(path_to_dir + '/' + each,
                        path_to_copy)
        ## Used only when dB is empty
        else:
            if date > current-timedelta(1):
                sH.copy(path_to_dir + '/' + each,
                    path_to_copy)
        ##############################

    ##Adds a new transfer record in the dB          
    c.execute("INSERT INTO transfer_info VALUES (?,?,?)",(current,path_to_dir,path_to_copy))
    conn.commit()
    lastTransferEntry.delete(0,'end')
    lastTransferEntry.insert(0,generateLastTransfer())
    #########################################
            
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
    transferLabel = ttk.Label(frame,text='Last Transfer Recorded')
    transferLabel.grid(row=3,column=0,columnspan=2)
    global lastTransferEntry
    lastTransferEntry = ttk.Entry(frame,width=50,justify = 'center')
    lastTransferEntry.grid(row=4,column=0,columnspan=2)
    lastTransferEntry.insert(0,generateLastTransfer())

##  Grabs the directory the user wants to copy from and adds
##  it to the screen. Also generates a file list for copyNew
##  to work with
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


generateLastTransfer()

root = Tk()
generateGUI()
mainloop()

            



