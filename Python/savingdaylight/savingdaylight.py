import sys
for line in sys.stdin:
    *date,dawn,dusk = line.split()
    dawnHour, dawnMinutes = [int(s) for s in dawn.split(":")]
    duskHour, duskMinutes = [int(s) for s in dusk.split(":")]
    resultminutes = 0
    if(dawnMinutes > duskMinutes):
        duskHour -= 1
        resultminutes = 60 - (dawnMinutes - duskMinutes)
    else:
        resultminutes = duskMinutes - dawnMinutes
    resultHour = duskHour - dawnHour
    print(" ".join(date) +" " + str(resultHour) + " hours " + str(resultminutes) + " minutes")
#hello gamer

    