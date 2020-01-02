import operator
from Users import myUsers

users = myUsers.MyUsers("My Users")

#f = open("RepliedToShit.txt", "r")
#fR = f.read()
#f.close()
#print(fR)

# Grab the user account
#bot = users.LordPhantom_Bot
#def downvoteComment(com):
#    #print("Upvoting " + com.id, "By " + com.author.name)
#    for bot in users.Bots[0:5]:
#        #print("Currently logged in as '", bot.user.me(), "' and going to downvote: ", com.body)
#        bot.comment(com).downvote()

#downvoteComment(bot.comment("efffqfd"))

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





#All = (bot.subreddit("All").comments(limit=None))
#All = (bot.subreddit("All").comments.)
#Israel = (bot.subreddit("Israel").comments(limit=None))
#ani_bm = (bot.subreddit("ani_bm").comments(limit=None))# + bot.subreddit("Israel").comments(limit=None)

def isAscii(st):
    try:
        st.encode('ascii')
        return True
    except:
        return False

def readWordsFile():
    f = open("Words", "r+")
    fr = f.read()
    f.close()
    return fr

def writeWordsFile(wrds):
    st = ""
    for ob in wrds:
        st += ob + " " + str(wrds[ob]) + "\n"
    f = open("Words", "w+")
    f.write(st)
    f.close()
#def appendWordsFile(wrds):
#    f = open("Words", "a+")
#    f.write(wrds)
#    f.close()

def get_pair(line):
    key, sep, value = line.strip().partition(" ")
    return int(key), value

i = 0

dict = {}
dictH = {}

f = open("Words", "r")
fl = f.readlines()
for l in fl:
    i+=1
    k = l.split()[0]
    v = int(l.split()[1])
    if isAscii(k):
        dict[k] = v
    else:
        dictH[k] = v

print("=================================")
print("+++++++++++++++++++++++++++++++++")
print("=================================")
print(i)
print("+++++++++++++++++++++++++++++++++")

#print(dict)

sorted_x = sorted(dict.items(), key=operator.itemgetter(1))
sorted_y = sorted(dictH.items(), key=operator.itemgetter(1))

print(sorted_x[::-1])
print(sorted_y[::-1])

#f = open("RepliedToShit.txt", "w+")
#f.write(sorted_x)
#f.write(sorted_y)