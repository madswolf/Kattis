n,t = map(int,input().split())
people = []
for i in range(n):
    people.append([int(x) for x in input().split()])

people = sorted(people,key=lambda person: (person[1],-person[0]))

time = 0
count = 0
for i in range(len(people)):
    if(people[i][1] < time):
         continue
    if(time > t):
        break
    count += people[i][0]
    time += 1
print(count)