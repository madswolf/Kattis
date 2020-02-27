x = input()[::-1]
y = input()[::-1]
xAfter = []
yAfter = []
while len(x) < len(y):
    x += "0"
while len(y) < len(x):
    y += "0"
for i in range(len(x)):
    digit1 = int(x[i])
    digit2 = int(y[i])
    if digit1 > digit2:
        xAfter.append(str(digit1))
    elif digit2 > digit1:
        yAfter.append(str(digit2))
    else:
        xAfter.append(str(digit1))
        yAfter.append(str(digit2))
thing1 = "".join(xAfter[::-1])
thing2 = "".join(yAfter[::-1])
if thing1:
    print(str(int(thing1)))
else:
    print("YODA")
if thing2:
    print(str(int(thing2)))
else:
    print("YODA")
  
