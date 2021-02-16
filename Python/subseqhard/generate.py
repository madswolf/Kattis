import random

n = random.randint(1,10)
print(n)

for i in range(n):
    print()
    k = random.randint(0,10)
    print(k)
    arr = [str(random.randint(-100,100)) for _ in range(k)]
    print(" ".join(arr))