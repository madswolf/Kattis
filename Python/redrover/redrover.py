instructions = input()
best = len(instructions)
for i in range(len(instructions)):
    for j in range(len(instructions)):
        temp = instructions[i:j]
        thing = len(temp) + len(instructions.replace(temp,"M"))
        best = min(best,thing)
print(best)
