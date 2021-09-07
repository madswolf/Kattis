n = int(input())
pairs = []
for _ in range(n):
    a,b = [int(x) for x in input().split()]
    pairs.append((a,b))
pairs.sort(key = lambda x: -x[1])


currentTime = -1
count = 0
while pairs:
    if pairs[-1][0] >= currentTime:
        count += 1
        currentTime = pairs[-1][1]
    pairs.pop()
print(count)