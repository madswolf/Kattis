
import sys
minX = 0
minY = 0
maxX = 0
maxY = 0

currX = 0
currY = 0

lines = []
for line in sys.stdin:
    line = line.strip()
    if(line == "left"):
        currX = currX - 1
        if(currX < minX):
            minX = currX
    
    if(line == "down"):
        currY = currY - 1
        if(currY < minY):
            minY = currY
    
    if(line == "right"):
        currX = currX + 1
    if(currX > maxX):
        maxX = currX
    
    if(line == "up"):
        currY = currY + 1
        if(currY > maxY):
            maxY = currY
    lines.append(line)

array = [ [ ' ' for y in range((abs(minX  - maxX) + 1)) ] for x in range((abs(minY -  maxY) + 1)) ]

#flipped y axis to make it easier to print
#switched minY for maxY
currX = abs(minX)
currY = abs(maxY)

for line in lines:
    if(line == "left"):
        currX = currX - 1
    
    if(line == "down"):
        currY = currY + 1
    
    if(line == "right"):
        currX = currX + 1
    
    if(line == "up"):
        currY = currY - 1
    array[currY][currX] = '*'
array[abs(maxY)][abs(minX)] = 'S'
array[currY][currX] = 'E'

print("#" * (len(array[0]) + 2))
for i in array:
    out = "#"
    for j in i:
        out = out + j
    print(out + "#")
print("#" * (len(array[0]) + 2))