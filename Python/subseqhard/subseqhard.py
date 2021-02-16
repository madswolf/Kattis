#map and twosum
n = int(input())

for _ in range(n):
    input()
    input()

    arr = [int(x) for x in input().split()]
    prefixSums = {0:1}
    summation = 0
    count = 0
    for i in range(len(arr)):
        summation += arr[i]
        if (summation - 47) in prefixSums.keys():
            count += prefixSums[summation - 47]
        
        value = prefixSums[summation] + 1 if summation in prefixSums.keys() else 1
        prefixSums[summation] = value

    print(int(count))
