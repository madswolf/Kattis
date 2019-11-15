pokemonCount, size = [int(s) for s in input().split()]
pokemons = []
for i in range(pokemonCount):
    pokemons.append([int(s) for s in input().split()])
sortByAttack = sorted(pokemons, key = lambda x: x[0])[::-1]
sortByDefence = sorted(pokemons, key = lambda x: x[1])[::-1]
sortByHealth = sorted(pokemons, key = lambda x: x[2])[::-1]
result = []
for i in range(size):
    if(sortByAttack[i] not in result):
        result.append(sortByAttack[i])
    if(sortByDefence[i] not in result):
        result.append(sortByDefence[i])
    if(sortByHealth[i] not in result):
        result.append(sortByHealth[i])
print(len(result))