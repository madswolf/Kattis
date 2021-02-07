coll = [] 

for i in range(10):
    coll.append(int(input())%42)

print(len(set(coll)))