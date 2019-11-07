x = int(input())
for i in range(x):
    counter, previous, *arr = [int(y) for y in input().split()] 
    for y in range(counter-1):
        if(arr[y] == previous + 1):
            previous = arr[y]
            continue
        print(y+2)