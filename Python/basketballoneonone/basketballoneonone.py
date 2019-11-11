sequence = input()
a = 0
b = 0
for i in range(1, len(sequence)):
    if sequence[i - 1] == "A":
        a += int(sequence[i])
    elif sequence[i - 1] == "B":
        b += int(sequence[i])
if a > b:
    print("A")
else:
    print("B")