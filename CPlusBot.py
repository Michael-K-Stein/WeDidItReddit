from Users import myUsers

users = myUsers.MyUsers("users")


bot = users.CPlusBot

sub = bot.subreddit("MrSmithMemes")

for subm in sub.stream.submissions():
    try:
        print(subm.id, subm.author)
        subm.reply("6.5/10 memes. C+")
        subm.upvote()
    except:
        print("Bot failed.")