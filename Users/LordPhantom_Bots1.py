import praw

f = open(r"C:\Users\stein\Desktop\genericPassword.txt", "r")
genericPassword =f.read()
f.close()

class LordPhantom_Bots1:

    __client_id = "R31KJ_z05CVLog"
    __client_secret = "RP6CBl2nJub3YNmRGha5sn50vc4"
    def __init__(self, name):
        self.name = name    # instance variable unique to each instance

    LordPhantom_Bot = praw.Reddit(client_id=__client_id,
                                  client_secret=__client_secret,
                                  user_agent='LordPhantom_Bot',
                                  username='LordPhantom_Bot',
                                  password=genericPassword)
    LordPhantom_Bot1 = praw.Reddit(client_id=__client_id,
                                   client_secret=__client_secret,
                                   user_agent='LordPhantom_Bot1',
                                   username='LordPhantom_Bot1',
                                   password=genericPassword)
    LordPhantom_Bot2 = praw.Reddit(client_id=__client_id,
                                   client_secret=__client_secret,
                                   user_agent='LordPhantom_Bot2',
                                   username='LordPhantom_Bot2',
                                   password=genericPassword)
    LordPhantom_Bot3 = praw.Reddit(client_id=__client_id,
                                   client_secret=__client_secret,
                                   user_agent='LordPhantom_Bot3',
                                   username='LordPhantom_Bot3',
                                   password=genericPassword)
    LordPhantom_Bot4 = praw.Reddit(client_id=__client_id,
                                   client_secret=__client_secret,
                                   user_agent='LordPhantom_Bot4',
                                   username='LordPhantom_Bot4',
                                   password=genericPassword)
    LordPhantom_Bot5 = praw.Reddit(client_id=__client_id,
                                   client_secret=__client_secret,
                                   user_agent='LordPhantom_Bot5',
                                   username='LordPhantom_Bot5',
                                   password=genericPassword)
    LordPhantom_Bot6 = praw.Reddit(client_id=__client_id,
                                   client_secret=__client_secret,
                                   user_agent='LordPhantom_Bot6',
                                   username='LordPhantom_Bot6',
                                   password=genericPassword)
    LordPhantom_Bot7 = praw.Reddit(client_id=__client_id,
                                   client_secret=__client_secret,
                                   user_agent='LordPhantom_Bot7',
                                   username='LordPhantom_Bot7',
                                   password=genericPassword)
    LordPhantom_Bot8 = praw.Reddit(client_id=__client_id,
                                   client_secret=__client_secret,
                                   user_agent='LordPhantom_Bot8',
                                   username='LordPhantom_Bot8',
                                   password=genericPassword)
    LordPhantom_Bot9 = praw.Reddit(client_id=__client_id,
                                   client_secret=__client_secret,
                                   user_agent='LordPhantom_Bot9',
                                   username='LordPhantom_Bot9',
                                   password=genericPassword)
    LordPhantom_Bot10 = praw.Reddit(client_id=__client_id,
                                    client_secret=__client_secret,
                                    user_agent='LordPhantom_Bot10',
                                    username='LordPhantom_Bot10',
                                    password=genericPassword)
    LordPhantom_Bot11 = praw.Reddit(client_id=__client_id,
                                    client_secret=__client_secret,
                                    user_agent='LordPhantom_Bot11',
                                    username='LordPhantom_Bot11',
                                    password=genericPassword)
    LordPhantom_Bot12 = praw.Reddit(client_id=__client_id,
                                    client_secret=__client_secret,
                                    user_agent='LordPhantom_Bot12',
                                    username='LordPhantom_Bot12',
                                    password=genericPassword)
    LordPhantom_Bot13 = praw.Reddit(client_id=__client_id,
                                    client_secret=__client_secret,
                                    user_agent='LordPhantom_Bot13',
                                    username='LordPhantom_Bot13',
                                    password=genericPassword)
    LordPhantom_Bot14 = praw.Reddit(client_id=__client_id,
                                    client_secret=__client_secret,
                                    user_agent='LordPhantom_Bot14',
                                    username='LordPhantom_Bot14',
                                    password=genericPassword)
    LordPhantom_Bot15 = praw.Reddit(client_id=__client_id,
                                    client_secret=__client_secret,
                                    user_agent='LordPhantom_Bot15',
                                    username='LordPhantom_Bot15',
                                    password=genericPassword)
    LordPhantom_Bot16 = praw.Reddit(client_id=__client_id,
                                    client_secret=__client_secret,
                                    user_agent='LordPhantom_Bot16',
                                    username='LordPhantom_Bot16',
                                    password=genericPassword)
    LordPhantom_Bot17 = praw.Reddit(client_id=__client_id,
                                    client_secret=__client_secret,
                                    user_agent='LordPhantom_Bot17',
                                    username='LordPhantom_Bot17',
                                    password=genericPassword)
    LordPhantom_Bot18 = praw.Reddit(client_id=__client_id,
                                    client_secret=__client_secret,
                                    user_agent='LordPhantom_Bot18',
                                    username='LordPhantom_Bot18',
                                    password=genericPassword)
    LordPhantom_Bot19 = praw.Reddit(client_id=__client_id,
                                    client_secret=__client_secret,
                                    user_agent='LordPhantom_Bot19',
                                    username='LordPhantom_Bot19',
                                    password=genericPassword)
    ### Definitions
    All = [LordPhantom_Bot, LordPhantom_Bot1, LordPhantom_Bot2, LordPhantom_Bot3, LordPhantom_Bot4, LordPhantom_Bot5,
            LordPhantom_Bot6, LordPhantom_Bot7, LordPhantom_Bot8, LordPhantom_Bot9, LordPhantom_Bot10,
            LordPhantom_Bot11, LordPhantom_Bot12, LordPhantom_Bot13, LordPhantom_Bot14, LordPhantom_Bot15,
            LordPhantom_Bot16, LordPhantom_Bot17, LordPhantom_Bot18, LordPhantom_Bot19]

    ###


print("LordPhantom_Bots1: \t", LordPhantom_Bots1.All.__len__())