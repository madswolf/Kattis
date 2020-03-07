// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    
    let original = Console.ReadLine().ToCharArray()
    let replication = Console.ReadLine().ToCharArray()
    let length = min original.Length replication.Length

    let func (c:char [] * char [] * int) =
        let list1,list2,status = c
        if status <> -1 
        then (list1,list2,status)
        else 
            if list1.Length <> 0 && list2.Length <> 0 && list1.[0] = list2.[0]
            then (list1.[1..],list2.[1..],status)
            else (list1,list2,0)

    let roundone = List.fold (fun acc item -> func acc) (original,replication,-1) [0..(length-1)] 
    let original,replication,_ = roundone
    let roundtwo = List.fold (fun acc item -> func acc) (Array.rev original,Array.rev replication,-1) [0..(length-1)]
    
    let _,replication,_ = roundtwo
    printfn "%A" replication.Length
    0 // return an integer exit code
