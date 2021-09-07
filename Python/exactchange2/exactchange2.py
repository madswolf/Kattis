MAXPRICE = 2 * 10 ** 5
INF = 1000

T = int(input())


for _ in range(T):
    price = int(input())
    n = int(input())
    coins = list(map(int,[input() for _ in range(n)]))

    cache = dict()
    def opt(p,i):
        if (p == 0):
            return 0
        elif (p < 0 or i < 0):
            return INF
        elif (p,i) not in cache: 
            cache[(p,i)] = min(opt(p,i-1),opt(p-coins[i],i-1) + 1)
        return cache[(p,i)]

    for p in range(price, MAXPRICE):
        if opt(p,len(coins) -1) < INF:
            print(p, cache[(p, len(coins) - 1)])
            break
    
    