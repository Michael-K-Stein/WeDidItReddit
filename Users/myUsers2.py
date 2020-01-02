import praw
f = open(r"C:\Users\stein\Desktop\genericPassword.txt", "r")
genericPassword =f.read()
f.close()

__client_id = ""
__client_secret = ""

class MyUsers2:


    def __init__(self, name):
        self.name = name


    ### Definitions
    All = []
    ###

print("myUsers2: ", MyUsers2.All.__len__())