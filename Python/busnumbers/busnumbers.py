n = int(input())

nums = sorted([int(x) for x in input().split()])

firstSeqVal = nums[0]
lastSeqVal = nums[0]

out = ""
space = ""

def sequence(firstSeqVal, lastSeqVal, out):
    if(firstSeqVal == lastSeqVal - 1):
        out = out + space + str(firstSeqVal) + " " + str(lastSeqVal)
    elif(firstSeqVal == lastSeqVal):
        out = out + space + str(firstSeqVal)
    else:        
        out = out + space + str(firstSeqVal) + "-" + str(lastSeqVal)
    return out

for i in range(1,len(nums)):
    if((lastSeqVal == nums[i] - 1)):
        lastSeqVal = nums[i]
        continue
    out = sequence(firstSeqVal,lastSeqVal,out)
    firstSeqVal = nums[i]
    lastSeqVal = nums[i]
    space = " " 

out = sequence(firstSeqVal,lastSeqVal,out)
print(out)