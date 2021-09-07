import sys
lines = sys.stdin.readlines()
for i in range(len(lines)):
    n,m = map(int,lines[i].split())
    holes = []
    for _ in range(m):
        x,y = map(int,lines[i].split())
        holes.append((x,y))
        i += 1