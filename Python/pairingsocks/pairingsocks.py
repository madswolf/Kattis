import sys

n = int(input())
socks = [int (x) for x in input().split()][::-1]

aux = []
moves = 0
while(True):
    if(aux and socks):
        if(aux[-1] == socks[-1]):
            aux.pop()
            socks.pop()
        else:
            aux.append(socks.pop())
    elif(socks):       
            aux.append(socks.pop())
    else:
        break
    moves += 1

if(len(socks) != 0 or len(aux) != 0):
    print("impossible")
else:
    print(str(moves))