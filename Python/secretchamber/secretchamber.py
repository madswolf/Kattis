translationCount, pairCount = [int(s) for s in input().split()]
translations = {}
for i in range(translationCount):
    a,b = input().split()
    translations[a] = [b]
for i in range(pairCount):
    word1, word2 = input().split()
    tranlated1 = ""
    tranlated2 = ""
    for character in word1:
        if(character in translations.keys()):
            tranlated1 += "".join(translations[character])
    
    for character in word2:
        if(character in translations.keys()):
            tranlated2 += "".join(translations[character])
    print(tranlated1 + " " + tranlated2)
    if tranlated1 == tranlated2:
        print("yes")
    else:
        print("no")    