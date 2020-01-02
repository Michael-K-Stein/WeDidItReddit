import praw

f = open(r"C:\Users\stein\Desktop\genericPassword.txt", "r")
genericPassword = f.read()
f.close()


class NameGennedOld:
    __client_id = "YWG8eYJsvtTuFg"
    __client_secret = "tUuRNUirGe7DkD2uBXO2CzDorZM"

    def __init__(self, name):
        self.name = name

    _0ath_ologic = praw.Reddit(client_id='xLbWOPKmiYaDXA',
                                   client_secret='t7a42xFmvo3xqqEgeTvNwkOXJ8Y',
                                   user_agent='0ath_ologic',
                                   username='0ath_ologic',
                                   password=genericPassword)

    _rk_310 = praw.Reddit(client_id='sJux3s-dj7untA',
                          client_secret='rfS9g0jhxmfQ0y6TxHM6ih63cOs',
                          user_agent='rk_310',
                          username='rk_310',
                          password=genericPassword)

    LordPhantom_Bot6 = praw.Reddit(client_id='R31KJ_z05CVLog',
                                   client_secret='RP6CBl2nJub3YNmRGha5sn50vc4',
                                   user_agent='LordPhantom_Bot6',
                                   username='LordPhantom_Bot6',
                                   password=genericPassword)

    Downvotes_Slut = praw.Reddit(client_id='2qA2B7MXNavqjw',
                         client_secret='BonuPLResl8KMjUuDzk_1qsjsGI',
                         user_agent='Downvotes_Slut',
                         username='Downvotes_Slut',
                         password=genericPassword)
    _BornToNeverDie = praw.Reddit(client_id='41d8Pe9roomNFA',
                         client_secret='wMcHVyFWg0w5Z10z6cXbCNz-Exg',
                         user_agent='BornToNeverDie',
                         username='BornToNeverDie',
                         password=genericPassword)


    All = [_0ath_ologic, _rk_310, LordPhantom_Bot6, Downvotes_Slut, _BornToNeverDie]
    ###


print("NameGennedOld: \t\t", NameGennedOld.All.__len__())