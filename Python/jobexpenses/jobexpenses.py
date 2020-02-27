input()
arr = [int(s) for s in input().split()]
sum = 0
for number in arr:
    if number < 0:
        sum += abs(number)
print(sum)