import tweepy
auth = tweepy.OAuthHandler("C3h0wP2YFjSSyXRIHXlZWUfAc", "UNf2AYcxXK7uNEvN2UEKAG34ILFCw8VAQq3t4lzxEsSco3qblH")
auth.set_access_token("1110190088795942912-5AziAyIbYDF7TggXZMwCGmSgjXkHbM", "DC0zyBAIfCeavjkEORNwFljaJ5ne6tsZBrC4VqEO8UbT9")
api = tweepy.API(auth)
print ("Tweet From Public Urinal")
print ("Twitter For........")
tweet = input("What Would You Like To Tweet? ")
api.update_status(status =(tweet))
print ("Done!")