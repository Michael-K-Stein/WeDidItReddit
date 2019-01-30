import time
import datetime
from googletrans import Translator
import praw
import myUsers
users = myUsers.MyUsers("My Users")

f = open("RepliedToShit.txt", "a+")

f.write("HHHH")
f.close()
# Grab the user account
#bot = users.LordPhantom_Bot
#print(bot.redditor("CaptainLordPhantom").created_utc)
# Grab their created, and make it readable
#cakeday = datetime.datetime.fromtimestamp(int(bot.redditor("CaptainLordPhantom").created_utc)).strftime('%d/%m')

# Print cakeday

#trans = Translator()

#print(trans.translate("fuck you gay heeb", dest="he").text)

#for bot in users.All:
    #print("Currently logged in as '", bot.user.me(), "'")
    #bot.comment("efci2tj").downvote()
    #coms = list( bot.redditor("Guy2933").comments.new(limit=10) )
    #for c in coms:
    #    print(c, c.body)