from random import shuffle
from Users import myUsers2, myUsers

users = myUsers.MyUsers("users")
users2 = myUsers2.MyUsers2("users2")


bot = users.LordPhantom_Bot

askOuija = bot.subreddit("AskOuija")
bts = users.AskOuija[1:] + users2.All

while True:
    shuffle(bts)
    #bots = [users.CaptainLordPhantom] + bts
    bots = bts

    post = bot.submission(input("Post id: "))
    comment = input("Comment: ").upper()

    if True:#comment.__len__() < users.AskOuija.__len__() + 1:
        i = 0
        for let in comment:
            wrk = 0
            while wrk == 0:
                b = bots[i]
                print(b.user.me().name, let)
                try:
                    if i == 0:
                        b.submission(post).reply(let)
                    else:
                        b.comment(post).reply(let)
                        b.comment(post).upvote()
                    post = list(b.user.me().comments.new(limit=1))[0].id
                    #time.sleep(random.randint(1,5))
                    wrk = 1
                except Exception as e:
                    print("User failure: ", b.user.me().name)
                    i = (i + 1) % bots.__len__()
                    #time.sleep(2)
            #post2 = b.comment(post)
            #for ii in range(0, i):
                #post2.parent().upvote()
            i=(i+1)%bots.__len__()
        ba = 0
        while ba==0:
            try:
                b = bots[i]
                print(b.user.me().name, "Goodbye.")
                b.comment(post).reply("Goodbye.")
                ba=1
            except:
                b = bots[i]
                print("User failure: ", b.user.me().name)
                i=(i+1)%bots.__len__()
    else:
        print("Not enough accounts")
    print("Done.")