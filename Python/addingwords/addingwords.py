import sys
words = {}
nums = {}


for line in sys.stdin:
    parts = [i for i in line.strip().split()]
    if(parts[0] == "def"):
        if parts[1] in words.keys():
            del nums[int(words[parts[1]])]
        words[parts[1]] = parts[2]
        nums[int(parts[2])] = parts[1]
    elif(parts[0] == "clear"):
        words.clear()
        nums.clear()
    else:
        calc = line[5:].strip()
        if(len(list(filter(lambda z: z in words.keys(), parts[1:][::2]))) != len(parts[1:][::2])):
            print(" ".join(parts[1:]), "unknown")
        else:
            calc = " ".join(map(lambda z: words[z] if z in words.keys() else z, parts[1:-1]))
            result  = eval(calc)
            if(result in nums.keys()):
                print(" ".join(parts[1:]),nums[result])
            else:
                print(" ".join(parts[1:]),"unknown")