arr = [1,2,3,4,5,6,7,8,9]
tmp = arr[-1]
tmp2 = tmp

for i in range(0,arr.__len__()):
    tmp = arr[(i-1) % arr.__len__()]
    arr[(i-1) % arr.__len__()] = tmp2
    tmp2 = tmp

arr[arr.__len__()-1] = tmp2

print(arr)