cases = int(input())
for i in range(cases):
    arithmetic = True
    count, *arr = [int(x) for x in input().split()]
    previousDiff = arr[0] - arr[1]
    for j in range(2, len(arr)):
        currentDiff = arr[j - 1] - arr[j]
        if(previousDiff != currentDiff):
           arithmetic = False
        previousDiff = currentDiff
    if arithmetic:
        print("arithmetic")
    else:
        arithmetic = True
        arr = sorted(arr)
        previousDiff = arr[0] - arr[1]
        for j in range(2, len(arr)):
            currentDiff = arr[j - 1] - arr[j]
            if(previousDiff != currentDiff):
                arithmetic = False
        if arithmetic:
            print("permuted arithmetic")
        else:
            print("non-arithmetic")


