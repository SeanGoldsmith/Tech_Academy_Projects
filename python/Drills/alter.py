import sqlite3

conn = sqlite3.connect('fileTransfer.db')
c = conn.cursor()
c.execute("SELECT MAX(time) FROM transfer_info")
data = c.fetchall()
