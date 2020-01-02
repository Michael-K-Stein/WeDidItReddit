from praw.models import Comment
from praw.models import Submission

from Users import myUsers

users = myUsers.MyUsers("My Users")

def upvote(obj, Users):
    for bot in Users:
        if isinstance(obj, Comment):
            print("Upvoting " + obj.id, "With " + bot.user.me().name)
            bot.comment(obj.id).upvote()
        elif isinstance(obj, Submission):
            print("Upvoting " + obj.id, "With " + bot.user.me().name)
            bot.submission(obj.id).upvote()

for bot in users.All:
    print("Upvoting with " + bot.user.me().name)
    list(bot.redditor("BeSiyata_DiShmaya").comments.new(limit=2))[1].upvote()

#for post in users.LordPhantom_Bot.subreddit("LordPhantomBotTesting").new(limit=None):
#    for bot in users.All:
#        bot.submission(post.id).reply("Fuck me daddy pls!")
#        bot.submission(post.id).upvote()
#        for com in bot.submission(post.id).comments:
#            com.upvote()
#            com.reply("Fuck me daddy pls!")
