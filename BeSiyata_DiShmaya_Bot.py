bsd = "בס ד".replace(" ", chr(34))

import time
import praw
import myUsers
users = myUsers.MyUsers("My Users")

basad = users.BeSiyata_DiShmaya

anibm = basad.subreddit("ani_bm")

lastPost = "albf10"
while True:
    post = list(anibm.new(limit=1))[0]
    if post != lastPost:
        print(post, post.title)
        lastPost = post
        f = open("RepliedToShit.txt","a+")
        if not post.id in f.read():
            post.reply(bsd)
            f.write(post.id + ",\n")
        f.close()
        post.upvote()
    time.sleep(10)