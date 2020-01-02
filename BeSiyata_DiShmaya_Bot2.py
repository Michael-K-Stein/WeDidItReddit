bsd = "בס ד".replace(" ", chr(34))

import time
from Users import myUsers

users = myUsers.MyUsers("My Users")

#basad = users.BeSiyata_DiShmaya
from Users.Run2.NameGennedOld import NameGennedOld
basad = NameGennedOld._0ath_ologic

#anibm = basad.subreddit("ani_bm")
anibm = basad.subreddit("ich_iel")

lastPost = "albf10"
lastTimeCheck = 0
while True:
    post = list(anibm.new(limit=1))[0]
    if post != lastPost:

        print(post, post.title)
        lastPost = post
        frr = open("RepliedToShit.txt","r")
        fr = frr.read()
        frr.close()
        f = open("RepliedToShit.txt","a+")
        if not post.id in fr:
            post.reply(bsd)
            f.write(post.id + ",\n")
        f.close()
        post.upvote()
    time.sleep(10)
    if (time.time() - lastTimeCheck)>3600:
        #basad = users.BeSiyata_DiShmaya
        #anibm = basad.subreddit("ani_bm")
        lastTimeCheck = time.time()