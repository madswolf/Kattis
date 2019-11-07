s = input()
p = input()
out = "No"
if p == s or p.swapcase() == s:
    out = "Yes"
for i in range(10):
    if (p + str(i) == s) or (str(i) + p) == s :
        out = "Yes"
print(out)         