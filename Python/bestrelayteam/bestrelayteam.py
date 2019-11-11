#runs too slow, can't bother fixing it right now
cases = int(input())
firstLegMap = {}
otherLegMap = {}
for i in range(cases):
    name,firstLeg, otherLeg = input().split()
    firstLegMap[name] = float(firstLeg)
    otherLegMap[name] = float(otherLeg)

s = sorted(otherLegMap, key = lambda x:otherLegMap[x])

best = 200000000000000
team = []    
for firstLeg in firstLegMap:
    for secondLeg in otherLegMap:
        for thirdLeg in otherLegMap:
            for forthLeg in otherLegMap:        
                if forthLeg == thirdLeg or forthLeg == secondLeg or forthLeg == firstLeg or thirdLeg == secondLeg or thirdLeg == firstLeg or secondLeg == firstLeg:
                    continue
                if otherLegMap[forthLeg] + otherLegMap[thirdLeg] + otherLegMap[secondLeg] + firstLegMap[firstLeg] < best:
                    best = otherLegMap[forthLeg] + otherLegMap[thirdLeg] + otherLegMap[secondLeg] + firstLegMap[firstLeg]
                    team = [firstLeg,secondLeg,thirdLeg,forthLeg]
print(best)
for runner in team:
    print(runner)