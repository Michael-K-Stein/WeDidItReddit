import time
import praw
import myUsers
users = myUsers.MyUsers("My Users")

def upvoteComment(com):
    for bot in users.Bots:
        print("Currently logged in as '", bot.user.me(), "'")
        bot.comment(com).upvote()
def downvoteComment(com):
    for bot in users.Bots:
        print("Currently logged in as '", bot.user.me(), "'")
        bot.comment(com).downvote()
def downvotePost(p):
    for bot in users.Bots:
        print("Currently logged in as '", bot.user.me(), "'")
        bot.submission(p).downvote()


while True:
    try:
        newComs = users.LordPhantom_Bot.redditor("BeSiyata_DiShmaya").comments.new(limit=3)
        for com in newComs:
            upvoteComment(com)
        downvoteComment(list(users.LordPhantom_Bot.redditor("Downvotes_Slut").comments.new(limit=1))[0])
        downvotePost(list(users.LordPhantom_Bot.redditor("Downvotes_Slut").submissions.new(limit=1))[0])
    except:
        print("Shit.")
