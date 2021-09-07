import sys
board = [[False for i in range(8)] for i in range(8)]

lines = sys.stdin.readlines()
for i in range(len(lines)):
    line = lines[i]
    for j in range(len(line)):
        if line[j] == "*":
            board[i][j] = True

for i in range(8):
    for j in range(8):
        #if queen, check if it's threatened
        if(board[i][j] == True):
            for x in range(8):
                if(x == j):
                    continue
                if board[i][x] == True:
                    print("invalid")
                    sys.exit()
            for y in range(8):
                if(y == i):
                    continue
                if board[y][j] == True:
                    print("invalid")
                    sys.exit()
            y = i - 1
            x = j - 1
            while(x >= 0 and y >= 0):
                if board[y][x] == True:
                    print("invalid")
                    sys.exit()
                y -= 1
                x -= 1
            
            y = i + 1
            x = j + 1
            while(x < 8 and y < 8):
                if board[y][x] == True:
                    print("invalid")
                    sys.exit()
                y += 1
                x += 1
            
            y = i - 1
            x = j + 1
            while(x < 8 and y >= 0):
                if board[y][x] == True:
                    print("invalid")
                    sys.exit()
                y -= 1
                x += 1

            y = i + 1
            x = j - 1
            while(x >= 0 and y < 8):
                if board[y][x] == True:
                    print("invalid")
                    sys.exit()
                y += 1
                x -= 1
print("valid")