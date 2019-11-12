import math
n = int(input())
eulernumber = 0
for i in range(min(n + 1,20)):
    eulernumber += 1 / math.factorial(i)
print(eulernumber)