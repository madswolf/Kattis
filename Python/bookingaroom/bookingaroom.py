roomCount, bookedCount = [int(y) for y in input().split()] 
arr = [*range(1, roomCount+1)]
for i in range(bookedCount):
    arr.remove(int(input()))
if arr:
    print(arr[0]) 
else:
    print("too late")