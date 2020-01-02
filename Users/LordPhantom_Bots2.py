import praw

f = open(r"C:\Users\stein\Desktop\genericPassword.txt", "r")
genericPassword =f.read()
f.close()

class LordPhantom_Bots2:

    __client_id = "_8c0354RzaWPKg"
    __client_secret = "YoqBcEpRFQdqpr_kK4Ptkq-dxgA"
    def __init__(self, name):
        self.name = name    # instance variable unique to each instance

    LordPhantom_Bot20 = praw.Reddit(client_id=__client_id,
                                client_secret=__client_secret,
                                user_agent='LordPhantom_Bot20',
                                username='LordPhantom_Bot20',
                                password=genericPassword)
    LordPhantom_Bot21 = praw.Reddit(client_id=__client_id,
                                client_secret=__client_secret,
                                user_agent='LordPhantom_Bot21',
                                username='LordPhantom_Bot21',
                                password=genericPassword)
    LordPhantom_Bot22 = praw.Reddit(client_id=__client_id,
                                client_secret=__client_secret,
                                user_agent='LordPhantom_Bot22',
                                username='LordPhantom_Bot22',
                                password=genericPassword)
    LordPhantom_Bot23 = praw.Reddit(client_id=__client_id,
                                client_secret=__client_secret,
                                user_agent='LordPhantom_Bot23',
                                username='LordPhantom_Bot23',
                                password=genericPassword)

    ### Definitions
    All = [LordPhantom_Bot20,LordPhantom_Bot21,LordPhantom_Bot22,LordPhantom_Bot23]

    ###


print("LordPhantom_Bots2: \t", LordPhantom_Bots2.All.__len__())