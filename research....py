import operator
from Users import myUsers

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

#All = (bot.subreddit("All").comments(limit=None))
#All = (bot.subreddit("All").comments.)
#Israel = (bot.subreddit("Israel").comments(limit=None))
#ani_bm = (bot.subreddit("ani_bm").comments(limit=None))# + bot.subreddit("Israel").comments(limit=None)

def readWordsFile():
    f = open("Words", "r+", encoding="utf-8")
    fr = f.read()
    f.close()
    return fr

def writeWordsFile(wrds):
    st = ""
    for ob in wrds:
        st += ob + " " + str(wrds[ob]) + "\n"
    f = open("Words", "w+", encoding="utf-8")
    f.write(st)
    f.close()

def writeWordsFileH(wrds):
    st = ""
    for ob in wrds:
        st += ob + " " + str(wrds[ob]) + "\n"
    f = open("WordsH", "w+", encoding="utf-8")
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
for com in bot.subreddit("All").stream.comments():
    print(i, com.body)
    cb = com.body.replace(".","").replace("?","").replace("!","").replace(",","").replace("-","").replace("*","").replace(chr(34),"").replace("”","").replace("“","").replace("'","").replace("[","").replace("]","").replace("(","").replace(")","").replace("’","").replace("\u0103","").replace("×","").replace("’","")
    for ca in cb.split():
        c = ca.lower()
        with open("Words", "r+") as fd:
            for line in fd:
                dict[line.split()[0]] = line.split()[1]
        i+=1
        #print(c)
        if isAscii(c):
            if c in dict:
                dict[c] = int(dict[c]) + 1
            else:
                dict[c] = 1
        else:
            if c in dict:
                dict[c] = int(dict[c]) + 1
            else:
                dict[c] = 1
        try:
            writeWordsFile(dict)
        except Exception as e:
            print("Debug: Shit", c, e)
        #writeWordsFileH(dictH)
    if i > 100000:
        break

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