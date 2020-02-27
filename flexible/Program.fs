// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    
    let arr =  Console.ReadLine().Split([|' '|]) |> Array.map int
    let width = arr.[0]
    let placements = Console.ReadLine().Split([|' '|]) |> Array.map int |> List.ofArray 
    let placements = 0::width::placements 
    let thing = 
        List.fold (fun acc item-> List.fold (fun inneracc inneritem ->  abs(item - inneritem) :: inneracc ) acc placements) [] placements 
        |> Seq.ofList 
        |> Seq.distinct 
        |> Seq.sort 
        |> Seq.filter (fun item -> item <> 0 )
    let string = Seq.fold (fun acc item -> acc + " " + item.ToString()) "" thing
    printfn "%s" string.[1..string.Length-1]
    0 // return an integer exit code
