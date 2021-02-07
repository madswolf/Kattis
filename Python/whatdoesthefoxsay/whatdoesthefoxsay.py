N = int(input())

for i in range(N):
    output = input().split()
    line = input()

    while(not line.endswith("?")):
        sound = line[line.find("goes") + 5:]
        
        for j in range(len(output)):
            if(output[j] == sound):
                output[j] = ""
        line = input()
    
    output = list(filter(lambda a: a != "", output))
    out = ' '.join(output)
    print(out)
