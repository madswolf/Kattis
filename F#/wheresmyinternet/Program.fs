// Learn more about F# at http://fsharp.org

open System

type QuickUWPC (N) =
    //Parent index, id[i] is parent of i
    let id : int[] = Array.init N (fun i -> i)
    //Number of elements rooted at i
    let sz : int[] = Array.create N 1
     
    let root i = 
        let mutable q = i
        while (q <> id.[q]) do 
            id.[q] <- id.[id.[q]]
            q <- id.[q] 
        q

    member t.find(p, q) =
        root(p) = root(q)

    member t.unite(p, q) =
        let i = root(p)
        let j = root(q)
        if sz.[i] < sz.[j] then id.[i] <- j; sz.[j] <- sz.[j] + sz.[i]
        else id.[j] <- i; sz.[i] <- sz.[i] + sz.[j]    

[<EntryPoint>]
let main argv =

    let thing = (Console.ReadLine()).Split ' '  |> Array.map int
    let n = thing.[0]
    let m = thing.[1]
    let uf = QuickUWPC (n + 1)
    
    let func (list: int []) =
        let x = list.[0]
        let y = list.[1]
        uf.unite(x,y)

    List.iter (fun _ -> func (Console.ReadLine().Split ' ' |> Array.map int)) [1..m]
    
    let funky x y (hasprinted:bool)=
        if  uf.find(x,y)
        then hasprinted
        else 
            printfn "%i" y 
            true
    
    let hasPrinted = List.fold (fun acc x -> funky 1 x acc) false [1..n]
    if (not hasPrinted) then printfn "Connected"
    0 // return an integer exit code
