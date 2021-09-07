import sys

def optimal(n,time,lis):
    total_time, penalty = 0,0
    for i,t in enumerate(lis):
        if total_time + t > time:
            return i, penalty
        total_time += t
        penalty = (penalty + total_time) % 1000000007
    return n, penalty

n,t = map(int,input().split())
A,B,C,t0 = map(int,input().split())
arr = [t0]
for _ in range(1,n):
    arr.append(((A * arr[-1] + B) % C) + 1)

print(*optimal(n,t,sorted(arr)))

