// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let swaps = Console.ReadLine() |> int
    let bits = Console.ReadLine()
    
    let deletion = 
        (Console.ReadLine()).ToCharArray() |> 
        Array.map string |> 
        Array.map int |> 
        List.ofArray

    let deletion =
        if swaps % 2 <> 0
        then List.map (fun bit -> string(1 - bit)) deletion
        else List.map string deletion
    printfn "%s" (if String.concat "" deletion = bits then "Deletion succeeded" else "Deletion failed")
    0 // return an integer exit code
