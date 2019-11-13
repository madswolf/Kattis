def gcd(x,y):
    while(y > 0):
        temp = y
        y = x % y
        x = temp
    return x

def lcm(x,y):
    return x * (y / gcd(x,y))

interval1,interval2, timeframe = [int(s) for s in input().split()]
if lcm(interval1,interval2) <= timeframe:
    print("yes")
else:
    print("no")

