dishCount, *arr = [int(s) for s in input().split()]
if sum(arr) <= dishCount * 2:
    print("possible")
else:
    print("impossible")