x = input()[::-1]
y = input()[::-1]
xAfter = []
yAfter = []
for i in range(len(x)):
    #print(str(x[i]),str(y[i]))
    if int(x[i]) == int(y[i]):
        #print("1")
        xAfter.append(x[i])
        yAfter.append(y[i])
    elif  int(x[i]) > int(y[i]):
        #print("2")
        xAfter.append(x[i])
    else:
        #print("3")
        yAfter.append(y[i])
    if i == len(y)-1:
        break
if(len(x) > len(y)):
    xAfter.append(x[len(y):])
if(len(y) > len(x)):
    yAfter.append(y[len(x):])
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
  
