import sys
n = int(input())
while(n != 0):
    a = 0
    b = 0
    for i in range(n):
        command, m = [x for x in input().split()]
        m = int(m)
        if(command == "DROP"):
            b += m
            print("DROP 2",m)
        else:
            if(a >= m):
                a -= m
                print("TAKE 1",m)
            else:
                if(a != 0):
                    print("TAKE 1",a)
                    m -= a
                    a = 0
                print("MOVE 2->1",b)
                print("TAKE 1",m)
                a = (b - m)
                b = 0
    n = int(input())
    print()