import sys
lines = sys.stdin.readlines()
rightDiagonals,leftDiagonals,horizontals,verticals,count = [0] * 5
for y in range(len(lines)):
    for x in range(len(lines[y])):
        if lines[y][x] == "*":
            count += 1
            currVert = 1 << (x + 1)
            currHori = 1 << (y + 1)
            currRightDia = 1 << (x - y) + 7
            currLeftDia = 1 << (y + x)
            if verticals & currVert == currVert or horizontals & currHori == currHori or leftDiagonals & currRightDia == currRightDia or rightDiagonals & currLeftDia == currLeftDia:
                sys.stdout.write(str("invalid\n"))
                sys.exit()
            verticals       |= currVert
            horizontals     |= currHori
            leftDiagonals   |= currRightDia
            rightDiagonals  |= currLeftDia 
print("invalid") if count != 8  else print("valid")