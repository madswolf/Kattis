class Trie:

    def __init__(self):
        self.root = Node()

    def insert(self,s):
        node = self.root
        node.count += 1
        for i,c in enumerate(s):
            if not node.children[ord(c) - ord('a')]:
                node = node.create(s,i)
                break
            node = node.children[ord(c) - ord('a')]
            node.count += 1
        return node.count


    
class Node:
    def __init__(self):
        self.children = [None] * 26
        self.count = 0

    def create(self,s,index):
        node = self
        for i in range(index,len(s)):
            n = Node()
            node.children[ord(s[i]) - ord('a')] = n
            node = n
        return node

N = int(input())
t = Trie()

for _ in range(N):
    print(t.insert(input().strip()))