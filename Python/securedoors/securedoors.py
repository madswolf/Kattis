cases = int(input())
people = []
for i in range(cases):
    event, person = input().split()
    out = person
    if event.startswith("entry"):
        out += " entered"
        if person in people:
            out += " (ANOMALY)"
        else:    
            people.append(person)
    else:
        out += " exited"
        if person not in people:
            out += " (ANOMALY)"
        else:
            people.remove(person)
    print(out)    