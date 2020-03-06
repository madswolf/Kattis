// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    
    let original = Console.ReadLine().ToCharArray()
    let replication = Console.ReadLine().ToCharArray()
    let length = min original.Length replication.Length
    let roundone = List.fold (fun acc item -> if original.[item] <> replication.[item] then (if acc = -1 then item else acc) else acc ) -1 [0..(length - 1)]
    printfn "%i" roundone
    let original = Array.rev original.[roundone..]
    let replication = Array.rev replication.[roundone..]
    printfn "%A %A" original replication
    let length = min original.Length replication.Length
    //let roundtwo = List.fold () (0,-1) [0..length]
    0 // return an integer exit code
