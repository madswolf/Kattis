swaps = int(input())
bits = input()
deletion = [int(x) for x in input()]
if swaps % 2 != 0:
    for i in range(len(deletion)):
        deletion[i] = 1 - deletion[i]
if "".join([str(i) for i in deletion]) == bits:
    print("Deletion succeeded") 
else:
    print("Deletion failed")