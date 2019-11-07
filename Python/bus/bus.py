cases = int(input())
for i in range(cases):
    iterations = int(input())
    amount = 1
    for j in range(1, iterations):
        amount += 0.5
        amount *= 2
    print(int(amount))