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
    s = list(map(itemgetter(0), sorted(toys.items(), key=itemgetter(1,0))))
    for pair in s:
        print(pair[0] + " " + str(pair[1]))
