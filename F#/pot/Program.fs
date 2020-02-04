// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let readNlines n = List.init n (fun _ -> Console.ReadLine() |> int)
    let linecount =  Console.ReadLine() |> int 
    let arr = readNlines linecount
    
    arr
    |> List.fold (fun total x -> total + (pown (x/10) (x%10))) 0
    |> printf "%A"
    0 // return an integer exit code
