length = input()
line = input()
stack = ['Ø']
out = ""
for i in range(len(line)):
    currentDelimiter = line[i]
    if(currentDelimiter == "Ø" or currentDelimiter == " "):
        continue
    expectedEndDelimiter = stack.pop()
    if currentDelimiter == expectedEndDelimiter or currentDelimiter == "Ø" :
        continue
    elif currentDelimiter == "(":
        stack.append(expectedEndDelimiter)
        stack.append(")")
    elif currentDelimiter == "[":
        stack.append(expectedEndDelimiter)
        stack.append("]")
    elif currentDelimiter == "{":
        stack.append(expectedEndDelimiter)
        stack.append("}")
    else:
        out = currentDelimiter + " " + str(i)
        break
if out == "":
    out = "ok so far"
print(out)