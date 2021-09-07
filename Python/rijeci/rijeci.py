n = int(input())

aCount = 1
bCount = 0
for _ in range(n):
    bCount = aCount + bCount
    aCount = bCount - aCount
print(aCount,bCount)