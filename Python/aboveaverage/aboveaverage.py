cases = int(input())

for i in range(cases):
    gradeCount, *grades = [int(s) for s in input().split()]
    sum = 0
    for grade in grades:
        sum += grade
    average = sum/gradeCount
    passedCount = 0
    for grade in grades:
        if grade > average:
            passedCount = passedCount + 1
    value = str(round(((passedCount / gradeCount) * 100),3))
    while len(value.split('.')[1]) < 3:
        value += "0"
    print(str(value) + "%")