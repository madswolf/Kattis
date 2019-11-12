*arr, legcount = [int(s) for s in input().split()]
result = []
firstmultiplier = 0
secondmultiplier = 0
thirdmultiplier = 0
while firstmultiplier * arr[0] <= legcount:
    while secondmultiplier * arr[1] + thirdmultiplier * arr[2] <= legcount - firstmultiplier * arr[0]:
        while secondmultiplier * arr[1] + thirdmultiplier * arr[2] <= legcount - firstmultiplier * arr[0]:
            if(firstmultiplier * arr[0] + secondmultiplier * arr[1] + thirdmultiplier * arr[2] == legcount):
                result.append(str(firstmultiplier) + " " + str(secondmultiplier) + " " + str(thirdmultiplier))
            thirdmultiplier += 1
        secondmultiplier += 1
        thirdmultiplier = 0
    firstmultiplier +=1
    secondmultiplier = 0
    thirdmultiplier = 0   
if result:
    for permutation in result:
        print(permutation)                
else:
    print("impossible")    