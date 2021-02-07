
x,y,N = [int(x) for x in input().split()]


for i in range(1,N+1):

    out = ""
    if(i%x == 0):
        out = out + "Fizz"
    if(i%y == 0):
        out = out + "Buzz"

    if(out == ""):
        print(i)
    else:
        print(out)