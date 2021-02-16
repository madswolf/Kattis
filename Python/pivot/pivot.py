n = int(input())
arr = [int(x) for x in input().split()]
minArr = [None] * len(arr)
maxArr = [None] * len(arr)

minimum = float('inf') 
for i in reversed(range(len(arr))):
    if minimum > arr[i]:
        minimum = arr[i]
    minArr[i] = minimum

maximum = float('-inf') 
for i in range(len(arr)):
    if maximum < arr[i]:
        maximum = arr[i]
    maxArr[i] = maximum

count = 0
for i in range(len(arr)):
    if arr[i] == minArr[i] and arr[i] == maxArr[i]:
        count += 1

print(count)