import sys
vowels = "aeiouy"
for line in sys.stdin:
    words = line[:-1].split()
    result = []
    for word in words:
        if word[0] in vowels:
            result.append(word + "yay")
        else:
            for i in range(len(word)):
                if word[i] in vowels:
                    result.append(word[i:] + word[:i] + "ay")
                    break
    print(" ".join(result))