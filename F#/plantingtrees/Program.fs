// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let input = Console.ReadLine() |> int
    
    let order = 
        Console.ReadLine().Split([|' '|]) |> 
        List.ofArray |> 
        List.map int64 |> 
        List.sort |> 
        List.rev |> 
        List.mapi (fun index item -> int64 index + item + 2L) |>
        List.sort
        
    printfn "%i" order.[order.Length-1]
    0 // return an integer exit code
