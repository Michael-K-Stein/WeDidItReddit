import praw

f = open(r"C:\Users\stein\Desktop\genericPassword.txt", "r")
f2 = open(r"C:\Users\stein\Desktop\nongenericPassword.txt", "r")
genericPassword =f.read()
nongenericPassword =f2.read()
f.close()
f2.close()

class MyUsers4:
    __client_id = "RuMVK50LGdFxBQ"
    __client_secret = "lvOae9gAjOL-mNvj_o-P90GLRv4"

    def __init__(self, name):
        self.name = name

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
    STFU_SFTU_KARMA_BOT = praw.Reddit(client_id='RuMVK50LGdFxBQ',
                             client_secret='lvOae9gAjOL-mNvj_o-P90GLRv4',
                             user_agent='STFU_SFTU_KARMA_BOT',
                             username='STFU_SFTU_KARMA_BOT',
                             password=genericPassword)


    All = [WishIWasNotDepressed, STFU_SFTU_KARMA_BOT]
    ###


print("MyUsers4: \t\t", MyUsers4.All.__len__())