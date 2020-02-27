cases = int(input())
for i in range(cases):
    arr = [int(s) for s in input()][::-1]
    sumCount = 0
    for j in range(len(arr)):
        if j % 2 == 1:
            number = arr[j] * 2
            if number > 9:
                sumCount += sum([int(s) for s in str(number)])
            else:
                sumCount += number
        else:
            sumCount += arr[j]
    out = "FAIL"
    if sumCount % 10 == 0:
        out = "PASS"
    print(out)
