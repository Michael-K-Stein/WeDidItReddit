import praw

f = open(r"C:\Users\stein\Desktop\genericPassword.txt", "r")
genericPassword = f.read()
f.close()


class NameGenned13:
    __client_id = "NQL6T7E-a5iLLQ"
    __client_secret = "9LJ5V-F8hIkzizEt31b56qekMgU"

    def __init__(self, name):
        self.name = name

    _Fridoli6ounet = praw.Reddit(client_id=__client_id,
                                 client_secret=__client_secret,
                                 user_agent='Fridoli6ounet',
                                 username='Fridoli6ounet',
                                 password=genericPassword)

    ### Definitions
    All = [_Fridoli6ounet]
    ###


print("NameGenned13: \t\t", NameGenned13.All.__len__())