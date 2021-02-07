x = int(input())

out = 0

temps = [int(i) for i in input().split()]

for x in temps:
    if(x < 0):
        out += 1

print(out)
