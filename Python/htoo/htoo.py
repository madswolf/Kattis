import re
def convertToMap(molecule, multi):
    dictionary ={}
    thing = re.findall("([A-Z])([0-9]*)?",molecule)
    multiplier = int(multi)
    for pair in thing:
        if pair[1] != "":
            plus = int(pair[1]) * multiplier
        else:
            plus = 1 *multiplier
        if pair[0] in dictionary:
            dictionary[pair[0]] += plus
        else:
            dictionary[pair[0]] = plus
    return dictionary
startMolecule = input().split()
endMolecule = input()
previousChar = ""
atomsStart = convertToMap(startMolecule[0], startMolecule[1])
atomsEnd = convertToMap(endMolecule, "1")
out = 2**31
for key in atomsEnd:
    if key not in atomsStart:
        out = 0
        break
    elif atomsStart[key] / atomsEnd[key] < out:
        out = int(atomsStart[key] / atomsEnd[key])
print(out)