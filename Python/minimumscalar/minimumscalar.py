n = int(input())

for _ in range(n):
    i = int(input())

    arr1 = [int(x) for x in input().split()]
    arr2 = [int(x) for x in input().split()]

    arr1 = sorted(arr1)
    arr2 = sorted(arr2)[::-1]

    scalarProduct = 0
    for j in range(i):
        scalarProduct += arr1[j] * arr2[j]

    print(scalarProduct)