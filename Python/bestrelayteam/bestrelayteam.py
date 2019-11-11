#runs too slow, can't bother fixing it right now
import operator
cases = int(input())
firstLegMap = {}
otherLegMap = {}
for i in range(cases):
    name,firstLeg, otherLeg = input().split()
    firstLegMap[name] = float(firstLeg)
    otherLegMap[name] = float(otherLeg)

s = sorted(otherLegMap.items(), key=operator.itemgetter(1))[:5]
best = 200000000000000
team = []    
for firstLeg in firstLegMap:
    for secondLeg in s:
        for thirdLeg in s:
            for forthLeg in s:        
                if forthLeg == thirdLeg or forthLeg == secondLeg or forthLeg[0] == firstLeg or thirdLeg == secondLeg or thirdLeg[0] == firstLeg or secondLeg[0] == firstLeg:
                    continue
                if forthLeg[1] + thirdLeg[1] + secondLeg[1] + firstLegMap[firstLeg] < best:
                    best = forthLeg[1] + thirdLeg[1] + secondLeg[1] + firstLegMap[firstLeg]
                    team = [firstLeg,secondLeg[0],thirdLeg[0],forthLeg[0]]
print(best)
for runner in team:
    print(runner)