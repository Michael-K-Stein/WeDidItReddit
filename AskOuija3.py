from Users import myUsers
#from Users import LordPhantom_Bots1
import random
from random import shuffle
import time
import praw
from Users.Run2.NameGennedOld import NameGennedOld
from Users.Run2.myUsers4 import MyUsers4
from Users.Run2.Run2 import MyUsers3

_NameGennedOld = NameGennedOld.All
_MyUsers4 = MyUsers4.All
_MyUsers3 = MyUsers3.All

f = open(r"C:\Users\stein\Desktop\genericPassword.txt", "r")
f2 = open(r"C:\Users\stein\Desktop\nongenericPassword.txt", "r")
genericPassword =f.read()
nongenericPassword =f2.read()
f.close()
f2.close()


# Hym1djLG_VMOGOGO2R4lq444nkU
# DJ68z5_HCD_vTw

WishIWasNotDepressed = praw.Reddit(client_id='RuMVK50LGdFxBQ',
                         client_secret='lvOae9gAjOL-mNvj_o-P90GLRv4',
                         user_agent='WishIWasNotDepressed',
                         username='WishIWasNotDepressed',
                         password=genericPassword)
WhereIsMyWill2Live = praw.Reddit(client_id='RuMVK50LGdFxBQ',
                         client_secret='lvOae9gAjOL-mNvj_o-P90GLRv4',
                         user_agent='WhereIsMyWill2Live',
                         username='WhereIsMyWill2Live',
                         password=genericPassword)


askOuija = WishIWasNotDepressed.subreddit("AskOuija")
STFUBot = WishIWasNotDepressed.redditor("STFU_U_KARMA_BOT")

def upVote(comID):
    WishIWasNotDepressed.comment(comID).upvote()
    WhereIsMyWill2Live.comment(comID).upvote()
def downVote(comID):
    for bot in _MyUsers3:
        try:
            print(bot.user.me().name)
            bot.comment(comID).downvote()
        except Exception as e:
            print(e)

#all_users = users.All

try:
    for com in STFUBot.comments.top():
        print(com.id)
        downVote(com.id)
except Exception as e:
    print("Going to sleep...")
    #time.sleep(3)
