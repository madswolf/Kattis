n,m = map(int, input().split())

pairs = set()

for _ in range(m):
    a,b = map((lambda x: int(x) -1),input().split())
    pairs.add(1 << a | 1 << b)

count = 0

for i in range(1 << n):
    count += 1
    for a in pairs:
        if i & a == a:
            count -= 1
            break

print(count)
