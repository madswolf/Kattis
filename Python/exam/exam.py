n = int(input())
line1 = input()
line2 = input()

count = 0
for i in range(len(line1)):
    if(line1[i] == line2[i]):
        count += 1

#print(n,count)
correct = min(n,count) + (len(line1) - max(count,n))
print(correct)