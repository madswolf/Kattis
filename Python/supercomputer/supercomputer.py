import sys
lines = sys.stdin.readlines()
n, k = [int(x) for x in lines[0].split()]

fenwickTree = [0] * (n+1)

values = [0] * (n+1)


for j in range(1,(k + 1)):
    #sys.stderr.write(str(values) + "\n")
    #sys.stderr.write(str(fenwickTree) + "\n")
    arr = lines[j].split()
    i = int(arr[1])
    #Sum from (i,r)
    if arr[0] == "C":
        summation = 0
        i -= 1
        r = int(arr[2])
        while(r >= 1):
            summation += fenwickTree[r]
            r -= r & (-r)

        while(i >= 1):
           summation -= fenwickTree[i]
           i -= i & (-i)
        
        sys.stdout.write(str(summation) + "\n")

    #flip the value and update in the tree
    else:
        change = -1 if values[i] else 1
        values[i] = 0 if values[i] else 1
        while(i <= n):
            fenwickTree[i] += change
            #print(i,fenwickTree[i])
            i += i & (-i)
            

#print(fenwickTree)
