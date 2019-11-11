cases = int(input())
for i in range(cases):
    command = input().lower()
    if 'simon says' in command:
        print(command.replace("simon says",""))
    else:
        print()