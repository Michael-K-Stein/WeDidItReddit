import praw
from Users.Run2.Run2 import MyUsers3

myUsers = MyUsers3.All

f = open(r"C:\Users\stein\Desktop\genericPassword.txt", "r")
f2 = open(r"C:\Users\stein\Desktop\nongenericPassword.txt", "r")
genericPassword =f.read()
nongenericPassword =f2.read()
f.close()
f2.close()


STFU_SFTU_KARMA_BOT = praw.Reddit(client_id='GQ1cExQklKP11g',
                                  client_secret='4fA8ep9pWqfp7H4VRAtWV8B6OFk',
                                  user_agent='STFU_SFTU_KARMA_BOT',
                                  username='STFU_SFTU_KARMA_BOT',
                                  password=genericPassword)

bot=STFU_SFTU_KARMA_BOT

def FuckThisBitch(comID):
    bot.comment(comID).downvote()
    bot.comment(comID).reply("Fuck off you shitty bot")

print(bot.user.me().name)

while True:
    for com in bot.redditor("STFU_U_KARMA_BOT").comments.top():
        FuckThisBitch(com.id)