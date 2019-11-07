firstNumber = input()
secondNumber = input()
carryOver = 0
out = []
if len(firstNumber) > len(secondNumber):
    largest = firstNumber
    smallest = secondNumber
else:
    largest = secondNumber
    smallest = firstNumber   
for i in range(len(smallest)):
    digitOne = int(smallest[i])
    digitTwo = int(secondNumber[i])
    if carryOver != 0:
        digitOne += 1
        carryOver = 0
    newDigit = digitOne + digitTwo
    if newDigit > 9:
        carryOver = 1
        newDigit = newDigit % 10    
    print(newDigit)
    out.append(newDigit)
counter = len(smallest)
while(carryOver != 0):
    newDigit = int(largest[counter]) + 1
    carryOver = 0
    if newDigit > 9:
        carryOver = 1
        newDigit = newDigit % 10
    out.append(newDigit)
    print(newDigit)
for i in range(len(smallest), len(largest)):
    print(int(largest[i]))
    out.append(int(largest[i]))
print(*out, sep="")    