number = int(input())
out = ""
if number == 1:
    out = "Either"
elif number == 2 or number % 3 == 0:
    out = "Odd"
elif number % 4 == 0:
    out = "Even"
elif number % 5 == 0:
    out = "Odd"
print(out)
input()