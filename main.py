from Users import myUsers2, myUsers

users = myUsers.MyUsers("My Users")
users2 = myUsers2.MyUsers2("My Users2")

def upvoteComment(com):
    for bot in users.Bots:
        if com.score < 4:
            print("Currently logged in as '", bot.user.me(), "'")
            bot.comment(com.id).upvote()
        else:
            break
def downvoteComment(com):
    for bot in users.Bots:
        print("Currently logged in as '", bot.user.me(), "'")
        bot.comment(com).downvote()
def downvotePost(p):
    for bot in users.Bots:
        print("Currently logged in as '", bot.user.me(), "'")
        bot.submission(p).downvote()

print(users.LordPhantom_Bot.subreddit("stonesoft"))

_all = users.All + users2.All

for bot in _all[8:]:
    try:
        print("Posting with '", bot.user.me(), "'")
        bot.subreddit("stonesoft").submit("Hi! I am " + bot.user.me().name + " !", selftext="")
    except:
        print("Failed to post with ", bot.user.me())
    #print("Subscribing to STONESOFT with",bot.user.me().name)
    #bot.subreddit("stonesoft").subscribe()


#for bot in users.All:
#    print("Subscribing with '", bot.user.me().name, "'")
#    bot.subreddit("MrSmithMemes").subscribe()

#while True:
#    try:
#        newComs = users.LordPhantom_Bot.redditor("CPlusBot").comments.new(limit=10)
#        for com in newComs:
#            upvoteComment(com)
        #downvoteComment(list(users.LordPhantom_Bot.redditor("Downvotes_Slut").comments.new(limit=1))[0])
        #downvotePost(list(users.LordPhantom_Bot.redditor("Downvotes_Slut").submissions.new(limit=1))[0])
#    except Exception as e:
#        print("Shit.")
