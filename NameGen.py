from Users import myUsers
import random

users = myUsers.MyUsers

def hasNumbers(inputString):
    return any(char.isdigit() for char in inputString)

def exists(userName):
    try:
        a = bot.redditor(userName).trophies()
        return True
    except:
        return False

while True:
    bot = users.LordPhantom_Bot
    for subm in bot.subreddit("All").stream.submissions():
        authN = subm.author.name
        if not authN.lower().__contains__("bot") and authN.__len__()<20:
            chars = []
            if hasNumbers(authN):
                for char in authN:
                    if not char.isdigit():
                        chars.append(char)
                    else:
                        chars.append(int(char) + 1)
            else:
                for char in authN:
                    chars.append(char)
                chars[random.randint(0,authN.__len__()-1)] = random.randint(0,9)
            authN2 = ""
            for c in chars:
                authN2 += str(c)
            if not exists(authN2):
                print(authN2)
                f = open(r"C:\Users\stein\source\repos\Reddit\Reddit\bin\Debug\AvaUsernames2.txt", "a+")
                f.write(authN2 + "\n")
                f.close()