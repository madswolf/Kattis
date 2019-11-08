firstDegree = int(input())
secondDegree = int(input())
minimum = secondDegree - firstDegree
if(minimum > 180):
    minimum -= 360
elif minimum < -180:
    minimum += 360
elif(minimum == -180):
    minimum = 180
print(minimum)