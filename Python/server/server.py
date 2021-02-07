n, T = [int (x) for x in input().split()]

tasks = [int (x) for x in input().split()]

numTasks = 0
currTime = 0

for task in tasks:
    currTime += task
    if(currTime > T):
        break
    numTasks += 1

print(numTasks)