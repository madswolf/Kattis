input()
arr = [int(s) for s in input().split()]
arr.sort()
arr = arr[::-1]
result = 0
for i in range(2,len(arr))[::3]:
    result += arr[i]
print(result)
