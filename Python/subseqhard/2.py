#naive solution, too slow
n = int(input())

for _ in range(n):
    input()
    input()

    arr = [int(x) for x in input().split()]
    prefixSums = []
    summation = 0
    for i in range(len(arr)):
        summation += arr[i]
        prefixSums.append(summation)
    count = 0
    for i in range(len(prefixSums)):
        for j in range(len(prefixSums)):
            if i == j:
                continue
            if (abs(prefixSums[i] - prefixSums[j])) == 47:
                count += 1 
    print(int(count/2))