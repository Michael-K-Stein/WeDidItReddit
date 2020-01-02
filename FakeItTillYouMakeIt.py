import random
from random import shuffle
import time
from Users import myUsers2, myUsers

users = myUsers.MyUsers("My Users")
users2 = myUsers2.MyUsers2("My Users2")


#from Users.Run2 import Run2
#users3 = Run2.MyUsers3("My Users3")
#All = users3.All

from Users.Run2 import NameGennedOld
users3 = NameGennedOld.NameGennedOld("My Users3")
All = users3.All

while True:
    shuffle(All)
    try:
        #stat = random.randint(1,100)
        #print("Stat:",stat)
        bot = users3.Downvotes_Slut
        for subm in bot.subreddit("All").new():
            #a = random.randint(1,100)
            #if a== stat:
            print("BINGO!")
            b = All[random.randint(0,All.__len__()-1)]
            print("Honours go to ", b.user.me().name)
            sub = b.submission(subm.id)
            sub.crosspost(subreddit="stonesoft")
            #else:
            #    for b in All:
            #        print("Upvoting with: ",b.user.me().name)
            list(b.subreddit("stonesoft").new(limit=2))[1].reply(list(b.subreddit("AskOuija").new(limit=1))[0].title)
            time.sleep(5)
    except Exception as e:
        print("Fuck.", e)
        time.sleep(15)