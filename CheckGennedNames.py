from Users import myUsers

users = myUsers.MyUsers

bot = users.DonutEarthTheorist

def exists(userName):
    try:
        a = bot.redditor(userName).trophies()
        return True
    except:
        return False

f = open(r"C:\Users\stein\source\repos\Reddit\Reddit\bin\Debug\UserTake.txt", "r+")
fr = f.read()
f.close()

for usrr in fr.split():
    usr = usrr.replace(",","")
    usrE = exists(usr)
    print(usr, usrE)
    if usrE:
        f2 = open(r"C:\Users\stein\source\repos\Reddit\Reddit\bin\Debug\ActTake.txt", "a+")
        f2.write(usrr + "\n")
        f2.close()
    else:
        f3 = open(r"C:\Users\stein\source\repos\Reddit\Reddit\bin\Debug\ActN.txt", "a+")
        f3.write(usrr + "\n")
        f3.close()
print("Done.")