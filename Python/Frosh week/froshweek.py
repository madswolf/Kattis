import sys
def mergesortInversions(arr):
    if(len(arr) == 1):
        return arr,0
    else:
        a = arr[:int(len(arr)/2)]
        b = arr[int(len(arr)/2):]

        a, ai = mergesortInversions(a)
        b, bi = mergesortInversions(b)
        i = 0
        j = 0
        inversions = ai + bi
        c = []

        while (i < len(a) and j < len(b)):
            if(a[i] <= b[j]):
                c.append(a[i])
                i += 1
            else:
                c.append(b[j])
                j += 1
                inversions += (len(a) - i)

        c += a[i:]
        c += b[j:]
        return c, inversions

n = int(input())
arr = []
for i in range(n):
    arr.append(int(input()))

arr, inversions = mergesortInversions(arr)
print(inversions)
