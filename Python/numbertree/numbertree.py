line = input()

if "R" in line or "L" in line:
    thing = line.split()
    size = int(thing[0])
    instructions = thing[1]
else:
    size = int(line)
    instructions = ""    
index = 1
if instructions != "":
    for instruction in instructions:
        if instruction == 'R':
            index = index * 2 + 1
        else:
            index = index * 2            
print(2**(size+1) - index)   
    