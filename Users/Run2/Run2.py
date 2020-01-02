import praw

from Users.Run2.NameGennedOld import NameGennedOld
from Users.Run2.myUsers4 import MyUsers4

_NameGennedOld = NameGennedOld.All
_MyUsers4 = MyUsers4.All

class MyUsers3:


    def __init__(self, name):
        self.name = name    # instance variable unique to each instance

    ### Definitions
    All = _NameGennedOld +_MyUsers4
    ###

#print("myUsers: \t\t\t", MyUsers.Orig.__len__())
print("Run2 Tot: \t\t\t", MyUsers3.All.__len__())