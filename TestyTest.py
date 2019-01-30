bsd = "בס ד".replace(" ", chr(34))
bsd2 = "בס״ד"
bot_tov = "בוט טוב"
robot_tov = "רובוט טוב"
toda_capara = "תודה כפרה"
die = "די"
dieeee = "דייי"
lo = "לא."
mamash_lo = "ממש לא."
cus = "כוס"
zona = "זונה"
zain = "זין"
mehazek = "מחזק"
zayen_oti_abush = "זיין אותי אבוש"
big_oof = "אוף גדול"
bigger_oof = "אוף גדול יותר"
ze_mah_shehakadosh_razah = "זה מה שהקדוש ברוחו רצה"
hesber = "הסבר"
ad_120_shanah = "עד 120 שנה"
cake_day = "יום עוגה"
todah = "תודה"
halo_davar = "הלא דבר"
upvotes = "הצבעות מעלה"
upvotes2 = "הצבעות עילי"
from_father = "מאבא שבשמים"

import praw
from praw.models import Comment
import myUsers
import time

users = myUsers.MyUsers("My Users")
while True:
    cR = users.BeSiyata_DiShmaya.inbox.unread()
    for cr in cR:
        f = open("RepliedToShit.txt","a+")
        if isinstance(cr, Comment) and not cr.id in f.read():
            if cr.body == bot_tov or cr.body == robot_tov or cr.body == mehazek:
                cr.reply(toda_capara)
                cr.upvote()
            elif cr.body[0:2] == die:
                if cr.body[0:4] == dieeee:
                    cr.reply(mamash_lo)
                else:
                    cr.reply(lo)
            elif upvotes in cr.body or upvotes2 in cr.body:
                cr.reply(from_father)
            #else:
            #    cr.reply(bsd)
            cr.mark_read()
            f.write(cr.id + ",\n")
            f.close()
            print(cr.body)
    time.sleep(5)

#for user in users.All:
#    print("Currently logged in as '", user.user.me(), "'")

#    for c in user.subreddit("All").stream.comments():
#        print(c.body)

    #anibm = user.subreddit("stonesoft")

    #anibm.subscribe()

    #post = list(anibm.new(limit=1))[0]
    #post.upvote()
    #for com in post.comments.list():
    #    com.upvote()
    #post.reply("All hail our lord and savior " + post.author.name)


    #stonesoft = user.subreddit("stonesoft")
    #stonesoft.subscribe()
    #GenericPostsW = stonesoft.new()

    #GenericPosts = []
    #for post in GenericPostsW:
    #    GenericPosts.append(post)

    #GenericPost1 = GenericPosts[1]
    #GenericPost1.upvote()
    #for comment in GenericPost1.comments.list():
    #    comment.upvote()
    #GenericPost1.reply("Reply Reply Reply")