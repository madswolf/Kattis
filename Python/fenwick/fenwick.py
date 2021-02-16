import sys
lines = sys.stdin.readlines()
n, q = [int(x) for x in lines[0].split()]

fenwickTree = [0] * (n+1)

for j in range(1,(q + 1)):
    arr = lines[j].split()
    i = int(arr[1])
    #print(i,fenwickTree)

    #Sum from (1,i)
    if arr[0] == "?":
        summation = 0
        while(i >= 1):
           summation += fenwickTree[i]
           i -= i & (-i)
        sys.stdout.write(str(summation) + "\n")

    #Add v to i element and mentain other segments
    else:
        i += 1
        v = int(arr[2])
        while(i <= n):
            fenwickTree[i] += v
            #print(i,fenwickTree[i])
            i += i & (-i)
            

#print(fenwickTree)
