import praw
from praw import exceptions
from Users import myUsers
from random import shuffle
users = myUsers.MyUsers("My Users")
Bots = users.All
bot = users.LordPhantom_Bot

abc = "abcdefghijklmnopqrstuvwxyz"
ABC = list(abc.upper())

shuffle(ABC)

def exists(userName):
    try:
        a = bot.redditor(userName).trophies()
        return True
    except:
        return False

def user_exists(user):
    exists = True
    try:
        a = 1
        #r.get_redditor(user).fullname
    except praw.exceptions:
        exists = False
    return exists

for let1 in ABC:
    for let2 in ABC:
        for let3 in ABC:
            for let4 in ABC:
                e = exists(let1 + let2 + let3 + let4)
                print(let1 + let2 + let3 + let4, e)
                if not e:
                    f = open("OpenUsernames4", "a+")
                    f.write(let1 + let2 + let3 + let4 + "\n")
                    f.close()

#for com in bot.redditor("BeSiyata_DiShmaya").comments.top(limit=None):
#shift = 5
#for com in bot.redditor("GuyThatKilledHitler").comments.new(limit=None):
#    if com.score < 5:
#        print(com.id, com.score, com.submission.title)
#        i = 0
#        while i < 6 - com.score:
#            b = Bots[(i + shift) % len(Bots)]
#            #   for b in users.All[0:(-1) * com.score + 4]:
#            print("Upvoting com ", com, " with user ", b.user.me().name)
#            try:
#                b.comment(com.id).upvote()
#            except:
#                print("shit.")
#            i+=1
#        shift += 1