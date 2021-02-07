import math
n = int(input())

class Graph:
    def __init__(self):
        self.edges = {}

    def add_vertex(self, x1,y1):
        self.edges[(x1,y1)] = set()

        for x2,y2 in self.edges.keys():
            if (x1 == x2 and y1 == y2):
                continue
            if((abs(x1 - x2) + abs(y1 - y2)) <= 1000):
                self.edges[(x1,y1)].add((x2,y2))
                self.edges[(x2,y2)].add((x1,y1))

for i in range(n):
    graph = Graph()
    shopCount = int(input())
    startX,startY = [int(x) for x in input().split()]
    graph.add_vertex(startX,startY)

    for i in range(shopCount):
        shopX,shopY = [int(x) for x in input().split()]
        graph.add_vertex(shopX,shopY)
    
    endX,endY =[int(x) for x in input().split()]
    graph.add_vertex(endX,endY)

    stack = [(startX,startY)]
    visited = set()
    isHappy = False

    while(stack):
        currX,currY = stack.pop()
        if((currX,currY) == (endX,endY)):
            isHappy = True
            break
        if((currX,currY) in visited):
            continue
        visited.add((currX,currY))
        for (x,y) in graph.edges[(currX,currY)]:
            if((x,y) not in visited):
                stack.append((x,y))

    if(isHappy):
        print("happy")
    else:
        print("sad")    

