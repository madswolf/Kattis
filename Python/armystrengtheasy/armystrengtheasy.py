cases = int(input())
for i in range(cases):
    input()
    godzillaCount, mechagodzillaCount = [int(s) for s in input().split()]
    godzillaMonsters = [int(s) for s in input().split()]
    mechagodzillaMonsters = [int(s) for s in input().split()]
    godzillaMonsters.sort(reverse=True)
    mechagodzillaMonsters.sort(reverse=True)
    if godzillaMonsters[0] >= mechagodzillaMonsters[0]:
        print("Godzilla")
    else:
        print("MechaGodzilla")
    