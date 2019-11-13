from operator import itemgetter
cases = int(input())
for i in range(cases):
    count = int(input())
    toys = {}
    for j in range(count):
        toy, amount = input().split()
        if toy in toys:
            toys[toy] += int(amount)
        else:
            toys[toy] = int(amount)
    print(len(toys))
    thingsArr = sorted(toys.items(), key=lambda x: x[0])
    thingsArr.sort(key=lambda x: -x[1])
    for pair in thingsArr:
        print(pair[0],pair[1])