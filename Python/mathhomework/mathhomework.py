*arr, legcount = [int(s) for s in input().split()]
result = []

for i in range(int(legcount/arr[0])+1):
    for j in range(int(legcount/arr[1])+1):
        for v in range(int(legcount/arr[2])+1):
            if i * arr[0] + j * arr[1] + v * arr[2] == legcount:
                result.append(str(i) + " " + str(j) + " " + str(v))
if result:
    for permutation in result:
        print(permutation)                
else:
    print("impossible")    