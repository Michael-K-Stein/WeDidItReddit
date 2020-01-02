import time
import random
import os
from Users import myUsers

users = myUsers.MyUsers("My Users2")
_all = users.All

for file in os.listdir(r"C:\Users\stein\Pictures\PuppiesGallore"):
    fail = 1
    bA = _all[random.randint(0,_all.__len__()-1)]
    while fail == 1:
        try:
            b = _all[random.randint(0,_all.__len__()-1)]
            bA = b
            if list(b.user.me().submissions.new()).__len__() < 1:
                print(b.user.me().name, file.split('.')[0])
                b.subreddit("aww").submit_image(file.split('.')[0],r"C:\Users\stein\Pictures\PuppiesGallore//" + file)
                time.sleep(60)
                fail = 0
        except Exception as e:
            print("Failed", e, bA.user.me())
            time.sleep(10)