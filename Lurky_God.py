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
ziun = "זיון"
homo = "הומו"
koksinel = "קוקסינל"
mehazek = "מחזק"
zayen_oti_abush = "זיין אותי אבוש"
big_oof = "אוף גדול"
bigger_oof = "אוף גדול יותר"
ze_mah_shehakadosh_razah = "זה מה שהקדוש ברוחו רצה"
hesber = "הסבר"
ad_120_shanah = "עד 120 שנה"
cake_day = "יום עוגה"
happy_cake_day = "יום עוגה שמח!"
todah = "תודה"
bevakasha = "בבקשה"
halo_davar = "הלא דבר"
met = " מת "
yes = "כן"
no = "לא"
no_u = "לא אתה"
only_u = "רק אתה, נשמה"
harag = "הרג "
laaz = "לעז?!? האם התכוונת: "
zal = "ז ל".replace(" ", chr(34))

def isAscii(st):
    try:
        st.encode('ascii')
        return True
    except:
        return False

def upvoteComment(com):
    if com.author.name != "Guy2933":
        print("Upvoting " + com.id, "By " + com.author)
        for bot in users.Bots:
            #print("Currently logged in as '", bot.user.me(), "'")
            bot.comment(com).upvote()
    else:
        repl(com, "די.")
def downvoteComment(com):
    print("Downvoting " + com.id, "By " + com.author)
    for bot in users.Bots:
        #print("Currently logged in as '", bot.user.me(), "' and going to downvote: ", com.body)
        bot.comment(com).downvote()

import praw
import datetime
from praw.models import Comment
import myUsers
users = myUsers.MyUsers("My Users")
import time
from googletrans import Translator

def repl(c, re):
    f = open("RepliedToShit.txt", "a+")
    if c.author.name != "BeSiyata_DiShmaya" and (time.time() - c.created_utc) < 300 and not c.id in f.read():
        if c.author.name != "Guy2933":
            print("Replying " + re + " to " + c.id)
            c.reply(re)
            f.write(c.id + ",\n")
            f.close()
        else:
            c.reply(die + " Guy2933")
            f.write(c.id + ",\n")
            f.close()

while True:
    for c in users.BeSiyata_DiShmaya.subreddit("ani_bm").stream.comments():
        if (time.time() - c.created_utc) < 300:
            print(int(time.time() - c.created_utc),c.id, c.author, c.body)
            try:
                if isAscii(c.body) and c.body != "?" and not "r/" in c.body and not "http" in c.body:
                    downvoteComment(c)
                    trans = Translator()
                    repl(c, laaz + trans.translate(c.body, dest="he").text)
                elif cus in c.body or zona in c.body or zain in c.body or homo in c.body or koksinel in c.body or ziun in c.body:
                    repl(c, zayen_oti_abush)
                elif big_oof in c.body:
                    repl(c, bigger_oof)
                elif hesber in c.body:
                    repl(c, ze_mah_shehakadosh_razah)
                elif cake_day in c.body:
                    upvoteComment(c)
                    repl(c, ad_120_shanah)
                elif todah in c.body:
                    upvoteComment(c)
                    repl(c, halo_davar)
                elif bevakasha in c.body:
                    upvoteComment(c)
                elif met in c.body or harag in c.body:
                    repl(c, zal)
                elif c.body[0:6] == no_u:
                    repl(c, only_u)
                #elif no in c.body:
                #    repl(c, yes)
                #elif yes in c.body:
                #    repl(c, no)
                elif bsd in c.body:
                    upvoteComment(c)
                    repl(c, bsd)
                elif bsd2 in c.body:
                    upvoteComment(c)
                    repl(c, bsd)
                elif datetime.datetime.fromtimestamp(int(c.author.created_utc)).strftime('%d/%m') == time.strftime('%d/%m'):
                    upvoteComment(c)
                    repl(c,happy_cake_day)
            except:
                time.sleep(5)