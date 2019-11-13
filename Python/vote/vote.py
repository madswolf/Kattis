cases = int(input())
for i in range(cases):
    voteCount = int(input())
    votes = []
    for i in range(voteCount):
        votes.append(int(input()))
    sumOfVotes = sum(votes)
    maxFraction = 0.0
    out = "no winner"
    for i in range(len(votes)):
        if votes[i]/sumOfVotes > maxFraction and votes[i]/sumOfVotes > 0.5:
            out = "majority winner " + str(i+1)
            maxFraction =  votes[i]/sumOfVotes
        elif votes[i]/sumOfVotes > maxFraction:
            out = "minority winner " + str(i+1)
            maxFraction =  votes[i]/sumOfVotes
        elif votes[i]/sumOfVotes == maxFraction:
            out = "no winner"
    if(i == cases-1 ):
        print(out ,end="")
    else:
        print(out)