import time
import praw
import operator
import myUsers
users = myUsers.MyUsers("My Users")

def isAscii(st):
    try:
        st.encode('ascii')
        return True
    except:
        return False

bot = users.LordPhantom_Bot

dict = {}
dictH = {}

i = 0
for com in bot.subreddit("Israel").comments(limit=None):
    cb = com.body.replace(".","").replace("?","").replace("!","").replace(",","").replace("-","").replace("*","").replace(chr(34),"").replace("”","").replace("“","").replace("'","").replace("[","").replace("]","").replace("(","").replace(")","").replace("’","")
    for c in cb.split():
        i+=1
        print(c)
        if isAscii(c):
            if c in dict:
                dict[c] = int(dict[c]) + 1
            else:
                dict[c] = 1
        else:
            if c in dictH:
                dictH[c] = int(dictH[c]) + 1
            else:
                dictH[c] = 1

print("=================================")
print("+++++++++++++++++++++++++++++++++")
print("=================================")
print(i)
print("+++++++++++++++++++++++++++++++++")

print(dict)

sorted_x = sorted(dict.items(), key=operator.itemgetter(1))
sorted_y = sorted(dictH.items(), key=operator.itemgetter(1))

print(sorted_x)
print(sorted_y)

f = open("RepliedToShit.txt", "w+")
f.write(sorted_x)
f.write(sorted_y)