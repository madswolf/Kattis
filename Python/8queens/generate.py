import random
for i in range(8):
    out = ""
    for j in range(8):
        thing = "*" if random.randint(0,10) < 2 else "." 
        out = out + thing
    print(out)
