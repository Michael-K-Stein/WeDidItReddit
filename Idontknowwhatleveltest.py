import operator
import time

from Users.myUsers import MyUsers
users = MyUsers("users")
_all = [users.CaptainLordPhantom] + users.All

tot = 0

dic = {}

print("Tot: ",_all.__len__())
bot = users.CaptainLordPhantom

def exists(userName):
    try:
        a = bot.redditor(userName).trophies()
        return True
    except:
        return False

print(exists("rapmachine4odiggidy"))

for usr in _all:
    try:
        #usr.subreddit("stonesoft").subscribe()
        #usr.subreddit("HaKfarHaYarok").subscribe()
        #ban = any(usr.subreddit('stonesoft').banned(redditor=usr.user.me().name))
        totK = usr.user.me().comment_karma + usr.user.me().link_karma
        dic[usr.user.me().name] = totK
        print(usr.user.me().name + "\t" + str(totK) + "\t" + str(usr.user.me().created_utc) + "\t" + str(
            usr.config.client_id) + "\t" + str(usr.user.me().comment_karma) + "\t" + str(
            usr.user.me().link_karma) + "\t" + str(exists(usr.user.me().name)))

        tot += totK
    except Exception as e:
        #totK = usr.user.me().comment_karma + usr.user.me().link_karma
        #dic[usr.user.me().name] = totK
        #print(usr.user.me().name + "\t" + str(totK) + "\t" + str(usr.user.me().created_utc) + "\t" + str(usr.config.client_id) + "\t" + str(usr.user.me().comment_karma) + "\t" + str(usr.user.me().link_karma) + "\t" + "True")
        #tot+=totK
        print(e)
        #print(usr.user.me())
        #time.sleep(10)
        #totK = usr.user.me().comment_karma + usr.user.me().link_karma
        #dic[usr.user.me().name] = totK
        #print(usr.user.me().name, totK)
        #tot += totK
print(tot)

sorted_x = sorted(dic.items(), key=operator.itemgetter(1))

print(sorted_x)