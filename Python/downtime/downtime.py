from collections import deque
from math import ceil
n,k = [int(x) for x in input().split()]

queue = deque()
maxServers = 1
for i in range(n):
    x = int(input())
    while(queue):
        if(abs(queue[0] - x) >= 1000):
            queue.popleft()
        else:
            break

    queue.append(x)
    needed = ceil(len(queue)/k)
    if needed > maxServers:
        maxServers = needed
print(maxServers)