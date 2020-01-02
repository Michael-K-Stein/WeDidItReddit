#from Users import myUsers
#from Users import LordPhantom_Bots1
import random
from random import shuffle
import time
import praw

f = open(r"C:\Users\stein\Desktop\genericPassword.txt", "r")
f2 = open(r"C:\Users\stein\Desktop\nongenericPassword.txt", "r")
genericPassword =f.read()
nongenericPassword =f2.read()
f.close()
f2.close()


#users = myUsers.MyUsers("users")

abc = "abcdefghijklmnopqrstuvwxyz" + "aaaeeeiiiooouuu" + "ffggsstt"
lets = """SomebodyoncetoldmetheworldisgonnarollmeIaintthesharpesttoolintheshedShewaslookingkindofdumbwithherfingerandherthumbIntheshapeofanLonherforeheadWelltheyearsstartcomingandtheydontstopcomingFedtotherulesandIhitthegroundrunningDidntmakesensenottoliveforfunYourbraingetssmartbutyourheadgetsdumbSomuchtodosomuchtoseeSowhatswrongwithtakingthebackstreetsYoullneverknowifyoudontgoYoullnevershineifyoudontglowHeynowyoureanallstargetyourgameongoplayHeynowyourearockstargettheshowongetpaidAndallthatglittersisgoldOnlyshootingstarsbreakthemoldItsacoolplaceandtheysayitgetscolderYourebundledupnowwaittillyougetolderButthemeteormenbegtodifferJudgingbytheholeinthesatellitepictureTheiceweskateisgettingprettythinThewatersgettingwarmsoyoumightaswellswimMyworldsonfirehowaboutyoursThatsthewayIlikeitandInevergetboredHeynowyoureanallstargetyourgameongoplayHeynowyourearockstargettheshowongetpaidAllthatglittersisgoldOnlyshootingstarsbreakthemoldHeynowyoureanallstargetyourgameongoplayHeynowyourearockstargettheshowongetpaidAndallthatglittersisgoldOnlyshootingstarsSomebodyonceaskedcouldIsparesomechangeforgasIneedtogetmyselfawayfromthisplaceIsaidyepwhataconceptIcouldusealittlefuelmyselfAndwecouldallusealittlechangeWelltheyearsstartcomingandtheydontstopcomingFedtotherulesandIhitthegroundrunningDidntmakesensenottoliveforfunYourbraingetssmartbutyourheadgetsdumbSomuchtodosomuchtoseeSowhatswrongwithtakingthebackstreetsYoullneverknowifyoudontgogoYoullnevershineifyoudontglowHeynowyoureanallstargetyourgameongoplayHeynowyourearockstargettheshowongetpaidAndallthatglittersisgoldOnlyshootingstarsbreakthemoldAndallthatglittersisgoldOnlyshootingstarsbreakthemold""".upper()[::-1]
ABC = list(abc.upper())

# Hym1djLG_VMOGOGO2R4lq444nkU
# DJ68z5_HCD_vTw

BeingHeldAgainstWill = praw.Reddit(client_id='DJ68z5_HCD_vTw',
                         client_secret='Hym1djLG_VMOGOGO2R4lq444nkU',
                         user_agent='BeingHeldAgainstWill',
                         username='BeingHeldAgainstWill',
                         password=nongenericPassword)
WishIWasNotDepressed = praw.Reddit(client_id='RuMVK50LGdFxBQ',
                         client_secret='lvOae9gAjOL-mNvj_o-P90GLRv4',
                         user_agent='WishIWasNotDepressed',
                         username='WishIWasNotDepressed',
                         password=genericPassword)
WhereIsMyWill2Live = praw.Reddit(client_id='RuMVK50LGdFxBQ',
                         client_secret='lvOae9gAjOL-mNvj_o-P90GLRv4',
                         user_agent='WhereIsMyWill2Live',
                         username='WhereIsMyWill2Live',
                         password=genericPassword)

bot = WhereIsMyWill2Live

askOuija = bot.subreddit("AskOuija")

def upVote(comID):
    WishIWasNotDepressed.comment(comID).upvote()
    WhereIsMyWill2Live.comment(comID).upvote()

#all_users = users.All
ind = 2
while True:
    for pst in askOuija.stream.submissions():
        print(pst, ind, lets[ind])
        pst.reply(lets[ind])
        ind+=1