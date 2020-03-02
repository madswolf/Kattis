// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let caseCount = Console.ReadLine() |> int
    let func x = 
        let cities::pilots::xs = 
            Console.ReadLine().Split([|' '|]) |>
            Array.map int |>
            List.ofArray
        List.iter (fun _ -> Console.ReadLine() |> ignore) [0..(pilots - 1)]
        if pilots < cities then pilots else (cities - 1)

    let results = List.map (fun x -> func x) [1..caseCount]
    List.iter (fun x -> printfn "%i" x) results

    0 // return an integer exit code

